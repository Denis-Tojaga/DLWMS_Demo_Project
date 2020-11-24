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

        public Student()
        {
            PredmetiStudenta = new List<Predmet>();
            DodajBuiltInPredmete();
            DodajBuiltInOcjene();
            PostaviProsjekPredmetima();
        }

        /// <summary>
        /// Dodavanje ugradjenih predmeta prilikom kreiranja studenta,kao i ocjena za taj predmet,za svaki predmet se odmah izracuna prosjek ocjena
        /// i postavlja u vrijednost propertyja
        /// </summary>
        private void DodajBuiltInOcjene()
        {
            foreach (var predmet in PredmetiStudenta)
            {
                predmet.OcjenePredmeta.Add(randomOcjena.Next(5, 10));
                predmet.OcjenePredmeta.Add(randomOcjena.Next(5, 10));
                predmet.OcjenePredmeta.Add(randomOcjena.Next(5, 10));
                predmet.OcjenePredmeta.Add(randomOcjena.Next(5, 10));
                predmet.OcjenePredmeta.Add(randomOcjena.Next(5, 10));
            }
        }
        private void DodajBuiltInPredmete()
        {
            PredmetiStudenta.Add(new Predmet()
            {
                NazivPredmeta = "Programiranje 2",
                GodinaStudija="Prva godina",
                OcjenePredmeta = new List<int>(),
            });

            PredmetiStudenta.Add(new Predmet()
            {
                NazivPredmeta = "Baze podataka 2",
                GodinaStudija = "Druga godina",
                OcjenePredmeta = new List<int>()
            });

            PredmetiStudenta.Add(new Predmet()
            {
                NazivPredmeta = "Web razvoj i dizajn",
                GodinaStudija = "Prva godina",
                OcjenePredmeta = new List<int>()
            });

            PredmetiStudenta.Add(new Predmet()
            {
                NazivPredmeta = "Matematika 2",
                GodinaStudija = "Prva godina",
                OcjenePredmeta = new List<int>()
            });

            PredmetiStudenta.Add(new Predmet()
            {
                NazivPredmeta = "Razvoj softvera",
                GodinaStudija = "Treca godina",
                OcjenePredmeta = new List<int>()
            });
        }
        private void PostaviProsjekPredmetima()
        {
            foreach (var predmet in PredmetiStudenta)
                predmet.ProsjekOcjena = IzracunajProsjekOcjena(predmet);
        }
        private double IzracunajProsjekOcjena(Predmet predmetStudenta)
        {
            double prosjek = 0;
            if (predmetStudenta.OcjenePredmeta.Count == 0)
                return prosjek;
            foreach (var ocjena in predmetStudenta.OcjenePredmeta)
                prosjek += ocjena;
            return prosjek / predmetStudenta.OcjenePredmeta.Count;
        }
    }
}
