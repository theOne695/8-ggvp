using System;
using System.Text;

namespace test
{
    internal class program
    {

        static void Main(string[] args)
        {

            perevod.names();

        }

        static void vvod()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                switch (a)
                {
                    case 1:
                        vvod();
                        break;
                    
                    case 2:
                        timer1();
                        break;

                    case 3:
                        text1();
                        break;

                } 
                a = Convert.ToInt32(Console.ReadLine());
            }
        }


        public static void timer1()
        {
            text1();
            Thread timer = new Thread(_ =>
            {
                Console.SetCursorPosition(100, 10);
                int time = 60;
                while (time != 0)
                {
                    Thread.Sleep(1000);
                    time--;
                    Console.WriteLine("Осталось " + time + " секунд");
                }
            });
            timer.Start();  
        }

       public static void text1()
       {
            int position = 1;
            int letter = 1;
            int letter2 = 0;
            string text2 =
                "Эта книга адресована всем, кто изучает русский язык. Но состоит она не из правил, упражнений и учебных текстов. Для этого созданы другие замечательные учебники. У этой книги совсем иная задача.";
            Console.WriteLine(text2);
            Console.SetCursorPosition(0, 0);
            List<char> chel = new List<char>();
            foreach (char i in text2)
            {
                chel.Add(i);
            }

            for (int i = 0; i < chel.Count; i++)
            {
                var key = Console.ReadKey();
                if (key.KeyChar == chel[i])
                {
                    Console.ForegroundColor = System.ConsoleColor.Green;
                    letter++;
                    position++;
                }

                if (key.KeyChar != chel[i])
                {
                    Console.ForegroundColor = System.ConsoleColor.Cyan;
                    letter2++;
                    position++;
                }

                if (key.Key == ConsoleKey.Backspace)
                {
                    Console.ForegroundColor = System.ConsoleColor.DarkRed;
                    i--;
                    
                    position--;
                    position--;
                    Console.WriteLine(chel[position]);
                    Console.SetCursorPosition(0, 0);
                    if (key.KeyChar != chel[i])
                    {
                        letter2--;
                    }

                    if (key.KeyChar == chel[i])
                    {
                        letter--;
                    }

                }
            }
       }
    }
}
