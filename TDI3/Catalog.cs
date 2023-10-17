using System;
using System.Collections.Generic;
using System.Text;

namespace TDI3
{
    public class Catalog
    {
            public string NumeClasa { get; set; }

            public List<Elev> Elevi { get; set; }

            public Catalog(string NumeClasa, List<Elev> elevi)
            {
                this.NumeClasa = NumeClasa;
                this.Elevi = elevi;
            }

            public Catalog()
            {
            }


        // Prima Varianta de la prima problema   ///  O functie care va returna un string continand numele clasei si al fiecarui elev in parte. ///////
            //public string GetClasaElev(Catalog catalog)
            //{
            //    string numeElev = "";
            //    string clasa = catalog.NumeClasa + ": ";

            //    foreach (var item in catalog.Elevi)
            //    {
            //        numeElev = item.Nume + " " + item.Prenume + ", ";
            //        clasa += numeElev;
            //    }
            //    clasa =  clasa.TrimEnd(',',' ');
            //    clasa = clasa + ".";

            //    return clasa;
            //}

        // A doua varianta cu stringBuilder ///   O functie care va returna un string continand numele clasei si al fiecarui elev in parte. /////

        public string GetClasaElev(Catalog catalog)
        {

            StringBuilder clasa = new StringBuilder();
            clasa.Append(catalog.NumeClasa + " formata din urmatori elevi: ");

            foreach (var item in catalog.Elevi)
            {
                string numeElev = item.Nume + " " + item.Prenume + ", ";
                clasa.Append(numeElev);
            }
            string result = clasa.ToString();
            result = result.TrimEnd(',',' ');
            result = result + ".";

            return result;
        }

        public string GetPremiantul(Catalog catalog)
            {
       
            string elev = "";
                int nota = 0;

                foreach (var item in catalog.Elevi)
                {
                    foreach (var element in item.Note)
                    {
                        if (item.GetMedieElev(item.Note) > nota)
                        {
                            nota = element;
                            elev = item.Nume + " " + item.Prenume;
                        }
                    }
                }
                return elev;
            }
        }
    }
