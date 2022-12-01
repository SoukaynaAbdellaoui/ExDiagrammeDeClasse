using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExDiagrammeDeClasse
{

    class exam
    {
        private string num;
        private string titre;
        private DateTime date;
        private int duree;
        private List<question> listeQuestion;

        public String getNum()
        {
            return num;
        }
        public String gettitre()
        {
            return titre;
        }
        public DateTime getdate()
        {
            return date;
        }

        public void ajouterQuestion(question question)
        {
            listeQuestion.Add(question);

        }
    }
}
