using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExDiagrammeDeClasse
{
    class noteFinale
    {
        private condidat candidate;
        private exam ex;
        private List<reponse> reponse;
        private int ScoreTotal;

        public noteFinale(condidat candidate, exam ex)
        {
            this.candidate = candidate;
            this.ex = ex;
            this.reponse = new List<reponse>();

        }
        public void ajouterReponse(reponse res)
        {
            reponse.Add(res);
        }


    }
    }

