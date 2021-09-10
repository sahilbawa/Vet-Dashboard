using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vet_Dashboard.Models;
using Vet_Dashboard.ViewModels;

namespace Vet_Dashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dal = new DashboardDAL();
            List<AppointmentViewModel> model = dal.GetAppointmentViewModels();

            return View(model);
        }

        [HttpPost]
        public void SendNewApptProposal(int userId, DateTime newDateTime)
        {
            var dal = new DashboardDAL();
            dal.SendNewApptProposal(userId, newDateTime);
        }
    }
}