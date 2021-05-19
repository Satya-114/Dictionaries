using System;
using System.Collections.Generic;


namespace Remove_Dictionary
{
    class Program
    {
        
            static public void Main()
            {

                // Creating a dictionary
                // using Dictionary<TKey,TValue> class
                Dictionary<int, string> My_dict =
                             new Dictionary<int, string>();

                // Adding key/value pairs in the 
                // Dictionary Using Add() method
                My_dict.Add(1123, "Welcome");
                My_dict.Add(1124, "to");
                My_dict.Add(1125, "GeeksforGeeks");

                // Before Remove() method
                foreach (KeyValuePair<int, string> ele in My_dict)
                {
                    Console.WriteLine("{0} and {1}",
                                ele.Key, ele.Value);
                }
                Console.WriteLine();

                // Using Remove() method 
                My_dict.Remove(1123);

                // After Remove() method
                foreach (KeyValuePair<int, string> ele in My_dict)
                {
                    Console.WriteLine("{0} and {1}",
                                ele.Key, ele.Value);
                }
                Console.WriteLine();


                // Using Clear() method
                My_dict.Clear();

                Console.WriteLine("Total number of key/value " +
                 "pairs present in My_dict:{0}", My_dict.Count);

            }
        }
      
      }
  
