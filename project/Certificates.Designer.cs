namespace Hristo_Botev_Secondary_School
{
    partial class Certificates
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
            System.Windows.Forms.Label код_на_ученикLabel;
            System.Windows.Forms.Label номер_на_удостоверениеLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certificates));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hristo_Botev_SchoolDataSet = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSet();
            this.удостоверенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.удостоверенияTableAdapter = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.УдостоверенияTableAdapter();
            this.tableAdapterManager = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.TableAdapterManager();
            this.ученициTableAdapter = new Hristo_Botev_Secondary_School.Hristo_Botev_SchoolDataSetTableAdapters.УченициTableAdapter();
            this.удостоверенияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.удостоверенияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.удостоверенияMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ученициBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ученициУдостоверенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номер_на_удостоверениеTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            код_на_ученикLabel = new System.Windows.Forms.Label();
            номер_на_удостоверениеLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hristo_Botev_SchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостоверенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостоверенияBindingNavigator)).BeginInit();
            this.удостоверенияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.удостоверенияMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученициBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученициУдостоверенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // код_на_ученикLabel
            // 
            код_на_ученикLabel.AutoSize = true;
            код_на_ученикLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            код_на_ученикLabel.Location = new System.Drawing.Point(748, 157);
            код_на_ученикLabel.Name = "код_на_ученикLabel";
            код_на_ученикLabel.Size = new System.Drawing.Size(99, 21);
            код_на_ученикLabel.TabIndex = 2;
            код_на_ученикLabel.Text = "се издава на";
            // 
            // номер_на_удостоверениеLabel
            // 
            номер_на_удостоверениеLabel.AutoSize = true;
            номер_на_удостоверениеLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            номер_на_удостоверениеLabel.Location = new System.Drawing.Point(725, 97);
            номер_на_удостоверениеLabel.Name = "номер_на_удостоверениеLabel";
            номер_на_удостоверениеLabel.Size = new System.Drawing.Size(144, 21);
            номер_на_удостоверениеLabel.TabIndex = 4;
            номер_на_удостоверениеLabel.Text = "Удостоверение №:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            описаниеLabel.Location = new System.Drawing.Point(758, 214);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(100, 21);
            описаниеLabel.TabIndex = 10;
            описаниеLabel.Text = "за постигнат";
            описаниеLabel.Click += new System.EventHandler(this.описаниеLabel_Click);
            // 
            // hristo_Botev_SchoolDataSet
            // 
            this.hristo_Botev_SchoolDataSet.DataSetName = "Hristo_Botev_SchoolDataSet";
            this.hristo_Botev_SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // удостоверенияBindingSource
            // 
            this.удостоверенияBindingSource.DataMember = "Удостоверения";
            this.удостоверенияBindingSource.DataSource = this.hristo_Botev_SchoolDataSet;
            // 
            // удостоверенияTableAdapter
            // 
            this.удостоверенияTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПредметиTableAdapter = null;
            this.tableAdapterManager.ПрисъствияTableAdapter = null;
            this.tableAdapterManager.Редове_графикTableAdapter = null;
            this.tableAdapterManager.РъководителиTableAdapter = null;
            this.tableAdapterManager.УдостоверенияTableAdapter = this.удостоверенияTableAdapter;
            this.tableAdapterManager.УрокTableAdapter = null;
            this.tableAdapterManager.УченициTableAdapter = this.ученициTableAdapter;
            // 
            // ученициTableAdapter
            // 
            this.ученициTableAdapter.ClearBeforeFill = true;
            // 
            // удостоверенияBindingNavigator
            // 
            this.удостоверенияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.удостоверенияBindingNavigator.BindingSource = this.удостоверенияBindingSource;
            this.удостоверенияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.удостоверенияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.удостоверенияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.удостоверенияBindingNavigatorSaveItem});
            this.удостоверенияBindingNavigator.Location = new System.Drawing.Point(30, 97);
            this.удостоверенияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.удостоверенияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.удостоверенияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.удостоверенияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.удостоверенияBindingNavigator.Name = "удостоверенияBindingNavigator";
            this.удостоверенияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.удостоверенияBindingNavigator.Size = new System.Drawing.Size(960, 25);
            this.удостоверенияBindingNavigator.TabIndex = 0;
            this.удостоверенияBindingNavigator.Text = "bindingNavigator1";
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
            // удостоверенияBindingNavigatorSaveItem
            // 
            this.удостоверенияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.удостоверенияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("удостоверенияBindingNavigatorSaveItem.Image")));
            this.удостоверенияBindingNavigatorSaveItem.Name = "удостоверенияBindingNavigatorSaveItem";
            this.удостоверенияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.удостоверенияBindingNavigatorSaveItem.Text = "Save Data";
            this.удостоверенияBindingNavigatorSaveItem.Click += new System.EventHandler(this.удостоверенияBindingNavigatorSaveItem_Click);
            // 
            // удостоверенияMetroGrid
            // 
            this.удостоверенияMetroGrid.AllowUserToResizeRows = false;
            this.удостоверенияMetroGrid.AutoGenerateColumns = false;
            this.удостоверенияMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.удостоверенияMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.удостоверенияMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.удостоверенияMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.удостоверенияMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.удостоверенияMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.удостоверенияMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.удостоверенияMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.удостоверенияMetroGrid.DataSource = this.удостоверенияBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.удостоверенияMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.удостоверенияMetroGrid.EnableHeadersVisualStyles = false;
            this.удостоверенияMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.удостоверенияMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.удостоверенияMetroGrid.Location = new System.Drawing.Point(30, 135);
            this.удостоверенияMetroGrid.Name = "удостоверенияMetroGrid";
            this.удостоверенияMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.удостоверенияMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.удостоверенияMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.удостоверенияMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.удостоверенияMetroGrid.Size = new System.Drawing.Size(581, 220);
            this.удостоверенияMetroGrid.Style = MetroFramework.MetroColorStyle.Teal;
            this.удостоверенияMetroGrid.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Код_на_ученик";
            this.Column1.DataSource = this.ученициBindingSource;
            this.Column1.DisplayMember = "Име";
            this.Column1.FillWeight = 110.5386F;
            this.Column1.HeaderText = "Име";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "Код_на_ученик";
            // 
            // ученициBindingSource
            // 
            this.ученициBindingSource.DataMember = "Ученици";
            this.ученициBindingSource.DataSource = this.hristo_Botev_SchoolDataSet;
            // 
            // ученициУдостоверенияBindingSource
            // 
            this.ученициУдостоверенияBindingSource.DataMember = "Ученици_Удостоверения";
            this.ученициУдостоверенияBindingSource.DataSource = this.ученициBindingSource;
            // 
            // номер_на_удостоверениеTextBox
            // 
            this.номер_на_удостоверениеTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.номер_на_удостоверениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ученициУдостоверенияBindingSource, "Номер_на_удостоверение", true));
            this.номер_на_удостоверениеTextBox.Enabled = false;
            this.номер_на_удостоверениеTextBox.Location = new System.Drawing.Point(779, 125);
            this.номер_на_удостоверениеTextBox.Name = "номер_на_удостоверениеTextBox";
            this.номер_на_удостоверениеTextBox.Size = new System.Drawing.Size(37, 29);
            this.номер_на_удостоверениеTextBox.TabIndex = 5;
            this.номер_на_удостоверениеTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ученициУдостоверенияBindingSource, "Дата", true));
            this.датаDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.датаDateTimePicker.Location = new System.Drawing.Point(711, 345);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(116, 29);
            this.датаDateTimePicker.TabIndex = 7;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ученициУдостоверенияBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(694, 238);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(207, 29);
            this.описаниеTextBox.TabIndex = 11;
            this.описаниеTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(617, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 393);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn5.FillWeight = 124.1456F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Брой_часове";
            this.dataGridViewTextBoxColumn4.FillWeight = 60.9137F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Брой часове";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn3.FillWeight = 124.1456F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_на_ученик";
            this.dataGridViewTextBoxColumn1.DataSource = this.ученициBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Фамилия";
            this.dataGridViewTextBoxColumn1.FillWeight = 124.1456F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "Код_на_ученик";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_на_удостоверение";
            this.dataGridViewTextBoxColumn2.FillWeight = 56.11098F;
            this.dataGridViewTextBoxColumn2.HeaderText = "№";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.metroComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.удостоверенияBindingSource, "Код_на_ученик", true));
            this.metroComboBox2.DataSource = this.ученициBindingSource;
            this.metroComboBox2.DisplayMember = "Фамилия";
            this.metroComboBox2.Enabled = false;
            this.metroComboBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(803, 181);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 14;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.ValueMember = "Код_на_ученик";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.metroComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.удостоверенияBindingSource, "Код_на_ученик", true));
            this.metroComboBox1.DataSource = this.ученициBindingSource;
            this.metroComboBox1.DisplayMember = "Име";
            this.metroComboBox1.Enabled = false;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(676, 181);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 13;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "Код_на_ученик";
            // 
            // Certificates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 431);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(код_на_ученикLabel);
            this.Controls.Add(номер_на_удостоверениеLabel);
            this.Controls.Add(this.номер_на_удостоверениеTextBox);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(this.удостоверенияMetroGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.удостоверенияBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Certificates";
            this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Удостоверения";
            this.Load += new System.EventHandler(this.Certificates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hristo_Botev_SchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостоверенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостоверенияBindingNavigator)).EndInit();
            this.удостоверенияBindingNavigator.ResumeLayout(false);
            this.удостоверенияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.удостоверенияMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученициBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученициУдостоверенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Hristo_Botev_SchoolDataSet hristo_Botev_SchoolDataSet;
        private System.Windows.Forms.BindingSource удостоверенияBindingSource;
        private Hristo_Botev_SchoolDataSetTableAdapters.УдостоверенияTableAdapter удостоверенияTableAdapter;
        private Hristo_Botev_SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator удостоверенияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton удостоверенияBindingNavigatorSaveItem;
        private Hristo_Botev_SchoolDataSetTableAdapters.УченициTableAdapter ученициTableAdapter;
        private MetroFramework.Controls.MetroGrid удостоверенияMetroGrid;
        private System.Windows.Forms.BindingSource ученициBindingSource;
        private System.Windows.Forms.BindingSource ученициУдостоверенияBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.TextBox номер_на_удостоверениеTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}