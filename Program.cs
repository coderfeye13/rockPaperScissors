using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int nWin = 0, nLose = 0;
            Console.Title = "Rock Paper Scissors";
            Console.WriteLine("\n\tBaşlamak için bir tuşa basınız.");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("\n\tTaş Kağıt Makas\n\t------------------\n\n", ConsoleColor.Yellow);
                Console.WriteLine("\t[1] ", ConsoleColor.White);
                Console.WriteLine("Taş\n", ConsoleColor.Gray);
                Console.WriteLine("\t[2] ", ConsoleColor.White);
                Console.WriteLine("Kağıt\n", ConsoleColor.Gray);
                Console.WriteLine("\t[3] ", ConsoleColor.White);
                Console.WriteLine("Makas\n", ConsoleColor.Gray);

                string userSelection = "x";
                bool selection = false;
                while (!selection)
                {
                    userSelection = Console.ReadKey(true).KeyChar.ToString();
                    selection = ShowSelection(userSelection,"Kulanıcı");
                }
                string computerSelection = new Random().Next(1, 4).ToString();
                ShowSelection(computerSelection, "Bilgisayar");
                if (userSelection.Equals(computerSelection))
                    Console.WriteLine(String.Format("\n\n\t{0} : {0} berabere. \n", GetElement(userSelection)), ConsoleColor.White);
                else if (userSelection == "1" && computerSelection == "2")
                {
                    Console.WriteLine("\n\n\tKağıt taşı sarar: Bilgisayar kazandı.\n", ConsoleColor.Magenta);
                    nLose++;
                }
                else if (userSelection == "1" && computerSelection == "3")
                {
                    Console.WriteLine("\n\n\tTaş makası kırar: Kullanıcı kazandı.\n", ConsoleColor.Green);
                    nWin++;
                }
                else if (userSelection == "2" && computerSelection == "1")
                {
                    Console.WriteLine("\n\n\tKağıt taşı sarar: Kullanıcı kazandı.\n", ConsoleColor.Green);
                    nWin++;
                }
                else if (userSelection == "2" && computerSelection == "3")
                {
                    Console.WriteLine("\n\n\tMakas kağıdı keser: Bilgisayar kazandı.\n", ConsoleColor.Magenta);
                    nLose++;
                }
                else if (userSelection == "3" && computerSelection == "1")
                {
                    Console.WriteLine("\n\n\tTaş makası kırar: Bilgisayar kazandı.\n", ConsoleColor.Magenta);
                    nLose++;
                }
                else if (userSelection == "3" && computerSelection == "2")
                {
                    Console.WriteLine("\n\n\tMakas kağıdı keser: Kullanıcı kazandı.\n", ConsoleColor.Green);
                    nWin++;
                }
                Console.WriteLine(String.Format("\n\tKullanıcı: {0} puan\n\tBilgisayar{1} puan",nWin,nLose),ConsoleColor.White);
            }
        }
        static string GetElement(string selection)
        {
            switch (selection)
            {
                case "1": return "Taş";   
                case "2": return "Kağıt";   
                case "3": return "Makas";   
                default: return String.Empty;
            }
        }
        static bool ShowSelection (string x, string user)
        {
            x = GetElement(x);
            if (x == String.Empty)
            {
                Console.WriteLine("\n\tYanlış seçim! Tekrar deneyin...\n",ConsoleColor.Red);
                return false;
            }
            Console.WriteLine(String.Format("\n\t{0}: {1}", user, x), ConsoleColor.Green);
            return true;
        }
    }
}
