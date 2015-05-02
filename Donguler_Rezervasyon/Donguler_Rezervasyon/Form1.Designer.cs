namespace Donguler_Rezervasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.nubXSirasi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nubYSirasi = new System.Windows.Forms.NumericUpDown();
            this.btnKoltuklariYerlestir = new System.Windows.Forms.Button();
            this.scAnaPanel = new System.Windows.Forms.SplitContainer();
            this.pnlSecenekler = new System.Windows.Forms.Panel();
            this.rbHicbiri = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.cmbSecim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKoltukTipi = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nubXSirasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubYSirasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scAnaPanel)).BeginInit();
            this.scAnaPanel.Panel1.SuspendLayout();
            this.scAnaPanel.Panel2.SuspendLayout();
            this.scAnaPanel.SuspendLayout();
            this.pnlSecenekler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yan Yana Koltuk Sayısı";
            // 
            // nubXSirasi
            // 
            this.nubXSirasi.Location = new System.Drawing.Point(233, 29);
            this.nubXSirasi.Name = "nubXSirasi";
            this.nubXSirasi.Size = new System.Drawing.Size(120, 20);
            this.nubXSirasi.TabIndex = 1;
            this.nubXSirasi.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arka Arkaya Koltuk Sayısı";
            // 
            // nubYSirasi
            // 
            this.nubYSirasi.Location = new System.Drawing.Point(233, 67);
            this.nubYSirasi.Name = "nubYSirasi";
            this.nubYSirasi.Size = new System.Drawing.Size(120, 20);
            this.nubYSirasi.TabIndex = 1;
            this.nubYSirasi.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnKoltuklariYerlestir
            // 
            this.btnKoltuklariYerlestir.Location = new System.Drawing.Point(372, 29);
            this.btnKoltuklariYerlestir.Name = "btnKoltuklariYerlestir";
            this.btnKoltuklariYerlestir.Size = new System.Drawing.Size(84, 58);
            this.btnKoltuklariYerlestir.TabIndex = 2;
            this.btnKoltuklariYerlestir.Text = "Koltukları Yerleştir";
            this.btnKoltuklariYerlestir.UseVisualStyleBackColor = true;
            this.btnKoltuklariYerlestir.Click += new System.EventHandler(this.btnKoltuklariYerlestir_Click);
            // 
            // scAnaPanel
            // 
            this.scAnaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scAnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scAnaPanel.Location = new System.Drawing.Point(0, 0);
            this.scAnaPanel.Name = "scAnaPanel";
            this.scAnaPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scAnaPanel.Panel1
            // 
            this.scAnaPanel.Panel1.Controls.Add(this.btnKoltuklariYerlestir);
            this.scAnaPanel.Panel1.Controls.Add(this.label1);
            this.scAnaPanel.Panel1.Controls.Add(this.nubYSirasi);
            this.scAnaPanel.Panel1.Controls.Add(this.label2);
            this.scAnaPanel.Panel1.Controls.Add(this.nubXSirasi);
            // 
            // scAnaPanel.Panel2
            // 
            this.scAnaPanel.Panel2.Controls.Add(this.pnlSecenekler);
            this.scAnaPanel.Size = new System.Drawing.Size(541, 567);
            this.scAnaPanel.SplitterDistance = 126;
            this.scAnaPanel.TabIndex = 3;
            // 
            // pnlSecenekler
            // 
            this.pnlSecenekler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSecenekler.Controls.Add(this.lbKoltukTipi);
            this.pnlSecenekler.Controls.Add(this.label4);
            this.pnlSecenekler.Controls.Add(this.cmbSecim);
            this.pnlSecenekler.Controls.Add(this.rbHicbiri);
            this.pnlSecenekler.Controls.Add(this.label3);
            this.pnlSecenekler.Controls.Add(this.rbKadin);
            this.pnlSecenekler.Controls.Add(this.rbErkek);
            this.pnlSecenekler.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSecenekler.Location = new System.Drawing.Point(339, 0);
            this.pnlSecenekler.Name = "pnlSecenekler";
            this.pnlSecenekler.Size = new System.Drawing.Size(200, 435);
            this.pnlSecenekler.TabIndex = 0;
            // 
            // rbHicbiri
            // 
            this.rbHicbiri.AutoSize = true;
            this.rbHicbiri.Checked = true;
            this.rbHicbiri.Location = new System.Drawing.Point(25, 89);
            this.rbHicbiri.Name = "rbHicbiri";
            this.rbHicbiri.Size = new System.Drawing.Size(54, 17);
            this.rbHicbiri.TabIndex = 3;
            this.rbHicbiri.TabStop = true;
            this.rbHicbiri.Text = "Hiçbiri";
            this.rbHicbiri.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet";
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(25, 66);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 1;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(25, 43);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 0;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // cmbSecim
            // 
            this.cmbSecim.FormattingEnabled = true;
            this.cmbSecim.Items.AddRange(new object[] {
            "Pencere",
            "Koridor"});
            this.cmbSecim.Location = new System.Drawing.Point(7, 146);
            this.cmbSecim.Name = "cmbSecim";
            this.cmbSecim.Size = new System.Drawing.Size(121, 21);
            this.cmbSecim.TabIndex = 1;
            this.cmbSecim.SelectedIndexChanged += new System.EventHandler(this.cmbSecim_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(4, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Koltuk";
            // 
            // lbKoltukTipi
            // 
            this.lbKoltukTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbKoltukTipi.FormattingEnabled = true;
            this.lbKoltukTipi.ItemHeight = 20;
            this.lbKoltukTipi.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Hiçbiri"});
            this.lbKoltukTipi.Location = new System.Drawing.Point(8, 174);
            this.lbKoltukTipi.Name = "lbKoltukTipi";
            this.lbKoltukTipi.Size = new System.Drawing.Size(120, 124);
            this.lbKoltukTipi.TabIndex = 5;
            this.lbKoltukTipi.SelectedIndexChanged += new System.EventHandler(this.lbKoltukTipi_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 567);
            this.Controls.Add(this.scAnaPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nubXSirasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubYSirasi)).EndInit();
            this.scAnaPanel.Panel1.ResumeLayout(false);
            this.scAnaPanel.Panel1.PerformLayout();
            this.scAnaPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scAnaPanel)).EndInit();
            this.scAnaPanel.ResumeLayout(false);
            this.pnlSecenekler.ResumeLayout(false);
            this.pnlSecenekler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nubXSirasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nubYSirasi;
        private System.Windows.Forms.Button btnKoltuklariYerlestir;
        private System.Windows.Forms.SplitContainer scAnaPanel;
        private System.Windows.Forms.Panel pnlSecenekler;
        private System.Windows.Forms.RadioButton rbHicbiri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.ComboBox cmbSecim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbKoltukTipi;
    }
}

