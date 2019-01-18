using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CustomModelBindingApp.Models
{
    public class CustomModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException(nameof(bindingContext));

            string valueFromBody = string.Empty;

            using (var sr = new StreamReader(bindingContext.HttpContext.Request.Body))
            {
                valueFromBody = sr.ReadToEnd();
            }

            if (string.IsNullOrEmpty(valueFromBody))
            {
                return Task.CompletedTask;
            }

            var splitModel = valueFromBody.Split(new char[] { '^' });

            var items = new List<UserModel>();

            if (splitModel.Length >= 1)
            {
                foreach (var model in splitModel)
                {
                    var splitData = model.ToString().Split(new char[] { '|' });
                    if (splitData.Length >= 2)
                    {
                        var result = new UserModel
                        {
                            UserIid = splitData[0],
                            Name = splitData[1],
                            Address = splitData[2]
                        };
                        items.Add(result);
                    }
                }
            }

            bindingContext.Result = ModelBindingResult.Success(JsonConvert.SerializeObject(items));

            return Task.CompletedTask;
        }
    }
}