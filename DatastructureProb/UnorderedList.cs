using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DatastructureProb
{
    class UnorderedList<T>
    {
        static string[] dataFile;
        public void GetInput()
        {
            //Read input from Text File
            dataFile = File.ReadAllText(@"D:\DataStructureProgram\DatastructureProb\Utility\List.txt").Split(" ");

            //Create object for LinkedList Class
            LinkedList<string> linkedList = new LinkedList<string>();

            //Insert all file data to Linked List
            foreach (var element in dataFile)
            {
                linkedList.InsertAtFront(element);
            }
            linkedList.Display();

            //Enter element to be Searched
            Console.WriteLine("\nEnter the Element to be Searched");
            string searchElement = Console.ReadLine();
            if (linkedList.Search(searchElement))
            {
                linkedList.DeleteElement(searchElement);
            }
            else
            {
                linkedList.InsertAtFront(searchElement);
            }

            //Write Content back to File
            string StringValues = linkedList.ReturnToString();
            File.WriteAllText(@"D:\DataStructureProgram\DatastructureProb\Utility\List.txt", StringValues);
        }
    }
}