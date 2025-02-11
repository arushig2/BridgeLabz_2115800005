using System;
using System.Collections.Generic;

public class User
{
    public int userId;
    public string name;
    public int age;
    public List<User> friends;
    public User next;

    public User(int userId, string name, int age)
    {
        this.userId = userId;
        this.name = name;
        this.age = age;
        this.friends = new List<User>();
        this.next = null;
    }
}

public class SocialNetwork
{
    private User head;

    public void AddUser(User user)
    {
        if (head == null)
        {
            head = user;
        }
        else
        {
            User temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = user;
        }
    }

    public void AddFriend(int userId, int friendId)
    {
        User user = head;
        User friend = head;
        while (user != null && user.userId != userId)
        {
            user = user.next;
        }
        while (friend != null && friend.userId != friendId)
        {
            friend = friend.next;
        }
        if (user == null || friend == null)
        {
            Console.WriteLine("User or friend not found.");
            return;
        }
        user.friends.Add(friend);
        friend.friends.Add(user);
    }

    public void RemoveFriend(int userId, int friendId)
    {
        User user = head;
        User friend = head;
        while (user != null && user.userId != userId)
        {
            user = user.next;
        }
        while (friend != null && friend.userId != friendId)
        {
            friend = friend.next;
        }
        if (user == null || friend == null)
        {
            Console.WriteLine("User or friend not found.");
            return;
        }
        user.friends.Remove(friend);
        friend.friends.Remove(user);
    }

    public void FindMutualFriend(int user1ID, int user2ID)
    {
        User user1 = head;
        User user2 = head;

        while (user1 != null && user1.userId != user1ID)
        {
            user1 = user1.next;
        }

        while (user2 != null && user2.userId != user2ID)
        {
            user2 = user2.next;
        }

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        HashSet<int> user1Friends = new HashSet<int>();
        foreach (var friend in user1.friends)
        {
            user1Friends.Add(friend.userId);
        }

        List<User> mutualFriends = new List<User>();
        foreach (var friend in user2.friends)
        {
            if (user1Friends.Contains(friend.userId))
            {
                mutualFriends.Add(friend);
            }
        }

        if (mutualFriends.Count == 0)
        {
            Console.WriteLine("No mutual friends found.");
        }
        else
        {
            Console.WriteLine("Mutual Friends:");
            foreach (var mutualFriend in mutualFriends)
            {
                Console.WriteLine($"ID: {mutualFriend.userId}, Name: {mutualFriend.name}");
            }
        }
    }

    public void DisplayFriends(int userId)
    {
        User user = head;
        while (user != null && user.userId != userId)
        {
            user = user.next;
        }
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }
        if (user.friends.Count == 0)
        {
            Console.WriteLine("No friends found.");
        }
        else
        {
            Console.WriteLine("Friends:");
            foreach (var friend in user.friends)
            {
                Console.WriteLine($"ID: {friend.userId}, Name: {friend.name}");
            }
        }
    }

    public void SearchUserByName(string name)
    {
        User user = head;
        bool found = false;
        while (user != null)
        {
            if (user.name == name)
            {
                Console.WriteLine($"ID: {user.userId}, Name: {user.name}, Age: {user.age}");
                found = true;
            }
            user = user.next;
        }
        if (!found)
        {
            Console.WriteLine("User not found.");
        }
    }

    public void SearchUserByID(int userId)
    {
        User user = head;
        while (user != null && user.userId != userId)
        {
            user = user.next;
        }
        if (user == null)
        {
            Console.WriteLine("User not found.");
        }
        else
        {
            Console.WriteLine($"ID: {user.userId}, Name: {user.name}, Age: {user.age}");
        }
    }

    public void CountFriendsOfEachUser()
    {
        User user = head;
        while (user != null)
        {
            Console.WriteLine($"ID: {user.userId}, Name: {user.name}, Friends: {user.friends.Count}");
            user = user.next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SocialNetwork network = new SocialNetwork();

        // Adding users
        network.AddUser(new User(1, "Alice", 25));
        network.AddUser(new User(2, "Bob", 24));
        network.AddUser(new User(3, "Charlie", 26));
        network.AddUser(new User(4, "David", 23));

        // Adding friends
        network.AddFriend(1, 2);
        network.AddFriend(1, 3);
        network.AddFriend(2, 3);
        network.AddFriend(2, 4);

        Console.WriteLine("\nDisplaying friends of Alice (ID:1):");
        network.DisplayFriends(1);

        Console.WriteLine("\nDisplaying friends of Bob (ID:2):");
        network.DisplayFriends(2);

        Console.WriteLine("\nMutual friends between Alice (ID:1) and Bob (ID:2):");
        network.FindMutualFriend(1, 2);

        Console.WriteLine("\nMutual friends between Alice (ID:1) and David (ID:4):");
        network.FindMutualFriend(1, 4);

        Console.WriteLine("\nSearching for user 'Charlie':");
        network.SearchUserByName("Charlie");

        Console.WriteLine("\nSearching for user by ID 3:");
        network.SearchUserByID(3);

        Console.WriteLine("\nCounting friends of each user:");
        network.CountFriendsOfEachUser();

        Console.WriteLine("\nRemoving friendship between Alice (ID:1) and Charlie (ID:3)...");
        network.RemoveFriend(1, 3);

        Console.WriteLine("\nDisplaying friends of Alice after removal:");
        network.DisplayFriends(1);

        Console.WriteLine("\nMutual friends between Alice and Bob after removal:");
        network.FindMutualFriend(1, 2);
    }
}
