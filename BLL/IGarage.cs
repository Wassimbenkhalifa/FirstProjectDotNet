using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public enum SubType
    {
        Voiture, Moto
    };
    internal interface IGarage
    {

        String AddAuto(Automobile au);
        String updateAuto(Automobile au);
        int GetIndexAuto(Automobile au);
        String DeleteAuto(String immatriculation);

        Automobile GetAuto(String immatriculation);
        List<Automobile> AfficherAutomoiles(SubType soustype);
    }
}

