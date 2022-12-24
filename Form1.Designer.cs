namespace WinFormsAppXpCrosshairSecondBuild
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.animatedCrosshairsPanel = new WinFormsAppXpCrosshairSecondBuild.AnimatedCrosshairs();
            this.ExitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MaximizeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.xpText = new System.Windows.Forms.Label();
            this.CrosshairText = new System.Windows.Forms.Label();
            this.AnimatedCrosshairsButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.animatedCrosshairsPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 385);
            this.panel1.TabIndex = 0;
            // 
            // animatedCrosshairsPanel
            // 
            this.animatedCrosshairsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.animatedCrosshairsPanel.Location = new System.Drawing.Point(0, 0);
            this.animatedCrosshairsPanel.Name = "animatedCrosshairsPanel";
            this.animatedCrosshairsPanel.Size = new System.Drawing.Size(815, 385);
            this.animatedCrosshairsPanel.TabIndex = 10;
            this.animatedCrosshairsPanel.Load += new System.EventHandler(this.animatedCrosshairsPanel_Load);
            // 
            // ExitButton
            // 
            this.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButton.FillColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(794, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButton.Size = new System.Drawing.Size(15, 15);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinimizeButton.FillColor = System.Drawing.Color.Lime;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(752, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MinimizeButton.Size = new System.Drawing.Size(15, 15);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MaximizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MaximizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MaximizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MaximizeButton.FillColor = System.Drawing.Color.Yellow;
            this.MaximizeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeButton.ForeColor = System.Drawing.Color.White;
            this.MaximizeButton.Location = new System.Drawing.Point(773, 12);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MaximizeButton.Size = new System.Drawing.Size(15, 15);
            this.MaximizeButton.TabIndex = 4;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // xpText
            // 
            this.xpText.AutoSize = true;
            this.xpText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xpText.ForeColor = System.Drawing.Color.Red;
            this.xpText.Location = new System.Drawing.Point(12, 12);
            this.xpText.Name = "xpText";
            this.xpText.Size = new System.Drawing.Size(27, 18);
            this.xpText.TabIndex = 5;
            this.xpText.Text = "Xp";
            // 
            // CrosshairText
            // 
            this.CrosshairText.AutoSize = true;
            this.CrosshairText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CrosshairText.ForeColor = System.Drawing.Color.White;
            this.CrosshairText.Location = new System.Drawing.Point(34, 12);
            this.CrosshairText.Name = "CrosshairText";
            this.CrosshairText.Size = new System.Drawing.Size(77, 18);
            this.CrosshairText.TabIndex = 6;
            this.CrosshairText.Text = "Crosshair";
            // 
            // AnimatedCrosshairsButton
            // 
            this.AnimatedCrosshairsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AnimatedCrosshairsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AnimatedCrosshairsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AnimatedCrosshairsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AnimatedCrosshairsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AnimatedCrosshairsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnimatedCrosshairsButton.ForeColor = System.Drawing.Color.White;
            this.AnimatedCrosshairsButton.Image = global::WinFormsAppXpCrosshairSecondBuild.Properties.Resources.icons8_genauigkeit_30;
            this.AnimatedCrosshairsButton.Location = new System.Drawing.Point(0, 33);
            this.AnimatedCrosshairsButton.Name = "AnimatedCrosshairsButton";
            this.AnimatedCrosshairsButton.Size = new System.Drawing.Size(206, 26);
            this.AnimatedCrosshairsButton.TabIndex = 9;
            this.AnimatedCrosshairsButton.Text = "Animated/Static Crosshairs";
            this.AnimatedCrosshairsButton.Click += new System.EventHandler(this.AnimatedCrosshairsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.AnimatedCrosshairsButton);
            this.Controls.Add(this.CrosshairText);
            this.Controls.Add(this.xpText);
            this.Controls.Add(this.MaximizeButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton ExitButton;
        private Guna.UI2.WinForms.Guna2CircleButton MinimizeButton;
        private Guna.UI2.WinForms.Guna2CircleButton MaximizeButton;
        private Label xpText;
        private Label CrosshairText;
        private Guna.UI2.WinForms.Guna2Button AnimatedCrosshairsButton;
       
        private AnimatedCrosshairs animatedCrosshairsPanel;
    }
}