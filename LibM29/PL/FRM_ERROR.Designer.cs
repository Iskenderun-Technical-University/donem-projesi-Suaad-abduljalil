namespace LibM29.PL
{
    partial class FRM_ERROR
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
            this.components = new System.ComponentModel.Container();
            this.Lb_Ttle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Lb_Ttle
            // 
            this.Lb_Ttle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_Ttle.AutoSize = true;
            this.Lb_Ttle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Ttle.ForeColor = System.Drawing.Color.White;
            this.Lb_Ttle.Location = new System.Drawing.Point(164, 211);
            this.Lb_Ttle.Name = "Lb_Ttle";
            this.Lb_Ttle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lb_Ttle.Size = new System.Drawing.Size(321, 25);
            this.Lb_Ttle.TabIndex = 5;
            this.Lb_Ttle.Text = "Önce giriş koşullarını tamamlayın";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_ERROR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(648, 446);
            this.Controls.Add(this.Lb_Ttle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ERROR";
            this.Opacity = 0.85D;
            this.Text = "FRM_ERROR";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Ttle;
        private System.Windows.Forms.Timer timer1;
    }
}