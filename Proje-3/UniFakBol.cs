using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_3
{
    public partial class UniFakBol : Form
    {
        DataModel dataModel = new DataModel();
        public UniFakBol()
        {
            InitializeComponent();
        }

        private void UniFakBol_Load(object sender, EventArgs e)
        {
            comboBoxUni.ValueMember = "ID";
            comboBoxUni.DisplayMember = "Isim";
            List<Universite> universiteler = dataModel.GetUni();
            universiteler.Insert(0, new Universite { ID = 0, Isim = "Seç" });
            comboBoxUni.DataSource = universiteler;
            comboBoxFak.Enabled=false;
            comboBoxBol.Enabled=false;
        }

        private void comboBoxUni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int UniID = Convert.ToInt32(comboBoxUni.SelectedValue);
            if (UniID!=0)
            {
                List<Fakulte> fakulteler = dataModel.GetFakulte(UniID);
                fakulteler.Insert(0,new Fakulte { ID="0",UniversiteID=0, Isim="SEÇ"});
                comboBoxFak.Enabled = true;
                comboBoxFak.DisplayMember = "Isim";
                comboBoxFak.ValueMember = "ID";
                comboBoxFak.DataSource = fakulteler;
            }
            else
            {
                comboBoxFak.Enabled= false;
                comboBoxFak.Text = "";
                comboBoxBol.Enabled= false;
                comboBoxBol.Text = "";
            }
        }

        private void comboBoxFak_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FakID = Convert.ToString(comboBoxFak.SelectedValue);
            int UniID = Convert.ToInt32(comboBoxUni.SelectedValue);
            if (FakID != "0")
            {
                comboBoxBol.Enabled = true;
                comboBoxBol.DisplayMember = "Isim";
                comboBoxBol.ValueMember = "ID";
                comboBoxBol.DataSource = dataModel.GetBolum(FakID, UniID);
            }
            else
            {
                comboBoxBol.Enabled = false;
                comboBoxBol.Text = "";
            }
        }
    }
}
