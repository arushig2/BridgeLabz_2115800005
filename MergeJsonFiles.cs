using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string filePath1 = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment35\\file3.json";
        string filePath2 = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment35\\file4.json";

        if (File.Exists(filePath1) && File.Exists(filePath2))
        {
            string json1 = File.ReadAllText(filePath1);
            string json2 = File.ReadAllText(filePath2);

            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);


            obj1.Merge(obj2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Concat
            });

            Console.WriteLine("Merged JSON:");
            Console.WriteLine(obj1.ToString());
        }
        else
        {
            Console.WriteLine("One or both JSON files not found.");
        }
    }
}
