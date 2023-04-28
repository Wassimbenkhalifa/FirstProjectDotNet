using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Garage : IGarage
    {
        public String adress { get; set; }

        public List<Automobile> autos;

        public Garage()
        {
           
            this.autos = new List<Automobile>();
        }


        public string AddAuto(Automobile au)
        {
            try
            {
                autos.Add(au);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string updateAuto(Automobile au)
        {
            try
            {
                int index = GetIndexAuto(au);
                if (index != -1)
                {
                    autos[index] = au;
                    return "";
                }
                else
                    return "auto non trouvee";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int GetIndexAuto(Automobile au)
        {
            int existIndex = -1;
            if (this.autos.Contains(au))
            {
                existIndex = this.autos.IndexOf(au);
                return existIndex;
            }
            else return existIndex;
        }

        public String DeleteAuto(String immatriculation)
        {
            try
            {
                foreach (Automobile aut in autos)
                {
                    if (aut.immatriulation == immatriculation)
                    {
                        autos.Remove(aut);
                    }
                    else
                        return "automobile introuvable";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "";
        }

        public Automobile GetAuto(String immatriculation)
        {

            foreach (Automobile aut in autos)
            {
                if (aut.immatriulation == immatriculation)
                {
                    return aut;
                }
            }
            return null;

        }

        public List<Automobile> AfficherAutomoiles(SubType soustype)
        {
            List<Automobile> autosAffichers = new List<Automobile>();
            if (this.autos != null)
            {
                foreach (Automobile aut in this.autos)
                {
                    switch (soustype)
                    {
                        case (SubType.Voiture):
                            if (aut is Voiture)
                                autosAffichers.Add(aut);
                            break;

                        case (SubType.Moto):
                            if (aut is Moto)
                                autosAffichers.Add(aut);
                            break;
                    }
                }
            }
            return autosAffichers;
        }

        public string UpdateAuto(Automobile au)
        {
            throw new NotImplementedException();
        }

        public List<Automobile> AfficherAutomobiles(SubType soustype)
        {
            throw new NotImplementedException();
        }
    }
}
