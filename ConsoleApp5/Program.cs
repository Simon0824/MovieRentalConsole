using System;
namespace Program
{
    class Zadanie
    {
        
        class Film
        {
            protected string tytul;
            protected int liczbaWypozyczen;

            public Film()
            {
                this.tytul = string.Empty;
                this.liczbaWypozyczen = 0;
            }
            public void SetTytul(string tytuluzytkownika)
            {
                tytul = tytuluzytkownika;
            }

            public string GetTytul()
            {
                return tytul;
            }
            public int GetWypozyczenia()
            {
                return liczbaWypozyczen;
            }
            public void PrzechowujWypozyczenia()
            {
                liczbaWypozyczen++;
            }
        }
        static void Main(string[] args)
        {
            Film film = new Film();
            film.SetTytul("Mojfilmik");
            Console.WriteLine(film.GetTytul());
            Console.WriteLine(film.GetWypozyczenia());
            film.PrzechowujWypozyczenia();
            Console.WriteLine(film.GetWypozyczenia());
        }
    }
}
