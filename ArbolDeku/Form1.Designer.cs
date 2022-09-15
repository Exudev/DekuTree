
namespace ArbolDeku
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btngraficar = new System.Windows.Forms.Button();
            this.txtbox_graficar = new System.Windows.Forms.TextBox();
            this.lblpreorden = new System.Windows.Forms.Label();
            this.lbl_inorden = new System.Windows.Forms.Label();
            this.lblpostorden = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.lbln = new System.Windows.Forms.Label();
            this.lblpost = new System.Windows.Forms.Label();
            this.pbgrafica = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbgrafica)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngraficar
            // 
            this.btngraficar.Location = new System.Drawing.Point(273, 15);
            this.btngraficar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngraficar.Name = "btngraficar";
            this.btngraficar.Size = new System.Drawing.Size(96, 29);
            this.btngraficar.TabIndex = 0;
            this.btngraficar.Text = "Graficar";
            this.btngraficar.UseVisualStyleBackColor = true;
            this.btngraficar.Click += new System.EventHandler(this.btngraficar_Click);
            // 
            // txtbox_graficar
            // 
            this.txtbox_graficar.Location = new System.Drawing.Point(15, 15);
            this.txtbox_graficar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_graficar.Name = "txtbox_graficar";
            this.txtbox_graficar.Size = new System.Drawing.Size(248, 26);
            this.txtbox_graficar.TabIndex = 1;
            this.txtbox_graficar.UseWaitCursor = true;
            // 
            // lblpreorden
            // 
            this.lblpreorden.AutoSize = true;
            this.lblpreorden.Location = new System.Drawing.Point(19, 25);
            this.lblpreorden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpreorden.Name = "lblpreorden";
            this.lblpreorden.Size = new System.Drawing.Size(68, 19);
            this.lblpreorden.TabIndex = 2;
            this.lblpreorden.Text = "Preorden:";
            this.lblpreorden.Click += new System.EventHandler(this.lblpreorden_Click);
            // 
            // lbl_inorden
            // 
            this.lbl_inorden.AutoSize = true;
            this.lbl_inorden.Location = new System.Drawing.Point(19, 57);
            this.lbl_inorden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inorden.Name = "lbl_inorden";
            this.lbl_inorden.Size = new System.Drawing.Size(59, 19);
            this.lbl_inorden.TabIndex = 3;
            this.lbl_inorden.Text = "Inorden:";
            // 
            // lblpostorden
            // 
            this.lblpostorden.AutoSize = true;
            this.lblpostorden.Location = new System.Drawing.Point(19, 90);
            this.lblpostorden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpostorden.Name = "lblpostorden";
            this.lblpostorden.Size = new System.Drawing.Size(74, 19);
            this.lblpostorden.TabIndex = 4;
            this.lblpostorden.Text = "Postorden:";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(170, 25);
            this.lblPre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(51, 19);
            this.lblPre.TabIndex = 5;
            this.lblPre.Text = "-------";
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(170, 57);
            this.lbln.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(51, 19);
            this.lbln.TabIndex = 6;
            this.lbln.Text = "-------";
            // 
            // lblpost
            // 
            this.lblpost.AutoSize = true;
            this.lblpost.Location = new System.Drawing.Point(170, 90);
            this.lblpost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpost.Name = "lblpost";
            this.lblpost.Size = new System.Drawing.Size(51, 19);
            this.lblpost.TabIndex = 7;
            this.lblpost.Text = "-------";
            // 
            // pbgrafica
            // 
            this.pbgrafica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbgrafica.Location = new System.Drawing.Point(15, 72);
            this.pbgrafica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbgrafica.Name = "pbgrafica";
            this.pbgrafica.Size = new System.Drawing.Size(285, 214);
            this.pbgrafica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbgrafica.TabIndex = 8;
            this.pbgrafica.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblpreorden);
            this.panel1.Controls.Add(this.lblPre);
            this.panel1.Controls.Add(this.lblpost);
            this.panel1.Controls.Add(this.lbl_inorden);
            this.panel1.Controls.Add(this.lblpostorden);
            this.panel1.Controls.Add(this.lbln);
            this.panel1.Location = new System.Drawing.Point(308, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 127);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pablo Edu Diaz ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(623, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbgrafica);
            this.Controls.Add(this.txtbox_graficar);
            this.Controls.Add(this.btngraficar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Arbol Deku";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbgrafica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngraficar;
        private System.Windows.Forms.TextBox txtbox_graficar;
        private System.Windows.Forms.Label lblpreorden;
        private System.Windows.Forms.Label lbl_inorden;
        private System.Windows.Forms.Label lblpostorden;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.Label lblpost;
        private System.Windows.Forms.PictureBox pbgrafica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

