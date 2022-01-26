namespace FoodDeliveryUI
{
    partial class RestoranDashBoard
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
            this.lblDeals = new System.Windows.Forms.Label();
            this.lbNarudzbe = new System.Windows.Forms.ListBox();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeals
            // 
            this.lblDeals.AutoSize = true;
            this.lblDeals.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeals.Location = new System.Drawing.Point(134, 9);
            this.lblDeals.Name = "lblDeals";
            this.lblDeals.Size = new System.Drawing.Size(289, 45);
            this.lblDeals.TabIndex = 2;
            this.lblDeals.Text = "Pending orders";
            // 
            // lbNarudzbe
            // 
            this.lbNarudzbe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNarudzbe.FormattingEnabled = true;
            this.lbNarudzbe.ItemHeight = 17;
            this.lbNarudzbe.Location = new System.Drawing.Point(20, 70);
            this.lbNarudzbe.Name = "lbNarudzbe";
            this.lbNarudzbe.Size = new System.Drawing.Size(519, 225);
            this.lbNarudzbe.TabIndex = 3;
            this.lbNarudzbe.SelectedIndexChanged += new System.EventHandler(this.lbNarudzbe_SelectedIndexChanged);
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.BackColor = System.Drawing.Color.Brown;
            this.btnFinishOrder.FlatAppearance.BorderSize = 0;
            this.btnFinishOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishOrder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishOrder.ForeColor = System.Drawing.Color.White;
            this.btnFinishOrder.Location = new System.Drawing.Point(182, 334);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(185, 35);
            this.btnFinishOrder.TabIndex = 35;
            this.btnFinishOrder.Text = "Finish Order";
            this.btnFinishOrder.UseVisualStyleBackColor = false;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // RestoranDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 425);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.lbNarudzbe);
            this.Controls.Add(this.lblDeals);
            this.Name = "RestoranDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeals;
        private System.Windows.Forms.ListBox lbNarudzbe;
        private System.Windows.Forms.Button btnFinishOrder;
    }
}