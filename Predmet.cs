using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS_Demo
{
    public class Predmet
    {
        public string NazivPredmeta { get; set; }
        public string GodinaStudija { get; set; }
        public int ECTS { get; set; }
        public int BrojSati { get; set; }
        public  int OcjenaPredmeta { get; set; }

        public Profesor PredavacPredmeta { get; set; }

        public Predmet()
        {
            PredavacPredmeta = new Profesor();
        }
    }
}
