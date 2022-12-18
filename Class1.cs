namespace test;

public static class perevod
{
    static public void names()
    {
        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine("Введите ваше имя: ");
        string name = Console.ReadLine();
        File.AppendAllText("C:\\Users\\Глеб\\Desktop\\ggvp.txt", name);
        if (key.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            program.text1();

        }

    }

}
