namespace Sever
{
    partial class UCAnswerBox
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
            this.chkAnwerCorrect = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txtAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // chkAnwerCorrect
            // 
            this.chkAnwerCorrect.BackColor = System.Drawing.Color.Transparent;
            this.chkAnwerCorrect.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkAnwerCorrect.CheckedState.BorderRadius = 10;
            this.chkAnwerCorrect.CheckedState.BorderThickness = 0;
            this.chkAnwerCorrect.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.chkAnwerCorrect.CheckedState.Parent = this.chkAnwerCorrect;
            this.chkAnwerCorrect.Location = new System.Drawing.Point(3, 20);
            this.chkAnwerCorrect.Name = "chkAnwerCorrect";
            this.chkAnwerCorrect.ShadowDecoration.Parent = this.chkAnwerCorrect;
            this.chkAnwerCorrect.Size = new System.Drawing.Size(30, 30);
            this.chkAnwerCorrect.TabIndex = 0;
            this.chkAnwerCorrect.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkAnwerCorrect.UncheckedState.BorderRadius = 10;
            this.chkAnwerCorrect.UncheckedState.BorderThickness = 0;
            this.chkAnwerCorrect.UncheckedState.FillColor = System.Drawing.Color.White;
            this.chkAnwerCorrect.UncheckedState.Parent = this.chkAnwerCorrect;
            this.chkAnwerCorrect.UseTransparentBackground = true;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BorderRadius = 30;
            this.txtAnswer.BorderThickness = 0;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.DefaultText = "";
            this.txtAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.DisabledState.Parent = this.txtAnswer;
            this.txtAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.FocusedState.Parent = this.txtAnswer;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.HoverState.Parent = this.txtAnswer;
            this.txtAnswer.Location = new System.Drawing.Point(50, 0);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(0);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.PlaceholderText = "Type your answer...";
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.ShadowDecoration.Parent = this.txtAnswer;
            this.txtAnswer.Size = new System.Drawing.Size(450, 70);
            this.txtAnswer.TabIndex = 1;
            // 
            // UCAnswerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.chkAnwerCorrect);
            this.Name = "UCAnswerBox";
            this.Size = new System.Drawing.Size(500, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomCheckBox chkAnwerCorrect;
        private Guna.UI2.WinForms.Guna2TextBox txtAnswer;
    }
}
