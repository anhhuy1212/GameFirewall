namespace client
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Timer_AboutUS = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlHow = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClosed = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grvListGame = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlHow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListGame)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_AboutUS
            // 
            this.Timer_AboutUS.Interval = 1000;
            this.Timer_AboutUS.Tick += new System.EventHandler(this.Timer_AboutUS_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 753);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(93, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 261);
            this.panel3.TabIndex = 19;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLeft.Controls.Add(this.pnlHow);
            this.pnlLeft.Controls.Add(this.grvListGame);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Location = new System.Drawing.Point(572, -1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(723, 763);
            this.pnlLeft.TabIndex = 24;
            // 
            // pnlHow
            // 
            this.pnlHow.BackColor = System.Drawing.Color.Transparent;
            this.pnlHow.BorderColor = System.Drawing.Color.SpringGreen;
            this.pnlHow.BorderRadius = 30;
            this.pnlHow.BorderThickness = 2;
            this.pnlHow.Controls.Add(this.iconButton3);
            this.pnlHow.Controls.Add(this.label3);
            this.pnlHow.Controls.Add(this.btnClosed);
            this.pnlHow.Controls.Add(this.label4);
            this.pnlHow.Controls.Add(this.iconButton2);
            this.pnlHow.Controls.Add(this.iconButton1);
            this.pnlHow.Controls.Add(this.label2);
            this.pnlHow.Controls.Add(this.label1);
            this.pnlHow.Controls.Add(this.label5);
            this.pnlHow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlHow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlHow.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlHow.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlHow.Location = new System.Drawing.Point(3, 60);
            this.pnlHow.Name = "pnlHow";
            this.pnlHow.ShadowDecoration.Parent = this.pnlHow;
            this.pnlHow.Size = new System.Drawing.Size(715, 693);
            this.pnlHow.TabIndex = 18;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Asterisk;
            this.iconButton3.IconColor = System.Drawing.Color.Red;
            this.iconButton3.IconSize = 40;
            this.iconButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconButton3.Location = new System.Drawing.Point(50, 164);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(43, 42);
            this.iconButton3.TabIndex = 15;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(99, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 74);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bạn Có thể kết nối game sau 5s với điều kiện game đang được mở. Và bạn phải đăng " +
    "nhập thông tin cá nhân trước khi vào được Game.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClosed
            // 
            this.btnClosed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClosed.CheckedState.Parent = this.btnClosed;
            this.btnClosed.CustomImages.Parent = this.btnClosed;
            this.btnClosed.FillColor = System.Drawing.Color.Transparent;
            this.btnClosed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClosed.ForeColor = System.Drawing.Color.White;
            this.btnClosed.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.HoverState.Image")));
            this.btnClosed.HoverState.Parent = this.btnClosed;
            this.btnClosed.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.Image")));
            this.btnClosed.ImageSize = new System.Drawing.Size(60, 60);
            this.btnClosed.Location = new System.Drawing.Point(636, 3);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClosed.ShadowDecoration.Parent = this.btnClosed;
            this.btnClosed.Size = new System.Drawing.Size(76, 60);
            this.btnClosed.TabIndex = 13;
            this.btnClosed.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(-2, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(709, 74);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chúc các bạn chơi Game vui vẻ !!!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Asterisk;
            this.iconButton2.IconColor = System.Drawing.Color.Red;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconButton2.Location = new System.Drawing.Point(50, 474);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(43, 42);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Asterisk;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconButton1.Location = new System.Drawing.Point(50, 299);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(43, 42);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(99, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 74);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bạn có 20 giây để trả lời câu hỏi bằng cách click chọn 1 trong những đáp án của h" +
    "ệ thống. Sau 20s, hệ thống sẽ ghi nhận bạn không có câu trả lời nếu bạn không ch" +
    "ọn áp án\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(99, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 174);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SpringGreen;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(4, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(708, 74);
            this.label5.TabIndex = 5;
            this.label5.Text = "TOTURIAL PLAY TO GAME";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grvListGame
            // 
            this.grvListGame.AllowUserToAddRows = false;
            this.grvListGame.AllowUserToDeleteRows = false;
            this.grvListGame.AllowUserToResizeColumns = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.grvListGame.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.grvListGame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvListGame.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grvListGame.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvListGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvListGame.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvListGame.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListGame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grvListGame.ColumnHeadersHeight = 20;
            this.grvListGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvListGame.DefaultCellStyle = dataGridViewCellStyle19;
            this.grvListGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.grvListGame.EnableHeadersVisualStyles = false;
            this.grvListGame.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListGame.Location = new System.Drawing.Point(0, 60);
            this.grvListGame.Name = "grvListGame";
            this.grvListGame.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListGame.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.grvListGame.RowHeadersVisible = false;
            this.grvListGame.RowHeadersWidth = 10;
            this.grvListGame.RowTemplate.Height = 24;
            this.grvListGame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grvListGame.Size = new System.Drawing.Size(723, 693);
            this.grvListGame.TabIndex = 17;
            this.grvListGame.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grvListGame.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grvListGame.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grvListGame.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grvListGame.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grvListGame.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grvListGame.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.grvListGame.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListGame.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grvListGame.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvListGame.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grvListGame.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grvListGame.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvListGame.ThemeStyle.HeaderStyle.Height = 20;
            this.grvListGame.ThemeStyle.ReadOnly = true;
            this.grvListGame.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grvListGame.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvListGame.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grvListGame.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grvListGame.ThemeStyle.RowsStyle.Height = 24;
            this.grvListGame.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListGame.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Yellow;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(723, 60);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Giới Thiệu GameShow";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlLeft);
            this.Name = "Tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            this.panel2.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlHow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvListGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_AboutUS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2DataGridView grvListGame;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlHow;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton btnClosed;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}