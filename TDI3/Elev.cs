using System;
using System.Collections.Generic;
using System.Text;

namespace TDI3
{
    public class Elev
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public List<int> Note { get; set; }

        public Elev(string Nume, string Prenume, List<int> Note)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.Note = Note;
        }

        public decimal GetMedieElev(List<int> note)
        {
            decimal medie = 0;

            foreach (var item in note)
            {
                medie += item;
            }

            medie /= note.Count;

            return medie;
        }

        public string GetNoteElev(Elev elevul)
        {

            StringBuilder elev = new StringBuilder();


            elev.Append( elevul.Nume + " " + elevul.Prenume + ": ");


            foreach (var item in elevul.Note)
            {
                elev.Append(item + ", ");
            }
            string result = elev.ToString();
            result = result.TrimEnd(',', ' ');
            result = result + ".";

            return result;
        }
    }
}