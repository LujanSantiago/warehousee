namespace Warehouse
{
    partial class warehouse
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcant = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnactualiza = new System.Windows.Forms.Button();
            this.btnborra = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.41281F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.04626F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.76868F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.05694F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.24911F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblcant, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblprice, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbldesc, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(226, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.685446F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.31455F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(83, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(234, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(316, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(394, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblid.Location = new System.Drawing.Point(3, 36);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(74, 13);
            this.lblid.TabIndex = 5;
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblid.Click += new System.EventHandler(this.lblid_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblname.Location = new System.Drawing.Point(83, 36);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(145, 13);
            this.lblname.TabIndex = 6;
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcant.Location = new System.Drawing.Point(234, 36);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(76, 13);
            this.lblcant.TabIndex = 7;
            this.lblcant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcant.Click += new System.EventHandler(this.lblcant_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblprice.Location = new System.Drawing.Point(316, 36);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(72, 13);
            this.lblprice.TabIndex = 8;
            this.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblprice.Click += new System.EventHandler(this.lblprice_Click);
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldesc.Location = new System.Drawing.Point(394, 36);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(165, 13);
            this.lbldesc.TabIndex = 9;
            this.lbldesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldesc.Click += new System.EventHandler(this.lbldesc_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(25, 24);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(195, 37);
            this.btninsert.TabIndex = 1;
            this.btninsert.Text = "Insertar";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnactualiza
            // 
            this.btnactualiza.Location = new System.Drawing.Point(25, 100);
            this.btnactualiza.Name = "btnactualiza";
            this.btnactualiza.Size = new System.Drawing.Size(195, 37);
            this.btnactualiza.TabIndex = 2;
            this.btnactualiza.Text = "ventas";
            this.btnactualiza.UseVisualStyleBackColor = true;
            this.btnactualiza.Click += new System.EventHandler(this.btnactualiza_Click);
            // 
            // btnborra
            // 
            this.btnborra.Location = new System.Drawing.Point(25, 186);
            this.btnborra.Name = "btnborra";
            this.btnborra.Size = new System.Drawing.Size(195, 37);
            this.btnborra.TabIndex = 3;
            this.btnborra.Text = "porcentajes";
            this.btnborra.UseVisualStyleBackColor = true;
            this.btnborra.Click += new System.EventHandler(this.btnborra_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(25, 343);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(195, 37);
            this.logout.TabIndex = 4;
            this.logout.Text = "Cerrar sesión";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.btnborra);
            this.Controls.Add(this.btnactualiza);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "warehouse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.warehouse_FormClosed);
            this.Load += new System.EventHandler(this.warehouse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnactualiza;
        private System.Windows.Forms.Button btnborra;
        private System.Windows.Forms.Button logout;
    }
}