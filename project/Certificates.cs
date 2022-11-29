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
    public partial class Certificates : MetroFramework.Forms.MetroForm
    {
        public Certificates()
        {
            InitializeComponent();
        }

        private void Certificates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Ученици' table. You can move, or remove it, as needed.
            this.ученициTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Ученици);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Ученици' table. You can move, or remove it, as needed.
            this.ученициTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Ученици);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Удостоверения' table. You can move, or remove it, as needed.
            this.удостоверенияTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Удостоверения);

        }

        private void удостоверенияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.удостоверенияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hristo_Botev_SchoolDataSet);

        }

        private void описаниеLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
