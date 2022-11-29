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
    public partial class GroupTypes : MetroFramework.Forms.MetroForm
    {
        public GroupTypes()
        {
            InitializeComponent();
        }

        private void GroupTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Направления' table. You can move, or remove it, as needed.
            this.направленияTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Направления);

        }

        private void направленияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.направленияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hristo_Botev_SchoolDataSet);

        }
    }
}
