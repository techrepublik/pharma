namespace PharmaPos.forms
{
    partial class ProductQntyUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductQntyUpdateForm));
            System.Windows.Forms.Label productManufactureDateLabel;
            System.Windows.Forms.Label productQuanitityCostLabel;
            System.Windows.Forms.Label productQuantityDateLabel;
            System.Windows.Forms.Label productQuantityExpiryDateLabel;
            System.Windows.Forms.Label productQuantityIsActiveLabel;
            System.Windows.Forms.Label productQuantityIsDiscountedLabel;
            System.Windows.Forms.Label productQuantityIsExpiredLabel;
            System.Windows.Forms.Label productQuantityPriceLabel;
            System.Windows.Forms.Label productQuantityQntyLabel;
            System.Windows.Forms.Label label1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.productQuantityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productQuantityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productQuantityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productManufactureDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productQuanitityCostTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productQuantityExpiryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productQuantityIsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.productQuantityIsDiscountedCheckBox = new System.Windows.Forms.CheckBox();
            this.productQuantityIsExpiredCheckBox = new System.Windows.Forms.CheckBox();
            this.productQuantityPriceTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityQntyTextBox = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            productManufactureDateLabel = new System.Windows.Forms.Label();
            productQuanitityCostLabel = new System.Windows.Forms.Label();
            productQuantityDateLabel = new System.Windows.Forms.Label();
            productQuantityExpiryDateLabel = new System.Windows.Forms.Label();
            productQuantityIsActiveLabel = new System.Windows.Forms.Label();
            productQuantityIsDiscountedLabel = new System.Windows.Forms.Label();
            productQuantityIsExpiredLabel = new System.Windows.Forms.Label();
            productQuantityPriceLabel = new System.Windows.Forms.Label();
            productQuantityQntyLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityBindingNavigator)).BeginInit();
            this.productQuantityBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 40);
            this.panel1.TabIndex = 1;
            // 
            // productQuantityBindingSource
            // 
            this.productQuantityBindingSource.DataSource = typeof(PharmaPos.data.ProductQuantity);
            this.productQuantityBindingSource.CurrentChanged += new System.EventHandler(this.productQuantityBindingSource_CurrentChanged);
            // 
            // productQuantityBindingNavigator
            // 
            this.productQuantityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productQuantityBindingNavigator.BindingSource = this.productQuantityBindingSource;
            this.productQuantityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productQuantityBindingNavigator.DeleteItem = null;
            this.productQuantityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productQuantityBindingNavigatorSaveItem});
            this.productQuantityBindingNavigator.Location = new System.Drawing.Point(0, 40);
            this.productQuantityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productQuantityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productQuantityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productQuantityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productQuantityBindingNavigator.Name = "productQuantityBindingNavigator";
            this.productQuantityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productQuantityBindingNavigator.Size = new System.Drawing.Size(609, 25);
            this.productQuantityBindingNavigator.TabIndex = 2;
            this.productQuantityBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productQuantityBindingNavigatorSaveItem
            // 
            this.productQuantityBindingNavigatorSaveItem.Enabled = false;
            this.productQuantityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productQuantityBindingNavigatorSaveItem.Image")));
            this.productQuantityBindingNavigatorSaveItem.Name = "productQuantityBindingNavigatorSaveItem";
            this.productQuantityBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.productQuantityBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // productManufactureDateLabel
            // 
            productManufactureDateLabel.AutoSize = true;
            productManufactureDateLabel.Location = new System.Drawing.Point(19, 147);
            productManufactureDateLabel.Name = "productManufactureDateLabel";
            productManufactureDateLabel.Size = new System.Drawing.Size(96, 13);
            productManufactureDateLabel.TabIndex = 6;
            productManufactureDateLabel.Text = "Manufacture Date:";
            // 
            // productManufactureDateDateTimePicker
            // 
            this.productManufactureDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productQuantityBindingSource, "ProductManufactureDate", true));
            this.productManufactureDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.productManufactureDateDateTimePicker.Location = new System.Drawing.Point(161, 143);
            this.productManufactureDateDateTimePicker.Name = "productManufactureDateDateTimePicker";
            this.productManufactureDateDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.productManufactureDateDateTimePicker.TabIndex = 1;
            // 
            // productQuanitityCostLabel
            // 
            productQuanitityCostLabel.AutoSize = true;
            productQuanitityCostLabel.Location = new System.Drawing.Point(19, 172);
            productQuanitityCostLabel.Name = "productQuanitityCostLabel";
            productQuanitityCostLabel.Size = new System.Drawing.Size(31, 13);
            productQuanitityCostLabel.TabIndex = 8;
            productQuanitityCostLabel.Text = "Cost:";
            // 
            // productQuanitityCostTextBox
            // 
            this.productQuanitityCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productQuantityBindingSource, "ProductQuanitityCost", true));
            this.productQuanitityCostTextBox.Location = new System.Drawing.Point(161, 169);
            this.productQuanitityCostTextBox.Name = "productQuanitityCostTextBox";
            this.productQuanitityCostTextBox.Size = new System.Drawing.Size(138, 20);
            this.productQuanitityCostTextBox.TabIndex = 3;
            // 
            // productQuantityDateLabel
            // 
            productQuantityDateLabel.AutoSize = true;
            productQuantityDateLabel.Location = new System.Drawing.Point(19, 121);
            productQuantityDateLabel.Name = "productQuantityDateLabel";
            productQuantityDateLabel.Size = new System.Drawing.Size(60, 13);
            productQuantityDateLabel.TabIndex = 10;
            productQuantityDateLabel.Text = "Entry Date:";
            // 
            // productQuantityDateDateTimePicker
            // 
            this.productQuantityDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productQuantityBindingSource, "ProductQuantityDate", true));
            this.productQuantityDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.productQuantityDateDateTimePicker.Location = new System.Drawing.Point(161, 117);
            this.productQuantityDateDateTimePicker.Name = "productQuantityDateDateTimePicker";
            this.productQuantityDateDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.productQuantityDateDateTimePicker.TabIndex = 0;
            // 
            // productQuantityExpiryDateLabel
            // 
            productQuantityExpiryDateLabel.AutoSize = true;
            productQuantityExpiryDateLabel.Location = new System.Drawing.Point(349, 147);
            productQuantityExpiryDateLabel.Name = "productQuantityExpiryDateLabel";
            productQuantityExpiryDateLabel.Size = new System.Drawing.Size(64, 13);
            productQuantityExpiryDateLabel.TabIndex = 12;
            productQuantityExpiryDateLabel.Text = "Expiry Date:";
            // 
            // productQuantityExpiryDateDateTimePicker
            // 
            this.productQuantityExpiryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productQuantityBindingSource, "ProductQuantityExpiryDate", true));
            this.productQuantityExpiryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.productQuantityExpiryDateDateTimePicker.Location = new System.Drawing.Point(428, 143);
            this.productQuantityExpiryDateDateTimePicker.Name = "productQuantityExpiryDateDateTimePicker";
            this.productQuantityExpiryDateDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.productQuantityExpiryDateDateTimePicker.TabIndex = 2;
            // 
            // productQuantityIsActiveLabel
            // 
            productQuantityIsActiveLabel.AutoSize = true;
            productQuantityIsActiveLabel.Location = new System.Drawing.Point(19, 226);
            productQuantityIsActiveLabel.Name = "productQuantityIsActiveLabel";
            productQuantityIsActiveLabel.Size = new System.Drawing.Size(40, 13);
            productQuantityIsActiveLabel.TabIndex = 16;
            productQuantityIsActiveLabel.Text = "Active:";
            // 
            // productQuantityIsActiveCheckBox
            // 
            this.productQuantityIsActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productQuantityBindingSource, "ProductQuantityIsActive", true));
            this.productQuantityIsActiveCheckBox.Location = new System.Drawing.Point(161, 221);
            this.productQuantityIsActiveCheckBox.Name = "productQuantityIsActiveCheckBox";
            this.productQuantityIsActiveCheckBox.Size = new System.Drawing.Size(200, 24);
            this.productQuantityIsActiveCheckBox.TabIndex = 6;
            this.productQuantityIsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // productQuantityIsDiscountedLabel
            // 
            productQuantityIsDiscountedLabel.AutoSize = true;
            productQuantityIsDiscountedLabel.Location = new System.Drawing.Point(19, 250);
            productQuantityIsDiscountedLabel.Name = "productQuantityIsDiscountedLabel";
            productQuantityIsDiscountedLabel.Size = new System.Drawing.Size(64, 13);
            productQuantityIsDiscountedLabel.TabIndex = 18;
            productQuantityIsDiscountedLabel.Text = "Discounted:";
            // 
            // productQuantityIsDiscountedCheckBox
            // 
            this.productQuantityIsDiscountedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productQuantityBindingSource, "ProductQuantityIsDiscounted", true));
            this.productQuantityIsDiscountedCheckBox.Location = new System.Drawing.Point(161, 245);
            this.productQuantityIsDiscountedCheckBox.Name = "productQuantityIsDiscountedCheckBox";
            this.productQuantityIsDiscountedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.productQuantityIsDiscountedCheckBox.TabIndex = 7;
            this.productQuantityIsDiscountedCheckBox.UseVisualStyleBackColor = true;
            // 
            // productQuantityIsExpiredLabel
            // 
            productQuantityIsExpiredLabel.AutoSize = true;
            productQuantityIsExpiredLabel.Location = new System.Drawing.Point(19, 271);
            productQuantityIsExpiredLabel.Name = "productQuantityIsExpiredLabel";
            productQuantityIsExpiredLabel.Size = new System.Drawing.Size(45, 13);
            productQuantityIsExpiredLabel.TabIndex = 20;
            productQuantityIsExpiredLabel.Text = "Expired:";
            // 
            // productQuantityIsExpiredCheckBox
            // 
            this.productQuantityIsExpiredCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productQuantityBindingSource, "ProductQuantityIsExpired", true));
            this.productQuantityIsExpiredCheckBox.Location = new System.Drawing.Point(161, 266);
            this.productQuantityIsExpiredCheckBox.Name = "productQuantityIsExpiredCheckBox";
            this.productQuantityIsExpiredCheckBox.Size = new System.Drawing.Size(200, 24);
            this.productQuantityIsExpiredCheckBox.TabIndex = 8;
            this.productQuantityIsExpiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // productQuantityPriceLabel
            // 
            productQuantityPriceLabel.AutoSize = true;
            productQuantityPriceLabel.Location = new System.Drawing.Point(349, 172);
            productQuantityPriceLabel.Name = "productQuantityPriceLabel";
            productQuantityPriceLabel.Size = new System.Drawing.Size(68, 13);
            productQuantityPriceLabel.TabIndex = 22;
            productQuantityPriceLabel.Text = "Selling Price:";
            // 
            // productQuantityPriceTextBox
            // 
            this.productQuantityPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productQuantityBindingSource, "ProductQuantityPrice", true));
            this.productQuantityPriceTextBox.Location = new System.Drawing.Point(428, 169);
            this.productQuantityPriceTextBox.Name = "productQuantityPriceTextBox";
            this.productQuantityPriceTextBox.Size = new System.Drawing.Size(138, 20);
            this.productQuantityPriceTextBox.TabIndex = 4;
            // 
            // productQuantityQntyLabel
            // 
            productQuantityQntyLabel.AutoSize = true;
            productQuantityQntyLabel.Location = new System.Drawing.Point(19, 198);
            productQuantityQntyLabel.Name = "productQuantityQntyLabel";
            productQuantityQntyLabel.Size = new System.Drawing.Size(49, 13);
            productQuantityQntyLabel.TabIndex = 24;
            productQuantityQntyLabel.Text = "Quantity:";
            // 
            // productQuantityQntyTextBox
            // 
            this.productQuantityQntyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productQuantityBindingSource, "ProductQuantityQnty", true));
            this.productQuantityQntyTextBox.Location = new System.Drawing.Point(161, 195);
            this.productQuantityQntyTextBox.Name = "productQuantityQntyTextBox";
            this.productQuantityQntyTextBox.Size = new System.Drawing.Size(138, 20);
            this.productQuantityQntyTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 13);
            label1.TabIndex = 26;
            label1.Text = "Product:";
            // 
            // labelProductName
            // 
            this.labelProductName.Location = new System.Drawing.Point(161, 86);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(405, 23);
            this.labelProductName.TabIndex = 27;
            this.labelProductName.Text = "...";
            // 
            // ProductQntyUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(609, 316);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(label1);
            this.Controls.Add(productManufactureDateLabel);
            this.Controls.Add(this.productManufactureDateDateTimePicker);
            this.Controls.Add(productQuanitityCostLabel);
            this.Controls.Add(this.productQuanitityCostTextBox);
            this.Controls.Add(productQuantityDateLabel);
            this.Controls.Add(this.productQuantityDateDateTimePicker);
            this.Controls.Add(productQuantityExpiryDateLabel);
            this.Controls.Add(this.productQuantityExpiryDateDateTimePicker);
            this.Controls.Add(productQuantityIsActiveLabel);
            this.Controls.Add(this.productQuantityIsActiveCheckBox);
            this.Controls.Add(productQuantityIsDiscountedLabel);
            this.Controls.Add(this.productQuantityIsDiscountedCheckBox);
            this.Controls.Add(productQuantityIsExpiredLabel);
            this.Controls.Add(this.productQuantityIsExpiredCheckBox);
            this.Controls.Add(productQuantityPriceLabel);
            this.Controls.Add(this.productQuantityPriceTextBox);
            this.Controls.Add(productQuantityQntyLabel);
            this.Controls.Add(this.productQuantityQntyTextBox);
            this.Controls.Add(this.productQuantityBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "ProductQntyUpdateForm";
            this.Text = "Product Qnty Update Form";
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityBindingNavigator)).EndInit();
            this.productQuantityBindingNavigator.ResumeLayout(false);
            this.productQuantityBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource productQuantityBindingSource;
        private System.Windows.Forms.BindingNavigator productQuantityBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productQuantityBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker productManufactureDateDateTimePicker;
        private System.Windows.Forms.TextBox productQuanitityCostTextBox;
        private System.Windows.Forms.DateTimePicker productQuantityDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker productQuantityExpiryDateDateTimePicker;
        private System.Windows.Forms.CheckBox productQuantityIsActiveCheckBox;
        private System.Windows.Forms.CheckBox productQuantityIsDiscountedCheckBox;
        private System.Windows.Forms.CheckBox productQuantityIsExpiredCheckBox;
        private System.Windows.Forms.TextBox productQuantityPriceTextBox;
        private System.Windows.Forms.TextBox productQuantityQntyTextBox;
        private System.Windows.Forms.Label labelProductName;
    }
}