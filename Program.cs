double alt, ct1, ct2;

string sx;

Console.Clear();

Console.WriteLine("--- Saiba seu peso ideal ---");

Console.WriteLine("Digite sua altura em metros");
alt = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("Sexo [M]asculino / [F]eminino...:");
sx = Console.ReadLine();

ct1 = alt * 72.7 - 58;

ct2 = alt * 62.1 - 44.7;

if ( sx == "m" )
{
    Console.WriteLine($"Seu peso ideal é {ct1}");
}
else if ( sx == "f" )
{
    Console.WriteLine($"Seu peso ideal é {ct2}");
}