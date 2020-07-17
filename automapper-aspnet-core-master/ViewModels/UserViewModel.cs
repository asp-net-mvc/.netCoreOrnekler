using System.ComponentModel.DataAnnotations;

namespace AutoMapperDemo.ViewModels
{
    public class UserViewModel
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Country")]
        public string AddressCountry { get; set; }
        
        public string AddressCity { get; set; }
        public string FullAdress { get; set; }



        public string Email { get; set; }
    }
}


//Id = 1,
//                FirstName = "John",
//                LastName = "Smith",
//                Email = "John.Smith@gmail.com",
//                Address = new Address()
//{
//    Country = "US"
//                }



