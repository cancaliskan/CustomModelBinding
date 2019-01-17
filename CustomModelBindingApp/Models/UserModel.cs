using System;

namespace CustomModelBindingApp.Models
{
    public class UserModel
    {
        public string UserIid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

   /*     public UserModel()
        {

        }

        public UserModel(string name, string address)
        {
            UserIid = Guid.NewGuid().ToString();
            Name = name;
            Address = address;
        }*/
    }
}