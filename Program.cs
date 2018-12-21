using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomed = new Random().Next(49) + 1; // nombre Aléatoire
            int numberTry = 0;
            bool find = false;
            Console.SetCursorPosition(20,1);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Saisissez un nombre entre 1 et 50 :");
            while (!find)
            {
                string picked = Console.ReadLine();
                int pickedValue;
                if (int.TryParse(picked, out pickedValue))
                {
                    if (pickedValue == randomed)
                        find = true; // on sort de la boucle car find = true
                    else
                    {
                        if (pickedValue < randomed)
                        {
                            //Console.Clear();
                            //Console.WriteLine("Saisissez un nombre entre 1 et 50 :");
                            Console.WriteLine("Trop petit ...");
                        }
                        else
                        {
                            //Console.Clear();
                            //Console.WriteLine("Saisissez un nombre entre 1 et 50 :");
                            Console.WriteLine("Trop grand ...");
                        }
                    }
                    numberTry++;
                }
                else
                    Console.WriteLine("Le nombre saisie est incorrecte, veuillez recommencer ...");
            }
            if (numberTry == 1)
                Console.WriteLine("BRAVO ! Vous avez trouvé en " + numberTry + " coup");
            else
                Console.WriteLine("BRAVO ! Vous avez trouvé en " + numberTry + " coups");
        }
    }
}
