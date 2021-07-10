using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            //A constructor initializes when you create a new instance.

            #endregion

            #region question 2

            //If you create 7 new instances, the constructor will initialize 7 times.

            #endregion

            #region question 3

            //The return value of a constructor is the name of the class it is in.

            #endregion

            #region question 4

            /*Constructors can be used to get all the required information you need from a new instance.
              For example of a person(id, full name, phone number etc..)
              and only then put those details into an instance.*/

            #endregion

            #region question 5

            //Constructor overloading is the ability to add constructors if needed.

            #endregion

            #region question 6

            //You can call a constructor from a different constructor using: ":this(constructor parameter)".

            #endregion

            #region question 7

            Car myBrand = new Car("Ferrari");
            Car.GetBrand(myBrand._brand);

            #endregion

            #region question 8

            ConsolePlus cp1 = new ConsolePlus();

            ConsolePlus cp2 = new ConsolePlus("String");

            ConsolePlus cp3 = new ConsolePlus(2, 2);

            Console.WriteLine();

            #endregion

            #region question 9

            Console.WriteLine("Please enter array length");
            int lengthOfArr = int.Parse(Console.ReadLine());
            string[] myNameArr = new string[lengthOfArr];
            int[] myAgeArr = new int[lengthOfArr];

            string[] nameAndAge = new string[lengthOfArr];

            Random nameRnd = new Random();
            Random ageRnd = new Random();
            for (int i = 0; i < lengthOfArr; i++)
            {
                Console.WriteLine("Please enter a name");
                string nameToCtor = Console.ReadLine();
                Person myPerName = new Person(nameToCtor);
                myNameArr[i] = myPerName._name;

                int nameRandomizer = nameRnd.Next(0, lengthOfArr);
                int ageToCtor = ageRnd.Next(1, 101);
                Person myPerAge = new Person(myNameArr[nameRandomizer], ageToCtor);

            }

            for (int i = 0; i < lengthOfArr; i++)
            {
                int nameRandomizer = nameRnd.Next(0, lengthOfArr);

                int ageToCtor = ageRnd.Next(1, 101);
                Person myPerAge = new Person(myNameArr[nameRandomizer], ageToCtor);

                nameAndAge[i] = "Name: \"" + myPerAge._name + "\"." + "Age: " + myPerAge._age;
            }

            for (int i = 0; i < lengthOfArr; i++)
            {
                Console.WriteLine(nameAndAge[i]);
            }

            #endregion
        }
    }

    public class Car
    {
        public string _brand;

        public Car(string brand)
        {
            _brand = brand;
        }

        public static string GetBrand(string userBrand)
        {
            return userBrand;
        }
    }

    public class ConsolePlus
    {
        public string _userString;
        public int _Num1;
        public int _Num2;

        public ConsolePlus()
        {
            Console.WriteLine("Default");
        }

        public ConsolePlus(string userString) : this()
        {
            _userString = userString;
            Console.WriteLine(_userString);
        }

        public ConsolePlus(int num1, int num2)
        {
            _Num1 = num1;
            _Num2 = num2;

            Console.WriteLine(_Num1 + _Num2);
        }

        public ConsolePlus(string userString, int num1, int num2) : this(userString)
        {

        }
    }

    public class Person
    {
        public string _name;
        public int _age;

        public Person(string name)
        {
            _name = name;
        }

        public Person(string name, int age) : this(name)
        {
            _age = age;
        }


    }
}
