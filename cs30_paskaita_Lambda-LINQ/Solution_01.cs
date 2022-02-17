using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs30_paskaita_Lambda_LINQ
{
    public class Solution_01
    {

    
    public static void Solution_01_pt1()
        {
            // Sukurkite sąrašą su skaičiais.Sukurkite naują sąrašą ir jo reikšmei priskirkite pirmojo sąrašo Select grąžintą sąrašą.
            // Select metodas turi pakelti kiekvieną pirmojo sąrašo skaičių kvadratu.
            Console.WriteLine("Solution_01_pt1!");
            var intArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            intArray.Select(x => x*x);
            var intArray2 = intArray.Select(x => x*x);
            foreach (var x in intArray) { Console.WriteLine(x); }
            Console.WriteLine();
            foreach (var x in intArray2) { Console.WriteLine(x); }
            Console.WriteLine();
        }

        // Sukurkite sąraša teigiamų ir neigiamų elementų, sukurkite naują sąrašą iš jo su LINQ grąžinant tik teigiamus skaičius.
        public static void Solution_01_pt2()
        {
            Console.WriteLine("Solution_01_pt2!");
            var intArray = new int[] { 1, -2, 3, -4, 5, -6, 7 };
            var intArray2 = intArray.Select(x => x > 0); // <-- Select čia grąžina bool
            var intArray3 = intArray.Where(x => x > 0);
            foreach (var x in intArray) { Console.WriteLine(x); }
            Console.WriteLine();
            foreach (var x in intArray2) { Console.WriteLine(x); }
            Console.WriteLine();
            foreach (var x in intArray3) { Console.WriteLine(x); }
            Console.WriteLine();
        }

        // Sukurkite sąraša teigiamų ir neigiamų elementų, sukurkite naują sąrašą iš jo su LINQ grąžinant tik teigiamus skaičius kurie ne didesni už 10.
        public static void Solution_01_pt3()
        {
            Console.WriteLine("Solution_01_pt3!");
            var intArray = new int[] { 1, -2, 30, -4, 5, -6, 70 };
            var intArray2 = intArray.Where(x => x > 0).Where(x => x < 10);
            foreach (var x in intArray) { Console.WriteLine(x); }
            Console.WriteLine();
            foreach (var x in intArray2) { Console.WriteLine(x); }
            Console.WriteLine();
        }

        // Sukurkite skaičių sąrašą ir su LINQ surūšiuokite jį didėjančia tvarka.
        public static void Solution_01_pt4()
        {
            Console.WriteLine("Solution_01_pt4!");
            var intArray = new int[] { 1, -2, 30, -4, 5, -6, 70 };
            var intArray2 = intArray.OrderByDescending(x => -x);
            foreach (var x in intArray) { Console.WriteLine(x); }
            Console.WriteLine();
            foreach (var x in intArray2) { Console.WriteLine(x); }
            Console.WriteLine();
        }

        // Sukurkite skaičių sąrašą ir su LINQ surūšiuokite jį mažėjančia tvarka.
        public static void Solution_01_pt5()
        {
            Console.WriteLine("Solution_01_pt5!");
            var intArray = new int[] { 1, -2, 30, -4, 5, -6, 70 };
            var intArray2 = intArray.OrderByDescending(x => x);
            foreach (var x in intArray) { Console.WriteLine(x); }
            Console.WriteLine();
            foreach (var x in intArray2) { Console.WriteLine(x); }
            Console.WriteLine();
        }

        // Suraskite iš skaičių sąrašo didžiausią elementą naudodami LINQ.
        public static void Solution_01_pt6()
        {
            Console.WriteLine("Solution_01_pt6!");
            var intArray = new int[] { 1, -2, 30, -4, 5, -6, 70 };
            var number = intArray.Max(x => x);
            foreach (var x in intArray) { Console.WriteLine(x); }
            Console.WriteLine();
            Console.WriteLine(number);
            Console.WriteLine();
        }

        // Sukurkite klasę Person su parametrais Name ir Age, sukurkite sąrašą iš šių objektų.
        // Sukurkite naują sąrašą su LINQ paimdami tik žmonių vardus, kitą sąrašą tik iš amžiaus.
        public static void Solution_01_pt7()
        {
            Console.WriteLine("Solution_01_pt7!");
            var personList = new List<Person> { new Person ("Vytautas", 30), new Person("Gediminas", 35), new Person("Algirdas", 40) };
            var personNameList = personList.Select(x => x.Name);
            foreach (var x in personNameList) { Console.WriteLine(x); }
            Console.WriteLine();
            var personAgeList = personList.Select(x => x.Age);
            foreach (var x in personAgeList) { Console.WriteLine(x); }
            Console.WriteLine();
        }

        // Surūšiuokite sąrašą pagal amžių mažėjančia tvarka.
        public static void Solution_01_pt8()
        {
            Console.WriteLine("Solution_01_pt8!");
            var personList = new List<Person> { new Person("Vytautas", 30), new Person("Gediminas", 35), new Person("Algirdas", 40) };
            var personAgeList = personList.Select(x => x.Age).OrderByDescending(x => x);
            foreach (var x in personAgeList) { Console.WriteLine(x); }
            Console.WriteLine();
        }

        // Sukurkite naują sąrašą iš žmonių, kurių vardai prasideda iš A raidės.
        public static void Solution_01_pt9()
        {
            Console.WriteLine("Solution_01_pt9!");
            var personList = new List<Person> { new Person("Vytautas", 35), new Person("Gediminas", 35), new Person("Algirdas", 70),
                                                new Person("Aivaras", 40), new Person("Alvydas", 60), new Person("Egidijus", 40) };
            var personNameList = personList.Where(x => x.Name.StartsWith('A'));
            foreach (var x in personNameList) { Console.WriteLine(x.Name); }
            Console.WriteLine();

        }

        // Sukurkite naują sąrašą iš žmonių, kurių amžius yra virš 40 ir surūšiuokit pagal vardą.
        public static void Solution_01_pt10()
        {
            Console.WriteLine("Solution_01_pt10!");
            var personList = new List<Person> { new Person("Vytautas", 37), new Person("Gediminas", 38), new Person("Algirdas", 48),
                                                new Person("Alvydas", 100), new Person("Jonas", 39), new Person("Antanas", 51)  };
            var sortedList = personList.Where(x => x.Age > 40).OrderByDescending(x => x.Name);
            foreach (var x in sortedList) { Console.WriteLine($"{x.Name}, {x.Age}"); }
            Console.WriteLine();

        }
    }

    class Person
    {
        // Sukurkite klasę Person su parametrais Name ir Age, sukurkite sąrašą iš šių objektų.
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
