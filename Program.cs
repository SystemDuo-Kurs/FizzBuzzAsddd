do
{
    int maxBroj;
    do
    {
        Console.Write("Unesite broj (od 5 navise): ");
        maxBroj = int.Parse(Console.ReadLine());
        if (maxBroj < 5)
        {
            Console.WriteLine("Jok!");
        }
        else
        {
            break;
        }
    } while (true);

    for (int brojac = 1; brojac <= maxBroj; brojac++)
    {
        Console.Write(brojac);

        if (brojac % 3 == 0)
        {
            Console.Write(" Fizz ");
        }

        if (brojac % 5 == 0)
        {
            Console.Write(" Buzz ");
        }

        Console.WriteLine();
    }
} while (true);