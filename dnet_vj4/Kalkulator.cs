using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnet_vj4
{
    class Kalkulator
    {
        public delegate void NijeBrojDel();
        public event NijeBrojDel NijeBroj;



        public string OperandA;
        public string OperandB;
        public bool x;
        public bool y;

        public double Izracun(Form1.RacOperacija del)
        {   
            
            this.x = Double.TryParse(OperandA, out double a);
            this.y = Double.TryParse(OperandB, out double b);

            if(x == false || y == false)
                NijeBroj();
            return del(a, b);
           
           
        }

        
    }
}
