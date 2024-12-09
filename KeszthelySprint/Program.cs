namespace KeszthelySprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzok> versenyzok = new();
            foreach (var sor in File.ReadAllLines("eredmenyek.txt"))
            {
                versenyzok.Add(new Versenyzok(sor));
            }
            Console.WriteLine($"2.feladat:Enyien versenyeztek{versenyzok.Count()}");

            int a = 0;

            foreach (var j in versenyzok)
            {
                if (j.Kategoria == "elit junior")
                {
                    a ++;
                }
            }
            Console.WriteLine($"3.feladat:Enyien voltak elit juniorok: {a} fő");

            //4
            int össz_életkor = 0;
            foreach (var v in versenyzok)
            {
                össz_életkor += DateTime.Now.Year - v.Szuletes;
            }
            Console.WriteLine($"4.feladat: Átlag életkor: {(össz_életkor / versenyzok.Count()):0.0} év");

            //Console.WriteLine($"4.feladat: Átlag életkor: {Math.Round(össz_életkor / versenyzok.Count,1):0.0} év");
        }
    }
}
