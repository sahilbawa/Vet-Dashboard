using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vet_Dashboard.Models
{
    public class Animal
    {
        [JsonProperty("animalId")]
        public int AnimalId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("breed")]
        public string Breed { get; set; }

    }
}