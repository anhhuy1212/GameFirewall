namespace Sever
{
    partial class UcNext
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
            this.pcbNext = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbNext
            // 
            this.pcbNext.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pcbNext.ForeColor = System.Drawing.Color.Aqua;
            this.pcbNext.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.pcbNext.IconColor = System.Drawing.Color.Aqua;
            this.pcbNext.IconSize = 115;
            this.pcbNext.Location = new System.Drawing.Point(0, 0);
            this.pcbNext.Name = "pcbNext";
            this.pcbNext.Size = new System.Drawing.Size(124, 115);
            this.pcbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNext.TabIndex = 21;
            this.pcbNext.TabStop = false;
            // 
            // UcNext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcbNext);
            this.Name = "UcNext";
            this.Size = new System.Drawing.Size(124, 113);
            ((System.ComponentModel.ISupportInitialize)(this.pcbNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox pcbNext;
    }
}
