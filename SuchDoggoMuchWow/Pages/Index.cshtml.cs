using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuchDoggoMuchWow.Models;
using SuchDoggoMuchWow.Models.Entities;

namespace SuchDoggoMuchWow.Pages
{
    public class IndexModel : PageModel
    {
        private DogContext _context { get; set; }
        private List<Dog> dogs;
        public List<Dog> Dogs
        {
            get
            {
                if (dogs == null)
                {
                    dogs = new List<Dog>();
                    dogs.AddRange(_context.Dogs.ToList());
                }
                return dogs;
            }
        }

        public IndexModel(DogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }
    }
}
