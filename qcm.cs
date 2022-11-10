using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDiagrammeDeClasse
{
    internal class Qcm
    {



        class qcm: question
        {
            private List<proposition> items;
            private int ScoreInitial { get; set; }

            public qcm(int score)
            {
                ScoreInitial = score;
            }
            public void ajouterproposition(proposition prop)
            {
                items.Add(prop);
            }
        }
    }
}

