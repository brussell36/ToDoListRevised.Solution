using System;
using System.Collections.Generic;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      List<Item> toDoList = new List<Item>() { };
      Console.WriteLine("Welcome to your ToDo list. Press 1 to add an item. Press 2 to view your list.");
      string response = Console.ReadLine();

      if (response == "1")
      {
        Console.WriteLine("Enter an item for your to-do list: "); //take in user item
        string listItem = Console.ReadLine(); //set user item to a variable
        Item newItem = new Item(listItem);
        Main();
      }
      else if (response == "2")
      {
        //Incorrect way 
        // List<Item> result = Item.GetAll();
        // foreach (Item newItem in toDoList)
        // {
        //   Console.WriteLine(result.Description);
        // }
        //Correct Way
        List<Item> result = Item.GetAll();
        foreach (Item thisItem in result)//thisItem represents each actual item in result
        {
          Console.WriteLine(thisItem.Description);//the only way to access the description of the item is by touching the actual item not the list that holds all the items
        }

        //List<Item> newList = new List<Item> { newItem };

        // Console.WriteLine(result);
      }

      //foreach (Item thisItem in result)
      //{
      //Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);

      // Console.WriteLine("Would you like to add another item? [Y] for yes or [Enter for Main Menu] ");
      // string addAnother = Console.ReadLine();
      // if (addAnother == "Y" || "y")
      // {
      //   Console.WriteLine("Enter an item for your to-do list: ");
      // }
      // else Main();
      //Console.WriteLine(newItem.Description);//must do .Description to access details
      //Code for allowing the user to enter multiple items  - continual prompt for entering more items
      //code to show the entire list of items

      // Dictionary<int, string> dictionary = new Dictionary<int, string>();
      // int key = 1;
      // dictionary.Add(key, "asdf");
      // if (dictionary.ContainsKey(1))
      // {
      //   dictionary[key];
      // }
      // Console.WriteLine(value);

    }
  }
}