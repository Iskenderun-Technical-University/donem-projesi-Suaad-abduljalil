namespace LibM29.PL
{
    partial class FRM_ADDCAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADDCAT));
            this.Lb_Ttle = new System.Windows.Forms.Label();
            this.txt_catname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Ttle
            // 
            this.Lb_Ttle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lb_Ttle.AutoSize = true;
            this.Lb_Ttle.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Ttle.ForeColor = System.Drawing.Color.Black;
            this.Lb_Ttle.Location = new System.Drawing.Point(149, 77);
            this.Lb_Ttle.Name = "Lb_Ttle";
            this.Lb_Ttle.Size = new System.Drawing.Size(178, 42);
            this.Lb_Ttle.TabIndex = 2;
            this.Lb_Ttle.Text = "ÜRÜN ADI";
            // 
            // txt_catname
            // 
            this.txt_catname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_catname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_catname.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_catname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_catname.HintForeColor = System.Drawing.Color.Empty;
            this.txt_catname.HintText = "ÜRÜN ADI";
            this.txt_catname.isPassword = false;
            this.txt_catname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_catname.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_catname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_catname.LineThickness = 5;
            this.txt_catname.Location = new System.Drawing.Point(42, 173);
            this.txt_catname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_catname.Name = "txt_catname";
            this.txt_catname.Size = new System.Drawing.Size(393, 49);
            this.txt_catname.TabIndex = 3;
            this.txt_catname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnadd
            // 
            this.btnadd.ActiveBorderThickness = 1;
            this.btnadd.ActiveCornerRadius = 20;
            this.btnadd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnadd.ActiveForecolor = System.Drawing.Color.White;
            this.btnadd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.ButtonText = "eklemek";
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleBorderThickness = 1;
            this.btnadd.IdleCornerRadius = 20;
            this.btnadd.IdleFillColor = System.Drawing.Color.White;
            this.btnadd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Location = new System.Drawing.Point(18, 283);
            this.btnadd.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(466, 53);
            this.btnadd.TabIndex = 4;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::LibM29.Properties.Resources.delete_sign_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(464, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // FRM_ADDCAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 362);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txt_catname);
            this.Controls.Add(this.Lb_Ttle);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_ADDCAT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ADDCAT";
            this.Load += new System.EventHandler(this.FRM_ADDCAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label Lb_Ttle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnadd;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_catname;
    }
}