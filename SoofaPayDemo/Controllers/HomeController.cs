using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoofaPayDemo.Models;
using Soofa;
namespace SoofaPayDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Payment(decimal amount,string reference,string tid)
        {

            string till_number = "5002";
            string client_secret = "3ixwt45uq88wttqgixpyla8d27ob0w";
            ISoofaPay soofaPay = new SoofaPay(till_number, client_secret);
            var transaction=  soofaPay.GetTransaction(tid);
            if (transaction != null)
            {
               //Your Db logic goes here
               
            }
            //To get your Balance
            var balance = soofaPay.GetBalance();
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
