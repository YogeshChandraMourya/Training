using Microsoft.AspNetCore.Mvc;
using MVCApplicationForEvoke.Models;

namespace MVCApplicationForEvoke.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            #region model example
            Product product = new Product();
            product.Id = 12;
            product.Name = "Apple";
            product.Price = 120;
            product.Description = "It is good for health";
            #endregion



            Person p = new Person();
            Man man = new Man()
            {
                Id = 1,
                Name = "Arya",
                PlayingGames = "Hockey"
            };
            Woman woman = new Woman()
            {
                Id = 2,
                Name = "Geetha",
                Dancing = "Folk"



            };
            string result = DisplayDetails(man);
            return View(product);
        }
        /// <summary>
        /// This Function will display the object details
        /// Ex Person o -new Person()
        /// Man m=
        /// </summary>
        /// <param name="p" >This person Type data</param>
        /// <returns>Welcome the object name</returns>
            private string DisplayDetails(Person p)
            {
                string result = "Welcome ";
                if (p is Man)
                {
                    result = result + "Mr " + p.Name;
                }
                if (p is Woman)
                {
                    result = result + "Ms " + p.Name;
                }

                return result;
            }
        }
    } 
