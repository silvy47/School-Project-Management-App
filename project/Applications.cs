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
    public partial class Applications : MetroFramework.Forms.MetroForm
    {
        public Applications()
        {
            InitializeComponent();
        }

        private void Applications_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Групи' table. You can move, or remove it, as needed.
            this.групиTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Групи);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Ученици' table. You can move, or remove it, as needed.
            this.ученициTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Ученици);
            // TODO: This line of code loads data into the 'hristo_Botev_SchoolDataSet.Заявления_за_участие' table. You can move, or remove it, as needed.
            this.заявления_за_участиеTableAdapter.Fill(this.hristo_Botev_SchoolDataSet.Заявления_за_участие);

        }

        private void заявления_за_участиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявления_за_участиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hristo_Botev_SchoolDataSet);

        }
    }
}
