using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    public class Service
    {
        // Variable para almcenar url de json
        public static string url = "https://jsonplaceholder.typicode.com/posts";
        // Método que invoca un servicio
        public static string GetPost() // Static indica que es un metodo u objeto de clase
        {
            // Se hace solicitud a WebService
            WebRequest request = WebRequest.Create(url); // Envío como parametro la url

            // La solicitud la envio por metodo GET
            request.Method = "GET";

            // Se lee lectura del resultado
            var httpResponse = (HttpWebResponse)request.GetResponse();

            // Para leer la solicitud
            using(var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                // Return apra regrear como string
                return streamReader.ReadToEnd();
            }
        }
    }
}
