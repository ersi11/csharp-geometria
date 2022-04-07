using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{

    // ---- classe rettangolo ------

    internal class rettangolo
    {
     public int baseRettangolo;
     public int altezzaRettangolo;
       


    // ------ costruttore -----

        public rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

    //---------- calcolo perimetro del rettangolo ------------

        public int PerimetroRettangolo()
        {
            int perimetro = 2 * (baseRettangolo + altezzaRettangolo);
            return perimetro;
        }

        //-------- calcolo area del rettangolo ------       

        public int AreaRettangolo()
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;
        }

        public void StampaRettangoloConsole()
        {
            Console.WriteLine("perimetro è:  " + PerimetroRettangolo());
            Console.WriteLine("area è:  " + AreaRettangolo());
        }

        //------- stampare 2 rettangoli eserizio 3 -----
        
        public void StampaRettangolo1()
        {
          

        }




    }
}
