using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS_Demo
{
    public partial class ModUpravljanja : Form
    {
        private bool ModStudent = false;
        private bool ModAdministrator = false;
        public ModUpravljanja()
        {
            InitializeComponent();
        }

        private void ModUpravljanja_Load(object sender, EventArgs e)
        {
            InMemoryDB bazaPodataka = new InMemoryDB();
        }





        /// <summary>
        /// Biranje moda kojim zelimo upravljati
        /// </summary>
        private void pbAdministrator_Click(object sender, EventArgs e)
        {
            PromjeniBoju(lblStudent,lblAdministrator,pbStudent);
            ModAdministrator = true;
        }
        private void pbStudent_Click(object sender, EventArgs e)
        {
            PromjeniBoju(lblAdministrator, lblStudent, pbAdministrator);
            lblLoginMod.Text = "Unesite broj indeksa:";
            ModStudent = true;
        }







        /// <summary>
        /// Zakljucavanje mogucnosti odabira vise od jedanput, kada se klikne jedan mod drugi se zakljuca
        /// </summary>

        private void PromjeniBoju(Label labela1,Label labela2, PictureBox pBox)
        {
            labela1.Hide();
            pBox.Hide();
            labela2.BackColor = Color.White;
            labela2.ForeColor = Color.Black;
        }






        /// <summary>
        ///Logiranje sa korisnickim podacima u zavisnosti od moda koji smo izabrali, validacija polja na formi 
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ValidirajPolja() && ModStudent)
            {
                foreach (var student in InMemoryDB.Studenti)
                {
                    if(student.BrojIndeksa.Contains(txtUsername.Text) && student.Password.Contains(txtPassword.Text))
                    {
                        Hide();
                        frmStudentPodaci formaStudenta = new frmStudentPodaci(student);
                        formaStudenta.ShowDialog();
                        Close();
                    }
                }
                MessageBox.Show($"Uneseni podaci nisu validni, pokusajte ponovo!");
                return;
            }


            if(ValidirajPolja() && ModAdministrator)
            {
                foreach (var profesor in InMemoryDB.Profesori)
                {
                    if (profesor.Username.Contains(txtUsername.Text) && profesor.Password.Contains(txtPassword.Text))
                    {
                        //Hide();
                        //frmStudentPodaci formaStudenta = new frmStudentPodaci(profesor);
                        //formaStudenta.ShowDialog();
                        //Close();
                    }
                }
                MessageBox.Show($"Uneseni podaci nisu validni, pokusajte ponovo!");
                return;
            }
        }
        private bool ValidirajPolja()
        {
            return Validator.ValidirajPolje(txtUsername, err, "Ovo polje je obavezno!") &&
                 Validator.ValidirajPolje(txtPassword, err, "Ovo polje je obavezno!");
        }
    }
}
