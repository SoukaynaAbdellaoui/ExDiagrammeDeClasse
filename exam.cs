using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDiagrammeDeClasse
{
   
        class exam
        {
            private string id;
            private string titre;
            private DateTime ouverture;
            private int duree;
            private List<question> questionsList;
            public void ajouterQuestion(question question)
            {
                questionsList.Add(question);
            }
        }
}
