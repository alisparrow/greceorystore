using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komisiyonmelk
{
    class komesiyon
    {
        //filed hai vase class mored nazar
      
       private  double KomesiyoneDoTaraf;
     //constactor vase inke meghdar komesiyone ro begirim
     public komesiyon() {

            this.KomesiyoneDoTaraf = 0;
        }

        //feild hai public ma
             public  ulong TotallKomesiyone;
            public const uint Sadmilion = 100000000;
         public const uint Divestmilion = 200000000;
        public const uint Divestopanjahmilion = 250000000;
        //metod hai ke estefadeh meshan
        public void PlanOne()
        {
            if (TotallKomesiyone <= Sadmilion)
               KomesiyoneDoTaraf +=TotallKomesiyone * 0.01;
            else
                KomesiyoneDoTaraf += Sadmilion * 0.01;
        }
        public void PlanTow()
        {
            if (TotallKomesiyone <= Divestmilion)
               KomesiyoneDoTaraf += (Divestmilion - TotallKomesiyone) * 0.007;
            else
               KomesiyoneDoTaraf += (Divestmilion - Sadmilion) * 0.007;
        }
        public void PlanThree()
        {
            if (TotallKomesiyone <= Divestopanjahmilion)
               KomesiyoneDoTaraf += (Divestopanjahmilion - TotallKomesiyone) * 0.005;
            else
               KomesiyoneDoTaraf += ((Sadmilion + Divestmilion) - Divestopanjahmilion) * 0.005;
        }
        public void PlanFour()
        {
           KomesiyoneDoTaraf += (TotallKomesiyone- Divestopanjahmilion) * 0.0025;
        }
        public double Streamoutput
        {
            get { return KomesiyoneDoTaraf; }
        }
    }
    }


