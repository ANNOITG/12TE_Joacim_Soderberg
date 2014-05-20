using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Link_project
{
    public partial class Form1 : Form
    {
        Guildlist1DataContext db = new Guildlist1DataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            recordBandCbx.DataSource = from data in db.Bands
                                       orderby data.Band_Name
                                       select data;

            bandDGV.DataSource = bandBS;
            bandBS.DataSource = from data in db.Bands
                                select data;

            bandDGV.Columns[2].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Spara_btn_Click(object sender, EventArgs e)
        {

            Band b = new Band();

            try
            {
                b.Band_Name = bandnameTBX.Text;
                b.Members = int.Parse(bandcountTBX.Text);
                b.From_Location = bandfromTBX.Text;
                b.Info = bandinfoTBX.Text;

                db.Bands.InsertOnSubmit(b);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bandBS.DataSource = from allBands in db.Bands
                                select allBands;
            recordBandCbx.DataSource = from data in db.Bands
                                       orderby data.Band_Name
                                       select data;
        }

        private void bandRemoveBtn_Click(object sender, EventArgs e)
        {
            if (bandDGV.SelectedRows.Count == 1)
            {
                int selected_id = (int)bandDGV.SelectedRows[0].Cells[0].Value;
                Band b = db.Bands.Single(band => band.Band_ID == selected_id);

                db.Bands.DeleteOnSubmit(b);
                db.SubmitChanges();

                bandBS.DataSource = from data in db.Bands
                                    select data;
                recordBandCbx.DataSource = from data in db.Bands
                                           orderby data.Band_Name
                                           select data;
            }
        }

        int changeState = 0;
        int tempID;
        private void BandChangeBTN_Click(object sender, EventArgs e)
        {
            if (bandDGV.SelectedRows.Count == 1)
            {
                int selected_id = (int)bandDGV.SelectedRows[0].Cells[0].Value;

                Band b = db.Bands.Single(band => band.Band_ID == selected_id);
            }
        }
    }
}