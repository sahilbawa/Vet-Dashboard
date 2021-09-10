using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vet_Dashboard.Models
{
    public class Appointment
    {
        [JsonProperty("appointmentId")]
        public int AppointmentId { get; set; }

        [JsonProperty("appointmentType")]
        public string AppointmentType { get; set; }

        [JsonProperty("createDateTime")]
        public DateTime CreatedDateTime { get; set; }

        [JsonProperty("requestedDateTimeOffset")]
        public DateTimeOffset RequestedDateTimeOffset { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("animal")]
        public Animal Animal { get; set; }

    }
}