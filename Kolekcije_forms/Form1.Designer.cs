namespace Liste_forms
{
    partial class Form1
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
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.cmboVrsta = new System.Windows.Forms.ComboBox();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(29, 50);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(348, 31);
            this.txtMarka.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(29, 117);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(348, 31);
            this.txtModel.TabIndex = 1;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(446, 50);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(396, 253);
            this.txtIspis.TabIndex = 2;
            // 
            // cmboVrsta
            // 
            this.cmboVrsta.FormattingEnabled = true;
            this.cmboVrsta.Items.AddRange(new object[] {
            "Avion",
            "Automobil",
            "Brod"});
            this.cmboVrsta.Location = new System.Drawing.Point(29, 184);
            this.cmboVrsta.Name = "cmboVrsta";
            this.cmboVrsta.Size = new System.Drawing.Size(348, 33);
            this.cmboVrsta.TabIndex = 3;
            this.cmboVrsta.SelectedIndexChanged += new System.EventHandler(this.cmboVrsta_SelectedIndexChanged);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(721, 346);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIspis.Size = new System.Drawing.Size(121, 63);
            this.btnIspis.TabIndex = 4;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(12, 346);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(121, 63);
            this.btnUnos.TabIndex = 5;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(347, 346);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(121, 63);
            this.btnObradi.TabIndex = 6;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 464);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.cmboVrsta);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.ComboBox cmboVrsta;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObradi;
    }
}

