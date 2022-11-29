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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void other_Click(object sender, EventArgs e)
        {
            
        }

        private void предметиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Subjects().ShowDialog();
        }
        
        private void направленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GroupTypes().ShowDialog();
        }

        private void students_Click(object sender, EventArgs e)
        {
            new Students().ShowDialog();
        }

        private void teachers_Click(object sender, EventArgs e)
        {
            new Teachers().ShowDialog();
        }

        private void diplomas_Click(object sender, EventArgs e)
        {
            new Certificates().ShowDialog();
        }

        private void applications_Click(object sender, EventArgs e)
        {
            new Applications().ShowDialog();
        }

        private void groups_Click(object sender, EventArgs e)
        {
            new Groups().ShowDialog();
        }
    }
}
