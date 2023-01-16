namespace BMI;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BMI arvutamine");

        Console.WriteLine("Sisesta oma kaal (kg):");
        var kaal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Sisesta oma pikkus (m):");
        var pikkus = Convert.ToDouble(Console.ReadLine());
        // BMI arvutamise valem ja valikud, mis annavad hinnangu kehakaalule.

        double bmi = kaal / (pikkus * pikkus);
        string misKaalus = "";

        switch (bmi)
        {
            case < 18.5:
                misKaalus = "Alakaaluline. Peaksid rohkem sööma!";
                break;
            case >= 18.5 and <= 24.9:
                misKaalus = "Normaalkaaluline";
                break;
            case >= 25 and <= 29.9:
                misKaalus = "Ülekaaluline. Peaksid rohkem sporti tegema!";
                break;
            case > 30:
                misKaalus = "Paks. Püüa rohkem liikuda ja tervislikumalt süüa!";
                break;
        }

        Console.WriteLine($"BMI: {bmi:0.#}");
        Console.WriteLine($"Sinu kehakaal:{misKaalus}");
    }
}
   