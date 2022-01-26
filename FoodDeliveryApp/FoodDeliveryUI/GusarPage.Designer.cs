namespace FoodDeliveryUI
{
    partial class GusarPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GusarPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDeals = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tbImePrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCell = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblDeals
            // 
            this.lblDeals.AutoSize = true;
            this.lblDeals.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeals.Location = new System.Drawing.Point(101, 17);
            this.lblDeals.Name = "lblDeals";
            this.lblDeals.Size = new System.Drawing.Size(286, 45);
            this.lblDeals.TabIndex = 4;
            this.lblDeals.Text = "Pizzeria Gusar";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(93, 96);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(70, 25);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Menu";
            // 
            // lbMenu
            // 
            this.lbMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 21;
            this.lbMenu.Location = new System.Drawing.Point(33, 135);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(200, 189);
            this.lbMenu.TabIndex = 32;
            this.lbMenu.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(33, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Brown;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(173, 339);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(185, 35);
            this.btnOrder.TabIndex = 34;
            this.btnOrder.Text = "Make Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbImePrezime
            // 
            this.tbImePrezime.Location = new System.Drawing.Point(309, 135);
            this.tbImePrezime.Name = "tbImePrezime";
            this.tbImePrezime.Size = new System.Drawing.Size(203, 20);
            this.tbImePrezime.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Cell phone";
            // 
            // tbCell
            // 
            this.tbCell.Location = new System.Drawing.Point(309, 207);
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(203, 20);
            this.tbCell.TabIndex = 38;
            // 
            // GusarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbImePrezime);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblDeals);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GusarPage";
            this.Size = new System.Drawing.Size(575, 435);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDeals;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox tbImePrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCell;
    }
}
