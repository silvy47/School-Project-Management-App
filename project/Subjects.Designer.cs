namespace Hristo_Botev_Secondary_School
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label код_на_предметLabel;
            System.Windows.Forms.Label наименование_на_предметLabel;
            this.hristo_Botev_SchoolDataSet = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSet();
            this.предметиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.предметиTableAdapter = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.ПредметиTableAdapter();
            this.tableAdapterManager = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.TableAdapterManager();
            this.предметиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.предметиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.предметиMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.код_на_предметTextBox = new System.Windows.Forms.TextBox();
            this.наименование_на_предметTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            код_на_предметLabel = new System.Windows.Forms.Label();
            наименование_на_предметLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hristo_Botev_SchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметиBindingNavigator)).BeginInit();
            this.предметиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.предметиMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // hristo_Botev_SchoolDataSet
            // 
            this.hristo_Botev_SchoolDataSet.DataSetName = "Hristo_Botev_SchoolDataSet";
            this.hristo_Botev_SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // предметиBindingSource
            // 
            this.предметиBindingSource.DataMember = "Предмети";
            this.предметиBindingSource.DataSource = this.hristo_Botev_SchoolDataSet;
            // 
            // предметиTableAdapter
            // 
            this.предметиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГрафикTableAdapter = null;
            this.tableAdapterManager.ГрупиTableAdapter = null;
            this.tableAdapterManager.Записани_ученициTableAdapter = null;
            this.tableAdapterManager.Заявления_за_участиеTableAdapter = null;
            this.tableAdapterManager.НаправленияTableAdapter = null;
            this.tableAdapterManager.ПредметиTableAdapter = this.предметиTableAdapter;
            this.tableAdapterManager.ПрисъствияTableAdapter = null;
            this.tableAdapterManager.Редове_графикTableAdapter = null;
            this.tableAdapterManager.РъководителиTableAdapter = null;
            this.tableAdapterManager.УдостоверенияTableAdapter = null;
            this.tableAdapterManager.УрокTableAdapter = null;
            this.tableAdapterManager.УченициTableAdapter = null;
            // 
            // предметиBindingNavigator
            // 
            this.предметиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.предметиBindingNavigator.BindingSource = this.предметиBindingSource;
            this.предметиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.предметиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.предметиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.предметиBindingNavigatorSaveItem});
            this.предметиBindingNavigator.Location = new System.Drawing.Point(30, 97);
            this.предметиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.предметиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.предметиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.предметиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.предметиBindingNavigator.Name = "предметиBindingNavigator";
            this.предметиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.предметиBindingNavigator.Size = new System.Drawing.Size(655, 25);
            this.предметиBindingNavigator.TabIndex = 0;
            this.предметиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // предметиBindingNavigatorSaveItem
            // 
            this.предметиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.предметиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("предметиBindingNavigatorSaveItem.Image")));
            this.предметиBindingNavigatorSaveItem.Name = "предметиBindingNavigatorSaveItem";
            this.предметиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.предметиBindingNavigatorSaveItem.Text = "Save Data";
            this.предметиBindingNavigatorSaveItem.Click += new System.EventHandler(this.предметиBindingNavigatorSaveItem_Click);
            // 
            // предметиMetroGrid
            // 
            this.предметиMetroGrid.AllowUserToResizeRows = false;
            this.предметиMetroGrid.AutoGenerateColumns = false;
            this.предметиMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.предметиMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.предметиMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.предметиMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.предметиMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.предметиMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.предметиMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.предметиMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.предметиMetroGrid.DataSource = this.предметиBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.предметиMetroGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.предметиMetroGrid.EnableHeadersVisualStyles = false;
            this.предметиMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.предметиMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.предметиMetroGrid.Location = new System.Drawing.Point(30, 136);
            this.предметиMetroGrid.Name = "предметиMetroGrid";
            this.предметиMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.предметиMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.предметиMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.предметиMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.предметиMetroGrid.Size = new System.Drawing.Size(300, 219);
            this.предметиMetroGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.предметиMetroGrid.TabIndex = 1;
            // 
            // код_на_предметLabel
            // 
            код_на_предметLabel.AutoSize = true;
            код_на_предметLabel.Location = new System.Drawing.Point(347, 145);
            код_на_предметLabel.Name = "код_на_предметLabel";
            код_на_предметLabel.Size = new System.Drawing.Size(126, 21);
            код_на_предметLabel.TabIndex = 2;
            код_на_предметLabel.Text = "Код на предмет:";
            // 
            // код_на_предметTextBox
            // 
            this.код_на_предметTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.предметиBindingSource, "Код_на_предмет", true));
            this.код_на_предметTextBox.Location = new System.Drawing.Point(479, 142);
            this.код_на_предметTextBox.Name = "код_на_предметTextBox";
            this.код_на_предметTextBox.Size = new System.Drawing.Size(220, 29);
            this.код_на_предметTextBox.TabIndex = 3;
            // 
            // наименование_на_предметLabel
            // 
            наименование_на_предметLabel.AutoSize = true;
            наименование_на_предметLabel.Location = new System.Drawing.Point(347, 180);
            наименование_на_предметLabel.Name = "наименование_на_предметLabel";
            наименование_на_предметLabel.Size = new System.Drawing.Size(120, 21);
            наименование_на_предметLabel.TabIndex = 4;
            наименование_на_предметLabel.Text = "Наименование:";
            // 
            // наименование_на_предметTextBox
            // 
            this.наименование_на_предметTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.предметиBindingSource, "Наименование_на_предмет", true));
            this.наименование_на_предметTextBox.Location = new System.Drawing.Point(479, 177);
            this.наименование_на_предметTextBox.Name = "наименование_на_предметTextBox";
            this.наименование_на_предметTextBox.Size = new System.Drawing.Size(220, 29);
            this.наименование_на_предметTextBox.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование_на_предмет";
            this.dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 378);
            this.Controls.Add(код_на_предметLabel);
            this.Controls.Add(this.код_на_предметTextBox);
            this.Controls.Add(наименование_на_предметLabel);
            this.Controls.Add(this.наименование_на_предметTextBox);
            this.Controls.Add(this.предметиMetroGrid);
            this.Controls.Add(this.предметиBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Subjects";
            this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Предмети";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hristo_Botev_SchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.предметиBindingNavigator)).EndInit();
            this.предметиBindingNavigator.ResumeLayout(false);
            this.предметиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.предметиMetroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Hristo_Botev_SchoolDataSet hristo_Botev_SchoolDataSet;
        private System.Windows.Forms.BindingSource предметиBindingSource;
        private Hristo_Botev_SchoolDataSetTableAdapters.ПредметиTableAdapter предметиTableAdapter;
        private Hristo_Botev_SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator предметиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton предметиBindingNavigatorSaveItem;
        private MetroFramework.Controls.MetroGrid предметиMetroGrid;
        private System.Windows.Forms.TextBox код_на_предметTextBox;
        private System.Windows.Forms.TextBox наименование_на_предметTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}