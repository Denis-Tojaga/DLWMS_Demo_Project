using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS_Demo
{
    public class Student
    {
        private Random randomOcjena = new Random();
        public List<Predmet> PredmetiStudenta { get; set; }
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public string Email { get; set; }

        public Image SlikaStudenta { get; set; }

        public string Password { get; set; }
        public  double  ProsjekOcjena { get; set; }

        public Student()
        {
            PredmetiStudenta = new List<Predmet>();
            DodajBuiltInPredmete();
            DodajBuiltInOcjeneStudentu();
            ProsjekOcjena=PostaviProsjekStudentu();
        }

        /// <summary>
        /// Dodavanje ugradjenih predmeta prilikom kreiranja studenta,kao i ocjena za taj predmet,za svaki predmet se odmah izracuna prosjek ocjena
        /// i postavlja u vrijednost propertyja
        /// </summary>
        private void DodajBuiltInOcjeneStudentu()
        {
            foreach (var predmet in PredmetiStudenta)
                predmet.OcjenaPredmeta=randomOcjena.Next(5, 10);
        }
        private void DodajBuiltInPredmete()
        {
            foreach (var predmet in InMemoryDB.Predmeti)
                PredmetiStudenta.Add(predmet);
        }
        private double PostaviProsjekStudentu()
        {
            double ProsjekStudenta = 0;
            if (PredmetiStudenta.Count == 0)
                return ProsjekStudenta;
            foreach (var predmet in PredmetiStudenta)
                predmet.OcjenaPredmeta += predmet.OcjenaPredmeta;
            return ProsjekStudenta / PredmetiStudenta.Count;
        }
    }
}
