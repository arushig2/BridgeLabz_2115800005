using System;
using System.Collections.Generic;
using System.Linq;

abstract class JobRole
{
    public string RoleName { get; }
    public List<string> RequiredSkills { get; }

    protected JobRole(string roleName, List<string> requiredSkills)
    {
        RoleName = roleName;
        RequiredSkills = requiredSkills;
    }
}

class SoftwareEngineer : JobRole
{
    public SoftwareEngineer() : base("Software Engineer", new List<string> { "C#", "SQL", "OOP", "Data Structures" }) { }
}

class DataScientist : JobRole
{
    public DataScientist() : base("Data Scientist", new List<string> { "Python", "Machine Learning", "Statistics", "SQL" }) { }
}

class Resume<T> where T : JobRole
{
    public string CandidateName { get; }
    public List<string> Skills { get; }
    public T Job { get; }

    public Resume(string candidateName, List<string> skills, T job)
    {
        CandidateName = candidateName;
        Skills = skills;
        Job = job;
    }

    public void DisplayResume()
    {
        Console.WriteLine($"\nCandidate: {CandidateName}");
        Console.WriteLine($"Applying for: {Job.RoleName}");
        Console.WriteLine($"Skills: {string.Join(", ", Skills)}");
    }

    public bool MatchesJobRole()
    {
        return Job.RequiredSkills.All(skill => Skills.Contains(skill));
    }
}

class ResumeScreeningSystem
{
    private List<object> resumes = new List<object>(); 

    public void AddResume<T>(Resume<T> resume) where T : JobRole
    {
        resumes.Add(resume);
    }

    public void DisplayAllResumes()
    {
        Console.WriteLine("\nProcessed Resumes:");
        foreach (var resume in resumes)
        {
            dynamic res = resume;
            res.DisplayResume();
            Console.WriteLine(res.MatchesJobRole() ? "Passed Screening" : "Needs More Skills");
        }
    }

    public List<T> GetMatchingResumes<T>(List<Resume<T>> resumes) where T : JobRole
    {
        return resumes.Where(r => r.MatchesJobRole()).ToList();
    }
}

class Program
{
    static void Main()
    {
        ResumeScreeningSystem screeningSystem = new ResumeScreeningSystem();

        var resume1 = new Resume<SoftwareEngineer>("Alice", new List<string> { "C#", "SQL", "OOP", "Data Structures" }, new SoftwareEngineer());
        var resume2 = new Resume<DataScientist>("Bob", new List<string> { "Python", "Machine Learning", "SQL" }, new DataScientist());
        var resume3 = new Resume<SoftwareEngineer>("Charlie", new List<string> { "C#", "OOP" }, new SoftwareEngineer());

        screeningSystem.AddResume(resume1);
        screeningSystem.AddResume(resume2);
        screeningSystem.AddResume(resume3);

        screeningSystem.DisplayAllResumes();
    }
}
