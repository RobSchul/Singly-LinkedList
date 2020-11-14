using System;
using System.Collections.Generic;

namespace SinglyLinkedLists
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[2];
            LinkedList<int> intList = new LinkedList<int>(numbers);
            LinkedList listTest = new LinkedList();

            try
            {

            string[] words = { "Lorem", "ipsum", "dolor", "sit", "amet", };
            LinkedList<string> sentence = new LinkedList<string>(words);
            Console.WriteLine(listTest.FifthElementFromEnd(sentence));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try {

            numbers = new int[] { 0, 1, 2, 3, 4, 5 };
            intList = new LinkedList<int>(numbers);
            Console.WriteLine(listTest.FifthElementFromEnd(intList));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            try { 
            numbers = new int[] { 0, 1, 2, 3, 4, 5,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };

            intList = new LinkedList<int>(numbers);
            Console.WriteLine(listTest.FifthElementFromEnd(intList));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try { 
            numbers = new int[] { };

            intList = new LinkedList<int>(numbers);
            Console.WriteLine(listTest.FifthElementFromEnd(intList));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {

           
            numbers = new int[] { 17, 18, 19, 20 };

            intList = new LinkedList<int>(numbers);
            Console.WriteLine(listTest.FifthElementFromEnd(intList));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }




    }

   
}
