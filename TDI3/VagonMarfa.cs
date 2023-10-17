using System;
using System.Collections.Generic;
using System.Text;

namespace TDI3
{
    public class VagonMarfa : Vagon
    {
        public int TipMarfa { get; set; }
        public int Capacitatea { get; set; }
        public VagonMarfa()
        {
           
        }
        public VagonMarfa(Vagon vagon)
        {
            Masa = vagon.Masa;
            AnulFabricatiei = vagon.AnulFabricatiei;
            TipVagon = vagon.TipVagon;
    }
    }
}
