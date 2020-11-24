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
        public  List<int> OcjenePredmeta { get; set; }
        public double ProsjekOcjena { get; set; }

        public Profesor PredavacPredmeta { get; set; }

        public Predmet()
        {
            OcjenePredmeta = new List<int>();
            PredavacPredmeta = new Profesor();
        }
    }
}
