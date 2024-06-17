using CoolWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoolWebsite.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListPeople() 
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Oscar", LastName = "Hansson", BirthDate = new DateTime(1994, 8, 28) }) ;

            return View(people);
        }
    }
}
