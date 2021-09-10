using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Vet_Dashboard.ViewModels;

namespace Vet_Dashboard.Models
{
    public class DashboardDAL
    {
        private static string _apiAppointmentsUrl = "https://your.api.here";
        private readonly HttpClient _client;

        public DashboardDAL()
        {
            // get HttpClient singleton
            _client = MvcApplication.Client;
        }

        public List<AppointmentViewModel> GetAppointmentViewModels()
        {
            // order by date to get soonest appointments first
            List<Appointment> appointments = GetAppointments().OrderBy(a => a.RequestedDateTimeOffset).ToList();

            return appointments.Select(a => new AppointmentViewModel()
            {
                Id = a.AppointmentId,
                Types = SplitToList(a.AppointmentType, ','),
                CreatedTime = a.CreatedDateTime,
                RequestedTime = a.RequestedDateTimeOffset,
                User = new UserViewModel()
                {
                    Id = a.User.UserId,
                    FirstName = a.User.FirstName,
                    LastName = a.User.LastName
                },
                Animal = new AnimalViewModel()
                {
                    Id = a.Animal.AnimalId,
                    Name = a.Animal.FirstName,
                    Breed = a.Animal.Breed,
                    Species = a.Animal.Species ?? "Unknown",
                    SpeciesIconClass = GetSpeciesIconClass(a.Animal.Species)
                }
            }).ToList();
        }

        public void SendNewApptProposal(int userId, DateTime newDateTime)
        {
            // Retrieve user email from api using userId.

            // Build email notifying client of vet's alternative proposed appointment date.

            // Email will contain button to confirm that will link to a
            // server-side function taking encrypted userId and a parameter
            // denoting the acceptance of the new proposed appointment date.
        }

        private string GetSpeciesIconClass(string species)
        {
            string iconClass = "";
            switch(species?.ToLower())
            {
                case "dog":
                    iconClass = "fa-dog";
                    break;
                case "cat":
                    iconClass = "fa-cat";
                    break;
                case "bird":
                    iconClass = "fa-dove";
                    break;
                case "horse":
                    iconClass = "fa-horse";
                    break;
                case "dragon":
                    iconClass = "fa-dragon";
                    break;
                default:
                    iconClass = "fa-paw";
                    break;
            }

            return iconClass;
        }

        private List<Appointment> GetAppointments()
        {
            return GetJTokenAsync(_apiAppointmentsUrl).Result.ToObject<List<Appointment>>();
        }

        private List<string> SplitToList(string input, char separator)
        {
            return input.Split(separator).Select(t => t.Trim()).ToList();
        }

        // JToken function to allow general use of GET 
        private async Task<JToken> GetJTokenAsync(string url)
        {
            var response = await _client.GetAsync(url).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            string jsonStr = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<JToken>(jsonStr);
        }

    }
}