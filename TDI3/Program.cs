using System;
using System.Collections.Generic;

namespace TDI3
{
      class Program
    {
        static void Main(string[] args)
        {
            // Ex1

            Elev elev1 = new Elev("Popa", "Ion", new List<int>(){ 10, 9, 8 });
            Elev elev2 = new Elev("Ionescu", "Vasile", new List<int>(){ 7, 5, 6 });
            Elev elev3 = new Elev("Georgescu", "Maria", new List<int>(){ 6, 10, 9 });

            List<Elev> elevi = new List<Elev>();
            elevi.Add(elev1);
            elevi.Add(elev2);
            elevi.Add(elev3);

            Catalog catalog = new Catalog()
            {
                NumeClasa = "ClasaZero",
                Elevi = elevi
            };

            Console.WriteLine(catalog.GetPremiantul(catalog) + " are cea mai mare medie din " + catalog.NumeClasa);

            Console.WriteLine("Aceasta este " + catalog.GetClasaElev(catalog));

            foreach (var elev in elevi)
            {
                Console.WriteLine(elev.GetNoteElev(elev));
                Console.WriteLine("Media este " + elev.GetMedieElev(elev.Note) + ".");
            }


            // Ex2


            Tren TrenulSibiuBucuresti = new Tren();

            TrenulSibiuBucuresti.Name = "Trenul Sibiu - Bucuresti";
            TrenulSibiuBucuresti.Locomotiva = new Locomotiva()
            { Putere = 2500};

             TrenulSibiuBucuresti.AdaugaVagoane(new VagonMarfa() { Masa = 2500, AnulFabricatiei = 1986, NumarVagon = 7655, TipVagon = (int)TipuriVagoane.Marfa, Capacitatea = 3, TipMarfa = (int)TipMarfa.Otel });
            TrenulSibiuBucuresti.AdaugaVagoane(new VagonMarfa() { Masa = 3000, AnulFabricatiei = 1996, NumarVagon = 7875, TipVagon = (int)TipuriVagoane.Marfa, Capacitatea = 5, TipMarfa = (int)TipMarfa.Carbuni });
            TrenulSibiuBucuresti.AdaugaVagoane(new VagonMarfa() { Masa = 7000, AnulFabricatiei = 2000, NumarVagon = 3245, TipVagon = (int)TipuriVagoane.Marfa, Capacitatea = 4, TipMarfa = (int)TipMarfa.Cereale });
            TrenulSibiuBucuresti.AdaugaVagoane(new VagonPersoane() { Masa = 1500, AnulFabricatiei = 2007, TipVagon = (int)TipuriVagoane.Persoane, NumarVagon = 2255, NumarLocuri = 175 });
            TrenulSibiuBucuresti.AdaugaVagoane(new VagonPersoane() { Masa = 1500, AnulFabricatiei = 2022, TipVagon = (int)TipuriVagoane.Persoane, NumarVagon = 1255, NumarLocuri = 210 });
            TrenulSibiuBucuresti.AdaugaVagoane(new VagonPersoane() { Masa = 1500, AnulFabricatiei = 2017, TipVagon = (int)TipuriVagoane.Persoane, NumarVagon = 3385, NumarLocuri = 200 });
            TrenulSibiuBucuresti.AdaugaVagoane(new VagonClasaI() { Masa = 1500, AnulFabricatiei = 2017, TipVagon = (int)TipuriVagoane.Persoane, NumarVagon = 1085, NumarLocuri = 150 });
            TrenulSibiuBucuresti.AdaugaVagoane(new VagonClasaI() { Masa = 1500, AnulFabricatiei = 2020, TipVagon = (int)TipuriVagoane.Persoane, NumarVagon = 7585, NumarLocuri = 210 });
            TrenulSibiuBucuresti.AdaugaVagoane(new VagonClasaI() { Masa = 1500, AnulFabricatiei = 2022, TipVagon = (int)TipuriVagoane.Persoane, NumarVagon = 2358, NumarLocuri = 210 });


            TrenulSibiuBucuresti.PleacaDinGara();
            TrenulSibiuBucuresti.OpresteInGara();





        }
    }
}
