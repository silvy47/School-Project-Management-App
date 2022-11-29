namespace Hristo_Botev_Secondary_School
{
    partial class Applications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Applications));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hristo_Botev_SchoolDataSet = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSet();
            this.заявления_за_участиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявления_за_участиеTableAdapter = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.Заявления_за_участиеTableAdapter();
            this.tableAdapterManager = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.TableAdapterManager();
            this.групиTableAdapter = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.ГрупиTableAdapter();
            this.ученициTableAdapter = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.УченициTableAdapter();
            this.заявления_за_участиеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заявления_за_участиеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.заявления_за_участиеMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.групиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ученициBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hristo_Botev_SchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявления_за_участиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявления_за_участиеBindingNavigator)).BeginInit();
            this.заявления_за_участиеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявления_за_участиеMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученициBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hristo_Botev_SchoolDataSet
            // 
            this.hristo_Botev_SchoolDataSet.DataSetName = "Hristo_Botev_SchoolDataSet";
            this.hristo_Botev_SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявления_за_участиеBindingSource
            // 
            this.заявления_за_участиеBindingSource.DataMember = "Заявления_за_участие";
            this.заявления_за_участиеBindingSource.DataSource = this.hristo_Botev_SchoolDataSet;
            // 
            // заявления_за_участиеTableAdapter
            // 
            this.заявления_за_участиеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГрафикTableAdapter = null;
            this.tableAdapterManager.ГрупиTableAdapter = this.групиTableAdapter;
            this.tableAdapterManager.Записани_ученициTableAdapter = null;
            this.tableAdapterManager.Заявления_за_участиеTableAdapter = this.заявления_за_участиеTableAdapter;
            this.tableAdapterManager.НаправленияTableAdapter = null;
            this.tableAdapterManager.ПредметиTableAdapter = null;
            this.tableAdapterManager.ПрисъствияTableAdapter = null;
            this.tableAdapterManager.Редове_графикTableAdapter = null;
            this.tableAdapterManager.РъководителиTableAdapter = null;
            this.tableAdapterManager.УдостоверенияTableAdapter = null;
            this.tableAdapterManager.УрокTableAdapter = null;
            this.tableAdapterManager.УченициTableAdapter = this.ученициTableAdapter;
            // 
            // групиTableAdapter
            // 
            this.групиTableAdapter.ClearBeforeFill = true;
            // 
            // ученициTableAdapter
            // 
            this.ученициTableAdapter.ClearBeforeFill = true;
            // 
            // заявления_за_участиеBindingNavigator
            // 
            this.заявления_за_участиеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заявления_за_участиеBindingNavigator.BindingSource = this.заявления_за_участиеBindingSource;
            this.заявления_за_участиеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заявления_за_участиеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заявления_за_участиеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заявления_за_участиеBindingNavigatorSaveItem});
            this.заявления_за_участиеBindingNavigator.Location = new System.Drawing.Point(30, 97);
            this.заявления_за_участиеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заявления_за_участиеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заявления_за_участиеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заявления_за_участиеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заявления_за_участиеBindingNavigator.Name = "заявления_за_участиеBindingNavigator";
            this.заявления_за_участиеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заявления_за_участиеBindingNavigator.Size = new System.Drawing.Size(664, 25);
            this.заявления_за_участиеBindingNavigator.TabIndex = 0;
            this.заявления_за_участиеBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // заявления_за_участиеBindingNavigatorSaveItem
            // 
            this.заявления_за_участиеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заявления_за_участиеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заявления_за_участиеBindingNavigatorSaveItem.Image")));
            this.заявления_за_участиеBindingNavigatorSaveItem.Name = "заявления_за_участиеBindingNavigatorSaveItem";
            this.заявления_за_участиеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заявления_за_участиеBindingNavigatorSaveItem.Text = "Save Data";
            this.заявления_за_участиеBindingNavigatorSaveItem.Click += new System.EventHandler(this.заявления_за_участиеBindingNavigatorSaveItem_Click);
            // 
            // заявления_за_участиеMetroGrid
            // 
            this.заявления_за_участиеMetroGrid.AllowUserToResizeRows = false;
            this.заявления_за_участиеMetroGrid.AutoGenerateColumns = false;
            this.заявления_за_участиеMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.заявления_за_участиеMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.заявления_за_участиеMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.заявления_за_участиеMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.заявления_за_участиеMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.заявления_за_участиеMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.заявления_за_участиеMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заявления_за_участиеMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.заявления_за_участиеMetroGrid.DataSource = this.заявления_за_участиеBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.заявления_за_участиеMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.заявления_за_участиеMetroGrid.EnableHeadersVisualStyles = false;
            this.заявления_за_участиеMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.заявления_за_участиеMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.заявления_за_участиеMetroGrid.Location = new System.Drawing.Point(30, 125);
            this.заявления_за_участиеMetroGrid.Name = "заявления_за_участиеMetroGrid";
            this.заявления_за_участиеMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.заявления_за_участиеMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.заявления_за_участиеMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.заявления_за_участиеMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.заявления_за_участиеMetroGrid.Size = new System.Drawing.Size(664, 220);
            this.заявления_за_участиеMetroGrid.Style = MetroFramework.MetroColorStyle.Teal;
            this.заявления_за_участиеMetroGrid.TabIndex = 1;
            // 
            // групиBindingSource
            // 
            this.групиBindingSource.DataMember = "Групи";
            this.групиBindingSource.DataSource = this.hristo_Botev_SchoolDataSet;
            // 
            // ученициBindingSource
            // 
            this.ученициBindingSource.DataMember = "Ученици";
            this.ученициBindingSource.DataSource = this.hristo_Botev_SchoolDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_на_заявление";
            this.dataGridViewTextBoxColumn2.FillWeight = 40.70966F;
            this.dataGridViewTextBoxColumn2.HeaderText = "№";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_на_ученик";
            this.dataGridViewTextBoxColumn1.DataSource = this.ученициBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Име";
            this.dataGridViewTextBoxColumn1.FillWeight = 88.83241F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Ученик №";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 35;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "Код_на_ученик";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn3.FillWeight = 123.4858F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код_на_група";
            this.dataGridViewTextBoxColumn4.DataSource = this.групиBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Наименование";
            this.dataGridViewTextBoxColumn4.FillWeight = 123.4858F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Група";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Код_на_група";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Статус";
            this.dataGridViewCheckBoxColumn1.FillWeight = 123.4858F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Статус";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // Applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 379);
            this.Controls.Add(this.заявления_за_участиеMetroGrid);
            this.Controls.Add(this.заявления_за_участиеBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Applications";
            this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Заявления";
            this.Load += new System.EventHandler(this.Applications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hristo_Botev_SchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявления_за_участиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявления_за_участиеBindingNavigator)).EndInit();
            this.заявления_за_участиеBindingNavigator.ResumeLayout(false);
            this.заявления_за_участиеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявления_за_участиеMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученициBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Hristo_Botev_SchoolDataSet hristo_Botev_SchoolDataSet;
        private System.Windows.Forms.BindingSource заявления_за_участиеBindingSource;
        private Hristo_Botev_SchoolDataSetTableAdapters.Заявления_за_участиеTableAdapter заявления_за_участиеTableAdapter;
        private Hristo_Botev_SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заявления_за_участиеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заявления_за_участиеBindingNavigatorSaveItem;
        private Hristo_Botev_SchoolDataSetTableAdapters.УченициTableAdapter ученициTableAdapter;
        private MetroFramework.Controls.MetroGrid заявления_за_участиеMetroGrid;
        private System.Windows.Forms.BindingSource ученициBindingSource;
        private Hristo_Botev_SchoolDataSetTableAdapters.ГрупиTableAdapter групиTableAdapter;
        private System.Windows.Forms.BindingSource групиBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}