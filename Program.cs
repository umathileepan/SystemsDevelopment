using System;
using System.Collections.Generic;

var todos = new List<string>();

Console.WriteLine("Hello!\n\n");
do {
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");
    var answer = Console.ReadLine();
    switch (answer)
    {
        case "S":
        case "s":
            if(todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.\n\n");
                break;
            }
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine(value: $"{i+1}. {todos[i]}");
            }
            
            Console.WriteLine("\n");
            break;
        case "A":
        case "a":
            Console.WriteLine("Enter the TODO description:");
            var todo = Console.ReadLine();
            if (todo == null || todo.Trim() == "")
            {
                Console.WriteLine("The description cannot be empty.");
                break;
            }
            if (todos.Contains(todo))
            {
                Console.WriteLine("The description must be unique.");
                break;
            }
            todos.Add(todo);
            Console.WriteLine($"TODO successfully added: {todo}\n\n");
            break;
        case "R":
        case "r":
            Console.WriteLine("Select the index of the TODO you want to remove");
            var todoToRemove = Console.ReadLine();
            if (todoToRemove == null || todoToRemove.Trim() == "")
            {
                Console.WriteLine("Selected index cannot be empty.");
                break;
            }
            /*else if (!todos.Contains(todoToRemove))
            {
                Console.WriteLine("Todo not found.");
               
            }*/
            else if (!int.TryParse(todoToRemove, out int index) || index < 1 || index > todos.Count)
            {
                Console.WriteLine("Todo not found");
            }
            else
            {
                if(todos.Count == 0)
                {
                    Console.WriteLine("List is empty");
                }
                else
                {
                    int indexToRemove = int.Parse(todoToRemove) - 1;
                    todos.RemoveAt(indexToRemove);
                    Console.WriteLine($"TODO Removed: {todos[indexToRemove]}");
                }
              
            }
            break;  
        case "E":
        case "e":
            Console.WriteLine("Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
} while (true);

Console.ReadKey();
