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
            dgvPredmetiStudenta.AutoGenerateColumns = false;
            _student = new Student();
        }

        public frmStudentPodaci(Student student) : this()
        {
            if(student!=null)
                _student = student;
            UcitajPodatkeUFormu(_student);
        }


        /// <summary>
        /// Ucitavanje podataka studenta koji se logirao na sistem
        /// </summary>
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
            lblBrojPolozenih.Hide();
            OnemoguceBoxove();
        }

        private void OnemoguceBoxove()
        {
            txtBrojIndeksa.Enabled = false;
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtEmail.Enabled = false;
            btnChangePhoto.Enabled = false;
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
            lblBrojPolozenih.Show();
            lblBrojPolozenih.Text += _student.BrojPolozenih.ToString();
            dgvPredmetiStudenta.Show();
            dgvPredmetiStudenta.DataSource = _student.PredmetiStudenta;
        }





        /// <summary>
        /// Desnim klikom na predmet se prikazuje opcija za detaljni pregled predmeta 
        /// </summary>
        private void dgvPredmetiStudenta_MouseClick(object sender, MouseEventArgs e)
        {
            cmsMeni.Show(Cursor.Position);
        }
        private void checkDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Predmet kliknutiPredmet = dgvPredmetiStudenta.SelectedRows[0].DataBoundItem as Predmet;
            frmDetaljnoOPredmetu detaljiPredmeta = new frmDetaljnoOPredmetu(kliknutiPredmet);
            if (detaljiPredmeta.ShowDialog() == DialogResult.OK)
                Show();
        }
        private void urediPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OmoguciBoxove();
        }
        private void OmoguciBoxove()
        {
            txtBrojIndeksa.Enabled = true;
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            txtEmail.Enabled = true;
            btnChangePhoto.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (ValidacijaPolja())
            {
                _student.BrojIndeksa = txtBrojIndeksa.Text;
                _student.Ime = txtIme.Text;
                _student.Prezime = txtPrezime.Text;
                _student.Email = txtEmail.Text;
                MessageBox.Show($"Podaci uspjesno azurirani!","Edit mode successfull");
                btnSaveChanges.Hide();
            }else
                MessageBox.Show($"Podaci nisu azurirani,doslo je do greske!", "Edit mode unsuccessfull");
        }

        private bool ValidacijaPolja()
        {
            return Validator.ValidirajPolje(txtBrojIndeksa, err2, "This field is required!") &&
                Validator.ValidirajPolje(txtIme, err2, "This field is required!") &&
                Validator.ValidirajPolje(txtPrezime, err2, "This field is required!") &&
                Validator.ValidirajPolje(txtEmail, err2, "This field is required!") &&
                Validator.ValidirajPolje(pbProfilnaStudenta, err2, "This field is required!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
