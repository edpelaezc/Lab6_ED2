using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.IO;
using lab6.Models;

namespace lab6.Controllers
{
    public class CipherController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("getPublicKey")]
        public IActionResult getPublicKey(int a, int b)
        {           
            Diffie secretKey = new Diffie(a, b);
            Data.Instance.secretKey = secretKey.generateKey();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("caesar2")]
        public IActionResult caesar2(IFormFile file)
        {
            //lectura del archivo
            var result = new StringBuilder();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(reader.ReadLine());
            }

            //elimina caracteres extra que stringbuilder coloca al final de la cadena
            string text = result.ToString();
            text = text.Remove(text.Length - 1);
            text = text.Remove(text.Length - 1);
            Data.Instance.caesarCipher.cifrarCesar(text, Data.Instance.secretKey, file.FileName);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("caesar2Decipher")]
        public IActionResult caesar2Decipher(IFormFile cipherFile)
        {
            //lectura del archivo
            var result = new StringBuilder();
            using (var reader = new StreamReader(cipherFile.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(reader.ReadLine());
            }

            //elimina caracteres extra que stringbuilder coloca al final de la cadena
            string text = result.ToString();
            text = text.Remove(text.Length - 1);
            text = text.Remove(text.Length - 1);
            Data.Instance.caesarCipher.descifrarCesar(text, Data.Instance.secretKey, cipherFile.FileName);
            return RedirectToAction(nameof(Index));
        }

    }
}