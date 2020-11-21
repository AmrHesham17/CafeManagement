namespace CafeManagement.AllControl
{
    partial class UC_Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Order));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.chooseCategory = new Guna.UI.WinForms.GunaComboBox();
            this.fieldSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtItemName = new Guna.UI.WinForms.GunaTextBox();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.fieldTotal = new Guna.UI.WinForms.GunaTextBox();
            this.fieldQuantityUpDown = new Guna.UI.WinForms.GunaNumeric();
            this.btnAddtoBill = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPrint = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.totalBillLabel = new Guna.UI.WinForms.GunaLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Cairo", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaLabel1.Location = new System.Drawing.Point(13, -6);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(104, 60);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Order";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(20, 45);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(76, 30);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Category";
            // 
            // chooseCategory
            // 
            this.chooseCategory.BackColor = System.Drawing.Color.Transparent;
            this.chooseCategory.BaseColor = System.Drawing.Color.White;
            this.chooseCategory.BorderColor = System.Drawing.Color.Silver;
            this.chooseCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chooseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseCategory.FocusedColor = System.Drawing.Color.Empty;
            this.chooseCategory.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCategory.ForeColor = System.Drawing.Color.Black;
            this.chooseCategory.FormattingEnabled = true;
            this.chooseCategory.Items.AddRange(new object[] {
            "Cake",
            "Hot Drinks",
            "Soft drink",
            "Desserts",
            "Ice cream"});
            this.chooseCategory.Location = new System.Drawing.Point(25, 78);
            this.chooseCategory.Name = "chooseCategory";
            this.chooseCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chooseCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.chooseCategory.Size = new System.Drawing.Size(140, 38);
            this.chooseCategory.TabIndex = 2;
            this.chooseCategory.SelectedIndexChanged += new System.EventHandler(this.chooseCategory_SelectedIndexChanged);
            // 
            // fieldSearch
            // 
            this.fieldSearch.BaseColor = System.Drawing.Color.White;
            this.fieldSearch.BorderColor = System.Drawing.Color.Silver;
            this.fieldSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fieldSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.fieldSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fieldSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.fieldSearch.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldSearch.ForeColor = System.Drawing.Color.Silver;
            this.fieldSearch.Location = new System.Drawing.Point(25, 131);
            this.fieldSearch.Name = "fieldSearch";
            this.fieldSearch.PasswordChar = '\0';
            this.fieldSearch.SelectedText = "";
            this.fieldSearch.Size = new System.Drawing.Size(140, 40);
            this.fieldSearch.TabIndex = 3;
            this.fieldSearch.Text = "Search";
            this.fieldSearch.TextChanged += new System.EventHandler(this.fieldSearch_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(210, 22);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(89, 30);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Item Name";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(452, 22);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(47, 30);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Price";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(210, 94);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(73, 30);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "Quantity";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(452, 94);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(47, 30);
            this.gunaLabel6.TabIndex = 8;
            this.gunaLabel6.Text = "Total";
            // 
            // txtItemName
            // 
            this.txtItemName.BaseColor = System.Drawing.Color.White;
            this.txtItemName.BorderColor = System.Drawing.Color.Silver;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtItemName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtItemName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItemName.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.DimGray;
            this.txtItemName.Location = new System.Drawing.Point(215, 51);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.SelectedText = "";
            this.txtItemName.Size = new System.Drawing.Size(182, 40);
            this.txtItemName.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.Location = new System.Drawing.Point(457, 51);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(182, 40);
            this.txtPrice.TabIndex = 10;
            // 
            // fieldTotal
            // 
            this.fieldTotal.BaseColor = System.Drawing.Color.White;
            this.fieldTotal.BorderColor = System.Drawing.Color.Silver;
            this.fieldTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fieldTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.fieldTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fieldTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.fieldTotal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldTotal.ForeColor = System.Drawing.Color.DimGray;
            this.fieldTotal.Location = new System.Drawing.Point(457, 127);
            this.fieldTotal.Name = "fieldTotal";
            this.fieldTotal.PasswordChar = '\0';
            this.fieldTotal.SelectedText = "";
            this.fieldTotal.Size = new System.Drawing.Size(182, 40);
            this.fieldTotal.TabIndex = 11;
            // 
            // fieldQuantityUpDown
            // 
            this.fieldQuantityUpDown.BaseColor = System.Drawing.Color.White;
            this.fieldQuantityUpDown.BorderColor = System.Drawing.Color.Silver;
            this.fieldQuantityUpDown.BorderSize = 2;
            this.fieldQuantityUpDown.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.fieldQuantityUpDown.ButtonForeColor = System.Drawing.Color.White;
            this.fieldQuantityUpDown.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldQuantityUpDown.ForeColor = System.Drawing.Color.DimGray;
            this.fieldQuantityUpDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fieldQuantityUpDown.Location = new System.Drawing.Point(215, 133);
            this.fieldQuantityUpDown.Maximum = ((long)(9999999));
            this.fieldQuantityUpDown.Minimum = ((long)(0));
            this.fieldQuantityUpDown.Name = "fieldQuantityUpDown";
            this.fieldQuantityUpDown.Size = new System.Drawing.Size(182, 30);
            this.fieldQuantityUpDown.TabIndex = 12;
            this.fieldQuantityUpDown.Text = "gunaNumeric1";
            this.fieldQuantityUpDown.Value = ((long)(0));
            this.fieldQuantityUpDown.ValueChanged += new System.EventHandler(this.fieldQuantityUpDown_ValueChanged);
            // 
            // btnAddtoBill
            // 
            this.btnAddtoBill.AnimationHoverSpeed = 0.07F;
            this.btnAddtoBill.AnimationSpeed = 0.03F;
            this.btnAddtoBill.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnAddtoBill.BorderColor = System.Drawing.Color.Black;
            this.btnAddtoBill.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnAddtoBill.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddtoBill.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddtoBill.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddtoBill.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddtoBill.CheckedImage")));
            this.btnAddtoBill.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddtoBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddtoBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddtoBill.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddtoBill.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoBill.ForeColor = System.Drawing.Color.White;
            this.btnAddtoBill.Image = ((System.Drawing.Image)(resources.GetObject("btnAddtoBill.Image")));
            this.btnAddtoBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddtoBill.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddtoBill.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddtoBill.Location = new System.Drawing.Point(457, 173);
            this.btnAddtoBill.Name = "btnAddtoBill";
            this.btnAddtoBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(101)))));
            this.btnAddtoBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddtoBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddtoBill.OnHoverImage = null;
            this.btnAddtoBill.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddtoBill.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddtoBill.Size = new System.Drawing.Size(182, 42);
            this.btnAddtoBill.TabIndex = 13;
            this.btnAddtoBill.Text = "Add to bill";
            this.btnAddtoBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddtoBill.Click += new System.EventHandler(this.btnAddtoBill_Click);
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 22;
            this.gunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(184, 241);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(474, 118);
            this.gunaDataGridView1.TabIndex = 15;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // btnRemove
            // 
            this.btnRemove.AnimationHoverSpeed = 0.07F;
            this.btnRemove.AnimationSpeed = 0.03F;
            this.btnRemove.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnRemove.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnRemove.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRemove.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRemove.CheckedForeColor = System.Drawing.Color.White;
            this.btnRemove.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.CheckedImage")));
            this.btnRemove.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemove.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRemove.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRemove.Location = new System.Drawing.Point(184, 394);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(101)))));
            this.btnRemove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemove.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemove.OnHoverImage = null;
            this.btnRemove.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRemove.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemove.Size = new System.Drawing.Size(136, 42);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnPrint.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPrint.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPrint.CheckedForeColor = System.Drawing.Color.White;
            this.btnPrint.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.CheckedImage")));
            this.btnPrint.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrint.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPrint.Location = new System.Drawing.Point(522, 394);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(101)))));
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Size = new System.Drawing.Size(136, 42);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(382, 362);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(71, 30);
            this.gunaLabel7.TabIndex = 18;
            this.gunaLabel7.Text = "Total bill";
            // 
            // totalBillLabel
            // 
            this.totalBillLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(101)))));
            this.totalBillLabel.Font = new System.Drawing.Font("Cairo SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBillLabel.Location = new System.Drawing.Point(354, 392);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(133, 48);
            this.totalBillLabel.TabIndex = 19;
            this.totalBillLabel.Text = "LE. 00";
            this.totalBillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(25, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 244);
            this.listBox1.TabIndex = 20;
            // 
            // UC_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.totalBillLabel);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.btnAddtoBill);
            this.Controls.Add(this.fieldQuantityUpDown);
            this.Controls.Add(this.fieldTotal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.fieldSearch);
            this.Controls.Add(this.chooseCategory);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "UC_Order";
            this.Size = new System.Drawing.Size(715, 500);
            this.Load += new System.EventHandler(this.UC_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox fieldSearch;
        private Guna.UI.WinForms.GunaComboBox chooseCategory;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox fieldTotal;
        private Guna.UI.WinForms.GunaTextBox txtPrice;
        private Guna.UI.WinForms.GunaTextBox txtItemName;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddtoBill;
        private Guna.UI.WinForms.GunaNumeric fieldQuantityUpDown;
        private Guna.UI.WinForms.GunaLabel totalBillLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaAdvenceButton btnPrint;
        private Guna.UI.WinForms.GunaAdvenceButton btnRemove;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ListBox listBox1;
    }
}
