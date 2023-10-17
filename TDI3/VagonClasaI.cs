using System;
using System.Collections.Generic;
using System.Text;

namespace TDI3
{
    public class VagonClasaI : VagonPersoane
    {
        public VagonClasaI() { }

        public VagonClasaI(Vagon vagon)
        {
            Masa = vagon.Masa;
            AnulFabricatiei = vagon.AnulFabricatiei;
            TipVagon = vagon.TipVagon;
        }

        public void GetStartAC()
        {
            Console.WriteLine("Porneste aerul conditionat");
        }


        public void GetStopAC()
        {
            Console.WriteLine("Aerul conditionat a fost oprit in vagonul " + this.NumarVagon);
        }
    }
}
