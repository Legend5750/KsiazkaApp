using KsiazkaApp;

string daneZPliku = File.ReadAllText(@"C:\Users\Student\Desktop\Dane.txt");
string[] tablicaStron = daneZPliku.Split(";");

Ksiazka ksiazka = new Ksiazka(tablicaStron[0]);

for (int i = 1; i < tablicaStron.Length; i++)
{
    ksiazka.DodajStrone(tablicaStron[i]);
}   

foreach (Strona str in ksiazka.strony)
{
    if (str.numerStrony == 1)
    {
        Console.WriteLine($"Numer strony: {str.numerStrony} \nTytuł strony: {str.trescStrony}");
    }
    else
    {
        Console.WriteLine($"Numer strony: {str.numerStrony} \nTreść strony: {str.trescStrony}");
    }

}