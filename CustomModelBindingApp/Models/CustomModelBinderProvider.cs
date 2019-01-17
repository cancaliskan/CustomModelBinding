using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomModelBindingApp.Models
{
    public class CustomModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(UserModel))
                return new CustomModelBinder();

            return null;
        }
    }
}