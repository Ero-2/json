using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace json
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ruta del archivo JSON
            string filePath = "archivo.json";

            try
            {
                // Leer el contenido del archivo JSON
                string jsonContent = file.ReadAllText(filePath);

                // Deserializar el JSON a un objeto C#
                dynamic jsonObject = JsonConvert.DeserializeObject(jsonContent);

                // Ejemplo: Acceder a los datos del objeto JSON
                string nombre = jsonObject.nombre;
                int edad = jsonObject.edad;

                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Edad: " + edad);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al procesar el archivo JSON: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
