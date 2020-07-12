using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;


namespace Innova_TRIAL.ViewModels.RegisterViewModel
{
    public class UserRegistrationViewModel
    {
       
        public string FirstName { get; set; }

      
        public string LastName { get; set; }


        public string Email { get; set; }

     
        public string Password { get; set; }


        public string ConfirmPassword { get; set; }

        public bool IsVerified { get; set; }

        public string PhoneNumber { get; set; }

        public bool SendNotification { get; set; }



    }
}