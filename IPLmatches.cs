using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using CsvHelper.Configuration;

class IPLDataProcessor
{
    static void Main()
    {
        string jsonInputFile = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment35\\ipl.json";
        string csvInputFile = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment35\\ipl.csv";
        string jsonOutputFile = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment35\\ipl_matches_censored.json";
        string csvOutputFile = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment35\\ipl_matches_censored.csv";

        if (File.Exists(jsonInputFile))
        {
            string jsonData = File.ReadAllText(jsonInputFile);
            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(jsonData);
            ApplyCensorship(matches);
            File.WriteAllText(jsonOutputFile, JsonConvert.SerializeObject(matches, Formatting.Indented));
            Console.WriteLine("Censored JSON file created successfully!");
        }

        if (File.Exists(csvInputFile))
        {
            using (var reader = new StreamReader(csvInputFile))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var matches = new List<Match>(csv.GetRecords<Match>());
                ApplyCensorship(matches);
                using (var writer = new StreamWriter(csvOutputFile))
                using (var csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csvWriter.WriteRecords(matches);
                }
                Console.WriteLine("Censored CSV file created successfully!");
            }
        }
    }

    static void ApplyCensorship(List<Match> matches)
    {
        foreach (var match in matches)
        {
            if (match == null) continue; // Skip null records

            match.team1 = CensorTeamName(match.team1);
            match.team2 = CensorTeamName(match.team2);
            match.winner = CensorTeamName(match.winner);
            match.player_of_match = "REDACTED";

            // Check if score dictionary is null
            if (match.score != null)
            {
                Dictionary<string, int> censoredScore = new Dictionary<string, int>();
                foreach (var kvp in match.score)
                {
                    censoredScore[CensorTeamName(kvp.Key)] = kvp.Value;
                }
                match.score = censoredScore;
            }
        }
    }



    static string CensorTeamName(string teamName)
    {
        if (string.IsNullOrEmpty(teamName))
            return teamName;

        string[] words = teamName.Split(' ');

        if (words.Length > 1)
        {
            return words[0] + " ***"; 
        }

        return teamName; 
    }

}

public class Match
{
    public int match_id { get; set; }
    public string team1 { get; set; }
    public string team2 { get; set; }
    public Dictionary<string, int> score { get; set; }
    public string winner { get; set; }
    public string player_of_match { get; set; }
}
