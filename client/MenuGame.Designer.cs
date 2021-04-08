namespace client
{
    partial class MenuGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGame));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlNearestGame = new System.Windows.Forms.Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGameTime = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblWaitingTime = new System.Windows.Forms.Label();
            this.lblGameID = new System.Windows.Forms.Label();
            this.grvListGame = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GamerTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerX = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimeEnterGame = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAboutus = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.TimeAudioGame = new System.Windows.Forms.Timer(this.components);
            this.pnlLeft.SuspendLayout();
            this.pnlNearestGame.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListGame)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Yellow;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(701, 60);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "LỊCH PHÁT SÓNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Yellow;
            this.pnlLeft.Controls.Add(this.pnlNearestGame);
            this.pnlLeft.Controls.Add(this.grvListGame);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Location = new System.Drawing.Point(560, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(701, 753);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlNearestGame
            // 
            this.pnlNearestGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnlNearestGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlNearestGame.BackgroundImage")));
            this.pnlNearestGame.Controls.Add(this.guna2Panel5);
            this.pnlNearestGame.Controls.Add(this.guna2Panel4);
            this.pnlNearestGame.Controls.Add(this.guna2Panel3);
            this.pnlNearestGame.Controls.Add(this.guna2Panel2);
            this.pnlNearestGame.Controls.Add(this.guna2Panel1);
            this.pnlNearestGame.Controls.Add(this.lblGameTime);
            this.pnlNearestGame.Controls.Add(this.lblGameName);
            this.pnlNearestGame.Controls.Add(this.lblWaitingTime);
            this.pnlNearestGame.Controls.Add(this.lblGameID);
            this.pnlNearestGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNearestGame.Location = new System.Drawing.Point(0, 459);
            this.pnlNearestGame.Name = "pnlNearestGame";
            this.pnlNearestGame.Size = new System.Drawing.Size(701, 294);
            this.pnlNearestGame.TabIndex = 18;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Black;
            this.guna2Panel5.BorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2Panel5.BorderRadius = 15;
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Controls.Add(this.label3);
            this.guna2Panel5.Location = new System.Drawing.Point(23, 214);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(105, 44);
            this.guna2Panel5.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time :";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Black;
            this.guna2Panel4.BorderColor = System.Drawing.Color.OrangeRed;
            this.guna2Panel4.BorderRadius = 15;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.label5);
            this.guna2Panel4.Location = new System.Drawing.Point(23, 166);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(197, 44);
            this.guna2Panel4.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Waiting time :";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Orchid;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.label13);
            this.guna2Panel3.Location = new System.Drawing.Point(23, 119);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(130, 44);
            this.guna2Panel3.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(19, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 32);
            this.label13.TabIndex = 10;
            this.label13.Text = "Name :";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Orange;
            this.guna2Panel2.BorderRadius = 13;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Location = new System.Drawing.Point(23, 72);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(69, 44);
            this.guna2Panel2.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "ID :";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Lime;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(177, 6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(305, 65);
            this.guna2Panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch Gần Nhất";
            // 
            // lblGameTime
            // 
            this.lblGameTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGameTime.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTime.ForeColor = System.Drawing.Color.White;
            this.lblGameTime.Location = new System.Drawing.Point(226, 226);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(424, 32);
            this.lblGameTime.TabIndex = 14;
            this.lblGameTime.Text = "#Thời gian game phát sóng (lblGameTime)";
            // 
            // lblGameName
            // 
            this.lblGameName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGameName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(226, 131);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(431, 32);
            this.lblGameName.TabIndex = 13;
            this.lblGameName.Text = "#GameName (lblGameName)";
            // 
            // lblWaitingTime
            // 
            this.lblWaitingTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWaitingTime.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitingTime.ForeColor = System.Drawing.Color.White;
            this.lblWaitingTime.Location = new System.Drawing.Point(226, 178);
            this.lblWaitingTime.Name = "lblWaitingTime";
            this.lblWaitingTime.Size = new System.Drawing.Size(397, 32);
            this.lblWaitingTime.TabIndex = 12;
            this.lblWaitingTime.Text = "#Thời gian chờ (lblWaitingTime)";
            // 
            // lblGameID
            // 
            this.lblGameID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGameID.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameID.ForeColor = System.Drawing.Color.White;
            this.lblGameID.Location = new System.Drawing.Point(226, 84);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(424, 32);
            this.lblGameID.TabIndex = 11;
            this.lblGameID.Text = "#GameID (lblGameID)";
            // 
            // grvListGame
            // 
            this.grvListGame.AllowUserToAddRows = false;
            this.grvListGame.AllowUserToDeleteRows = false;
            this.grvListGame.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grvListGame.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvListGame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvListGame.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grvListGame.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvListGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvListGame.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvListGame.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListGame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvListGame.ColumnHeadersHeight = 20;
            this.grvListGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvListGame.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvListGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.grvListGame.EnableHeadersVisualStyles = false;
            this.grvListGame.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListGame.Location = new System.Drawing.Point(0, 60);
            this.grvListGame.Name = "grvListGame";
            this.grvListGame.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListGame.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvListGame.RowHeadersVisible = false;
            this.grvListGame.RowHeadersWidth = 10;
            this.grvListGame.RowTemplate.Height = 24;
            this.grvListGame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grvListGame.Size = new System.Drawing.Size(701, 399);
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
            // GamerTimer
            // 
            this.GamerTimer.Tick += new System.EventHandler(this.GamerTimer_Tick);
            // 
            // TimerX
            // 
            this.TimerX.Tick += new System.EventHandler(this.TimerX_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.lblTimeEnterGame);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnAboutus);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 765);
            this.panel2.TabIndex = 19;
            // 
            // lblTimeEnterGame
            // 
            this.lblTimeEnterGame.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeEnterGame.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnterGame.ForeColor = System.Drawing.Color.Gold;
            this.lblTimeEnterGame.Location = new System.Drawing.Point(155, 439);
            this.lblTimeEnterGame.Name = "lblTimeEnterGame";
            this.lblTimeEnterGame.Size = new System.Drawing.Size(272, 43);
            this.lblTimeEnterGame.TabIndex = 9;
            this.lblTimeEnterGame.Text = "00:59";
            this.lblTimeEnterGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimeEnterGame.Click += new System.EventHandler(this.lblTimeEnterGame_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(143, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 46);
            this.label4.TabIndex = 20;
            this.label4.Text = "Play Game To After";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(79, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 261);
            this.panel3.TabIndex = 19;
            // 
            // btnAboutus
            // 
            this.btnAboutus.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutus.BorderRadius = 20;
            this.btnAboutus.CheckedState.Parent = this.btnAboutus;
            this.btnAboutus.CustomImages.Parent = this.btnAboutus;
            this.btnAboutus.FillColor = System.Drawing.Color.Salmon;
            this.btnAboutus.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutus.ForeColor = System.Drawing.Color.White;
            this.btnAboutus.HoverState.Parent = this.btnAboutus;
            this.btnAboutus.Location = new System.Drawing.Point(150, 632);
            this.btnAboutus.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnAboutus.Name = "btnAboutus";
            this.btnAboutus.ShadowDecoration.Parent = this.btnAboutus;
            this.btnAboutus.Size = new System.Drawing.Size(293, 59);
            this.btnAboutus.TabIndex = 17;
            this.btnAboutus.Text = "Tutorial";
            this.btnAboutus.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderRadius = 20;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.Enabled = false;
            this.btnStart.FillColor = System.Drawing.Color.Tan;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(150, 543);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(293, 59);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "START";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TimeAudioGame
            // 
            this.TimeAudioGame.Tick += new System.EventHandler(this.TimeAudioGame_Tick);
            // 
            // MenuGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlLeft);
            this.Name = "MenuGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGameMenu";
            this.Load += new System.EventHandler(this.MenuGame_Load);
            this.SizeChanged += new System.EventHandler(this.MenuGame_SizeChanged);
            this.pnlLeft.ResumeLayout(false);
            this.pnlNearestGame.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListGame)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlNearestGame;
        private Guna.UI2.WinForms.Guna2DataGridView grvListGame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimeEnterGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnAboutus;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private System.Windows.Forms.Timer GamerTimer;
        private System.Windows.Forms.Timer TimerX;
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblWaitingTime;
        private System.Windows.Forms.Label lblGameID;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer TimeAudioGame;
    }
}