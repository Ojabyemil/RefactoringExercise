namespace RefactoringExercise
{
    internal class Program
    {
        static void Main()
        {   
            int answer = -1;
            while (answer != 0)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?\n 1. A line\n 2. My Line\n 3. A Square\n 4. My Square\n 5. A border\n 6. My border\n 0. Exit");
                int.TryParse(Console.ReadLine(), out answer); //Parses the given string into an int, if it can't then returns 0
                switch (answer)
                {
                    case 1:
                        Console.Write("\n #  #  #  #  #  # "); //Writes the following line
                        break;
                    case 2:
                        Console.Write("How many hashtags (max 10)? ");
                        int.TryParse(Console.ReadLine(), out int times);
                        Console.WriteLine();
                        for (int i = 0; i < times && i < 10; i++)  //Writes each part of the line until the given length or at max 10
                        {
                            Console.Write(" # ");
                        }
                        break;
                    case 3:
                        Console.Write("\n##########\n##########\n##########\n##########\n##########"); //Writes a 5x5 square
                        break;
                    case 4:
                        Console.Write("How many hashtags (max 10)? ");
                        int.TryParse(Console.ReadLine(), out times);
                        Console.WriteLine();
                        for (int i = 0; i < times && i < 10; i++)  //Writes out the square to the given length, or at max 10
                        {
                            for (int j = 0; j < times && j < 10; j++)
                            {
                                Console.Write("##");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.Write("\n #  #  #  #  #  #  #  #  #  #  #  #  #  #  #  #  # ");  //Writes the border
                        Console.WriteLine("\n# Static Border #");
                        Console.Write("\n #  #  #  #  #  #  #  #  #  #  #  #  #  #  #  #  # ");
                        break;
                    case 6:
                        Console.WriteLine("Write a text of max 20 characters long:");
                        string innerText = Console.ReadLine();
                        if (innerText.Length > 20)  //Makes sure that the given string isn't too long
                        {
                            Console.Write("\nToo long");
                            break;
                        }
                        Console.WriteLine();
                        for (int i = 0; i < innerText.Length + 4; i++)  //Writes the border to fit the given string
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine("\n# " + innerText + " #");
                        for (int i = 0; i < innerText.Length + 4; i++)
                        {
                            Console.Write("#");
                        }
                        break;
                }
                Console.WriteLine("\n \n Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
