using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vet_Dashboard.ViewModels
{
    public class AnimalViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Species { get; set; }

        public string Breed { get; set; }

        public string SpeciesIconClass { get; set; }
    }
}