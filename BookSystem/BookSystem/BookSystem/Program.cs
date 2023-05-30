using BookSystem.BAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem
{
    public class Program
    {
        public static void ShowData()
        {
            List<Movies> list = new List<Movies>()
            {
                new Movies() {ID=1001,TITLE="Avatar",BOXOFFICE="$2787965087",ACTIVE="Yes",DATEOFLANUCH="15-03-2017",GENRE="Friction",HASTEASER="Yes"},
                new Movies() {ID=1002,TITLE="Avengers End Game",BOXOFFICE="$2787965087",ACTIVE="Yes",DATEOFLANUCH="23-12-2017",GENRE="Superhero",HASTEASER="No"},
                new Movies() {ID=1003,TITLE="Titanic",BOXOFFICE="$2787965087",ACTIVE="Yes",DATEOFLANUCH="21-08-2017",GENRE="Friction",HASTEASER="No"},
                new Movies() {ID=1004,TITLE="Captain Marvel",BOXOFFICE="$2787965087",ACTIVE="N0",DATEOFLANUCH="02-07-2017",GENRE="Superhero",HASTEASER="Yes"},
                new Movies() {ID=1005,TITLE="John Wick",BOXOFFICE="$2787965087",ACTIVE="Yes",DATEOFLANUCH="02-11-2022",GENRE="Friction",HASTEASER="Yes" }
             };
            List<Movies> Clist = new List<Movies>()
            {
                new Movies() {ID=1001,TITLE="Avatar",BOXOFFICE="$2787965087",ACTIVE="Yes",DATEOFLANUCH="15-03-2017",GENRE="Friction",HASTEASER="Yes"},
                new Movies() {ID=1002,TITLE="Iron Man",BOXOFFICE="$2787965087",ACTIVE="Yes",DATEOFLANUCH="23-12-2017",GENRE="Friction",HASTEASER="No"},
                new Movies() {ID=1003,TITLE="Titanic",BOXOFFICE="$2787965087",ACTIVE="Yes",DATEOFLANUCH="21-08-2017",GENRE="Friction",HASTEASER="No"},
            };

            int data = Convert.ToInt32(Console.ReadLine());

            if (data == 1)
            {
                Console.WriteLine("=======================================================================================");
                Console.WriteLine("                             Display movie for the Admin                               ");
                Console.WriteLine("=======================================================================================");
                Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
                Console.WriteLine("=======================================================================================");
                foreach (var num in list)
                {
                    Console.WriteLine(num.ID + "\t" + num.TITLE + "\t" + num.BOXOFFICE + "\t" + num.ACTIVE + "\t" + num.DATEOFLANUCH + "\t" + num.GENRE + "\t" + num.HASTEASER);

                }
                Console.WriteLine("=======================================================================================");
                Console.WriteLine("1.Search Data");
                Console.WriteLine("2.Exit");
                Console.WriteLine("(Enter 1 or 2)");
                int data2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=======================================================================================");
                if (data2 == 1)
                {
                    Console.WriteLine("Enter the ");
                    var data6 = Convert.ToInt32(Console.ReadLine());
                    Movies A = list.Find(movie => movie.ID == data6);
                    Console.WriteLine("=======================================================================================");
                    Console.WriteLine("                             Search movie for the Customer                               ");
                    Console.WriteLine("=======================================================================================");
                    Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
                    Console.WriteLine("=======================================================================================");

                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine(A.ID + "\t" + A.TITLE + "\t" + A.BOXOFFICE + "\t" + A.ACTIVE + "\t" + A.DATEOFLANUCH + "\t" + A.GENRE + "\t" + A.HASTEASER);

                    }
                    Console.WriteLine("=======================================================================================");
                }
                else if (data2 == 2)
                {
                    Console.WriteLine("Exit");
                }
            }
            else if (data == 2)
            {

                Console.WriteLine("=======================================================================================");
                Console.WriteLine("                             Display movie for the Customer                            ");
                Console.WriteLine("=======================================================================================");
                Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
                Console.WriteLine("=======================================================================================");
                foreach (var num in Clist)
                {
                    Console.WriteLine(num.ID + "\t" + num.TITLE + "\t" + num.BOXOFFICE + "\t" + num.ACTIVE + "\t" + num.DATEOFLANUCH + "\t" + num.GENRE + "\t" + num.HASTEASER);

                }
                Console.WriteLine("=======================================================================================");
                Console.WriteLine("Enter the operation performed on the favourities");
                Console.WriteLine("1.Add to favourities");
                Console.WriteLine("2.Remove from favourities");
                Console.WriteLine("3.Exit");
                Console.WriteLine("(Enter 1 or 2 or 3)");
                int data3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=======================================================================================");
                if (data3 == 1)
                {
                    Console.WriteLine("Enter the number of movies do you want to add");
                    int data4 = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < data4; i++)
                    {
                        Console.WriteLine("Enter the Id to add to favorite");
                        var data5 = Convert.ToInt32(Console.ReadLine());

                        Movies movieToAdd = list.Find(movie => movie.ID == data5);
                        if (movieToAdd != null)
                        {
                            Clist.Add(movieToAdd);
                            Console.WriteLine("Movie added to favorites!");
                        }
                        else
                        {
                            Console.WriteLine("Movie not found.");
                        }
                    }

                    Console.WriteLine("=======================================================================================");
                    Console.WriteLine("                             Display movie for the Customer                               ");
                    Console.WriteLine("=======================================================================================");
                    Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
                    Console.WriteLine("=======================================================================================");
                    foreach (var num in Clist)
                    {
                        Console.WriteLine(num.ID + "\t" + num.TITLE + "\t" + num.BOXOFFICE + "\t" + num.ACTIVE + "\t" + num.DATEOFLANUCH + "\t" + num.GENRE + "\t" + num.HASTEASER);

                    }
                    Console.WriteLine("=======================================================================================");
                }
                else if (data3 == 2)
                {
                    Console.Write("Enter the fav movie ID to remove: ");
                    int movieId = Convert.ToInt32(Console.ReadLine());
                    Movies movieToRemove = Clist.Find(movie => movie.ID == movieId);
                    if (movieToRemove != null)
                    {
                        Clist.Remove(movieToRemove);
                        Console.WriteLine("Movie removed successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Movie not found.");
                    }

                    Console.WriteLine("=======================================================================================");
                    Console.WriteLine("                             Display movie for the Customer                               ");
                    Console.WriteLine("=======================================================================================");
                    Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
                    Console.WriteLine("=======================================================================================");
                    foreach (var num in Clist)
                    {
                        Console.WriteLine(num.ID + "\t" + num.TITLE + "\t" + num.BOXOFFICE + "\t" + num.ACTIVE + "\t" + num.DATEOFLANUCH + "\t" + num.GENRE + "\t" + num.HASTEASER);

                    }
                    Console.WriteLine("=======================================================================================");
                }
                else if (data3 == 3)
                {
                    Console.WriteLine("Exit");
                }
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Specify Your Role");
            Console.WriteLine("1.Admin");
            Console.WriteLine("2.Customer");
            Console.WriteLine("(Enter 1 or 2)");
            ShowData();
            Console.ReadKey();
        }
    }

}
