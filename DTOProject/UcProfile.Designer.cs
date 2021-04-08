namespace DTOProject
{
    partial class UcProfile
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
            this.guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.SuspendLayout();
            // 
            // guna2CustomCheckBox1
            // 
            this.guna2CustomCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox1.CheckedState.BorderRadius = 15;
            this.guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.guna2CustomCheckBox1.CheckedState.Parent = this.guna2CustomCheckBox1;
            this.guna2CustomCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            this.guna2CustomCheckBox1.ShadowDecoration.Parent = this.guna2CustomCheckBox1;
            this.guna2CustomCheckBox1.Size = new System.Drawing.Size(130, 132);
            this.guna2CustomCheckBox1.TabIndex = 3;
            this.guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomCheckBox1.UncheckedState.BorderRadius = 15;
            this.guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.guna2CustomCheckBox1.UncheckedState.Parent = this.guna2CustomCheckBox1;
            this.guna2CustomCheckBox1.UseTransparentBackground = true;
            this.guna2CustomCheckBox1.CheckedChanged += new System.EventHandler(this.guna2CustomCheckBox1_CheckedChanged);
            // 
            // UcProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomCheckBox1);
            this.Name = "UcProfile";
            this.Size = new System.Drawing.Size(133, 136);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
    }
}
