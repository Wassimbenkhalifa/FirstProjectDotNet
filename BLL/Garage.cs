using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Garage : IGarage
    {
        public string Adresse { get; set; }

        public List<Automobile> Autos { get; set; }
        public Garage()
        {
            Autos = new List<Automobile>();
        }
        public Garage(string adresse)
        {
            this.Adresse = adresse;
            Autos = new List<Automobile>();
        }

        public string AddAuto(Automobile au)
        {
            throw new NotImplementedException();
        }

        public List<Automobile> AfficherAutomobiles(SubType soustype)
        {
            throw new NotImplementedException();
        }

        public string DeleteAuto(string immatriculation)
        {
            throw new NotImplementedException();
        }

        public Automobile GetAuto(string immatriculation)
        {
            throw new NotImplementedException();
        }

        public int GetIndexAuto(Automobile a1)
        {
            throw new NotImplementedException();
        }
        public string UpdateAuto(Automobile au)
        {
            throw new NotImplementedException();
        }
    }
}
