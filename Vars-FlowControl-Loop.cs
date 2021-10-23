using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{

    class Person
    {
        public string name;
        public string surname;
        public int age;
    }


    class Program
    {
        static void Main(string[] args)
        {
            //variables & types
            int num1;
            num1 = 10;
            int num2 = 45;

            int tot = num1 + num2;
            Console.WriteLine(tot);

            string vorname = "Ergin";
            string nachame = "Cetin";

            string vorundnachname = vorname + " " + nachame;

            Console.WriteLine(vorundnachname);

            //ARRAYS

            int[] nums = { 1, 5, 77, 931541 };

            Console.WriteLine("first number: {0} ", nums[0]);


            //control blocks

            // IF
            int grade = 10;

            if (grade > 45)
            {
                Console.WriteLine("succeeded");
            }
            else
            {

                Console.WriteLine("failed");
            }

            //switch case

            string name = "Ahmet";


            switch (name)
            {
                case "Ergin":
                    Console.WriteLine("You are {0} ", name);

                    break;

                case "Ahmet":
                    Console.WriteLine("You are {0}", name);
                    break;

                default:
                    Console.WriteLine("default case runs....");
                    break;
            }


            //for loop

            for (int a = 0; a < nums.Length; a++)
            {
                Console.WriteLine("{0}", nums[a]);
            }

            //

            int b = 15;
            while (b > 0)
            {

                Console.WriteLine("b: {0} ", b);
                b--;
            }

            //


            foreach (var item in nums)
            {
                Console.WriteLine(" {0}", item);
            }

            //CLASSES AND OBJECTS GENERATION

            Person p1 = new Person();

            p1.name = "Ergin";
            p1.surname = "Bolukbasi";
            p1.age = 34;

            Console.WriteLine("Age: {0} - Name: {1}  Surname: {2}", p1.age, p1.name, p1.surname
                );


            // another way to generate object


            Person p2 = new Person() {age = 45, name = "erden", surname = "vbbbb"} ;
            Console.WriteLine(p2.age);


            Console.Read();

        }
    }
}
