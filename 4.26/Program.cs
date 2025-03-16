// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
const int LIMITE = 10;
    int somma=0;
for (int i= 1; i < LIMITE; i++)
{
    Console.Write("Inserisci il numero{0}: ", i);
    int num = int.Parse(Console.ReadLine());
    somma += num;
    if (somma >= 100)

        break;

}

