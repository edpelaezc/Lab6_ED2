using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab6.Controllers
{
    public class CipherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("SendKeys")]
        public void SendKeys(int a, int b)
        {
            Console.WriteLine(a+b);
            Diffie secretKey = new Diffie(a, b);
            secretKey.generateKey();
        }
    }
}