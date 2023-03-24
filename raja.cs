using System;


namespace raja_mukabal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("hey hey hey listen this is so important think one two three four five six seven eight nine ten are you ready .. " +
                "" +
                "" +
                "" +
                "" +
                "no think");
            char[] arr = { '_', '_', '_', '_' };
            

            string Todayword =getTodayWord();
            int heart = Todayword .Length;
            int winner = 0;

            while (heart > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");

                }
                Console.WriteLine();
                char c = askuser();
                int result = checkletter(Todayword, c, arr);
                
                if (result == -1)
                {
                    heart--;
                    
                    Console.WriteLine("you have " + heart + " hearts left");

                }
                else
                {
                    arr[result] = c;
                }
                
                if (checkWin(arr) == 1)
                {
                    winner = 1;
                    break;
                }
                

                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
                Console.WriteLine();
            if (winner == 0)
            {
                Console.WriteLine("L0o0o0o0o0L");
            }
            else
            {
                Console.WriteLine("great job you winnn");
            }
            

        }
        public static char askuser()
        {
            Console.Write("Please enter a char: ");
            char c = Console.ReadLine()[0];
            return c;
        }
          public static  string getTodayWord()
          {
            string[] arr = { "raja", "loop","sori","samr","rami","gavi","sofi","sami","ball","real"};
            Random random = new Random();
            int rnd = random.Next(arr.Length);
            return arr[rnd];
          }
        
        
        static int checkletter(string todayWord,char ch, char[] list)
        {
            for (int i = 0; i < todayWord.Length; i++)
            {
                if (todayWord[i] == ch && list[i] != ch)
                {
                    return i;
                }
            }
            return -1;
        }

        static int checkWin(char[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == '_') {
                    return -1;
                }
            }
            return 1;
  
        }
    }
            
 }

