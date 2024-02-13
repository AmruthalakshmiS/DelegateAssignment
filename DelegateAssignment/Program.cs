// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using DelegateAssignment;
using DelegateAssignment.Models;
using DelegateAssignment.Services;


public class Program
{

    private static readonly List<Student> _students = new()
    {
        new Student { Id = 100, Name = "Ram", Age = 15, Score = 99 },
        new Student { Id = 121, Name = "Arjun", Age = 19, Score = 89.8 },
        new Student { Id = 101, Name = "Rahul", Age = 15, Score = 99.9 },
        new Student { Id = 102, Name = "Riya", Age = 16, Score = 78.5 }
    };

    private static readonly UserService _userService = new();

    public static void Main(string[] args)
    {
        bool start = true;
        while (start)
        {
            Console.WriteLine("\nAvailable Menu:\n");
            Console.WriteLine("1. Sort and Display Students");
            Console.WriteLine("2. Add User");
            Console.WriteLine("3. Update User");
            Console.WriteLine("4. Remove User");
            Console.WriteLine("5. Show Users");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter your choice: ");

            switch(Console.ReadLine())
            {
                case "1":
                       SortStudents();
                        break;
                case "2":
                    AddUser();
                    break;
                case "3":
                    //UpdateUser();
                    break;
                case "4":
                    RemoveUser();
                    break;
                case "5":
                    ShowUsers();
                    break;
                case "6":
                    start = false;
                    break;
                default:
                    Console.WriteLine("Choose from 1 to 6");
                    break;


            }

        }

    }

    public static void SortStudents()
    {
        var students = _students.ToArray();
        Sort.QuickSort(students, (x, y) => x.Score.CompareTo(y.Score));

        Console.WriteLine("Sorted list of students in ascending order:\n");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Score: {student.Score}");
            //Console.WriteLine();
        }

    }

    public static void AddUser() {
        var user = new User();

        Console.Write("Enter following details of User:\n");
        Console.Write("Name: ");
        user.Name = Console.ReadLine();
        Console.Write("Email: ");
        user.Email = Console.ReadLine();
        Console.Write("Contact: ");
        user.Contact = Console.ReadLine();

        _userService.AddUser(user);

        Console.WriteLine("User added successfully.");

    }

    public static void RemoveUser() {
        Console.WriteLine("Enter user id to be removed:");
        int id = int.Parse(Console.ReadLine());

        _userService.RemoveUser(id);
        Console.WriteLine("User removed successfully");

    }

    public static void ShowUsers() {
    
        if(_userService.ShowUsers().Any() != false)
        {
            foreach(var user in _userService.ShowUsers())
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}, Contact: {user.Contact}");
            }
        }
        else
        {
            Console.WriteLine("No users added yet!!!");
        }
    }

}