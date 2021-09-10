using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vet_Dashboard.ViewModels
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }

        public List<string> Types { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTimeOffset RequestedTime { get; set; }

        public UserViewModel User { get; set; }

        public AnimalViewModel Animal { get; set; }

    }
}