using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Boxing();
            Unboxing();
            Struct();

            //out keyword in parameters
            string test = "Test";
            Console.WriteLine(test);
            string t = OutKeyword(out test);
            Console.WriteLine(test);

            //?: operator
            Employee emp = new Employee();
            emp.ID = -3;
        }

        //The concept of boxing and unboxing underlines the C# unified view of the type system in which a value of any type can be treated as an object.
        /// <summary>
        /// Boxing
        /// Boxing is the process of converting a value type data type to the object or to any interface
        /// data type which is implemented by this value type. When the CLR boxes a value means when CLR is converting a value type to Object Type, it wraps the value inside a System.Object and stores it on the heap area in application domain. 
        /// </summary>
        public static void Boxing()
        {
            int i = 111;
            object o = i;
            Console.WriteLine("Boxing: " + 0);
        }
        
        //Unboxing
        public static void Unboxing()
        {
            object o = 111;
            int i = (int)o; //explicit Unboxing
            Console.WriteLine("Unboxing: " + i);
        }




        ///Struct vs Class
        ///
        public struct structObj
        {
            public string firstname;
            public string lastname;
            public int id;

            public override string ToString()
            {
                return string.Format("{0} - {1} - {2}", this.firstname, this.lastname, this.id);
            }
        }
        public static void Struct()
        {
            //No need for new operator (this is unique to structs vs class)
            structObj obj;
            obj.firstname = "Test";
            obj.lastname = "TestLast";
            obj.id = 1;

            //List of structs
            List<structObj> list = new List<structObj>();
            for (int i = 0; i < 5; i++)
            {
                structObj o;
                o.firstname = "first" + i;
                o.lastname = "last" + i;
                o.id = i;
                list.Add(o);
            }
            foreach (structObj o in list)
                Console.WriteLine(o.ToString());
        }



        //Ref vs out - keywords
        //The out and ref keywords are useful when we want to return a value in the same variables as are passed as an argument
        public static string OutKeyword(out string s)
        {
            s = "Now 'Test' changes to this because of out keyword parameter";
            string toReturn = "Out";
            return (toReturn + s);
        }



        //Properties
        public class Employee
        {
            private int _ID;
            public int ID
            {
                get { return this._ID; }
                set
                {
                    _ID = value;
                    string _bool = (value > 0) ? "positive" : "negative";
                    Console.WriteLine("ID is " + _bool);
                }
            }
        }
    }
}
