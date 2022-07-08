using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] arr = new int[10];

            //simple array not allow 
            //1 - increase size
            //2- delete and insert in middle of an aaray
            //so collection came into picture - auto resize , delete and insert into the middle of the collection
            // collection -1.0 - non generic collection - system.collection
            //destroy old array and create new array - then copy the value of old array into new array
            Array.Resize(ref arr, 20);



            //Array list
            Console.WriteLine("\nArray List -----");
            ArrayList al = new ArrayList();

            Console.WriteLine("Capacity of Array List before adding = " + al.Capacity);

            al.Add(100);  //will add at end and also accept null and object value
            al.Add(100);
            al.Add(100);
            al.Add(100);


            Console.WriteLine("Capacity of Array List after adding = " + al.Capacity);
            al.Add(100);
            Console.WriteLine("Capacity of Array List after adding 5th item = " + al.Capacity);


            Console.WriteLine("Elements of 1st array list");
            foreach (var item in al)
            {
                Console.WriteLine("Array list 1 : " + item);
            }

            //Array list
            Console.WriteLine("\nArray List with initial capacity-----");
            ArrayList al2 = new ArrayList(5);

            Console.WriteLine("Capacity of Array List before adding = " + al2.Capacity);

            al2.Add(100);  //will add at end and also accept null and object value
            al2.Add(100);
            al2.Add(100);
            al2.Add(100);
            al2.Add(100);

            Console.WriteLine("Capacity of Array List after adding = " + al2.Capacity);
            al2.Add(100);
            Console.WriteLine("Capacity of Array List after adding 6th item = " + al2.Capacity);

            Console.WriteLine("Elements of 2nd array list");
            foreach (var item in al2)
            {
                Console.WriteLine("Array list 2 : " + item);
            }

            //insert an item
            al2.Insert(3,300);
            al2.Insert(4, null);

            Console.WriteLine("Elements of 2nd array list after inserting element");
            foreach (var item in al2)
            {
                Console.WriteLine("Array list 2 : " + item);
            }



            //Remove an item
            al2.Remove(300);
            al2.Remove(null);

            Console.WriteLine("Elements of 2nd array list after removing element");
            foreach (var item in al2)
            {
                Console.WriteLine("Array list 2 : " + item);
            }


            //Removeat an item
            al2.Remove(1);

            Console.WriteLine("Elements of 2nd array list after removing  element - by remove at");
            foreach (var item in al2)
            {
                Console.WriteLine("Array list 2  : " + item);
            }

            Console.ReadLine();
        }
    }
}
