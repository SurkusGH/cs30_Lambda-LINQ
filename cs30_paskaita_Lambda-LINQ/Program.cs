using cs30_paskaita_Lambda_LINQ.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cs30_paskaita_Lambda_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs30_PASKAITA_λ-LINQ!");
            #region TEORIJA - λ-LINQ
            // input output
            Func<int, int> multiplyByFive = num => num * 5;
            Console.WriteLine(multiplyByFive(5));
            // Lambda =>
            Func<string, string> selector = str => str.ToUpper();
            Console.WriteLine(selector("labas"));
            string[] words = { "me", "you", "they" };
            var wordsToUpper = words.Select(selector);

            var wordsLINQ = words.Select(str => str.ToUpper());

            // Select() - naudojamas kai norima pasiimti VISUS elementus
            var wordsLINQ2 = words.Select(str => str == "you"); // false - true - false

            // Where()
            var wordsLINQ3 = words.Where(str => str == "you"); // you

            var wordsLINQ4 = words.Select(x => x.ToUpper()).Where(x => x.StartsWith("A")).OrderBy(x => x); //sortina by default abc tvarka

            // SingleOrDefault - gauni vieną arba default reikšmę: null (sting) arba 0 (skaičius)
            var list = new List<Person> { new Person(1, "Vytautas"), new Person(2, "Algirdas"), new Person(3, "Tomas") };
            var peopleOrder = list.OrderByDescending(person => person.Id);
            var person = list.SingleOrDefault(person => person.Name == "Vytautas");
            person.Name = "Giedrius"; // <-- pakeičiu anksčiau nutaikyto Vytauto vardą į Giedrius
             
            // Single()
            // var person2 = list.Single(person => person.Name == "Vytautas");

            var people2 = list.Where(person => person.Name.StartsWith("V")).
                               Where(person => person.Id < 2);
            #endregion

            #region TEORIJA - SELECTMANY

            // SelectMany() - Jeigu klasė Person ir ji viduje turi sąrašą Gyvūnų [...]
            
            // var people = new List<Person> { new Person ("Person1", new List<Pet> { new Pet ("Pet1"), new Pet ("Pet2") }}

            #endregion

            Solution_01.Solution_01_pt1();
            Solution_01.Solution_01_pt2();
            Solution_01.Solution_01_pt3();
            Solution_01.Solution_01_pt4();
            Solution_01.Solution_01_pt5();
            Solution_01.Solution_01_pt6();
            Solution_01.Solution_01_pt7();
            Solution_01.Solution_01_pt8();
            Solution_01.Solution_01_pt9();
            Solution_01.Solution_01_pt10();

            Solution_02.Solution_02_pt1();
            Solution_02.Solution_02_pt2();
            Console.WriteLine(Solution_02.Solution_02_pt3("Labas vakaras DRAUGAI labas rytas PRIEŠAI"));

        }
        #region TEORIJA - λ-LINQ | Teorijos klasė
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Person(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        class Pet
        {
            public string Name { get; set; }
            public List<Pet> Pets { get; set; }
        }
        #endregion
    }
}