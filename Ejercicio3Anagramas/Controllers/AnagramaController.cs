using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Objetos
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Ejercicio 3: Anagramas
Nombre del alumno: Brek Mejia Samuel Alexander
Cuatrimestre: 4
Grupo: B
Parcial: 1
*/

namespace Ejercicio3Anagramas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnagramaController : ControllerBase
    {
        [HttpGet]
        public IActionResult ValidarAnagrama(string firstword, string secondword)
        {
            bool Anagram;
            var Validar = "";
            if (firstword.Length != secondword.Length)
            {
                Anagram = false;
            }
            else
            {
                char[] firstletter = firstword.ToCharArray();
                Array.Sort(firstletter);
                char[] secondletter = secondword.ToCharArray();
                Array.Sort(secondletter);



                string palabra = new string(firstletter);
                string palabra2 = new string(secondletter);
                if (palabra == palabra2)
                {
                    Anagram = true;
                }
                else
                {
                    Anagram = false;
                }
            }
            if (Anagram == true)
            {
                Validar = "Las palabras ingresadas: " + firstword + " & " + secondword + " son Anagramas";
            }
            else
            {
                Validar = "Las palabras ingresadas: " + firstword + " & " + secondword + " no son Anagramas"; //no logré implementar el banco de palabras a segurir
            }
            return Ok(Validar);
        }
    }
}
