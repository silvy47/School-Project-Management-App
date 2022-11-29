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
    public partial class Teachers : MetroFramework.Forms.MetroForm
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Групи' table. You can move, or remove it, as needed.
            this.групиTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Групи);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Предмети' table. You can move, or remove it, as needed.
            this.предметиTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Предмети);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Ръководители' table. You can move, or remove it, as needed.
            this.ръководителиTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Ръководители);

        }

        private void ръководителиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ръководителиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hristo_Botev_SchoolDataSet);

        }
    }
}
