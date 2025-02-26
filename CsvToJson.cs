using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string csvFilePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment35\\data.csv";

        if (File.Exists(csvFilePath))
        {
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<dynamic>();

                string json = JsonConvert.SerializeObject(records, Formatting.Indented);

                Console.WriteLine(json);
            }
        }
        else
        {
            Console.WriteLine("CSV file not found.");
        }
    }
}
