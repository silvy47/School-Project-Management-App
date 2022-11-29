using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hristo_Botev_Secondary_School
{
    public partial class Groups : MetroFramework.Forms.MetroForm
    {
        public Groups()
        {
            InitializeComponent();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Урок' table. You can move, or remove it, as needed.
            this.урокTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Урок);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Редове_график' table. You can move, or remove it, as needed.
            this.редове_графикTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Редове_график);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.График' table. You can move, or remove it, as needed.
            this.графикTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.График);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Ръководители' table. You can move, or remove it, as needed.
            this.ръководителиTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Ръководители);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Предмети' table. You can move, or remove it, as needed.
            this.предметиTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Предмети);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Направления' table. You can move, or remove it, as needed.
            this.направленияTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Направления);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Ученици' table. You can move, or remove it, as needed.
            this.ученициTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Ученици);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Присъствия' table. You can move, or remove it, as needed.
            this.присъствияTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Присъствия);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Записани_ученици' table. You can move, or remove it, as needed.
            this.записани_ученициTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Записани_ученици);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Групи' table. You can move, or remove it, as needed.
            this.групиTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Групи);

        }

        private void групиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.групиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hristo_Botev_SchoolDataSet);

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void очаквани_резултатиLabel_Click(object sender, EventArgs e)
        {

        }

        private void целLabel_Click(object sender, EventArgs e)
        {

        }

        private void редове_графикMetroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
