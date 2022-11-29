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
    public partial class Students : MetroFramework.Forms.MetroForm
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Ученици' table. You can move, or remove it, as needed.
            this.ученициTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Ученици);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Записани_ученици' table. You can move, or remove it, as needed.
            this.записани_ученициTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Записани_ученици);

        }

        private void записани_ученициBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.записани_ученициBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hristo_Botev_SchoolDataSet);

        }
    }
}
