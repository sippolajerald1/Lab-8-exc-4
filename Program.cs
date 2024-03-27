namespace Lab_8_exc_4
{
    using System;
    using System.Linq;

    class famousPeople
    {
        public string? Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }


    public class Program
    {


        static void Main(string[] args)
        {


            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
     };
             var over1900people = from s in stemPeople
                                  where s.BirthYear > 1900
                                  select s;
            
            Console.WriteLine("People born after 1900");
            Console.WriteLine();
            foreach (famousPeople s in over1900people) {  
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine(("Birth year: " + s.BirthYear));
            
            }

   /********************************************************************/         

            var lowerCasell = from s in stemPeople
                      where s.Name.Contains("ll")
                      select s;


            Console.WriteLine("");
            Console.WriteLine("Names with two lowercase l's");
            foreach(famousPeople std  in lowerCasell)
            {
                Console.WriteLine("Name: " + std.Name);
                Console.WriteLine("-------------------------");
            }

/**************************************************************/
        
            var birth1950 = from std in stemPeople
                            where  std.BirthYear > 1950
                            && std.Name.Count() > 0
                            select std;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Birthdays after 1950: ");
            Console.WriteLine();

            foreach(famousPeople std in birth1950)
            {
            
                Console.WriteLine("Name: " + std.Name + " " + std.BirthYear);
               
            }
            Console.WriteLine("Count: " + birth1950.Count());


/****************************************************************/


            var birthBetween20and2000 = from st in stemPeople
                                        where st.BirthYear >= 1920  
                                        where st.BirthYear <= 2000
                                        orderby st.BirthYear.ToString()
                                        select st;
                                        var birthCount = birthBetween20and2000.Count();
            Console.WriteLine();
            Console.WriteLine("Birthdays between 1920-2000:");
            Console.WriteLine();
            
            foreach(famousPeople st in birthBetween20and2000)
                 { Console.WriteLine(st.Name);
                Console.WriteLine(st.BirthYear);
            }
            Console.WriteLine("BirthCount: " + birthCount);


            /************************************************************************************/
            Console.WriteLine();
            Console.WriteLine();

            var between1960and2015 = from a in stemPeople
                                     where a.DeathYear > 1960
                                     where a.DeathYear < 2015
                                     orderby a.Name
                                     group a by a.Name;
                                     

            // Iterate each group
            foreach(var ageGroup in between1960and2015)
            {
         
                // Each group has inner collection you can access and display
                foreach(famousPeople a in ageGroup)
                {
                    Console.WriteLine("Persons Name: (Death between 1960-2015) " + a.Name);

                }
                Console.WriteLine();
            } 
                                      
        }
    }

}

