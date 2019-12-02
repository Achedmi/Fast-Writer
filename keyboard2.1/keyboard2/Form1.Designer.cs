namespace keyboard2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation3 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnsetup = new Guna.UI.WinForms.GunaButton();
            this.lblsetup = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.txthearts = new Guna.UI.WinForms.GunaTextBox();
            this.txtseconds = new Guna.UI.WinForms.GunaTextBox();
            this.btnstart = new Guna.UI.WinForms.GunaButton();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.txtanswer = new Guna.UI.WinForms.GunaTextBox();
            this.btnverifie = new Guna.UI.WinForms.GunaButton();
            this.btnrestart = new Guna.UI.WinForms.GunaButton();
            this.btnstart2 = new Guna.UI.WinForms.GunaButton();
            this.lbltime = new Guna.UI.WinForms.GunaLabel();
            this.lbldethstring = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackgroundImage = global::keyboard2.Properties.Resources.Untitled_design__2_;
            this.gunaPanel1.Controls.Add(this.btnsetup);
            this.gunaPanel1.Controls.Add(this.lblsetup);
            this.gunaTransition1.SetDecoration(this.gunaPanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(698, 358);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnsetup
            // 
            this.btnsetup.AnimationHoverSpeed = 0.07F;
            this.btnsetup.AnimationSpeed = 0.03F;
            this.btnsetup.BackColor = System.Drawing.Color.Transparent;
            this.btnsetup.BaseColor = System.Drawing.Color.Transparent;
            this.btnsetup.BorderColor = System.Drawing.Color.White;
            this.btnsetup.BorderSize = 2;
            this.gunaTransition1.SetDecoration(this.btnsetup, Guna.UI.Animation.DecorationType.None);
            this.btnsetup.FocusedColor = System.Drawing.Color.Empty;
            this.btnsetup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetup.ForeColor = System.Drawing.Color.White;
            this.btnsetup.Image = null;
            this.btnsetup.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsetup.Location = new System.Drawing.Point(242, 248);
            this.btnsetup.Name = "btnsetup";
            this.btnsetup.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnsetup.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnsetup.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnsetup.OnHoverImage = null;
            this.btnsetup.OnPressedColor = System.Drawing.Color.Black;
            this.btnsetup.OnPressedDepth = 10;
            this.btnsetup.Radius = 10;
            this.btnsetup.Size = new System.Drawing.Size(186, 42);
            this.btnsetup.TabIndex = 2;
            this.btnsetup.Text = "Set up";
            this.btnsetup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsetup.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // lblsetup
            // 
            this.lblsetup.AutoSize = true;
            this.lblsetup.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.lblsetup, Guna.UI.Animation.DecorationType.None);
            this.lblsetup.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsetup.ForeColor = System.Drawing.Color.White;
            this.lblsetup.Location = new System.Drawing.Point(92, 57);
            this.lblsetup.Name = "lblsetup";
            this.lblsetup.Size = new System.Drawing.Size(516, 64);
            this.lblsetup.TabIndex = 0;
            this.lblsetup.Text = "Take typing speed test, practice your touch \r\n                         typing ski" +
    "lls";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackgroundImage = global::keyboard2.Properties.Resources.Untitled_design__2_;
            this.gunaPanel2.Controls.Add(this.txthearts);
            this.gunaPanel2.Controls.Add(this.txtseconds);
            this.gunaPanel2.Controls.Add(this.btnstart);
            this.gunaTransition1.SetDecoration(this.gunaPanel2, Guna.UI.Animation.DecorationType.None);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(698, 358);
            this.gunaPanel2.TabIndex = 2;
            // 
            // txthearts
            // 
            this.txthearts.BackColor = System.Drawing.Color.Transparent;
            this.txthearts.BaseColor = System.Drawing.Color.White;
            this.txthearts.BorderColor = System.Drawing.Color.Silver;
            this.txthearts.BorderSize = 0;
            this.txthearts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txthearts, Guna.UI.Animation.DecorationType.None);
            this.txthearts.FocusedBaseColor = System.Drawing.Color.White;
            this.txthearts.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txthearts.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txthearts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthearts.ForeColor = System.Drawing.Color.Gray;
            this.txthearts.Location = new System.Drawing.Point(242, 162);
            this.txthearts.Name = "txthearts";
            this.txthearts.PasswordChar = '\0';
            this.txthearts.Radius = 4;
            this.txthearts.Size = new System.Drawing.Size(186, 35);
            this.txthearts.TabIndex = 4;
            this.txthearts.Text = "How Many Hearts You Want ?";
            this.txthearts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txthearts.Enter += new System.EventHandler(this.gunaTextBox1_Enter);
            this.txthearts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gunaTextBox1_KeyPress);
            this.txthearts.Leave += new System.EventHandler(this.gunaTextBox1_Leave);
            // 
            // txtseconds
            // 
            this.txtseconds.BackColor = System.Drawing.Color.Transparent;
            this.txtseconds.BaseColor = System.Drawing.Color.White;
            this.txtseconds.BorderColor = System.Drawing.Color.Silver;
            this.txtseconds.BorderSize = 0;
            this.txtseconds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txtseconds, Guna.UI.Animation.DecorationType.None);
            this.txtseconds.FocusedBaseColor = System.Drawing.Color.White;
            this.txtseconds.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtseconds.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtseconds.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtseconds.ForeColor = System.Drawing.Color.Gray;
            this.txtseconds.Location = new System.Drawing.Point(242, 86);
            this.txtseconds.Name = "txtseconds";
            this.txtseconds.PasswordChar = '\0';
            this.txtseconds.Radius = 4;
            this.txtseconds.Size = new System.Drawing.Size(186, 35);
            this.txtseconds.TabIndex = 3;
            this.txtseconds.Text = "How Many Seconds You Want ?";
            this.txtseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtseconds.Enter += new System.EventHandler(this.gunaTextBox2_Enter);
            this.txtseconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gunaTextBox2_KeyPress);
            this.txtseconds.Leave += new System.EventHandler(this.gunaTextBox2_Leave);
            // 
            // btnstart
            // 
            this.btnstart.AnimationHoverSpeed = 0.07F;
            this.btnstart.AnimationSpeed = 0.03F;
            this.btnstart.BackColor = System.Drawing.Color.Transparent;
            this.btnstart.BaseColor = System.Drawing.Color.Transparent;
            this.btnstart.BorderColor = System.Drawing.Color.White;
            this.btnstart.BorderSize = 2;
            this.gunaTransition1.SetDecoration(this.btnstart, Guna.UI.Animation.DecorationType.None);
            this.btnstart.FocusedColor = System.Drawing.Color.Empty;
            this.btnstart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.White;
            this.btnstart.Image = null;
            this.btnstart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnstart.Location = new System.Drawing.Point(242, 248);
            this.btnstart.Name = "btnstart";
            this.btnstart.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnstart.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnstart.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnstart.OnHoverImage = null;
            this.btnstart.OnPressedColor = System.Drawing.Color.Black;
            this.btnstart.OnPressedDepth = 10;
            this.btnstart.Radius = 10;
            this.btnstart.Size = new System.Drawing.Size(186, 42);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnstart.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.gunaTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.gunaTransition1.DefaultAnimation = animation3;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackgroundImage = global::keyboard2.Properties.Resources.Untitled_design__2_;
            this.gunaPanel3.Controls.Add(this.txtanswer);
            this.gunaPanel3.Controls.Add(this.btnverifie);
            this.gunaPanel3.Controls.Add(this.btnrestart);
            this.gunaPanel3.Controls.Add(this.btnstart2);
            this.gunaPanel3.Controls.Add(this.lbltime);
            this.gunaPanel3.Controls.Add(this.lbldethstring);
            this.gunaTransition1.SetDecoration(this.gunaPanel3, Guna.UI.Animation.DecorationType.None);
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(698, 358);
            this.gunaPanel3.TabIndex = 5;
            // 
            // txtanswer
            // 
            this.txtanswer.BackColor = System.Drawing.Color.Transparent;
            this.txtanswer.BaseColor = System.Drawing.Color.White;
            this.txtanswer.BorderColor = System.Drawing.Color.Silver;
            this.txtanswer.BorderSize = 0;
            this.txtanswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txtanswer, Guna.UI.Animation.DecorationType.None);
            this.txtanswer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtanswer.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtanswer.FocusedForeColor = System.Drawing.Color.Black;
            this.txtanswer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanswer.ForeColor = System.Drawing.Color.Gray;
            this.txtanswer.Location = new System.Drawing.Point(53, 162);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.PasswordChar = '\0';
            this.txtanswer.Radius = 4;
            this.txtanswer.Size = new System.Drawing.Size(582, 60);
            this.txtanswer.TabIndex = 9;
            this.txtanswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtanswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtanswer_KeyPress);
            // 
            // btnverifie
            // 
            this.btnverifie.AnimationHoverSpeed = 0.07F;
            this.btnverifie.AnimationSpeed = 0.03F;
            this.btnverifie.BackColor = System.Drawing.Color.Transparent;
            this.btnverifie.BaseColor = System.Drawing.Color.Transparent;
            this.btnverifie.BorderColor = System.Drawing.Color.White;
            this.btnverifie.BorderSize = 2;
            this.gunaTransition1.SetDecoration(this.btnverifie, Guna.UI.Animation.DecorationType.None);
            this.btnverifie.FocusedColor = System.Drawing.Color.Empty;
            this.btnverifie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverifie.ForeColor = System.Drawing.Color.White;
            this.btnverifie.Image = null;
            this.btnverifie.ImageSize = new System.Drawing.Size(20, 20);
            this.btnverifie.Location = new System.Drawing.Point(449, 282);
            this.btnverifie.Name = "btnverifie";
            this.btnverifie.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnverifie.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnverifie.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnverifie.OnHoverImage = null;
            this.btnverifie.OnPressedColor = System.Drawing.Color.Black;
            this.btnverifie.OnPressedDepth = 10;
            this.btnverifie.Radius = 10;
            this.btnverifie.Size = new System.Drawing.Size(186, 42);
            this.btnverifie.TabIndex = 8;
            this.btnverifie.Text = "Verifie";
            this.btnverifie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnverifie.Click += new System.EventHandler(this.btnverifie_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.AnimationHoverSpeed = 0.07F;
            this.btnrestart.AnimationSpeed = 0.03F;
            this.btnrestart.BackColor = System.Drawing.Color.Transparent;
            this.btnrestart.BaseColor = System.Drawing.Color.Transparent;
            this.btnrestart.BorderColor = System.Drawing.Color.White;
            this.btnrestart.BorderSize = 2;
            this.gunaTransition1.SetDecoration(this.btnrestart, Guna.UI.Animation.DecorationType.None);
            this.btnrestart.FocusedColor = System.Drawing.Color.Empty;
            this.btnrestart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.ForeColor = System.Drawing.Color.White;
            this.btnrestart.Image = null;
            this.btnrestart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnrestart.Location = new System.Drawing.Point(251, 282);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnrestart.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnrestart.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnrestart.OnHoverImage = null;
            this.btnrestart.OnPressedColor = System.Drawing.Color.Black;
            this.btnrestart.OnPressedDepth = 10;
            this.btnrestart.Radius = 10;
            this.btnrestart.Size = new System.Drawing.Size(186, 42);
            this.btnrestart.TabIndex = 7;
            this.btnrestart.Text = "Restart";
            this.btnrestart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btnstart2
            // 
            this.btnstart2.AnimationHoverSpeed = 0.07F;
            this.btnstart2.AnimationSpeed = 0.03F;
            this.btnstart2.BackColor = System.Drawing.Color.Transparent;
            this.btnstart2.BaseColor = System.Drawing.Color.Transparent;
            this.btnstart2.BorderColor = System.Drawing.Color.White;
            this.btnstart2.BorderSize = 2;
            this.gunaTransition1.SetDecoration(this.btnstart2, Guna.UI.Animation.DecorationType.None);
            this.btnstart2.FocusedColor = System.Drawing.Color.Empty;
            this.btnstart2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart2.ForeColor = System.Drawing.Color.White;
            this.btnstart2.Image = null;
            this.btnstart2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnstart2.Location = new System.Drawing.Point(53, 282);
            this.btnstart2.Name = "btnstart2";
            this.btnstart2.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnstart2.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnstart2.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnstart2.OnHoverImage = null;
            this.btnstart2.OnPressedColor = System.Drawing.Color.Black;
            this.btnstart2.OnPressedDepth = 10;
            this.btnstart2.Radius = 10;
            this.btnstart2.Size = new System.Drawing.Size(186, 42);
            this.btnstart2.TabIndex = 6;
            this.btnstart2.Text = "Start";
            this.btnstart2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnstart2.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.lbltime, Guna.UI.Animation.DecorationType.None);
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(581, 34);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 32);
            this.lbltime.TabIndex = 4;
            // 
            // lbldethstring
            // 
            this.lbldethstring.AutoSize = true;
            this.lbldethstring.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.lbldethstring, Guna.UI.Animation.DecorationType.None);
            this.lbldethstring.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldethstring.ForeColor = System.Drawing.Color.White;
            this.lbldethstring.Location = new System.Drawing.Point(47, 34);
            this.lbldethstring.Name = "lbldethstring";
            this.lbldethstring.Size = new System.Drawing.Size(166, 32);
            this.lbldethstring.TabIndex = 2;
            this.lbldethstring.Text = "Death Score :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 358);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel2);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel lblsetup;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton btnstart;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaTextBox txthearts;
        private Guna.UI.WinForms.GunaTextBox txtseconds;
        private Guna.UI.WinForms.GunaButton btnsetup;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaButton btnverifie;
        private Guna.UI.WinForms.GunaButton btnrestart;
        private Guna.UI.WinForms.GunaButton btnstart2;
        private Guna.UI.WinForms.GunaLabel lbltime;
        private Guna.UI.WinForms.GunaLabel lbldethstring;
        private Guna.UI.WinForms.GunaTextBox txtanswer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

