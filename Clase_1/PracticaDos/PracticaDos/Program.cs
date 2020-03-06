using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticaDos
{
    class Memoria
    {
        public void LeerMemoria()
        {
            string archivoD8 = "../../../db.json";
            StreamReader reader = new StreamReader(archivoD8);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            //Prueba de lectura de archivo de.json
            //var result = dbObject,ToString()
            //var result = dbObject["arreglo"].ToString();
            //var result = dbObject["arreglo"][0].ToString();
            //Lectura de json iterable
            foreach (var key, var item) in dbObject)
            {
                //Iteracion individual de cada grupo de datos del objeto json.
                Console.WriteLine("Dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(DateTime.Now, item["operacion"].ToString(), (int)item["resultado"]);
                Console.WriteLine(Key.ToString());
                Console.WriteLine(memoriaData.resultado.ToString());
            }

        }
    }
    class  







}
