using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace Program.ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List, Would you like to add an item to your list or view your list? (Add/View)");
      string response = Console.ReadLine();
      if (response == "Add" || response == "add")
      {
        Console.WriteLine("What would you like to add?");
      } else if (response == "View" || response == "view") {
        Console.WriteLine("Here's your current to do list");
      List<Item> result = Item.GetAll();
      for (int i = 0; i <= result.Count -1; i++)
      {
      Console.WriteLine(result[i].Description);
      }
      } else {
        Console.WriteLine("Please use 'Add' or 'View'");
      }
      string userTask = Console.ReadLine();
      Item userItem = new Item(userTask);
      Console.WriteLine("you've added " + userTask + " to your to do list " );
      
      Main();
    }
  }
}