using System;
using System.Collections.Generic;

public class HospitalSystem
{
    public static void PatientsWithPriority(PriorityQueue<string, int> pq)
    {
        while (pq.Count > 0)
        {
            var patient = pq.Dequeue();
            Console.WriteLine(patient);
        }
    }

    public static void Main()
    {
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        while (true)
        {

            string s = Console.ReadLine();
            if (s == null) break;


            int n;
            if (!int.TryParse(Console.ReadLine(), out n)) break;

            if (n == -1)
            {
                break;
            }


            pq.Enqueue(s, -n);
        }

        PatientsWithPriority(pq);
    }
}
