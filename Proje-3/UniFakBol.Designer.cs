namespace Proje_3
{
    partial class UniFakBol
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUni = new System.Windows.Forms.ComboBox();
            this.comboBoxFak = new System.Windows.Forms.ComboBox();
            this.comboBoxBol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üniversite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fakülte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bölüm";
            // 
            // comboBoxUni
            // 
            this.comboBoxUni.FormattingEnabled = true;
            this.comboBoxUni.Location = new System.Drawing.Point(72, 10);
            this.comboBoxUni.Name = "comboBoxUni";
            this.comboBoxUni.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUni.TabIndex = 1;
            this.comboBoxUni.SelectedIndexChanged += new System.EventHandler(this.comboBoxUni_SelectedIndexChanged);
            // 
            // comboBoxFak
            // 
            this.comboBoxFak.FormattingEnabled = true;
            this.comboBoxFak.Location = new System.Drawing.Point(72, 44);
            this.comboBoxFak.Name = "comboBoxFak";
            this.comboBoxFak.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFak.TabIndex = 1;
            this.comboBoxFak.SelectedIndexChanged += new System.EventHandler(this.comboBoxFak_SelectedIndexChanged);
            // 
            // comboBoxBol
            // 
            this.comboBoxBol.FormattingEnabled = true;
            this.comboBoxBol.Location = new System.Drawing.Point(72, 78);
            this.comboBoxBol.Name = "comboBoxBol";
            this.comboBoxBol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBol.TabIndex = 1;
            // 
            // UniFakBol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 122);
            this.Controls.Add(this.comboBoxBol);
            this.Controls.Add(this.comboBoxFak);
            this.Controls.Add(this.comboBoxUni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UniFakBol";
            this.Text = "UniFakBol";
            this.Load += new System.EventHandler(this.UniFakBol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUni;
        private System.Windows.Forms.ComboBox comboBoxFak;
        private System.Windows.Forms.ComboBox comboBoxBol;
    }
}