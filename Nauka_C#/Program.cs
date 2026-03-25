
try
{
    double promien;

    Console.WriteLine("Podaj promien");
    string wejscie = Console.ReadLine();

    promien = double.Parse(wejscie);
    double Pole = Math.PI * promien * promien;
    Console.WriteLine($"Pole wynosi: {Pole}");

}
catch (Exception x)
{
    Console.WriteLine("Nieprawidlowe dane");
}