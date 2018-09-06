namespace Zeichnen
{
    partial class Strichdicke
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
            this.nud_dicke = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbl_dicke = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_abb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dicke)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_dicke
            // 
            this.nud_dicke.Location = new System.Drawing.Point(30, 29);
            this.nud_dicke.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_dicke.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_dicke.Name = "nud_dicke";
            this.nud_dicke.Size = new System.Drawing.Size(102, 20);
            this.nud_dicke.TabIndex = 0;
            this.nud_dicke.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_dicke
            // 
            this.lbl_dicke.AutoSize = true;
            this.lbl_dicke.Location = new System.Drawing.Point(27, 13);
            this.lbl_dicke.Name = "lbl_dicke";
            this.lbl_dicke.Size = new System.Drawing.Size(105, 13);
            this.lbl_dicke.TabIndex = 1;
            this.lbl_dicke.Text = "Srichdicke (1 - 1000)";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 55);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(64, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_abb
            // 
            this.btn_abb.Location = new System.Drawing.Point(82, 55);
            this.btn_abb.Name = "btn_abb";
            this.btn_abb.Size = new System.Drawing.Size(64, 23);
            this.btn_abb.TabIndex = 2;
            this.btn_abb.Text = "Abbrechen";
            this.btn_abb.UseVisualStyleBackColor = true;
            this.btn_abb.Click += new System.EventHandler(this.btn_abb_Click);
            // 
            // Strichdicke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 90);
            this.Controls.Add(this.btn_abb);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_dicke);
            this.Controls.Add(this.nud_dicke);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Strichdicke";
            this.Text = "Strichdicke ändern";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Strichdicke_FormClosing);
            this.Load += new System.EventHandler(this.Strichdicke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_dicke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_dicke;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbl_dicke;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_abb;
    }
}