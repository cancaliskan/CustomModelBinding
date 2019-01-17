using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomModelBindingApp.Models
{
    public class CustomModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(string))
                return new CustomModelBinder();

            return null;
        }
    }
}