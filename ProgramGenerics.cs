using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    public class ProgramGenerics
    {
        public static void Main(string[] args)
        {
            List<Items> genericList = new List<Items>();

            genericList.Add(new Items() {id=1, itemName="Laptop" });
            genericList.Add(new Items() { id = 2, itemName = "SmartPHone" });
            genericList.Add(new Items() { id = 3, itemName = "Book" });
            genericList.Add(new Items() { id = 4, itemName = "Shampoo" });

            genericList.Reverse();

            Console.WriteLine();
            foreach (Items item in genericList)
            {
                Console.WriteLine(item.id + "  " + item.itemName);                
            }



        }

    }


    

    public class Items{
        public int id { get; set; }
        public string itemName { get; set; }

    }
    
}
/*Write a generic class that meets the following requirements:
1)    That constrains a developer to only instantiate the class based on value types
2)    Contains a private generic collection
3)    Has a method to add items to the private collection
4)    Has a method that will return an  item from the list (e.g. item 3 or item 4 in the list)
5)    Has a method that returns a sorted collection with the items in descending order*/