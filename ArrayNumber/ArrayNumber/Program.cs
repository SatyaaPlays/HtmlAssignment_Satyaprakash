using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNumber
{

    public delegate void GameDetails();
    public delegate void PlayerDetails();

    public class Game
    {
        string game_name;
        string game_type;
        string player_name;
        string player_type;
        event GameDetails Games;
        event PlayerDetails Players;

        public Game()
        {
            game_name = "GTA V";
            game_type = "AAA";
            player_name = "Satyaprakash Pandey";
            player_type = "Pro";
        }

        void showGameDetails()
        {
            Console.WriteLine("Game Name {0}", game_name);
            Console.WriteLine("Game Type {0}", game_type);
        }

        void showPlayerDetails()
        {
            Console.WriteLine("Player Type {0}", player_type);
            Console.WriteLine("Player Name {0}", player_name);
        }

        static void Main(string[] args)
        {
            try
            {

                Game game = new Game();
                game.Games += new GameDetails(game.showGameDetails);
                game.Players += new PlayerDetails(game.showPlayerDetails);
                game.Games();
                game.Players();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("You are going to run anyhow, it doesn't matter how much exception is in program.");
            }

            Console.ReadKey();
        }

    }

//    internal class Program
//    {
//        //    //public delegate void deleg(int num1, int num2);
//        //    ////static void DelMethod(string message)
//        //    ////{
//        //    ////    Console.WriteLine(message);
//        //    ////}

//        //    //static void DelMethod1(int num1, int num2)
//        //    //{
//        //    //    Console.WriteLine(num1 + num2);
//        //    //}
//        //    //static void DelMethod2(int num1, int num2)
//        //    //{
//        //    //    Console.WriteLine(num1 - num2);
//        //    //}
//        //    //static void DelMethod3(int num1, int num2)
//        //    //{
//        //    //    Console.WriteLine(num1 * num2);
//        //    //}
//        //    //static void DelMethod4(int num1, int num2)
//        //    //{
//        //    //    Console.WriteLine(num1 / num2);
//        //    //}


//        delegate void intrest(float principal, int time, float rate);
//        delegate int processn(int n);

//        static void SimpleIntrest(float principal, int time, float rate)
//        {
//            Console.WriteLine(principal * time * rate);
//        }
//        static void CompoundIntrest(float principal, int year, float rate)
//        {
//            Console.WriteLine((principal * year * rate) / 100);
//        }
//        static void RealIntrest(float NI, int inf, float num = 0)
//        {
//            Console.WriteLine(NI - inf);
//        }

//        static void Main(string[] args)
//        {
//            try
//            {
//                string[][] customers = new string[2][];
//                customers[0] = new string[] { "101", "Aakash" };
//                customers[0] = new string[] { "102", "Satyaprakash" };

//                intrest intrest1 = new intrest(SimpleIntrest);
//                intrest1 += new intrest(CompoundIntrest);
//                intrest1 += new intrest(RealIntrest);

//                if (intrest1 != null)
//                {
//                    intrest1(20000, 2, 12.4f);
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }

//            //try
//            //{

//            //    processn t = (val1)=> {
//            //        int x = val1 * val1; 
//            //        return x; 
//            //    };
//            //    Console.WriteLine(t(5));
//            //Console.WriteLine("Enter a value: ");
//            //int value = Convert.ToInt32(Console.ReadLine());
//            //if (value == 0)
//            //{
//            //    throw new ExceptionHandle("Value cannot be zero");
//            //}
//            //if (value < 0)
//            //{
//            //    throw new ExceptionHandle("Value cannot be negative number");
//            //}

//            //deleg dgt = new deleg(DelMethod1);
//            //dgt += new deleg(DelMethod2);
//            //dgt += new deleg(DelMethod3);
//            //dgt += new deleg(DelMethod4);

//            //if (dgt != null) 
//            //{
//            //    dgt(20,10);
//            //}

//            //deleg dgt = new deleg(DelMethod);
//            //dgt("This is example of Delegates.");
       
//        //catch (Exception ex)
//        //{
//        //    Console.WriteLine(ex.Message);
//        //}
//        //finally
//        //{
//        //    Console.WriteLine("You are going to run anyhow, it doesn't matter how much exception is in program.");
//        //}

//        Console.ReadKey();
//    }
//}
}
