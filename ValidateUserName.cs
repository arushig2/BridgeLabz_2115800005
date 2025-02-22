﻿using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsValidUsername(string username)
    {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        return Regex.IsMatch(username, pattern);
    }

    static void Main()
    {
        string[] testUsernames = { "user_123", "123user", "us", "ValidUser" };

        foreach (string username in testUsernames)
        {
            Console.WriteLine($"'{username}'  {(IsValidUsername(username) ? "Valid" : "Invalid")}");
        }
    }
}
