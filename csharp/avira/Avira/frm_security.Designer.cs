namespace Avira
{
    partial class frm_security
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_security));
            this.gunaLabelScan = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabelProtection = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabelQuarantine = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabelUpdater = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabelFirewall = new Guna.UI.WinForms.GunaLabel();
            this.gunaButtonFirewall = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaButtonUpdater = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaButtonQuarantine = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaButtonProtection = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaButtonScan = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.SuspendLayout();
            // 
            // gunaLabelScan
            // 
            this.gunaLabelScan.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabelScan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabelScan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaLabelScan.Location = new System.Drawing.Point(21, 160);
            this.gunaLabelScan.Name = "gunaLabelScan";
            this.gunaLabelScan.Size = new System.Drawing.Size(190, 23);
            this.gunaLabelScan.TabIndex = 5;
            this.gunaLabelScan.Text = "Scan your device for viruses";
            this.gunaLabelScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabelProtection
            // 
            this.gunaLabelProtection.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabelProtection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabelProtection.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaLabelProtection.Location = new System.Drawing.Point(226, 160);
            this.gunaLabelProtection.Name = "gunaLabelProtection";
            this.gunaLabelProtection.Size = new System.Drawing.Size(190, 23);
            this.gunaLabelProtection.TabIndex = 6;
            this.gunaLabelProtection.Text = "Choose barriers against viruses ";
            this.gunaLabelProtection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabelQuarantine
            // 
            this.gunaLabelQuarantine.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabelQuarantine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabelQuarantine.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaLabelQuarantine.Location = new System.Drawing.Point(431, 160);
            this.gunaLabelQuarantine.Name = "gunaLabelQuarantine";
            this.gunaLabelQuarantine.Size = new System.Drawing.Size(190, 23);
            this.gunaLabelQuarantine.TabIndex = 7;
            this.gunaLabelQuarantine.Text = "Repair or delete unsafe files";
            this.gunaLabelQuarantine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabelUpdater
            // 
            this.gunaLabelUpdater.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabelUpdater.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabelUpdater.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaLabelUpdater.Location = new System.Drawing.Point(21, 364);
            this.gunaLabelUpdater.Name = "gunaLabelUpdater";
            this.gunaLabelUpdater.Size = new System.Drawing.Size(190, 23);
            this.gunaLabelUpdater.TabIndex = 9;
            this.gunaLabelUpdater.Text = "Fix security risks in your apps";
            this.gunaLabelUpdater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabelFirewall
            // 
            this.gunaLabelFirewall.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabelFirewall.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabelFirewall.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaLabelFirewall.Location = new System.Drawing.Point(226, 364);
            this.gunaLabelFirewall.Name = "gunaLabelFirewall";
            this.gunaLabelFirewall.Size = new System.Drawing.Size(190, 23);
            this.gunaLabelFirewall.TabIndex = 10;
            this.gunaLabelFirewall.Text = "Keep threats away";
            this.gunaLabelFirewall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaButtonFirewall
            // 
            this.gunaButtonFirewall.Animated = true;
            this.gunaButtonFirewall.AnimationHoverSpeed = 0.07F;
            this.gunaButtonFirewall.AnimationSpeed = 0.03F;
            this.gunaButtonFirewall.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonFirewall.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.gunaButtonFirewall.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonFirewall.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaButtonFirewall.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaButtonFirewall.CheckedForeColor = System.Drawing.Color.White;
            this.gunaButtonFirewall.CheckedImage = null;
            this.gunaButtonFirewall.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaButtonFirewall.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonFirewall.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonFirewall.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F);
            this.gunaButtonFirewall.ForeColor = System.Drawing.Color.White;
            this.gunaButtonFirewall.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonFirewall.Image")));
            this.gunaButtonFirewall.ImageSize = new System.Drawing.Size(44, 44);
            this.gunaButtonFirewall.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButtonFirewall.Location = new System.Drawing.Point(226, 223);
            this.gunaButtonFirewall.Name = "gunaButtonFirewall";
            this.gunaButtonFirewall.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.gunaButtonFirewall.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonFirewall.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonFirewall.OnHoverImage = null;
            this.gunaButtonFirewall.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButtonFirewall.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonFirewall.Radius = 2;
            this.gunaButtonFirewall.Size = new System.Drawing.Size(190, 129);
            this.gunaButtonFirewall.TabIndex = 4;
            this.gunaButtonFirewall.TabStop = false;
            this.gunaButtonFirewall.Text = "Firewall";
            this.gunaButtonFirewall.TextImageOffsetY = 15;
            // 
            // gunaButtonUpdater
            // 
            this.gunaButtonUpdater.Animated = true;
            this.gunaButtonUpdater.AnimationHoverSpeed = 0.07F;
            this.gunaButtonUpdater.AnimationSpeed = 0.03F;
            this.gunaButtonUpdater.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonUpdater.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.gunaButtonUpdater.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonUpdater.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaButtonUpdater.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaButtonUpdater.CheckedForeColor = System.Drawing.Color.White;
            this.gunaButtonUpdater.CheckedImage = null;
            this.gunaButtonUpdater.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaButtonUpdater.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonUpdater.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonUpdater.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F);
            this.gunaButtonUpdater.ForeColor = System.Drawing.Color.White;
            this.gunaButtonUpdater.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonUpdater.Image")));
            this.gunaButtonUpdater.ImageSize = new System.Drawing.Size(44, 44);
            this.gunaButtonUpdater.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButtonUpdater.Location = new System.Drawing.Point(21, 223);
            this.gunaButtonUpdater.Name = "gunaButtonUpdater";
            this.gunaButtonUpdater.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.gunaButtonUpdater.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonUpdater.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonUpdater.OnHoverImage = null;
            this.gunaButtonUpdater.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButtonUpdater.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonUpdater.Radius = 2;
            this.gunaButtonUpdater.Size = new System.Drawing.Size(190, 129);
            this.gunaButtonUpdater.TabIndex = 3;
            this.gunaButtonUpdater.TabStop = false;
            this.gunaButtonUpdater.Text = "Software updater";
            this.gunaButtonUpdater.TextImageOffsetY = 15;
            // 
            // gunaButtonQuarantine
            // 
            this.gunaButtonQuarantine.Animated = true;
            this.gunaButtonQuarantine.AnimationHoverSpeed = 0.07F;
            this.gunaButtonQuarantine.AnimationSpeed = 0.03F;
            this.gunaButtonQuarantine.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonQuarantine.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.gunaButtonQuarantine.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonQuarantine.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaButtonQuarantine.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaButtonQuarantine.CheckedForeColor = System.Drawing.Color.White;
            this.gunaButtonQuarantine.CheckedImage = null;
            this.gunaButtonQuarantine.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaButtonQuarantine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonQuarantine.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonQuarantine.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F);
            this.gunaButtonQuarantine.ForeColor = System.Drawing.Color.White;
            this.gunaButtonQuarantine.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonQuarantine.Image")));
            this.gunaButtonQuarantine.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaButtonQuarantine.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButtonQuarantine.Location = new System.Drawing.Point(431, 21);
            this.gunaButtonQuarantine.Name = "gunaButtonQuarantine";
            this.gunaButtonQuarantine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.gunaButtonQuarantine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonQuarantine.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonQuarantine.OnHoverImage = null;
            this.gunaButtonQuarantine.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButtonQuarantine.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonQuarantine.Radius = 2;
            this.gunaButtonQuarantine.Size = new System.Drawing.Size(190, 129);
            this.gunaButtonQuarantine.TabIndex = 2;
            this.gunaButtonQuarantine.TabStop = false;
            this.gunaButtonQuarantine.Text = "Quarantine";
            this.gunaButtonQuarantine.TextImageOffsetY = 15;
            // 
            // gunaButtonProtection
            // 
            this.gunaButtonProtection.Animated = true;
            this.gunaButtonProtection.AnimationHoverSpeed = 0.07F;
            this.gunaButtonProtection.AnimationSpeed = 0.03F;
            this.gunaButtonProtection.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonProtection.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.gunaButtonProtection.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonProtection.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaButtonProtection.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaButtonProtection.CheckedForeColor = System.Drawing.Color.White;
            this.gunaButtonProtection.CheckedImage = null;
            this.gunaButtonProtection.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaButtonProtection.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonProtection.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonProtection.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F);
            this.gunaButtonProtection.ForeColor = System.Drawing.Color.White;
            this.gunaButtonProtection.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonProtection.Image")));
            this.gunaButtonProtection.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaButtonProtection.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButtonProtection.Location = new System.Drawing.Point(226, 21);
            this.gunaButtonProtection.Name = "gunaButtonProtection";
            this.gunaButtonProtection.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.gunaButtonProtection.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonProtection.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonProtection.OnHoverImage = null;
            this.gunaButtonProtection.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButtonProtection.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonProtection.Radius = 2;
            this.gunaButtonProtection.Size = new System.Drawing.Size(190, 129);
            this.gunaButtonProtection.TabIndex = 1;
            this.gunaButtonProtection.TabStop = false;
            this.gunaButtonProtection.Text = "Protection options";
            this.gunaButtonProtection.TextImageOffsetY = 15;
            // 
            // gunaButtonScan
            // 
            this.gunaButtonScan.Animated = true;
            this.gunaButtonScan.AnimationHoverSpeed = 0.07F;
            this.gunaButtonScan.AnimationSpeed = 0.03F;
            this.gunaButtonScan.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonScan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.gunaButtonScan.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonScan.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaButtonScan.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaButtonScan.CheckedForeColor = System.Drawing.Color.White;
            this.gunaButtonScan.CheckedImage = null;
            this.gunaButtonScan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaButtonScan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonScan.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonScan.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F);
            this.gunaButtonScan.ForeColor = System.Drawing.Color.White;
            this.gunaButtonScan.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonScan.Image")));
            this.gunaButtonScan.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButtonScan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButtonScan.Location = new System.Drawing.Point(21, 21);
            this.gunaButtonScan.Name = "gunaButtonScan";
            this.gunaButtonScan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.gunaButtonScan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonScan.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonScan.OnHoverImage = null;
            this.gunaButtonScan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButtonScan.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonScan.Radius = 2;
            this.gunaButtonScan.Size = new System.Drawing.Size(190, 129);
            this.gunaButtonScan.TabIndex = 0;
            this.gunaButtonScan.TabStop = false;
            this.gunaButtonScan.Text = "Virus scans";
            this.gunaButtonScan.TextImageOffsetY = 15;
            // 
            // frm_security
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(643, 570);
            this.ControlBox = false;
            this.Controls.Add(this.gunaLabelFirewall);
            this.Controls.Add(this.gunaLabelUpdater);
            this.Controls.Add(this.gunaLabelQuarantine);
            this.Controls.Add(this.gunaLabelProtection);
            this.Controls.Add(this.gunaLabelScan);
            this.Controls.Add(this.gunaButtonFirewall);
            this.Controls.Add(this.gunaButtonUpdater);
            this.Controls.Add(this.gunaButtonQuarantine);
            this.Controls.Add(this.gunaButtonProtection);
            this.Controls.Add(this.gunaButtonScan);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_security";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceTileButton gunaButtonScan;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaButtonProtection;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaButtonQuarantine;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaButtonUpdater;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaButtonFirewall;
        private Guna.UI.WinForms.GunaLabel gunaLabelScan;
        private Guna.UI.WinForms.GunaLabel gunaLabelProtection;
        private Guna.UI.WinForms.GunaLabel gunaLabelQuarantine;
        private Guna.UI.WinForms.GunaLabel gunaLabelUpdater;
        private Guna.UI.WinForms.GunaLabel gunaLabelFirewall;
    }
}