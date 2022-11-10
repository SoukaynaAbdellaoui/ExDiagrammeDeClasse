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
        private Exam exam;
        private List<reponse> reponse;
        private int ScoreTotal;

        public noteFinale(condidat candidate, Exam exam)
        {
            this.candidate = candidate;
            this.exam = exam;
            this.reponse = new List<reponse>();
            this.ScoreTotal = 0;
        }
        public void ajouterReponse(reponse res)
        {
            reponse.Add(res);
        }

        public void scoreCalcul(Func<string, int> getQuestion)
        {
            foreach (reponse res in reponse)
            {
                if (res.question is questionOuverte)
                {
                    ScoreTotal += getQuestion(res.question.statement);
                }
                else
                {
                    ScoreTotal += res.question.ScoreInitiale;


                }
            }
        }
    }

    class responses
    {
    }
}

