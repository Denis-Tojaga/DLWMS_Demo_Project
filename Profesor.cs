using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS_Demo
{
    public class Profesor
    {
        public List<Predmet> PredmetiProfesora { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Titula { get; set; }
        public string Email { get; set; }
        public Image slikaProfesora { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }


        public Profesor()
        {
            PredmetiProfesora = new List<Predmet>();
        }
    }
}
