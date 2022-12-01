using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDiagrammeDeClasse
{
    internal class qcm
    {



        class Qcm : question
        {
            private List<proposition> listeProposition;


            public Qcm()
            {

            }
            public void ajouterproposition(proposition prop)
            {
                listeProposition.Add(prop);
            }
        }
    }
}

