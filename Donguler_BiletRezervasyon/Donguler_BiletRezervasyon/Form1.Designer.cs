namespace Donguler_BiletRezervasyon
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
            this.gbKoltuklar = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbKoltuklar
            // 
            this.gbKoltuklar.Location = new System.Drawing.Point(12, 12);
            this.gbKoltuklar.Name = "gbKoltuklar";
            this.gbKoltuklar.Size = new System.Drawing.Size(320, 578);
            this.gbKoltuklar.TabIndex = 0;
            this.gbKoltuklar.TabStop = false;
            this.gbKoltuklar.Text = "Koltuklar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 602);
            this.Controls.Add(this.gbKoltuklar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKoltuklar;
    }
}

