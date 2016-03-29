using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorfisme
{
    class Program
    {
        public static void Main(String[] args) {
            Koe k = new Koe();	
            Eend e = new Eend(); 
            Dier[] ds = {k,e};

            foreach (Dier d in ds) {
                if (d.GetType() == k.GetType())
                {
                    Console.Write(k.toString());
                }
                else
                {
                    Console.Write(e.toString());
                }
                Console.WriteLine(" en ik zeg " + d.speak());
            }
            e.setKanVliegen(false);
            k.setLitersMelk(6);
            foreach (Dier d in ds) {
                
                if(d.GetType() == k.GetType()){
                    Console.Write(k.toString());
                }else{
                    Console.Write(e.toString());
                }
                Console.WriteLine(" en ik zeg " + d.speak());
            }
            Console.Read();
        }
        public abstract class Dier {
	        protected int aantalPoten;
	
	        public Dier() 	{ aantalPoten = 0; }	
	        public Dier(int aP)	{ aantalPoten = aP; }
	
	        public abstract String speak();
	
	        public String toString() {
		        return "Ik heb " + aantalPoten + " poten";
	        }
        }


        public class Koe : Dier {
	        private double litersMelk;
	
	        public Koe() :base(4) {  }
	
	        public void setLitersMelk(double lt) {
		        litersMelk = lt;
	        }
	
	        public override String speak() {
		        return "Boe!";
	        }
	
	        new public String toString() {
		        return "Ik ben een koe met " + litersMelk + " liters melk. "
         + base.toString();
	        }
        }

        public class Eend : Dier {
	        private bool kanVliegen;
	
	        public Eend():base(2) {
		        
		        kanVliegen = true;
	        }
	
	        public void setKanVliegen(bool b) {
		        kanVliegen = b;
	        }

            public override String speak()
            {
		        return "Kwek!";
	        }

            new public String toString()
            {
		        return "Ik ben een eend en ik kan " + (kanVliegen ? "wel" :
        "niet") + " vliegen. "+ base.toString();
	        }
        }

    }
}
