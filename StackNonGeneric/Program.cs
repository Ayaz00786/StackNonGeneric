using System;
using System.Collections;

namespace StackNonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack list = new Stack();

            //-----------Stack Push----------

                    list.Push("php");
                    list.Push("java");
                    list.Push("css");
                    list.Push("html");
                    list.Push("sql");

                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine(item);
                    //}

            //---------Stack Pop----------

                    //list.Pop();
                    //list.Pop();

                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine(item);
                    //}

            //---------Stack Peek-----------
            
                     //Console.WriteLine(list.Peek());

            //--------Stack Clear---------

                    //list.Clear();
                    //foreach (var item in list)
                    //{
                    //    Console.WriteLine(item);
                    //}

            //-----------stack clone---------

            var list2= (Stack) list.Clone();
            list.Clear();  //Clear first list without affecting second list 
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
