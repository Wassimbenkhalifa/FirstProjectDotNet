using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Moto : Automobile
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string TypeV { get; set; }

        public Voiture(int annee, string Imm, string couleur, string marque, string typeV) : base(annee, Imm)
        {
            this.Couleur = couleur;
            this.Marque = marque;
            this.TypeV = typeV;
        }
        public Moto()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " " + Couleur + " " + Marque + " " + TypeV;
        }
    }
}
