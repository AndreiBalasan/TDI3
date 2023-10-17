using System;
using System.Collections.Generic;
using System.Text;

namespace TDI3
{
   public class Locomotiva
    {

        public decimal Putere { get; set; }


        public Locomotiva() {
        }

        public void PornesteLocomotiva()
        {

            Console.WriteLine("Locomotiva a pornit");

        }



        public void OpresteLocomotiva()
        {

            Console.WriteLine("Locomotiva s-a oprit");

        }
    }
}
