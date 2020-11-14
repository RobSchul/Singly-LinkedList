using SinglyLinkedLists;
using System;
using System.Collections.Generic;
using Xunit;

namespace SinglyLinkedListsTest
{
    public class LinkedListsTest
    {
        LinkedList listTest = new LinkedList();


        [Fact]
        public void TestIntLong()
        {
            try
            {
                 
                
                int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                LinkedList<int> intList = new LinkedList<int>(numbers);
                if (listTest.FifthElementFromEnd(intList) == 16)
                {
                    Assert.True(true);
                }
                else
                    Assert.True(false);

            }
            catch (Exception e)
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void TestIntShort()
        {
            try
            {


                int[] numbers = new int[] { 0, 1, 2, 3, 4, 5 };
                LinkedList<int> intList = new LinkedList<int>(numbers);
                if (listTest.FifthElementFromEnd(intList) == 1)
                {
                    Assert.True(true);
                }
                else
                    Assert.True(false);

            }
            catch (Exception e)
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void TestIntTooShort()
        {
            try
            {


                int[] numbers = new int[] { 0, 1, 2, 3};
                LinkedList<int> intList = new LinkedList<int>(numbers);
                if (listTest.FifthElementFromEnd(intList) == 1)
                {
                    Assert.True(false);
                }
                else
                    Assert.True(false);

            }
            catch (Exception e)
            {
                Assert.True(true);
            }
        }


        [Fact]
        public void TestIntEmpty()
        {
            try
            {
                int[] numbers = new int[] { };
                LinkedList<int> intList = new LinkedList<int>(numbers);
                if (listTest.FifthElementFromEnd(intList) == 1)
                {
                    Assert.True(false);
                }
                else
                    Assert.True(false);

            }
            catch (Exception e)
            {
                Assert.True(true);
            }
        }



        [Fact]
        public void TestStringEmpty()
        {
            try
            {


                string[] words = new string[] { };
                LinkedList<string> wordsList = new LinkedList<string>(words);
                if (listTest.FifthElementFromEnd(wordsList) == "")
                {
                    Assert.True(false);
                }
                else
                    Assert.True(false);

            }
            catch (Exception e)
            {
                Assert.True(true);
            }
        }


        [Fact]
        public void TestStringTooShort()
        {
            try
            {


                string[] words = new string[] { "first", "last"};
                LinkedList<string> wordsList = new LinkedList<string>(words);
                if (listTest.FifthElementFromEnd(wordsList) == "")
                {
                    Assert.True(false);
                }
                else
                    Assert.True(false);

            }
            catch (Exception e)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TestStringShort()
        {
            try
            {

                string[] words = new string[] { "Lorem", "ipsum" ,"dolor", "sit", "amet", "consectetur"};
                LinkedList<string> wordsList = new LinkedList<string>(words);
                if (listTest.FifthElementFromEnd(wordsList) == "ipsum")
                {
                    Assert.True(true);
                }
                else
                    Assert.True(false);

            }
            catch (Exception e)
            {
                Assert.True(false);
            }
        }


        [Fact]
        public void TestStringLong()
        {
            try
            {

                string[] words = new string[] { "Lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "Sed", "ut", "perspiciatis", "unde", "omnis", "iste", "natus", "error", "sit", "voluptatem", "accusantium", "doloremque", "laudantium", "totam" ,"rem", "aperiam", "eaque", "ipsa" };
                LinkedList<string> wordsList = new LinkedList<string>(words);
                if (listTest.FifthElementFromEnd(wordsList) == "totam")
                {
                    Assert.True(true);
                }
                else
                    Assert.True(false);

            }
            catch (Exception e)
            {
                Assert.True(false);
            }
        }
    }
}
