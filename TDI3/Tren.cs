using System;
using System.Collections.Generic;
using System.Text;

namespace TDI3
{
    public class Tren
    {
        public string Name { get; set; }
        public Locomotiva Locomotiva { get; set; }

        public List<VagonMarfa> VagoaneMarfa { get; set; }
        public List<VagonPersoane> VagoanePersoane { get; set; }
        public List<VagonClasaI> VagoaneClasaI { get; set; }


     

        public Tren() {
            this.VagoaneMarfa = new List<VagonMarfa>();
            this.VagoanePersoane = new List<VagonPersoane>();
            this.VagoaneClasaI = new List<VagonClasaI>();

        }

        public void AdaugaVagoane(Vagon vagon)
        {
            if(vagon.TipVagon == (int)TipuriVagoane.Marfa)
            {
                this.VagoaneMarfa.Add(new VagonMarfa(vagon));
            }
            if(vagon.TipVagon == (int)TipuriVagoane.Persoane)
            {
                this.VagoanePersoane.Add(new VagonPersoane(vagon));
            }
            if (vagon.TipVagon == (int)TipuriVagoane.ClasaI)
            {
                this.VagoaneClasaI.Add(new VagonClasaI(vagon));
            }
        }

        public void AdaugaVagoane(VagonMarfa vagon)
        {
                this.VagoaneMarfa.Add(vagon);
        }

        public void AdaugaVagoane(VagonPersoane vagon)
        {
            this.VagoanePersoane.Add(vagon);
        }

        public void AdaugaVagoane(VagonClasaI vagon)
        {
            this.VagoaneClasaI.Add(vagon);
        }
        public void PleacaDinGara()
        {
            foreach (var vagonPersoane in this.VagoanePersoane)
            {
                vagonPersoane.ConfirmaUsiInchise();
            }
            foreach (var vagonClasaI in this.VagoaneClasaI)
            {
                vagonClasaI.ConfirmaUsiInchise();
            }
            this.Locomotiva.PornesteLocomotiva();
        }
        public void OpresteInGara()
        {
            this.Locomotiva.OpresteLocomotiva();

            foreach (var vagonPersoane in this.VagoanePersoane)
            {
                vagonPersoane.ConfirmaUsiDeschise();
            }
            foreach (var vagonClasaI in this.VagoaneClasaI)
            {
                vagonClasaI.ConfirmaUsiDeschise();
                vagonClasaI.GetStopAC();
            }
        }

    }
}