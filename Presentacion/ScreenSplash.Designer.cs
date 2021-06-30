namespace Presentacion
{
    partial class ScreenSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSplash));
            this.pbxScreenSplash = new System.Windows.Forms.PictureBox();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxScreenSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxScreenSplash
            // 
            this.pbxScreenSplash.Image = ((System.Drawing.Image)(resources.GetObject("pbxScreenSplash.Image")));
            this.pbxScreenSplash.Location = new System.Drawing.Point(21, 21);
            this.pbxScreenSplash.Name = "pbxScreenSplash";
            this.pbxScreenSplash.Size = new System.Drawing.Size(596, 320);
            this.pbxScreenSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxScreenSplash.TabIndex = 0;
            this.pbxScreenSplash.TabStop = false;
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
            // 
            // ScreenSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(640, 361);
            this.Controls.Add(this.pbxScreenSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenSplash";
            this.TransparencyKey = System.Drawing.Color.Gray;
            ((System.ComponentModel.ISupportInitialize)(this.pbxScreenSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxScreenSplash;
        private System.Windows.Forms.Timer tmrTiempo;
    }
}