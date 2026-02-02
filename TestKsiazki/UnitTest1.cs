using KsiazkaApp;

namespace TestKsiazki
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestowaniePierwszejStrony()
        {
            //Arange
            Ksiazka ksiazka = new Ksiazka("Strona1");
            Strona strona = new Strona("Strona1");
            //Act
            //Assert
            Assert.AreEqual(ksiazka.strony[0].trescStrony, strona.trescStrony);
        }
        [TestMethod]
        public void TestowanieWczytywaniaZPliku()
        {
            string daneZPliku = File.ReadAllText(@"C:\Users\Student\Desktop\Dane.txt");
            string[] tablicaStron = daneZPliku.Split(";");

            Ksiazka ksiazka = new Ksiazka(tablicaStron[0]);

            for (int i = 1; i < tablicaStron.Length; i++)
            {
                ksiazka.DodajStrone(tablicaStron[i]);
            }

            string daneDoTestowania = "Powrót do miasta nie by³ ju¿ ucieczk¹, lecz wyborem. Ulice wydawa³y siê jaœniejsze, a ludzie mniej obcy. Adam zatrzyma³ siê przy tym samym zegarze, który kiedyœ go niepokoi³. Tym razem uœmiechn¹³ siê, widz¹c jego niedok³adnoœæ. Czas nie by³ wrogiem, lecz towarzyszem. Wiedzia³, ¿e przed nim jeszcze wiele niewiadomych, ale nie ba³ siê ich jak dawniej. Z listem schowanym g³êboko w kieszeni ruszy³ przed siebie, gotów pisaæ dalsz¹ czêœæ w³asnej historii.";



            Assert.AreEqual(tablicaStron[tablicaStron.Length - 1].Trim(), daneDoTestowania);
        }
        [TestMethod]
        public void TestowanieIlosciStron()
        {
            string daneZPliku = File.ReadAllText(@"C:\Users\Student\Desktop\Dane.txt");
            string[] tablicaStron = daneZPliku.Split(";");

            Ksiazka ksiazka = new Ksiazka(tablicaStron[0]);

            for (int i = 1; i < tablicaStron.Length; i++)
            {
                ksiazka.DodajStrone(tablicaStron[i]);
            }

            Assert.AreEqual(tablicaStron.Length, 10);
        }
    }
}