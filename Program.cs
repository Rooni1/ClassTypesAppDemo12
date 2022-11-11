using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo12
{
    internal class Program :AbstractTest
    {

        public override int TestMethod()
        {

            return x + y;

        }
        public override int GetX
        {
            get
            {
                return x * 3;
            }
        }

        public override int GetY
        {
            get
            {
                return y * 2;
            }
        }

        static void Main(string[] args)
        {
            //AssignValues();
            //Program pr = new Program();
            //var result = pr.TestMethod();
            //Console.WriteLine(result);  
            //Console.WriteLine("x = {0}, y = {1}",pr.GetX, pr.GetY);
            //Console.ReadLine();
            //PartialTest partialTest = new PartialTest(8, 10);
            //partialTest.PrintMath1();
            //Console.ReadLine();
            //SealedTest st = new SealedTest();
            //var addition = st.Add(2, 6);
            //Console.WriteLine("Addition is :{0}", addition);
            //Console.ReadLine();
            int[] arr = { 1, 2, 3, 4, 5 };

            // Display values of array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            try
            {
                Console.WriteLine(arr[7]);

            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }
            Console.ReadLine();




        }
        public static void AssignValues()
        {
            Person person = new Person();
            Console.WriteLine("Enter Person Id");
            person.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            person.name = Console.ReadLine();
            Console.WriteLine("Enter Adress");
            person.Adress = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            person.MobileNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hej {0}", person.name);
            Console.ReadLine();
        }

        public Person GetPerson()
        {
            Person pr = new Person();
            return pr;
        }
     

       
    }
    
}

    

