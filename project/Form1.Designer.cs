namespace Hristo_Botev_Secondary_School
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.students = new MetroFramework.Controls.MetroTile();
            this.teachers = new MetroFramework.Controls.MetroTile();
            this.other = new MetroFramework.Controls.MetroTile();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.направленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applications = new MetroFramework.Controls.MetroTile();
            this.diplomas = new MetroFramework.Controls.MetroTile();
            this.groups = new MetroFramework.Controls.MetroTile();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // students
            // 
            this.students.ActiveControl = null;
            this.students.Location = new System.Drawing.Point(33, 80);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(165, 118);
            this.students.Style = MetroFramework.MetroColorStyle.Teal;
            this.students.TabIndex = 0;
            this.students.Text = "Ученици";
            this.students.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.students.TileImage = ((System.Drawing.Image)(resources.GetObject("students.TileImage")));
            this.students.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.students.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.students.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.students.UseSelectable = true;
            this.students.UseTileImage = true;
            this.students.Click += new System.EventHandler(this.students_Click);
            // 
            // teachers
            // 
            this.teachers.ActiveControl = null;
            this.teachers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.teachers.Location = new System.Drawing.Point(570, 80);
            this.teachers.Name = "teachers";
            this.teachers.Size = new System.Drawing.Size(165, 118);
            this.teachers.Style = MetroFramework.MetroColorStyle.Teal;
            this.teachers.TabIndex = 1;
            this.teachers.Text = "Ръководители";
            this.teachers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.teachers.TileImage = ((System.Drawing.Image)(resources.GetObject("teachers.TileImage")));
            this.teachers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teachers.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.teachers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.teachers.UseSelectable = true;
            this.teachers.UseTileImage = true;
            this.teachers.Click += new System.EventHandler(this.teachers_Click);
            // 
            // other
            // 
            this.other.ActiveControl = null;
            this.other.ContextMenuStrip = this.metroContextMenu1;
            this.other.Location = new System.Drawing.Point(33, 313);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(702, 80);
            this.other.Style = MetroFramework.MetroColorStyle.Green;
            this.other.TabIndex = 2;
            this.other.Text = "Други номенклатури";
            this.other.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.other.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.other.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.other.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.other.UseSelectable = true;
            this.other.UseTileImage = true;
            this.other.Click += new System.EventHandler(this.other_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.направленияToolStripMenuItem,
            this.предметиToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(176, 56);
            // 
            // направленияToolStripMenuItem
            // 
            this.направленияToolStripMenuItem.Name = "направленияToolStripMenuItem";
            this.направленияToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.направленияToolStripMenuItem.Text = "Направления";
            this.направленияToolStripMenuItem.Click += new System.EventHandler(this.направленияToolStripMenuItem_Click);
            // 
            // предметиToolStripMenuItem
            // 
            this.предметиToolStripMenuItem.Name = "предметиToolStripMenuItem";
            this.предметиToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.предметиToolStripMenuItem.Text = "Предмети";
            this.предметиToolStripMenuItem.Click += new System.EventHandler(this.предметиToolStripMenuItem_Click);
            // 
            // applications
            // 
            this.applications.ActiveControl = null;
            this.applications.Location = new System.Drawing.Point(33, 214);
            this.applications.Name = "applications";
            this.applications.Size = new System.Drawing.Size(340, 80);
            this.applications.Style = MetroFramework.MetroColorStyle.Teal;
            this.applications.TabIndex = 3;
            this.applications.Text = "Заявления";
            this.applications.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.applications.TileImage = ((System.Drawing.Image)(resources.GetObject("applications.TileImage")));
            this.applications.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.applications.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.applications.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.applications.UseSelectable = true;
            this.applications.UseTileImage = true;
            this.applications.Click += new System.EventHandler(this.applications_Click);
            // 
            // diplomas
            // 
            this.diplomas.ActiveControl = null;
            this.diplomas.Location = new System.Drawing.Point(395, 214);
            this.diplomas.Name = "diplomas";
            this.diplomas.Size = new System.Drawing.Size(340, 80);
            this.diplomas.Style = MetroFramework.MetroColorStyle.Teal;
            this.diplomas.TabIndex = 4;
            this.diplomas.Text = "Удостоверения";
            this.diplomas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.diplomas.TileImage = ((System.Drawing.Image)(resources.GetObject("diplomas.TileImage")));
            this.diplomas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.diplomas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.diplomas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.diplomas.UseSelectable = true;
            this.diplomas.UseTileImage = true;
            this.diplomas.Click += new System.EventHandler(this.diplomas_Click);
            // 
            // groups
            // 
            this.groups.ActiveControl = null;
            this.groups.Location = new System.Drawing.Point(220, 80);
            this.groups.Name = "groups";
            this.groups.Size = new System.Drawing.Size(329, 118);
            this.groups.Style = MetroFramework.MetroColorStyle.Lime;
            this.groups.TabIndex = 5;
            this.groups.Text = "Работа с групи";
            this.groups.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.groups.TileImage = ((System.Drawing.Image)(resources.GetObject("groups.TileImage")));
            this.groups.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.groups.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.groups.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.groups.UseSelectable = true;
            this.groups.UseTileImage = true;
            this.groups.Click += new System.EventHandler(this.groups_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 440);
            this.Controls.Add(this.groups);
            this.Controls.Add(this.diplomas);
            this.Controls.Add(this.applications);
            this.Controls.Add(this.other);
            this.Controls.Add(this.teachers);
            this.Controls.Add(this.students);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Средно училище \"Христо Ботев\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile students;
        private MetroFramework.Controls.MetroTile teachers;
        private MetroFramework.Controls.MetroTile other;
        private MetroFramework.Controls.MetroTile applications;
        private MetroFramework.Controls.MetroTile diplomas;
        private MetroFramework.Controls.MetroTile groups;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem направленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметиToolStripMenuItem;
    }
}

