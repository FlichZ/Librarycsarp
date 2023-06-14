using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace ClassLibrary2
{
    public class Class1
    {
        public static void Serialize<T>(List<T> items, string fileName)
        {
            string pathJson = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileName + ".json";
            string json = JsonConvert.SerializeObject(items);
            File.WriteAllText(pathJson, json);
        }

        public static List<T> Deserialize<T>(string fileName)
        {
            try
            {
                string pathJson = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileName + ".json";
                string json = File.ReadAllText(pathJson);
                List<T> items = JsonConvert.DeserializeObject<List<T>>(json);
                return items;
            }
            catch
            {
                return new List<T>();
            }
        }
         
    }
}
