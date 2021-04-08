namespace Sever
{
    partial class UcRev
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
            this.pcbRev = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRev)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbRev
            // 
            this.pcbRev.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pcbRev.ForeColor = System.Drawing.Color.Bisque;
            this.pcbRev.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.pcbRev.IconColor = System.Drawing.Color.Bisque;
            this.pcbRev.IconSize = 115;
            this.pcbRev.Location = new System.Drawing.Point(0, 0);
            this.pcbRev.Name = "pcbRev";
            this.pcbRev.Size = new System.Drawing.Size(125, 115);
            this.pcbRev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRev.TabIndex = 22;
            this.pcbRev.TabStop = false;
            // 
            // UcRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcbRev);
            this.Name = "UcRev";
            this.Size = new System.Drawing.Size(126, 118);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox pcbRev;
    }
}
