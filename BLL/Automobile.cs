using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Automobile
    {
        public int année { get; set; }
        public string immatriculation { get; set; }
        public Automobile(int année, string immatriculation)
        {
            this.année = année;
            this.immatriculation = immatriculation;
        }
        public Automobile() { }
        
        public void afficher() { }
        public override string toString() {
        return  année.ToString() + " " + immatriculation;
        }
    }
}
