namespace PeksegBeadando
{
    partial class PeksegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeksegForm));
            this.tabControl_Pekseg = new System.Windows.Forms.TabControl();
            this.tabPage_Adatok = new System.Windows.Forms.TabPage();
            this.grpBx_peksegek = new System.Windows.Forms.GroupBox();
            this.lstBx_peksegTermekei = new System.Windows.Forms.ListBox();
            this.lstBx_peksegek = new System.Windows.Forms.ListBox();
            this.bttn_plusz = new System.Windows.Forms.Button();
            this.bttn_hozzaadasPekseg = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grpBx_Pekaru = new System.Windows.Forms.GroupBox();
            this.txtBx_ar = new System.Windows.Forms.TextBox();
            this.lstBx_pekaru = new System.Windows.Forms.ListBox();
            this.bttn_hozzaadasPekaru = new System.Windows.Forms.Button();
            this.chckBx_laktoz = new System.Windows.Forms.CheckBox();
            this.txtBx_nev = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl_Pekseg.SuspendLayout();
            this.tabPage_Adatok.SuspendLayout();
            this.grpBx_peksegek.SuspendLayout();
            this.grpBx_Pekaru.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Pekseg
            // 
            resources.ApplyResources(this.tabControl_Pekseg, "tabControl_Pekseg");
            this.tabControl_Pekseg.Controls.Add(this.tabPage_Adatok);
            this.tabControl_Pekseg.Controls.Add(this.tabPage2);
            this.tabControl_Pekseg.Name = "tabControl_Pekseg";
            this.tabControl_Pekseg.SelectedIndex = 0;
            // 
            // tabPage_Adatok
            // 
            resources.ApplyResources(this.tabPage_Adatok, "tabPage_Adatok");
            this.tabPage_Adatok.Controls.Add(this.grpBx_peksegek);
            this.tabPage_Adatok.Controls.Add(this.grpBx_Pekaru);
            this.tabPage_Adatok.Name = "tabPage_Adatok";
            this.tabPage_Adatok.UseVisualStyleBackColor = true;
            // 
            // grpBx_peksegek
            // 
            resources.ApplyResources(this.grpBx_peksegek, "grpBx_peksegek");
            this.grpBx_peksegek.Controls.Add(this.lstBx_peksegTermekei);
            this.grpBx_peksegek.Controls.Add(this.lstBx_peksegek);
            this.grpBx_peksegek.Controls.Add(this.bttn_plusz);
            this.grpBx_peksegek.Controls.Add(this.bttn_hozzaadasPekseg);
            this.grpBx_peksegek.Controls.Add(this.textBox4);
            this.grpBx_peksegek.Name = "grpBx_peksegek";
            this.grpBx_peksegek.TabStop = false;
            // 
            // lstBx_peksegTermekei
            // 
            resources.ApplyResources(this.lstBx_peksegTermekei, "lstBx_peksegTermekei");
            this.lstBx_peksegTermekei.FormattingEnabled = true;
            this.lstBx_peksegTermekei.Name = "lstBx_peksegTermekei";
            // 
            // lstBx_peksegek
            // 
            resources.ApplyResources(this.lstBx_peksegek, "lstBx_peksegek");
            this.lstBx_peksegek.FormattingEnabled = true;
            this.lstBx_peksegek.Name = "lstBx_peksegek";
            // 
            // bttn_plusz
            // 
            resources.ApplyResources(this.bttn_plusz, "bttn_plusz");
            this.bttn_plusz.Name = "bttn_plusz";
            this.bttn_plusz.UseVisualStyleBackColor = true;
            // 
            // bttn_hozzaadasPekseg
            // 
            resources.ApplyResources(this.bttn_hozzaadasPekseg, "bttn_hozzaadasPekseg");
            this.bttn_hozzaadasPekseg.Name = "bttn_hozzaadasPekseg";
            this.bttn_hozzaadasPekseg.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // grpBx_Pekaru
            // 
            resources.ApplyResources(this.grpBx_Pekaru, "grpBx_Pekaru");
            this.grpBx_Pekaru.Controls.Add(this.txtBx_ar);
            this.grpBx_Pekaru.Controls.Add(this.lstBx_pekaru);
            this.grpBx_Pekaru.Controls.Add(this.bttn_hozzaadasPekaru);
            this.grpBx_Pekaru.Controls.Add(this.chckBx_laktoz);
            this.grpBx_Pekaru.Controls.Add(this.txtBx_nev);
            this.grpBx_Pekaru.Name = "grpBx_Pekaru";
            this.grpBx_Pekaru.TabStop = false;
            // 
            // txtBx_ar
            // 
            resources.ApplyResources(this.txtBx_ar, "txtBx_ar");
            this.txtBx_ar.ForeColor = System.Drawing.Color.Gray;
            this.txtBx_ar.Name = "txtBx_ar";
            this.txtBx_ar.Enter += new System.EventHandler(this.txtBx_ar_Enter);
            this.txtBx_ar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_ar_KeyPress);
            this.txtBx_ar.Leave += new System.EventHandler(this.txtBx_ar_Leave);
            // 
            // lstBx_pekaru
            // 
            resources.ApplyResources(this.lstBx_pekaru, "lstBx_pekaru");
            this.lstBx_pekaru.FormattingEnabled = true;
            this.lstBx_pekaru.Name = "lstBx_pekaru";
            this.lstBx_pekaru.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBx_pekaru_MouseClick);
            this.lstBx_pekaru.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBx_pekaru_MouseDoubleClick);
            // 
            // bttn_hozzaadasPekaru
            // 
            resources.ApplyResources(this.bttn_hozzaadasPekaru, "bttn_hozzaadasPekaru");
            this.bttn_hozzaadasPekaru.Name = "bttn_hozzaadasPekaru";
            this.bttn_hozzaadasPekaru.UseVisualStyleBackColor = true;
            this.bttn_hozzaadasPekaru.Click += new System.EventHandler(this.bttn_hozzaadasPekaru_Click);
            // 
            // chckBx_laktoz
            // 
            resources.ApplyResources(this.chckBx_laktoz, "chckBx_laktoz");
            this.chckBx_laktoz.Name = "chckBx_laktoz";
            this.chckBx_laktoz.UseVisualStyleBackColor = true;
            // 
            // txtBx_nev
            // 
            resources.ApplyResources(this.txtBx_nev, "txtBx_nev");
            this.txtBx_nev.ForeColor = System.Drawing.Color.Gray;
            this.txtBx_nev.Name = "txtBx_nev";
            this.txtBx_nev.Enter += new System.EventHandler(this.txtBx_nev_Enter);
            this.txtBx_nev.Leave += new System.EventHandler(this.txtBx_nev_Leave);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PeksegForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tabControl_Pekseg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PeksegForm";
            this.tabControl_Pekseg.ResumeLayout(false);
            this.tabPage_Adatok.ResumeLayout(false);
            this.grpBx_peksegek.ResumeLayout(false);
            this.grpBx_peksegek.PerformLayout();
            this.grpBx_Pekaru.ResumeLayout(false);
            this.grpBx_Pekaru.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Pekseg;
        private System.Windows.Forms.TabPage tabPage_Adatok;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpBx_peksegek;
        private System.Windows.Forms.ListBox lstBx_peksegTermekei;
        private System.Windows.Forms.ListBox lstBx_peksegek;
        private System.Windows.Forms.Button bttn_plusz;
        private System.Windows.Forms.Button bttn_hozzaadasPekseg;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox grpBx_Pekaru;
        private System.Windows.Forms.TextBox txtBx_ar;
        private System.Windows.Forms.ListBox lstBx_pekaru;
        private System.Windows.Forms.Button bttn_hozzaadasPekaru;
        private System.Windows.Forms.CheckBox chckBx_laktoz;
        private System.Windows.Forms.TextBox txtBx_nev;
    }
}

