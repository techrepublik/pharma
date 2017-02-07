namespace PharmaPos.forms
{
    partial class ProductUpdateForm
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
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label productAlertCountLabel;
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label productDescriptionLabel;
            System.Windows.Forms.Label productGenericNameLabel;
            System.Windows.Forms.Label productInstructionLabel;
            System.Windows.Forms.Label productLotNoLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label drugTypeIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUpdateForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.productAlertCountTextBox = new System.Windows.Forms.TextBox();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productGenericNameTextBox = new System.Windows.Forms.TextBox();
            this.productInstructionTextBox = new System.Windows.Forms.TextBox();
            this.productLotNoTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.drugTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            categoryIdLabel = new System.Windows.Forms.Label();
            productAlertCountLabel = new System.Windows.Forms.Label();
            productCodeLabel = new System.Windows.Forms.Label();
            productDescriptionLabel = new System.Windows.Forms.Label();
            productGenericNameLabel = new System.Windows.Forms.Label();
            productInstructionLabel = new System.Windows.Forms.Label();
            productLotNoLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            drugTypeIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(17, 192);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(52, 13);
            categoryIdLabel.TabIndex = 3;
            categoryIdLabel.Text = "Category:";
            // 
            // productAlertCountLabel
            // 
            productAlertCountLabel.AutoSize = true;
            productAlertCountLabel.Location = new System.Drawing.Point(17, 221);
            productAlertCountLabel.Name = "productAlertCountLabel";
            productAlertCountLabel.Size = new System.Drawing.Size(62, 13);
            productAlertCountLabel.TabIndex = 7;
            productAlertCountLabel.Text = "Alert Count:";
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new System.Drawing.Point(17, 91);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(75, 13);
            productCodeLabel.TabIndex = 9;
            productCodeLabel.Text = "Product Code:";
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new System.Drawing.Point(17, 247);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new System.Drawing.Size(103, 13);
            productDescriptionLabel.TabIndex = 11;
            productDescriptionLabel.Text = "Product Description:";
            // 
            // productGenericNameLabel
            // 
            productGenericNameLabel.AutoSize = true;
            productGenericNameLabel.Location = new System.Drawing.Point(17, 142);
            productGenericNameLabel.Name = "productGenericNameLabel";
            productGenericNameLabel.Size = new System.Drawing.Size(78, 13);
            productGenericNameLabel.TabIndex = 13;
            productGenericNameLabel.Text = "Generic Name:";
            // 
            // productInstructionLabel
            // 
            productInstructionLabel.AutoSize = true;
            productInstructionLabel.Location = new System.Drawing.Point(17, 273);
            productInstructionLabel.Name = "productInstructionLabel";
            productInstructionLabel.Size = new System.Drawing.Size(99, 13);
            productInstructionLabel.TabIndex = 17;
            productInstructionLabel.Text = "Product Instruction:";
            // 
            // productLotNoLabel
            // 
            productLotNoLabel.AutoSize = true;
            productLotNoLabel.Location = new System.Drawing.Point(356, 224);
            productLotNoLabel.Name = "productLotNoLabel";
            productLotNoLabel.Size = new System.Drawing.Size(42, 13);
            productLotNoLabel.TabIndex = 19;
            productLotNoLabel.Text = "Lot No:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(17, 117);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 21;
            productNameLabel.Text = "Product Name:";
            // 
            // drugTypeIdLabel
            // 
            drugTypeIdLabel.AutoSize = true;
            drugTypeIdLabel.Location = new System.Drawing.Point(356, 192);
            drugTypeIdLabel.Name = "drugTypeIdLabel";
            drugTypeIdLabel.Size = new System.Drawing.Size(60, 13);
            drugTypeIdLabel.TabIndex = 28;
            drugTypeIdLabel.Text = "Drug Type:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(17, 169);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(48, 13);
            supplierIdLabel.TabIndex = 29;
            supplierIdLabel.Text = "Supplier:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 40);
            this.panel1.TabIndex = 2;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = null;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 40);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(765, 25);
            this.productBindingNavigator.TabIndex = 3;
            this.productBindingNavigator.Text = "bindingNavigator1";
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
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PharmaPos.data.Product);
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.productBindingSource_CurrentChanged);
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
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.Enabled = false;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "&Close";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // productAlertCountTextBox
            // 
            this.productAlertCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductAlertCount", true));
            this.productAlertCountTextBox.Location = new System.Drawing.Point(141, 218);
            this.productAlertCountTextBox.Name = "productAlertCountTextBox";
            this.productAlertCountTextBox.Size = new System.Drawing.Size(197, 20);
            this.productAlertCountTextBox.TabIndex = 6;
            this.productAlertCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.productCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductCode", true));
            this.productCodeTextBox.Location = new System.Drawing.Point(141, 88);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(197, 20);
            this.productCodeTextBox.TabIndex = 0;
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductDescription", true));
            this.productDescriptionTextBox.Location = new System.Drawing.Point(141, 244);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(604, 20);
            this.productDescriptionTextBox.TabIndex = 8;
            // 
            // productGenericNameTextBox
            // 
            this.productGenericNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.productGenericNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductGenericName", true));
            this.productGenericNameTextBox.Location = new System.Drawing.Point(141, 139);
            this.productGenericNameTextBox.Name = "productGenericNameTextBox";
            this.productGenericNameTextBox.Size = new System.Drawing.Size(604, 20);
            this.productGenericNameTextBox.TabIndex = 2;
            // 
            // productInstructionTextBox
            // 
            this.productInstructionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductInstruction", true));
            this.productInstructionTextBox.Location = new System.Drawing.Point(141, 270);
            this.productInstructionTextBox.Name = "productInstructionTextBox";
            this.productInstructionTextBox.Size = new System.Drawing.Size(604, 20);
            this.productInstructionTextBox.TabIndex = 9;
            // 
            // productLotNoTextBox
            // 
            this.productLotNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductLotNo", true));
            this.productLotNoTextBox.Location = new System.Drawing.Point(418, 218);
            this.productLotNoTextBox.Name = "productLotNoTextBox";
            this.productLotNoTextBox.Size = new System.Drawing.Size(197, 20);
            this.productLotNoTextBox.TabIndex = 7;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(141, 114);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(604, 20);
            this.productNameTextBox.TabIndex = 1;
            // 
            // categoryIdComboBox
            // 
            this.categoryIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryId", true));
            this.categoryIdComboBox.DataSource = this.categoryBindingSource;
            this.categoryIdComboBox.DisplayMember = "CategoryName";
            this.categoryIdComboBox.FormattingEnabled = true;
            this.categoryIdComboBox.Location = new System.Drawing.Point(141, 189);
            this.categoryIdComboBox.Name = "categoryIdComboBox";
            this.categoryIdComboBox.Size = new System.Drawing.Size(197, 21);
            this.categoryIdComboBox.TabIndex = 4;
            this.categoryIdComboBox.ValueMember = "CategoryId";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(PharmaPos.data.Category);
            // 
            // drugTypeIdComboBox
            // 
            this.drugTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "DrugTypeId", true));
            this.drugTypeIdComboBox.DataSource = this.drugTypeBindingSource;
            this.drugTypeIdComboBox.DisplayMember = "DrugTypeName";
            this.drugTypeIdComboBox.FormattingEnabled = true;
            this.drugTypeIdComboBox.Location = new System.Drawing.Point(418, 191);
            this.drugTypeIdComboBox.Name = "drugTypeIdComboBox";
            this.drugTypeIdComboBox.Size = new System.Drawing.Size(197, 21);
            this.drugTypeIdComboBox.TabIndex = 5;
            this.drugTypeIdComboBox.ValueMember = "DrugTypeId";
            // 
            // drugTypeBindingSource
            // 
            this.drugTypeBindingSource.DataSource = typeof(PharmaPos.data.DrugType);
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DataSource = this.supplierBindingSource;
            this.supplierIdComboBox.DisplayMember = "SupplierName";
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(141, 164);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(474, 21);
            this.supplierIdComboBox.TabIndex = 3;
            this.supplierIdComboBox.ValueMember = "SupplierId";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(PharmaPos.data.Supplier);
            // 
            // ProductUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(765, 322);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(this.supplierIdComboBox);
            this.Controls.Add(drugTypeIdLabel);
            this.Controls.Add(this.drugTypeIdComboBox);
            this.Controls.Add(this.categoryIdComboBox);
            this.Controls.Add(categoryIdLabel);
            this.Controls.Add(productAlertCountLabel);
            this.Controls.Add(this.productAlertCountTextBox);
            this.Controls.Add(productCodeLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(productDescriptionLabel);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(productGenericNameLabel);
            this.Controls.Add(this.productGenericNameTextBox);
            this.Controls.Add(productInstructionLabel);
            this.Controls.Add(this.productInstructionTextBox);
            this.Controls.Add(productLotNoLabel);
            this.Controls.Add(this.productLotNoTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "ProductUpdateForm";
            this.Text = "Product Update Form";
            this.Load += new System.EventHandler(this.ProductUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productAlertCountTextBox;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productGenericNameTextBox;
        private System.Windows.Forms.TextBox productInstructionTextBox;
        private System.Windows.Forms.TextBox productLotNoTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.ComboBox categoryIdComboBox;
        private System.Windows.Forms.ComboBox drugTypeIdComboBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource drugTypeBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}