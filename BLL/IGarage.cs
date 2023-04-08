using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public enum SubType
    { Voiture, Moto }
    internal interface IGarage
    {
       
      
            string AddAuto(Automobile au);
            string UpdateAuto(Automobile au);
            int GetIndexAuto(Automobile a1);
            string DeleteAuto(string immatriculation);
            Automobile GetAuto(string immatriculation);
            List<Automobile> AfficherAutomobiles
                (SubType soustype);
        }
    }

