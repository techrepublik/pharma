namespace PharmaPos.forms
{
    partial class UserManagementForm
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
            System.Windows.Forms.Label userNoLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userPasswordLabel;
            System.Windows.Forms.Label userFullNameLabel;
            System.Windows.Forms.Label userLevelLabel;
            System.Windows.Forms.Label userDateLabel;
            System.Windows.Forms.Label userIsActiveLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.userNoTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userFullNameTextBox = new System.Windows.Forms.TextBox();
            this.userLevelComboBox = new System.Windows.Forms.ComboBox();
            this.userDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userIsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            userNoLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            userPasswordLabel = new System.Windows.Forms.Label();
            userFullNameLabel = new System.Windows.Forms.Label();
            userLevelLabel = new System.Windows.Forms.Label();
            userDateLabel = new System.Windows.Forms.Label();
            userIsActiveLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userNoLabel
            // 
            userNoLabel.AutoSize = true;
            userNoLabel.Location = new System.Drawing.Point(321, 95);
            userNoLabel.Name = "userNoLabel";
            userNoLabel.Size = new System.Drawing.Size(49, 13);
            userNoLabel.TabIndex = 3;
            userNoLabel.Text = "User No:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(307, 125);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 5;
            userNameLabel.Text = "User Name:";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Location = new System.Drawing.Point(314, 152);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new System.Drawing.Size(56, 13);
            userPasswordLabel.TabIndex = 7;
            userPasswordLabel.Text = "Password:";
            // 
            // userFullNameLabel
            // 
            userFullNameLabel.AutoSize = true;
            userFullNameLabel.Location = new System.Drawing.Point(313, 177);
            userFullNameLabel.Name = "userFullNameLabel";
            userFullNameLabel.Size = new System.Drawing.Size(57, 13);
            userFullNameLabel.TabIndex = 9;
            userFullNameLabel.Text = "Full Name:";
            // 
            // userLevelLabel
            // 
            userLevelLabel.AutoSize = true;
            userLevelLabel.Location = new System.Drawing.Point(334, 203);
            userLevelLabel.Name = "userLevelLabel";
            userLevelLabel.Size = new System.Drawing.Size(36, 13);
            userLevelLabel.TabIndex = 11;
            userLevelLabel.Text = "Level:";
            // 
            // userDateLabel
            // 
            userDateLabel.AutoSize = true;
            userDateLabel.Location = new System.Drawing.Point(312, 231);
            userDateLabel.Name = "userDateLabel";
            userDateLabel.Size = new System.Drawing.Size(58, 13);
            userDateLabel.TabIndex = 13;
            userDateLabel.Text = "Start Date:";
            // 
            // userIsActiveLabel
            // 
            userIsActiveLabel.AutoSize = true;
            userIsActiveLabel.Location = new System.Drawing.Point(330, 263);
            userIsActiveLabel.Name = "userIsActiveLabel";
            userIsActiveLabel.Size = new System.Drawing.Size(40, 13);
            userIsActiveLabel.TabIndex = 15;
            userIsActiveLabel.Text = "Active:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 40);
            this.panel1.TabIndex = 2;
            // 
            // userBindingNavigator
            // 
            this.userBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userBindingNavigator.BindingSource = this.userBindingSource;
            this.userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userBindingNavigator.DeleteItem = null;
            this.userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.userBindingNavigatorSaveItem});
            this.userBindingNavigator.Location = new System.Drawing.Point(0, 40);
            this.userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userBindingNavigator.Name = "userBindingNavigator";
            this.userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userBindingNavigator.Size = new System.Drawing.Size(738, 25);
            this.userBindingNavigator.TabIndex = 3;
            this.userBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // userBindingNavigatorSaveItem
            // 
            this.userBindingNavigatorSaveItem.Enabled = false;
            this.userBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorSaveItem.Image")));
            this.userBindingNavigatorSaveItem.Name = "userBindingNavigatorSaveItem";
            this.userBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.userBindingNavigatorSaveItem.Text = "Save Data";
            this.userBindingNavigatorSaveItem.Click += new System.EventHandler(this.userBindingNavigatorSaveItem_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8});
            this.userDataGridView.DataSource = this.userBindingSource;
            this.userDataGridView.Location = new System.Drawing.Point(12, 79);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersWidth = 30;
            this.userDataGridView.Size = new System.Drawing.Size(264, 315);
            this.userDataGridView.TabIndex = 7;
            // 
            // userNoTextBox
            // 
            this.userNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserNo", true));
            this.userNoTextBox.Location = new System.Drawing.Point(381, 95);
            this.userNoTextBox.Name = "userNoTextBox";
            this.userNoTextBox.Size = new System.Drawing.Size(124, 20);
            this.userNoTextBox.TabIndex = 0;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(381, 122);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserPassword", true));
            this.userPasswordTextBox.Location = new System.Drawing.Point(381, 148);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(192, 20);
            this.userPasswordTextBox.TabIndex = 2;
            this.userPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // userFullNameTextBox
            // 
            this.userFullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserFullName", true));
            this.userFullNameTextBox.Location = new System.Drawing.Point(381, 174);
            this.userFullNameTextBox.Name = "userFullNameTextBox";
            this.userFullNameTextBox.Size = new System.Drawing.Size(345, 20);
            this.userFullNameTextBox.TabIndex = 3;
            // 
            // userLevelComboBox
            // 
            this.userLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserLevel", true));
            this.userLevelComboBox.FormattingEnabled = true;
            this.userLevelComboBox.Items.AddRange(new object[] {
            "-- Select Level --",
            "1",
            "2",
            "3"});
            this.userLevelComboBox.Location = new System.Drawing.Point(381, 200);
            this.userLevelComboBox.Name = "userLevelComboBox";
            this.userLevelComboBox.Size = new System.Drawing.Size(121, 21);
            this.userLevelComboBox.TabIndex = 4;
            // 
            // userDateDateTimePicker
            // 
            this.userDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "UserDate", true));
            this.userDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.userDateDateTimePicker.Location = new System.Drawing.Point(381, 227);
            this.userDateDateTimePicker.Name = "userDateDateTimePicker";
            this.userDateDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.userDateDateTimePicker.TabIndex = 5;
            // 
            // userIsActiveCheckBox
            // 
            this.userIsActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userBindingSource, "UserIsActive", true));
            this.userIsActiveCheckBox.Location = new System.Drawing.Point(381, 258);
            this.userIsActiveCheckBox.Name = "userIsActiveCheckBox";
            this.userIsActiveCheckBox.Size = new System.Drawing.Size(104, 24);
            this.userIsActiveCheckBox.TabIndex = 6;
            this.userIsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "1 - Cashier, 2 - Encoder, 3 - Admin";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(PharmaPos.data.User);
            this.userBindingSource.CurrentChanged += new System.EventHandler(this.userBindingSource_CurrentChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UserIsActive";
            this.dataGridViewTextBoxColumn8.HeaderText = "Active";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PharmaPos.Properties.Resources.thFTZEPTJU;
            this.pictureBox2.Location = new System.Drawing.Point(9, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(386, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Provide needed information for User Management (Add New and Update Users).";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Management Form for the BOTIKA NG BAYAN. ";
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 414);
            this.Controls.Add(this.label2);
            this.Controls.Add(userIsActiveLabel);
            this.Controls.Add(this.userIsActiveCheckBox);
            this.Controls.Add(userDateLabel);
            this.Controls.Add(this.userDateDateTimePicker);
            this.Controls.Add(userLevelLabel);
            this.Controls.Add(this.userLevelComboBox);
            this.Controls.Add(userFullNameLabel);
            this.Controls.Add(this.userFullNameTextBox);
            this.Controls.Add(userPasswordLabel);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(userNoLabel);
            this.Controls.Add(this.userNoTextBox);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.userBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "UserManagementForm";
            this.Text = "User Management Form";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingNavigator userBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton userBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.TextBox userNoTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.TextBox userFullNameTextBox;
        private System.Windows.Forms.ComboBox userLevelComboBox;
        private System.Windows.Forms.DateTimePicker userDateDateTimePicker;
        private System.Windows.Forms.CheckBox userIsActiveCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}