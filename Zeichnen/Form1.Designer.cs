namespace Zeichnen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.nud_dicke = new System.Windows.Forms.NumericUpDown();
            this.pbx_kreis = new System.Windows.Forms.PictureBox();
            this.pbx_rechteck = new System.Windows.Forms.PictureBox();
            this.ckb_vorschau = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_d_neu = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_d_offnen = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_d_speichen = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_d_speichern_unter = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_d_beenden = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_b_zuruck = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_b_zuruc = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_b_vor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mst_b_dicke = new System.Windows.Forms.ToolStripMenuItem();
            this.farbeWählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_b_form_recht = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_b_form_kreis = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_b_vorschau = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_a_dicke = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_a_farbe = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_a_form = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_a_vorschau = new System.Windows.Forms.ToolStripMenuItem();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pbx_bild = new System.Windows.Forms.PictureBox();
            this.pbx_farbe = new System.Windows.Forms.PictureBox();
            this.cdg = new System.Windows.Forms.ColorDialog();
            this.pbx_radiren = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dicke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_kreis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_rechteck)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_farbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_radiren)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_dicke
            // 
            this.nud_dicke.Location = new System.Drawing.Point(13, 30);
            this.nud_dicke.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_dicke.Name = "nud_dicke";
            this.nud_dicke.Size = new System.Drawing.Size(55, 20);
            this.nud_dicke.TabIndex = 4;
            this.nud_dicke.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pbx_kreis
            // 
            this.pbx_kreis.Location = new System.Drawing.Point(42, 87);
            this.pbx_kreis.Name = "pbx_kreis";
            this.pbx_kreis.Size = new System.Drawing.Size(25, 25);
            this.pbx_kreis.TabIndex = 5;
            this.pbx_kreis.TabStop = false;
            this.pbx_kreis.Click += new System.EventHandler(this.pbx_kreis_Click);
            this.pbx_kreis.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_kreis_Paint);
            // 
            // pbx_rechteck
            // 
            this.pbx_rechteck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_rechteck.Location = new System.Drawing.Point(12, 87);
            this.pbx_rechteck.Name = "pbx_rechteck";
            this.pbx_rechteck.Size = new System.Drawing.Size(25, 25);
            this.pbx_rechteck.TabIndex = 5;
            this.pbx_rechteck.TabStop = false;
            this.pbx_rechteck.Click += new System.EventHandler(this.pbx_rechteck_Click);
            this.pbx_rechteck.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_rechteck_Paint);
            // 
            // ckb_vorschau
            // 
            this.ckb_vorschau.AutoSize = true;
            this.ckb_vorschau.Checked = true;
            this.ckb_vorschau.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_vorschau.Location = new System.Drawing.Point(11, 119);
            this.ckb_vorschau.Name = "ckb_vorschau";
            this.ckb_vorschau.Size = new System.Drawing.Size(71, 17);
            this.ckb_vorschau.TabIndex = 6;
            this.ckb_vorschau.Text = "Vorschau";
            this.ckb_vorschau.UseVisualStyleBackColor = true;
            this.ckb_vorschau.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.mst_b_zuruck,
            this.ansichtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mst_d_neu,
            this.mst_d_offnen,
            this.mst_d_speichen,
            this.mst_d_speichern_unter,
            this.mst_d_beenden});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // mst_d_neu
            // 
            this.mst_d_neu.Name = "mst_d_neu";
            this.mst_d_neu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mst_d_neu.Size = new System.Drawing.Size(168, 22);
            this.mst_d_neu.Text = "Neu";
            this.mst_d_neu.Click += new System.EventHandler(this.mst_d_neu_Click);
            // 
            // mst_d_offnen
            // 
            this.mst_d_offnen.Name = "mst_d_offnen";
            this.mst_d_offnen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mst_d_offnen.Size = new System.Drawing.Size(168, 22);
            this.mst_d_offnen.Text = "Öffnen...";
            this.mst_d_offnen.Click += new System.EventHandler(this.mst_d_offnen_Click);
            // 
            // mst_d_speichen
            // 
            this.mst_d_speichen.Name = "mst_d_speichen";
            this.mst_d_speichen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mst_d_speichen.Size = new System.Drawing.Size(168, 22);
            this.mst_d_speichen.Text = "Speichern";
            this.mst_d_speichen.Click += new System.EventHandler(this.mst_d_speichen_Click);
            // 
            // mst_d_speichern_unter
            // 
            this.mst_d_speichern_unter.Name = "mst_d_speichern_unter";
            this.mst_d_speichern_unter.Size = new System.Drawing.Size(168, 22);
            this.mst_d_speichern_unter.Text = "Speichen unter...";
            this.mst_d_speichern_unter.Click += new System.EventHandler(this.mst_d_speichern_unter_Click);
            // 
            // mst_d_beenden
            // 
            this.mst_d_beenden.Name = "mst_d_beenden";
            this.mst_d_beenden.Size = new System.Drawing.Size(168, 22);
            this.mst_d_beenden.Text = "Beenden";
            // 
            // mst_b_zuruck
            // 
            this.mst_b_zuruck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mst_b_zuruc,
            this.mst_b_vor,
            this.toolStripSeparator1,
            this.mst_b_dicke,
            this.farbeWählenToolStripMenuItem,
            this.formToolStripMenuItem,
            this.mst_b_vorschau});
            this.mst_b_zuruck.Name = "mst_b_zuruck";
            this.mst_b_zuruck.Size = new System.Drawing.Size(75, 20);
            this.mst_b_zuruck.Text = "Bearbeiten";
            // 
            // mst_b_zuruc
            // 
            this.mst_b_zuruc.Name = "mst_b_zuruc";
            this.mst_b_zuruc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mst_b_zuruc.Size = new System.Drawing.Size(189, 22);
            this.mst_b_zuruc.Text = "Schritt zurück";
            this.mst_b_zuruc.Click += new System.EventHandler(this.mst_b_zuruc_Click);
            // 
            // mst_b_vor
            // 
            this.mst_b_vor.Name = "mst_b_vor";
            this.mst_b_vor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mst_b_vor.Size = new System.Drawing.Size(189, 22);
            this.mst_b_vor.Text = "Schritt vor";
            this.mst_b_vor.Click += new System.EventHandler(this.mst_b_vor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // mst_b_dicke
            // 
            this.mst_b_dicke.Name = "mst_b_dicke";
            this.mst_b_dicke.Size = new System.Drawing.Size(189, 22);
            this.mst_b_dicke.Text = "Strichdicke ändern...";
            this.mst_b_dicke.Click += new System.EventHandler(this.mst_b_dicke_Click);
            // 
            // farbeWählenToolStripMenuItem
            // 
            this.farbeWählenToolStripMenuItem.Name = "farbeWählenToolStripMenuItem";
            this.farbeWählenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.farbeWählenToolStripMenuItem.Text = "Farbe wählen";
            this.farbeWählenToolStripMenuItem.Click += new System.EventHandler(this.farbeWählenToolStripMenuItem_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mst_b_form_recht,
            this.mst_b_form_kreis});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // mst_b_form_recht
            // 
            this.mst_b_form_recht.Checked = true;
            this.mst_b_form_recht.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mst_b_form_recht.Name = "mst_b_form_recht";
            this.mst_b_form_recht.Size = new System.Drawing.Size(122, 22);
            this.mst_b_form_recht.Text = "Rechteck";
            this.mst_b_form_recht.Click += new System.EventHandler(this.pbx_rechteck_Click);
            // 
            // mst_b_form_kreis
            // 
            this.mst_b_form_kreis.Name = "mst_b_form_kreis";
            this.mst_b_form_kreis.Size = new System.Drawing.Size(122, 22);
            this.mst_b_form_kreis.Text = "Kreis";
            this.mst_b_form_kreis.Click += new System.EventHandler(this.pbx_kreis_Click);
            // 
            // mst_b_vorschau
            // 
            this.mst_b_vorschau.Checked = true;
            this.mst_b_vorschau.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mst_b_vorschau.Name = "mst_b_vorschau";
            this.mst_b_vorschau.Size = new System.Drawing.Size(189, 22);
            this.mst_b_vorschau.Text = "Vorschau";
            this.mst_b_vorschau.Click += new System.EventHandler(this.mst_d_vorschau_Click);
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mst_a_dicke,
            this.mst_a_farbe,
            this.mst_a_form,
            this.mst_a_vorschau});
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // mst_a_dicke
            // 
            this.mst_a_dicke.Checked = true;
            this.mst_a_dicke.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mst_a_dicke.Name = "mst_a_dicke";
            this.mst_a_dicke.Size = new System.Drawing.Size(132, 22);
            this.mst_a_dicke.Text = "Strichdicke";
            this.mst_a_dicke.Click += new System.EventHandler(this.mst_a_dicke_Click);
            // 
            // mst_a_farbe
            // 
            this.mst_a_farbe.Checked = true;
            this.mst_a_farbe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mst_a_farbe.Name = "mst_a_farbe";
            this.mst_a_farbe.Size = new System.Drawing.Size(132, 22);
            this.mst_a_farbe.Text = "Farbe";
            this.mst_a_farbe.Click += new System.EventHandler(this.mst_a_farbe_Click);
            // 
            // mst_a_form
            // 
            this.mst_a_form.Checked = true;
            this.mst_a_form.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mst_a_form.Name = "mst_a_form";
            this.mst_a_form.Size = new System.Drawing.Size(132, 22);
            this.mst_a_form.Text = "Form";
            this.mst_a_form.Click += new System.EventHandler(this.mst_a_form_Click);
            // 
            // mst_a_vorschau
            // 
            this.mst_a_vorschau.Checked = true;
            this.mst_a_vorschau.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mst_a_vorschau.Name = "mst_a_vorschau";
            this.mst_a_vorschau.Size = new System.Drawing.Size(132, 22);
            this.mst_a_vorschau.Text = "Vorschau";
            this.mst_a_vorschau.Click += new System.EventHandler(this.mst_a_vorschau_Click);
            // 
            // sfd
            // 
            this.sfd.FileName = "Zeichnung";
            this.sfd.Filter = "Text-Dateien|*.txt";
            // 
            // ofd
            // 
            this.ofd.FileName = "Zeichnung";
            this.ofd.Filter = "Text-Dateien|*.txt";
            // 
            // pbx_bild
            // 
            this.pbx_bild.Location = new System.Drawing.Point(74, 30);
            this.pbx_bild.Name = "pbx_bild";
            this.pbx_bild.Size = new System.Drawing.Size(128, 69);
            this.pbx_bild.TabIndex = 8;
            this.pbx_bild.TabStop = false;
            this.pbx_bild.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_bild_Paint);
            this.pbx_bild.MouseLeave += new System.EventHandler(this.pbx_bild_MouseLeave);
            this.pbx_bild.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbx_bild_MouseMove);
            this.pbx_bild.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_bild_MouseUp);
            // 
            // pbx_farbe
            // 
            this.pbx_farbe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_farbe.Location = new System.Drawing.Point(12, 56);
            this.pbx_farbe.Name = "pbx_farbe";
            this.pbx_farbe.Size = new System.Drawing.Size(25, 25);
            this.pbx_farbe.TabIndex = 3;
            this.pbx_farbe.TabStop = false;
            this.pbx_farbe.Click += new System.EventHandler(this.pbx_farbe_Click);
            // 
            // pbx_radiren
            // 
            this.pbx_radiren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_radiren.Location = new System.Drawing.Point(42, 56);
            this.pbx_radiren.Name = "pbx_radiren";
            this.pbx_radiren.Size = new System.Drawing.Size(25, 25);
            this.pbx_radiren.TabIndex = 3;
            this.pbx_radiren.TabStop = false;
            this.pbx_radiren.Click += new System.EventHandler(this.pbx_radiren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 426);
            this.Controls.Add(this.pbx_bild);
            this.Controls.Add(this.ckb_vorschau);
            this.Controls.Add(this.pbx_rechteck);
            this.Controls.Add(this.pbx_kreis);
            this.Controls.Add(this.nud_dicke);
            this.Controls.Add(this.pbx_radiren);
            this.Controls.Add(this.pbx_farbe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(210, 185);
            this.Name = "Form1";
            this.Text = "Zeichnen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.nud_dicke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_kreis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_rechteck)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_farbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_radiren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_dicke;
        private System.Windows.Forms.PictureBox pbx_kreis;
        private System.Windows.Forms.PictureBox pbx_rechteck;
        private System.Windows.Forms.CheckBox ckb_vorschau;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mst_d_neu;
        private System.Windows.Forms.ToolStripMenuItem mst_d_offnen;
        private System.Windows.Forms.ToolStripMenuItem mst_d_speichen;
        private System.Windows.Forms.ToolStripMenuItem mst_d_speichern_unter;
        private System.Windows.Forms.ToolStripMenuItem mst_d_beenden;
        private System.Windows.Forms.ToolStripMenuItem mst_b_zuruck;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mst_b_zuruc;
        private System.Windows.Forms.ToolStripMenuItem mst_b_vor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mst_b_dicke;
        private System.Windows.Forms.ToolStripMenuItem farbeWählenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mst_b_form_recht;
        private System.Windows.Forms.ToolStripMenuItem mst_b_form_kreis;
        private System.Windows.Forms.ToolStripMenuItem mst_b_vorschau;
        private System.Windows.Forms.ToolStripMenuItem mst_a_dicke;
        private System.Windows.Forms.ToolStripMenuItem mst_a_farbe;
        private System.Windows.Forms.ToolStripMenuItem mst_a_form;
        private System.Windows.Forms.ToolStripMenuItem mst_a_vorschau;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.PictureBox pbx_bild;
        private System.Windows.Forms.PictureBox pbx_farbe;
        private System.Windows.Forms.ColorDialog cdg;
        private System.Windows.Forms.PictureBox pbx_radiren;
    }
}

