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
            this.txtBx_pekseg = new System.Windows.Forms.TextBox();
            this.grpBx_Pekaru = new System.Windows.Forms.GroupBox();
            this.txtBx_ar = new System.Windows.Forms.TextBox();
            this.lstBx_pekaru = new System.Windows.Forms.ListBox();
            this.bttn_hozzaadasPekaru = new System.Windows.Forms.Button();
            this.chckBx_laktoz = new System.Windows.Forms.CheckBox();
            this.txtBx_nev = new System.Windows.Forms.TextBox();
            this.tabPage_stat = new System.Windows.Forms.TabPage();
            this.lbl_laktoz = new System.Windows.Forms.Label();
            this.lbl_legdragabb = new System.Windows.Forms.Label();
            this.lbl_legolcsobb = new System.Windows.Forms.Label();
            this.lbl_avg = new System.Windows.Forms.Label();
            this.lbl_pekaruk = new System.Windows.Forms.Label();
            this.lbl_alapitas = new System.Windows.Forms.Label();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.lstBx_stat = new System.Windows.Forms.ListBox();
            this.tabControl_Pekseg.SuspendLayout();
            this.tabPage_Adatok.SuspendLayout();
            this.grpBx_peksegek.SuspendLayout();
            this.grpBx_Pekaru.SuspendLayout();
            this.tabPage_stat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Pekseg
            // 
            this.tabControl_Pekseg.Controls.Add(this.tabPage_Adatok);
            this.tabControl_Pekseg.Controls.Add(this.tabPage_stat);
            resources.ApplyResources(this.tabControl_Pekseg, "tabControl_Pekseg");
            this.tabControl_Pekseg.Name = "tabControl_Pekseg";
            this.tabControl_Pekseg.SelectedIndex = 0;
            // 
            // tabPage_Adatok
            // 
            this.tabPage_Adatok.Controls.Add(this.grpBx_peksegek);
            this.tabPage_Adatok.Controls.Add(this.grpBx_Pekaru);
            resources.ApplyResources(this.tabPage_Adatok, "tabPage_Adatok");
            this.tabPage_Adatok.Name = "tabPage_Adatok";
            this.tabPage_Adatok.UseVisualStyleBackColor = true;
            // 
            // grpBx_peksegek
            // 
            this.grpBx_peksegek.Controls.Add(this.lstBx_peksegTermekei);
            this.grpBx_peksegek.Controls.Add(this.lstBx_peksegek);
            this.grpBx_peksegek.Controls.Add(this.bttn_plusz);
            this.grpBx_peksegek.Controls.Add(this.bttn_hozzaadasPekseg);
            this.grpBx_peksegek.Controls.Add(this.txtBx_pekseg);
            resources.ApplyResources(this.grpBx_peksegek, "grpBx_peksegek");
            this.grpBx_peksegek.Name = "grpBx_peksegek";
            this.grpBx_peksegek.TabStop = false;
            // 
            // lstBx_peksegTermekei
            // 
            this.lstBx_peksegTermekei.FormattingEnabled = true;
            resources.ApplyResources(this.lstBx_peksegTermekei, "lstBx_peksegTermekei");
            this.lstBx_peksegTermekei.Name = "lstBx_peksegTermekei";
            // 
            // lstBx_peksegek
            // 
            this.lstBx_peksegek.FormattingEnabled = true;
            resources.ApplyResources(this.lstBx_peksegek, "lstBx_peksegek");
            this.lstBx_peksegek.Name = "lstBx_peksegek";
            this.lstBx_peksegek.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBx_peksegek.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBx_peksegek_MouseClick);
            this.lstBx_peksegek.SelectedIndexChanged += new System.EventHandler(this.lstBx_peksegek_SelectedIndexChanged);
            // 
            // bttn_plusz
            // 
            resources.ApplyResources(this.bttn_plusz, "bttn_plusz");
            this.bttn_plusz.Name = "bttn_plusz";
            this.bttn_plusz.UseVisualStyleBackColor = true;
            this.bttn_plusz.Click += new System.EventHandler(this.bttn_plusz_Click);
            // 
            // bttn_hozzaadasPekseg
            // 
            resources.ApplyResources(this.bttn_hozzaadasPekseg, "bttn_hozzaadasPekseg");
            this.bttn_hozzaadasPekseg.Name = "bttn_hozzaadasPekseg";
            this.bttn_hozzaadasPekseg.UseVisualStyleBackColor = true;
            this.bttn_hozzaadasPekseg.Click += new System.EventHandler(this.bttn_hozzaadasPekseg_Click);
            // 
            // txtBx_pekseg
            // 
            this.txtBx_pekseg.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.txtBx_pekseg, "txtBx_pekseg");
            this.txtBx_pekseg.Name = "txtBx_pekseg";
            this.txtBx_pekseg.Enter += new System.EventHandler(this.txtBx_pekseg_Enter);
            this.txtBx_pekseg.Leave += new System.EventHandler(this.txtBx_pekseg_Leave);
            // 
            // grpBx_Pekaru
            // 
            this.grpBx_Pekaru.Controls.Add(this.txtBx_ar);
            this.grpBx_Pekaru.Controls.Add(this.lstBx_pekaru);
            this.grpBx_Pekaru.Controls.Add(this.bttn_hozzaadasPekaru);
            this.grpBx_Pekaru.Controls.Add(this.chckBx_laktoz);
            this.grpBx_Pekaru.Controls.Add(this.txtBx_nev);
            resources.ApplyResources(this.grpBx_Pekaru, "grpBx_Pekaru");
            this.grpBx_Pekaru.Name = "grpBx_Pekaru";
            this.grpBx_Pekaru.TabStop = false;
            // 
            // txtBx_ar
            // 
            this.txtBx_ar.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.txtBx_ar, "txtBx_ar");
            this.txtBx_ar.Name = "txtBx_ar";
            this.txtBx_ar.Enter += new System.EventHandler(this.txtBx_ar_Enter);
            this.txtBx_ar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_ar_KeyPress);
            this.txtBx_ar.Leave += new System.EventHandler(this.txtBx_ar_Leave);
            // 
            // lstBx_pekaru
            // 
            this.lstBx_pekaru.FormattingEnabled = true;
            resources.ApplyResources(this.lstBx_pekaru, "lstBx_pekaru");
            this.lstBx_pekaru.Name = "lstBx_pekaru";
            this.lstBx_pekaru.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBx_pekaru.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBx_pekaru_MouseClick);
            this.lstBx_pekaru.SelectedIndexChanged += new System.EventHandler(this.lstBx_pekaru_SelectedIndexChanged);
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
            this.txtBx_nev.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.txtBx_nev, "txtBx_nev");
            this.txtBx_nev.Name = "txtBx_nev";
            this.txtBx_nev.Enter += new System.EventHandler(this.txtBx_nev_Enter);
            this.txtBx_nev.Leave += new System.EventHandler(this.txtBx_nev_Leave);
            // 
            // tabPage_stat
            // 
            this.tabPage_stat.Controls.Add(this.lbl_laktoz);
            this.tabPage_stat.Controls.Add(this.lbl_legdragabb);
            this.tabPage_stat.Controls.Add(this.lbl_legolcsobb);
            this.tabPage_stat.Controls.Add(this.lbl_avg);
            this.tabPage_stat.Controls.Add(this.lbl_pekaruk);
            this.tabPage_stat.Controls.Add(this.lbl_alapitas);
            this.tabPage_stat.Controls.Add(this.lbl_nev);
            this.tabPage_stat.Controls.Add(this.lstBx_stat);
            resources.ApplyResources(this.tabPage_stat, "tabPage_stat");
            this.tabPage_stat.Name = "tabPage_stat";
            this.tabPage_stat.UseVisualStyleBackColor = true;
            this.tabPage_stat.Enter += new System.EventHandler(this.tabPage_stat_Enter);
            // 
            // lbl_laktoz
            // 
            resources.ApplyResources(this.lbl_laktoz, "lbl_laktoz");
            this.lbl_laktoz.Name = "lbl_laktoz";
            // 
            // lbl_legdragabb
            // 
            resources.ApplyResources(this.lbl_legdragabb, "lbl_legdragabb");
            this.lbl_legdragabb.Name = "lbl_legdragabb";
            // 
            // lbl_legolcsobb
            // 
            resources.ApplyResources(this.lbl_legolcsobb, "lbl_legolcsobb");
            this.lbl_legolcsobb.Name = "lbl_legolcsobb";
            // 
            // lbl_avg
            // 
            resources.ApplyResources(this.lbl_avg, "lbl_avg");
            this.lbl_avg.Name = "lbl_avg";
            // 
            // lbl_pekaruk
            // 
            resources.ApplyResources(this.lbl_pekaruk, "lbl_pekaruk");
            this.lbl_pekaruk.Name = "lbl_pekaruk";
            // 
            // lbl_alapitas
            // 
            resources.ApplyResources(this.lbl_alapitas, "lbl_alapitas");
            this.lbl_alapitas.Name = "lbl_alapitas";
            // 
            // lbl_nev
            // 
            resources.ApplyResources(this.lbl_nev, "lbl_nev");
            this.lbl_nev.Name = "lbl_nev";
            // 
            // lstBx_stat
            // 
            this.lstBx_stat.FormattingEnabled = true;
            resources.ApplyResources(this.lstBx_stat, "lstBx_stat");
            this.lstBx_stat.Name = "lstBx_stat";
            this.lstBx_stat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBx_stat_MouseClick);
            // 
            // PeksegForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
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
            this.tabPage_stat.ResumeLayout(false);
            this.tabPage_stat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Pekseg;
        private System.Windows.Forms.TabPage tabPage_Adatok;
        private System.Windows.Forms.TabPage tabPage_stat;
        private System.Windows.Forms.GroupBox grpBx_peksegek;
        private System.Windows.Forms.ListBox lstBx_peksegTermekei;
        private System.Windows.Forms.ListBox lstBx_peksegek;
        private System.Windows.Forms.Button bttn_plusz;
        private System.Windows.Forms.Button bttn_hozzaadasPekseg;
        private System.Windows.Forms.TextBox txtBx_pekseg;
        private System.Windows.Forms.GroupBox grpBx_Pekaru;
        private System.Windows.Forms.TextBox txtBx_ar;
        private System.Windows.Forms.ListBox lstBx_pekaru;
        private System.Windows.Forms.Button bttn_hozzaadasPekaru;
        private System.Windows.Forms.CheckBox chckBx_laktoz;
        private System.Windows.Forms.TextBox txtBx_nev;
        private System.Windows.Forms.ListBox lstBx_stat;
        private System.Windows.Forms.Label lbl_laktoz;
        private System.Windows.Forms.Label lbl_legdragabb;
        private System.Windows.Forms.Label lbl_legolcsobb;
        private System.Windows.Forms.Label lbl_avg;
        private System.Windows.Forms.Label lbl_pekaruk;
        private System.Windows.Forms.Label lbl_alapitas;
        private System.Windows.Forms.Label lbl_nev;
    }
}

