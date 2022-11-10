using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDiagrammeDeClasse
{
    internal class reponse
    {
        internal questionOuverte question;

        class Response
        {
            private question quest
            {
                get { return quest; }
            }
            private int score;
            private Qcm question;

            private List<string> reponse
            {
                get { return reponse; }
            }

            private void ajouterReponse(object rep)
            {
                ajouterReponse(rep, reponse);
            }

            void ajouterReponse(Object rep, List<string> reponse)
            {
                if (question is Qcm)
                {
                    reponse.Add((string)rep);
                }
                else
                {
                    reponse.Insert(0, (string)rep);
                }
            }
        }
    }
}

