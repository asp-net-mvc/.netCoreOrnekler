using AutoMapper;
using AutoMapperDemo.Models;
using AutoMapperDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            // Populate the user details from DB
            var user = GetUserDetails();

            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);

            return View(userViewModel);
        }

        private static User GetUserDetails()
        {
            return new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Test = "Test",
                Email = "John.Smith@gmail.com",
                Address = new Address()
                {
                    Country = "US",
                    City="kayseri"
                }
            };
        }
    }
}

//public int Id { get; set; }

//public string FirstName { get; set; }

//public string LastName { get; set; }
//public string Test { get; set; }

//public string Email { get; set; }

//public Address Address { get; set; }

//public string GetFullName()
//{
//    return $"{this.LastName}, {this.FirstName}";
//}