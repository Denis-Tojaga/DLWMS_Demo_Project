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
            btnSaveChanges.Hide();
        }

        private void btnPrikaziPredmete_Click(object sender, EventArgs e)
        {
            dgvPredmetiStudenta.Show();
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            if(ofdSlika.ShowDialog() == DialogResult.OK)
            {
                string putanja = ofdSlika.FileName;
                pbProfilnaStudenta.Image = Image.FromFile(putanja);
                btnSaveChanges.Show();
            }
        }

        private void dgvPredmetiStudenta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                cmsMeni.Show(Cursor.Position);
            }
        }
    }
}
