using System;
using System.Collections.Generic;
using System.Text;

namespace TDI3
{
    public class VagonPersoane : Vagon
    {
        public int NumarLocuri { get; set; }

        public VagonPersoane()
        {

        }

        public VagonPersoane(Vagon vagon)
        {
            Masa = vagon.Masa;
            AnulFabricatiei = vagon.AnulFabricatiei;
            TipVagon = vagon.TipVagon;
        }
    
        public void ConfirmaUsiDeschise()
        {
             Console.WriteLine("Usile " + this.NumarVagon + " s-au deschis");
        }


        public void ConfirmaUsiInchise()
        {
            Console.WriteLine("Usile vagonului " + this.NumarVagon + " s-au inchis");

        }
    }
}
