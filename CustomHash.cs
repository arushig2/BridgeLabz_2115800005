using System;
using System.Collections.Generic;

class MyHashMap<K, V>
{
    private class Node
    {
        public K Key;
        public V Value;
        public Node Next;

        public Node(K key, V value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private const int DEFAULT_CAPACITY = 1000;
    private LinkedList<Node>[] buckets;

    public MyHashMap()
    {
        buckets = new LinkedList<Node>[DEFAULT_CAPACITY];
    }

    private int GetBucketIndex(K key)
    {
        return Math.Abs(key.GetHashCode()) % DEFAULT_CAPACITY;
    }

    public void Put(K key, V value)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] == null)
        {
            buckets[index] = new LinkedList<Node>();
        }

        foreach (var node in buckets[index])
        {
            if (node.Key.Equals(key))
            {
                node.Value = value;  // Update existing key
                return;
            }
        }

        buckets[index].AddLast(new Node(key, value));  // Insert new key-value pair
    }

    public V Get(K key)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] == null)
        {
            return default(V);
        }

        foreach (var node in buckets[index])
        {
            if (node.Key.Equals(key))
            {
                return node.Value;
            }
        }

        return default(V);
    }

    public void Remove(K key)
    {
        int index = GetBucketIndex(key);
        if (buckets[index] == null)
        {
            return;
        }

        var toRemove = new List<Node>();
        foreach (var node in buckets[index])
        {
            if (node.Key.Equals(key))
            {
                toRemove.Add(node);
            }
        }

        foreach (var node in toRemove)
        {
            buckets[index].Remove(node);
        }
    }

    public void Print()
    {
        for (int i = 0; i < buckets.Length; i++)
        {
            if (buckets[i] != null)
            {
                foreach (var node in buckets[i])
                {
                    Console.WriteLine($"[{node.Key} -> {node.Value}]");
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        MyHashMap<string, int> map = new MyHashMap<string, int>();

        map.Put("one", 1);
        map.Put("two", 2);
        map.Put("three", 3);

        Console.WriteLine("Value of 'two': " + map.Get("two"));  
        map.Remove("two");
        Console.WriteLine("Value of 'two' after removal: " + map.Get("two"));  

        map.Print();
    }
}
