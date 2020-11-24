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
    public partial class frmStudentPodaci : Form
    {
        private Student _student;
        public frmStudentPodaci()
        {
            InitializeComponent();
            _student = new Student();
        }

        public frmStudentPodaci(Student student) : this()
        {
            if(student!=null)
                _student = student;
            UcitajPodatkeUFormu(_student);
        }

        private void UcitajPodatkeUFormu(Student student)
        {
            if(student!=null)
            {
                txtBrojIndeksa.Text = student.BrojIndeksa;
                txtIme.Text = student.Ime;
                txtPrezime.Text = student.Prezime;
                txtEmail.Text = student.Email;
                dgvPredmetiStudenta.DataSource = student.PredmetiStudenta;
                pbProfilnaStudenta.Image = student.SlikaStudenta;
            }else
                MessageBox.Show($"Nije moguce ucitati podatke,student nije pronadjen!");
        }

        private void frmStudentPodaci_Load(object sender, EventArgs e)
        {
            dgvPredmetiStudenta.Hide();
            //btnSaveChanges.Hide();
        }




        /// <summary>
        /// Odabir slike iz fajlova i mijenjanje iste studentu
        /// </summary>
        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            if(ofdSlika.FileName==txtPutanjaDoSlike.Text)
            {
                _student.SlikaStudenta = pbProfilnaStudenta.Image;
                MessageBox.Show($"Slika uspjesno spasena!");
            }
            else
                MessageBox.Show($"Molimo odaberite sliku iz galerije!");
        }
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                if(ofdSlika.ShowDialog() == DialogResult.OK)
                {
                    string putanjaDoFajla = ofdSlika.FileName;
                    pbProfilnaStudenta.Image = Image.FromFile(putanjaDoFajla);
                    txtPutanjaDoSlike.Text = putanjaDoFajla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }


        /// <summary>
        /// Funckionalnosti menija
        /// </summary>
        private void prikazPredmetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPredmetiStudenta.Show();
            dgvPredmetiStudenta.DataSource = _student.PredmetiStudenta;
        }



        private void dgvPredmetiStudenta_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmsMeni.Show(Cursor.Position);
        }

        private void dodajPredmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
