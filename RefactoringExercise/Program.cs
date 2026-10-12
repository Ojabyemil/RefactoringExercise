using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RefactoringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //REFAKTORISERA KODEN
            //Fixa koden så den blir bättre att läsa och underhålla.
            //Lägg fokus på:
            //1- Undvik Repeterad kod. Ersätt den för metoder
            //2- Lägg kommentarer. Du kan väl gyssa vad koden gör och lägga den som kommentärer
            //3- Validera input. dvs, parsa och kolla att det är i rätt typ
            //4- Hantera errors. Informera om fel och/eller skapa kod som inte crashar.
            //5- Ge feedback till användaren. Om den skriver fel ska den få veta varför.
            
            int answer = -1;

            while (answer != 0)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?\n 1. A line\n 2. My Line\n 3. A Square\n 4. My Square\n 5. A border\n 6. My border\n 0. Exit");
                answer = int.Parse(Console.ReadLine());

                //Example Comment
                if (answer == 1)
                {
                        Console.WriteLine("");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(" # ");
                        }
                }else if(answer == 2)
                {
                    Console.Write("How many hashtags (max 10)? ");
                    int times = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    for (int i = 0; i < times; i++)
                    {
                        Console.Write(" # ");
                    }
                }
                else if(answer == 3)
                {
                    Console.WriteLine("");
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("##");
                        }
                        Console.WriteLine();
                    }
                }
                else if(answer == 4)
                {
                    Console.Write("How many hashtags (max 10)? ");
                    int times = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    for (int i = 0; i < times; i++)
                    {
                        for (int j = 0; j < times; j++)
                        {
                            Console.Write("##");
                        }
                        Console.WriteLine();
                    }
                }
                else if (answer == 5)
                {
                    Console.WriteLine("");
                    for (int i = 0; i < 17; i++)
                    {
                        Console.Write(" # ");
                    }
                    Console.WriteLine("\n# Static Border #");
                    for (int i = 0; i < 17; i++)
                    {
                        Console.Write(" # ");
                    }
                }
                else if(answer == 6)
                {
                    Console.WriteLine("Write a text of max 20 characters long:");
                    string innerText= Console.ReadLine();
                    Console.WriteLine("");
                    for (int i = 0; i < innerText.Length+4; i++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine("\n# "+innerText+" #");
                    for (int i = 0; i < innerText.Length+4; i++)
                    {
                        Console.Write("#");
                    }

                }

                Console.WriteLine("\n \n Press any key to continue...");
                Console.ReadKey();
                
            }
        }
    }
}
