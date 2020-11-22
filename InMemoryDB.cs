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



        public InMemoryDB()
        {
            Studenti = new List<Student>();
            Profesori = new List<Profesor>();
            DodajBuiltInStudente();
            DodajBuiltInProfesore();
        }


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
            }) ;

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

        

        private string GenerisiIndeks()
        {
            return $"IB{(DateTime.Now.Year - 2000)*10000 + Studenti.Count}";
        }
    }
}
