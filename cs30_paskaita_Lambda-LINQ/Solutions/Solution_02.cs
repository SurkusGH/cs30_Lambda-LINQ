using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs30_paskaita_Lambda_LINQ.Solutions
{
    public class Solution_02
    {
        public static void Solution_02_pt1()
        {
            Console.WriteLine("Solution_02_pt1!");
            //Sukurkite Person klasę su vardu ir sąrašu gyvūnų(irgi nauja klasė, gyvūnai turi tik vardą).
            //Sukurkite sąrašą su Person objektais ir viduje esančiais gyvūnų sąrašais.

            var personList = new List<Person> { new Person("Vytautas", new List<Pet>
                                              { new Pet("Rūkas"), new Pet("Fibi"), new Pet("Rokis")}),
                                                new Person("Giedrius", new List<Pet>
                                              { new Pet("Mikis"), new Pet("Tikis"), new Pet("Rikis")}),
                                                new Person("Jonas", new List<Pet>
                                              { new Pet("Likis"), new Pet("Kikis"), new Pet("Pikis")})
            };
            //Su LINQ Select ir SelectMany sukurkite sąrašą kurį sudarys visi gyvūnai iš sąrašo.
            var selectorList = personList.SelectMany(x => x.Pets);
            foreach (var x in selectorList) { Console.WriteLine($"{x.Name}"); }
            Console.WriteLine();
        }



        public static void Solution_02_pt2()
        {
            Console.WriteLine("Solution_02_pt2!");

            var personList = new List<Person2> { new Person2("Vytautas", new List<PetsWithAgeData>
                                               { new PetsWithAgeData("Rūkas", 2), new PetsWithAgeData("Fibi", 3), new PetsWithAgeData("Alpis", 4)}),
                                                 new Person2("Giedrius", new List<PetsWithAgeData>
                                               { new PetsWithAgeData("Airis", 5), new PetsWithAgeData("Akis", 6), new PetsWithAgeData("Aikis", 7)}),
                                                 new Person2("Jonas", new List<PetsWithAgeData>
                                               { new PetsWithAgeData("Kas", 8), new PetsWithAgeData("Kikis", 9), new PetsWithAgeData("Awhateva", 10)})
            };
            //Kitas sąrašas, kurį sudarys tik gyvūnai, kurių vardai prasideda iš A raidės.
            //Pridėkite prie Pet klasės amžių int Age, sudarykite kitą sąrašą iš gyvūnų, kurių vardai prasideda iš A raidės ir jų amžius yra virš 5 metų.
            var selectorList = personList.SelectMany(x => x.Pets).Where(x => x.Name.StartsWith('A')).Where(x => x.Age > 5);
            foreach (var x in selectorList) { Console.WriteLine($"{x.Name}, {x.Age}"); }
            Console.WriteLine();
        }

        public static IEnumerable<string> Solution_02_pt3(string parameter)
        {
            Console.WriteLine("Solution_02_pt3!");
            //Parašykite metodą, kuris priima vieną string parametrą. Parašykite LINQ funkcionalumą, kad grąžintų uppercase žodžius iš string.
            var upperCaseWords = parameter.Split(' ').Where(w => w == w.ToUpper());
            foreach (var x in upperCaseWords) { Console.WriteLine(x); }
            return upperCaseWords; //<-- Kažkas netaip...

        }

        class Person
        {
            //Sukurkite Person klasę su vardu ir sąrašu gyvūnų(irgi nauja klasė, gyvūnai turi tik vardą).
            public string Name { get; set; }
            public List<Pet> Pets { get; set; }

            public Person(string name, List<Pet> pets)
            {
                Name = name;
                Pets = pets;
            }
        }

        class Pet
        {
            //Sukurkite Person klasę su vardu ir sąrašu gyvūnų(irgi nauja klasė, gyvūnai turi tik vardą).
            public string Name { get; set; }

            public Pet(string name)
            {
                Name = name;
            }
        }
        class Person2
        {
            //Sukurkite Person klasę su vardu ir sąrašu gyvūnų(irgi nauja klasė, gyvūnai turi tik vardą).
            public string Name { get; set; }
            public List<PetsWithAgeData> Pets { get; set; }

            public Person2(string name, List<PetsWithAgeData> pets)
            {
                Name = name;
                Pets = pets;
            }
        }

        class PetsWithAgeData
        {
            //Kitas sąrašas, kurį sudarys tik gyvūnai, kurių vardai prasideda iš A raidės.
            //Pridėkite prie Pet klasės amžių int Age, sudarykite kitą sąrašą iš gyvūnų, kurių vardai prasideda iš A raidės ir jų amžius yra virš 5 metų.
            public string Name { get; set; }
            public int Age { get; set; }

            public PetsWithAgeData(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}
