using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LowVision.Models;
using Microsoft.AspNetCore.Authorization;
using LowVision.ViewModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;

namespace LowVision.Controllers
{
    public class HomeController : Controller
    {
                private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Donation()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Donation(DonorClass ur)
        {
            string connection = "Data Source=tpisql01.avcol.school.nz;Initial Catalog=(Ritesh)Blind&LowVisionDB;Integrated Security=True";

            using (SqlConnection sqlconn = new SqlConnection(connection))
            {
                string sqlquery = "insert into NewDonor(DonorName, Email, Country, DonationAmt, CCname, CCnumber, CCexpiration, CCcsc) values ('" + ur.DonorName + "','" + ur.Email + "','" + ur.Country + "','" + ur.DonationAmt + "','" + ur.CCname + "','" + ur.CCnumber + "','" + ur.CCexpiration + "','" + ur.CCcsc + "')";
                using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                {
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    ViewData["Message"] = "Your donation was of " + ur.DonationAmt + " was successful..!";
                }
            }
            if (ModelState.IsValid)
            {
                ModelState.Clear();
            }
            return View();
            
        } 
    }
}
