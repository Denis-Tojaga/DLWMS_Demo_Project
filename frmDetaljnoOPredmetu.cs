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
    public partial class frmDetaljnoOPredmetu : Form
    {
        private Predmet _predmet;
        public frmDetaljnoOPredmetu()
        {
            InitializeComponent();
            _predmet = new Predmet();
        }

        public frmDetaljnoOPredmetu(Predmet predmet) : this()
        {
            if(predmet!=null)
                _predmet = predmet;
        }


        /// <summary>
        /// Ucitavanje podataka o odabranom predmetu i njegovim ocjenama
        /// </summary>
        private void frmDetaljnoOPredmetu_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOPredmetu(_predmet);
        }
        private void UcitajPodatkeOPredmetu(Predmet predmet)
        {
            lblNazivPredmeta.Text = predmet.NazivPredmeta;
            lblPredavac.Text = predmet.PredavacPredmeta.ToString();
            lblBrojSati.Text = predmet.BrojSati.ToString();
            lblECTS.Text = predmet.ECTS.ToString();
            lblOcjena.Text = predmet.OcjenaPredmeta.ToString();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
