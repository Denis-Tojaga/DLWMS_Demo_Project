using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS_Demo
{
    public class InMemoryDB
    {
        public static List<Student> Studenti { get; set; }
        public static List<Profesor> Profesori { get; set; }
        public static List<Predmet> Predmeti { get; set; }

        public InMemoryDB()
        {
            Studenti = new List<Student>();
            Profesori = new List<Profesor>();
            Predmeti = new List<Predmet>();
            DodajBuiltInPredmete();
            DodajBuiltInProfesore();
            DodajProfesorePredmetima();
            DodajBuiltInStudente();
        }



        /// <summary>
        /// Dodavanje builtIn studenata i profesora u InMemoryDatabase
        /// </summary>
        private void DodajBuiltInProfesore()
        {
            Profesori.Add(new Profesor()
            {
                Ime = "Denis",
                Prezime = "Music",
                DatumRodjenja = DateTime.Parse("1.1.1980"),
                slikaProfesora=null,
                Email="denismusic@edu.fit.ba",
                Password="123123",
                Username="denis",
                Titula="profesor"
            });

            Profesori.Add(new Profesor()
            {
                Ime = "Elmir",
                Prezime = "Babovic",
                DatumRodjenja = DateTime.Parse("2.10.1990"),
                slikaProfesora = null,
                Email = "elmirbabovic@edu.fit.ba",
                Password = "123123",
                Username = "elmir",
                Titula = "profesor"
            });


            Profesori.Add(new Profesor()
            {
                Ime = "Emina",
                Prezime = "Junuz",
                DatumRodjenja = DateTime.Parse("5.1.1985"),
                slikaProfesora = null,
                Email = "eminajunuz@edu.fit.ba",
                Password = "123123",
                Username = "emina",
                Titula = "profesor"
            });


            Profesori.Add(new Profesor()
            {
                Ime = "Mohamed",
                Prezime = "Zayat",
                DatumRodjenja = DateTime.Parse("25.5.1985"),
                slikaProfesora = null,
                Email = "mohamedzayat@edu.fit.ba",
                Password = "123123",
                Username = "mohamed",
                Titula = "profesor"
            });

            Profesori.Add(new Profesor()
            {
                Ime = "Goran",
                Prezime = "Skondric",
                DatumRodjenja = DateTime.Parse("15.8.1975"),
                slikaProfesora = null,
                Email = "goranskondric@edu.fit.ba",
                Password = "123123",
                Username = "goran",
                Titula = "profesor"
            });
        }
        private void DodajBuiltInPredmete()
        {
            Predmeti.Add(new Predmet()
            {
                NazivPredmeta = "Programiranje 2",
                GodinaStudija = "Prva godina",
                ECTS = 7,
                BrojSati = 120
            });

            Predmeti.Add(new Predmet()
            {
                NazivPredmeta = "Baze podataka 2",
                GodinaStudija = "Druga godina",
                ECTS = 6,
                BrojSati = 110
            });

            Predmeti.Add(new Predmet()
            {
                NazivPredmeta = "Web razvoj i dizajn",
                GodinaStudija = "Prva godina",
                ECTS = 5,
                BrojSati = 110
            });

            Predmeti.Add(new Predmet()
            {
                NazivPredmeta = "Matematika 2",
                GodinaStudija = "Prva godina",
                ECTS = 7,
                BrojSati = 120
            });

            Predmeti.Add(new Predmet()
            {
                NazivPredmeta = "Razvoj softvera",
                GodinaStudija = "Treca godina",
                ECTS = 12,
                BrojSati = 220
            });
        }
        private void DodajBuiltInStudente()
        {
            Studenti.Add(new Student()
            {
                BrojIndeksa = GenerisiIndeks(),
                Ime = "Denis",
                Prezime = "Tojaga",
                DatumRodjenja = DateTime.Parse("2.8.2000"),
                SlikaStudenta=null,
                Email="IB200000@edu.fit.ba",
                Password="123123"
            });

            Studenti.Add(new Student()
            {
                BrojIndeksa = GenerisiIndeks(),
                Ime = "Anel",
                Prezime = "Memic",
                DatumRodjenja = DateTime.Parse("14.9.2000"),
                SlikaStudenta = null,
                Email = "IB200001@edu.fit.ba",
                Password = "123123"
            });

            Studenti.Add(new Student()
            {
                BrojIndeksa = GenerisiIndeks(),
                Ime = "Erin",
                Prezime = "Dzinic",
                DatumRodjenja = DateTime.Parse("14.9.2000"),
                SlikaStudenta = null,
                Email = "IB200002@edu.fit.ba",
                Password = "123123"
            });
        }

        /// <summary>
        /// Generator broja indeksa svakom studentu, svake akademske godine se mijenja
        /// </summary>
        private string GenerisiIndeks(){return $"IB{(DateTime.Now.Year - 2000)*10000 + Studenti.Count}"; }

        private void DodajProfesorePredmetima()
        {
            for (int i = 0; i < Predmeti.Count; i++)
                Predmeti[i].PredavacPredmeta = Profesori[i];
        }


    }
}
