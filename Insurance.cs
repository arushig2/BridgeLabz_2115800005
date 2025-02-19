using System;
using System.Collections.Generic;
using System.Linq;

class InsurancePolicy : IComparable<InsurancePolicy>
{
    public string PolicyNumber { get; }
    public string CoverageType { get; }
    public DateTime ExpiryDate { get; }

    public InsurancePolicy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public int CompareTo(InsurancePolicy other)
    {
        return ExpiryDate.CompareTo(other.ExpiryDate);
    }

    public override bool Equals(object obj)
    {
        return obj is InsurancePolicy policy && PolicyNumber == policy.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public override string ToString()
    {
        return $"PolicyNumber: {PolicyNumber}, CoverageType: {CoverageType}, ExpiryDate: {ExpiryDate:yyyy-MM-dd}";
    }
}

class InsurancePolicyManager
{
    private HashSet<InsurancePolicy> uniquePolicies = new HashSet<InsurancePolicy>();
    private LinkedList<InsurancePolicy> insertionOrderPolicies = new LinkedList<InsurancePolicy>();
    private SortedSet<InsurancePolicy> sortedPolicies = new SortedSet<InsurancePolicy>();
    private Dictionary<string, List<InsurancePolicy>> duplicatePolicies = new Dictionary<string, List<InsurancePolicy>>();

    public void AddPolicy(InsurancePolicy policy)
    {
        if (!uniquePolicies.Contains(policy))
        {
            uniquePolicies.Add(policy);
            insertionOrderPolicies.AddLast(policy);
            sortedPolicies.Add(policy);
        }
        else
        {
            if (!duplicatePolicies.ContainsKey(policy.PolicyNumber))
            {
                duplicatePolicies[policy.PolicyNumber] = new List<InsurancePolicy>();
            }
            duplicatePolicies[policy.PolicyNumber].Add(policy);
        }
    }

    public void DisplayAllPolicies()
    {
        Console.WriteLine("All Unique Policies:");
        foreach (var policy in uniquePolicies)
        {
            Console.WriteLine(policy);
        }
    }

    public void DisplayExpiringSoonPolicies()
    {
        Console.WriteLine("\nPolicies Expiring Soon (Next 30 Days):");
        DateTime today = DateTime.Today;
        DateTime threshold = today.AddDays(30);

        foreach (var policy in sortedPolicies)
        {
            if (policy.ExpiryDate <= threshold)
            {
                Console.WriteLine(policy);
            }
        }
    }

    public void DisplayPoliciesByCoverage(string coverageType)
    {
        Console.WriteLine($"\nPolicies with Coverage Type: {coverageType}");
        foreach (var policy in uniquePolicies.Where(p => p.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine(policy);
        }
    }

    public void DisplayDuplicatePolicies()
    {
        Console.WriteLine("\nDuplicate Policies:");
        foreach (var pair in duplicatePolicies)
        {
            Console.WriteLine($"Policy Number: {pair.Key}");
            foreach (var policy in pair.Value)
            {
                Console.WriteLine($" - {policy}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        InsurancePolicyManager manager = new InsurancePolicyManager();

        manager.AddPolicy(new InsurancePolicy("P001", "Health", DateTime.Today.AddDays(45)));
        manager.AddPolicy(new InsurancePolicy("P002", "Auto", DateTime.Today.AddDays(15)));
        manager.AddPolicy(new InsurancePolicy("P003", "Home", DateTime.Today.AddDays(10)));
        manager.AddPolicy(new InsurancePolicy("P004", "Health", DateTime.Today.AddDays(5)));
        manager.AddPolicy(new InsurancePolicy("P005", "Life", DateTime.Today.AddDays(90)));
        manager.AddPolicy(new InsurancePolicy("P001", "Health", DateTime.Today.AddDays(30))); 

        manager.DisplayAllPolicies();
        manager.DisplayExpiringSoonPolicies();
        manager.DisplayPoliciesByCoverage("Health");
        manager.DisplayDuplicatePolicies();
    }
}
