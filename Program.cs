class Program
{

    static void Main(string[] args)
    {
        Menu();
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finalizado.");
        Thread.Sleep(2000);
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S - Segundos => 1s = 1 segundo");
        Console.WriteLine("M - Minutos => 1m = 1 minuto");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();

        if (data.Substring(0, 1) != "0")
            PreStart();

        Stopwatch(data);
    }

    static void Stopwatch(string data)
    {
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;

        if (time == 0)
        {
            Console.Clear();
            Console.WriteLine("Bye bye!");
            Thread.Sleep(1500);
            Console.Clear();
            System.Environment.Exit(0);
        }

        Start(time * multiplier);
    }

    static void PreStart()
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Go!");
        Thread.Sleep(1000);
    }
}