using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json.Linq;

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

            string values = Convert.ToString(((JValue)JObject.Parse(valueFromBody)["value"]).Value);

            var splitData = values.Split(new char[] { '|' });
            if (splitData.Length >= 2)
            {
                var result = new UserModel
                {
                    UserIid = splitData[0],
                    Name = splitData[1],
                    Address = splitData[2]
                };
                bindingContext.Result = ModelBindingResult.Success(result);
            }

            return Task.CompletedTask;
        }
    }
}