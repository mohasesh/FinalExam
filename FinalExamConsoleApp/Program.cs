using System;

namespace FinalExamConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Adult a = new Adult();
            a.firstname = "Mohammed";
            a.lastname = "Adem";
            child c = new child();
            c.firstname = "Ali";
            c.lastname = "Lake";
            string[] myarray = new string[4];
            myarray[0] = a.firstname;
            myarray[1] = a.lastname;
            myarray[2] = c.firstname;
            myarray[3] = c.lastname;
            for( int i=0;i<myarray.Length;i++)
            {
                Console.WriteLine(myarray[i]);
            }


        }
    }

    public class Adult
        {
           public string firstname;
           public string lastname ;
        }
    public class child
        {
            public string firstname;
            public string lastname ;
        }
    }

