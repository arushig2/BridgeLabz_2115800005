using System;
using System.Collections.Generic;
using System.Linq;

class VotingSystem
{
    private Dictionary<string, int> votes = new Dictionary<string, int>();  
    private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>(); 
    private LinkedList<string> voteOrder = new LinkedList<string>();  

    public void CastVote(string candidate)
    {
        if (votes.ContainsKey(candidate))
        {
            votes[candidate]++;
        }
        else
        {
            votes[candidate] = 1;
            sortedVotes[candidate] = 1;
        }

        voteOrder.AddLast(candidate); 
    }

    public void DisplayVotingOrder()
    {
        Console.WriteLine("\nVoting Order:");
        foreach (var candidate in voteOrder)
        {
            Console.Write(candidate + " -> ");
        }
        Console.WriteLine("End");
    }

    public void DisplayVoteCounts()
    {
        Console.WriteLine("\nVote Counts:");
        foreach (var kvp in votes)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} votes");
        }
    }

    public void DisplaySortedResults()
    {
        Console.WriteLine("\nSorted Voting Results (Alphabetical Order):");
        foreach (var kvp in sortedVotes.OrderByDescending(kv => kv.Value))
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} votes");
        }
    }
}

class Program
{
    static void Main()
    {
        VotingSystem votingSystem = new VotingSystem();

    
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Charlie");
        votingSystem.CastVote("Alice");
        votingSystem.CastVote("Bob");
        votingSystem.CastVote("Alice");

     
        votingSystem.DisplayVoteCounts();
        votingSystem.DisplayVotingOrder();
        votingSystem.DisplaySortedResults();
    }
}
