namespace CafeManagement.AllControl
{
    partial class UC_AddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddItems));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnAddItem = new Guna.UI.WinForms.GunaGradientButton();
            this.fieldCategory = new Guna.UI.WinForms.GunaComboBox();
            this.fieldItemName = new Guna.UI.WinForms.GunaTextBox();
            this.fieldItemPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Cairo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(164, 31);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(287, 50);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Add new item to menu";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(117, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(76, 30);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Category";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(117, 176);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(89, 30);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Item Name";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(117, 249);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(83, 30);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Item Price";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.AnimationHoverSpeed = 0.07F;
            this.btnAddItem.AnimationSpeed = 0.03F;
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnAddItem.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnAddItem.BorderColor = System.Drawing.Color.Black;
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItem.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItem.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddItem.Location = new System.Drawing.Point(249, 343);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(101)))));
            this.btnAddItem.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnAddItem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddItem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddItem.OnHoverImage = null;
            this.btnAddItem.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddItem.Radius = 20;
            this.btnAddItem.Size = new System.Drawing.Size(134, 42);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // fieldCategory
            // 
            this.fieldCategory.BackColor = System.Drawing.Color.Transparent;
            this.fieldCategory.BaseColor = System.Drawing.Color.White;
            this.fieldCategory.BorderColor = System.Drawing.Color.Silver;
            this.fieldCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fieldCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldCategory.FocusedColor = System.Drawing.Color.Empty;
            this.fieldCategory.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldCategory.ForeColor = System.Drawing.Color.Black;
            this.fieldCategory.FormattingEnabled = true;
            this.fieldCategory.Items.AddRange(new object[] {
            "Cake",
            "Hot Drinks",
            "Soft drink",
            "Desserts",
            "Ice cream"});
            this.fieldCategory.Location = new System.Drawing.Point(122, 131);
            this.fieldCategory.Name = "fieldCategory";
            this.fieldCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fieldCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.fieldCategory.Size = new System.Drawing.Size(384, 38);
            this.fieldCategory.TabIndex = 5;
            // 
            // fieldItemName
            // 
            this.fieldItemName.BaseColor = System.Drawing.Color.White;
            this.fieldItemName.BorderColor = System.Drawing.Color.Silver;
            this.fieldItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fieldItemName.FocusedBaseColor = System.Drawing.Color.White;
            this.fieldItemName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fieldItemName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.fieldItemName.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldItemName.Location = new System.Drawing.Point(122, 203);
            this.fieldItemName.Name = "fieldItemName";
            this.fieldItemName.PasswordChar = '\0';
            this.fieldItemName.SelectedText = "";
            this.fieldItemName.Size = new System.Drawing.Size(384, 40);
            this.fieldItemName.TabIndex = 6;
            // 
            // fieldItemPrice
            // 
            this.fieldItemPrice.BaseColor = System.Drawing.Color.White;
            this.fieldItemPrice.BorderColor = System.Drawing.Color.Silver;
            this.fieldItemPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fieldItemPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.fieldItemPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fieldItemPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.fieldItemPrice.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldItemPrice.Location = new System.Drawing.Point(122, 276);
            this.fieldItemPrice.Name = "fieldItemPrice";
            this.fieldItemPrice.PasswordChar = '\0';
            this.fieldItemPrice.SelectedText = "";
            this.fieldItemPrice.Size = new System.Drawing.Size(384, 40);
            this.fieldItemPrice.TabIndex = 7;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // UC_AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fieldItemPrice);
            this.Controls.Add(this.fieldItemName);
            this.Controls.Add(this.fieldCategory);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "UC_AddItems";
            this.Size = new System.Drawing.Size(715, 500);
            this.Leave += new System.EventHandler(this.UC_AddItems_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaGradientButton btnAddItem;
        private Guna.UI.WinForms.GunaComboBox fieldCategory;
        private Guna.UI.WinForms.GunaTextBox fieldItemName;
        private Guna.UI.WinForms.GunaTextBox fieldItemPrice;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
