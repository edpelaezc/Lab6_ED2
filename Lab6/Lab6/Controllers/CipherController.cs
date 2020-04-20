using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab6.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CipherController : ControllerBase
    {
        // GET: api/Cipher
        [HttpGet("{algorithm}/{firstKey}/{secondKey}")]
        public int getPublicKey(string algorithm, int firstKey, int secondKey)//las claves se enviaran separadas por coma [a,b]
        {
            if (algorithm.Equals("diffie"))
            {                
                DiffieHelman cipherKey = new DiffieHelman(firstKey, secondKey);
            }
            return 0;
        }

        // GET: api/Cipher/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cipher
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Cipher/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
