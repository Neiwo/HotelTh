namespace hotel_reservation_system.Ucontrol
{
    partial class UC_DELETECLERK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DELETECLERK));
            this.label2 = new System.Windows.Forms.Label();
            this.deletebox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Input Employee ID to Delete";
            // 
            // deletebox
            // 
            this.deletebox.BackColor = System.Drawing.Color.Transparent;
            this.deletebox.BaseColor = System.Drawing.Color.White;
            this.deletebox.BorderColor = System.Drawing.Color.DimGray;
            this.deletebox.BorderSize = 3;
            this.deletebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deletebox.FocusedBaseColor = System.Drawing.Color.White;
            this.deletebox.FocusedBorderColor = System.Drawing.Color.Sienna;
            this.deletebox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.deletebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deletebox.Location = new System.Drawing.Point(314, 84);
            this.deletebox.Name = "deletebox";
            this.deletebox.PasswordChar = '\0';
            this.deletebox.Radius = 12;
            this.deletebox.SelectedText = "";
            this.deletebox.Size = new System.Drawing.Size(329, 42);
            this.deletebox.TabIndex = 63;
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.IndianRed;
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton4.BorderSize = 3;
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Firebrick;
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.CheckedImage")));
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.Image = null;
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(313, 202);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Firebrick;
            this.gunaAdvenceButton4.OnPressedDepth = 50;
            this.gunaAdvenceButton4.Radius = 8;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(330, 42);
            this.gunaAdvenceButton4.TabIndex = 64;
            this.gunaAdvenceButton4.Text = "DELETE ACCOUNT";
            this.gunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton4.Click += new System.EventHandler(this.gunaAdvenceButton4_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // UC_DELETECLERK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaAdvenceButton4);
            this.Controls.Add(this.deletebox);
            this.Name = "UC_DELETECLERK";
            this.Size = new System.Drawing.Size(936, 336);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaTextBox deletebox;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
