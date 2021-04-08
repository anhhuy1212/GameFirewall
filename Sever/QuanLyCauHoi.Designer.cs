namespace Sever
{
    partial class QuanLyCauHoi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBtnGroup = new System.Windows.Forms.Panel();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pnlGrv = new System.Windows.Forms.Panel();
            this.grvListQuestion = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddQuestion = new Guna.UI2.WinForms.Guna2Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTopicInfor = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlAnswerGroup = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ucAnswerBoxD = new Sever.UCAnswerBox();
            this.ucAnswerBoxC = new Sever.UCAnswerBox();
            this.ucAnswerBoxB = new Sever.UCAnswerBox();
            this.ucAnswerBoxA = new Sever.UCAnswerBox();
            this.pnlLeft.SuspendLayout();
            this.pnlBtnGroup.SuspendLayout();
            this.pnlGrv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListQuestion)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlAnswerGroup.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(0, 5558);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 753);
            this.panel3.TabIndex = 17;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Gray;
            this.pnlLeft.Controls.Add(this.pnlBtnGroup);
            this.pnlLeft.Controls.Add(this.pnlGrv);
            this.pnlLeft.Controls.Add(this.pnlTitle);
            this.pnlLeft.Controls.Add(this.panel3);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(656, 753);
            this.pnlLeft.TabIndex = 10;
            // 
            // pnlBtnGroup
            // 
            this.pnlBtnGroup.Controls.Add(this.btnRemove);
            this.pnlBtnGroup.Controls.Add(this.btnRemoveAll);
            this.pnlBtnGroup.Controls.Add(this.btnSave);
            this.pnlBtnGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtnGroup.Location = new System.Drawing.Point(0, 677);
            this.pnlBtnGroup.Name = "pnlBtnGroup";
            this.pnlBtnGroup.Size = new System.Drawing.Size(656, 76);
            this.pnlBtnGroup.TabIndex = 32;
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 20;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.FillColor = System.Drawing.Color.Chocolate;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(216, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(187, 60);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BorderRadius = 20;
            this.btnRemoveAll.CheckedState.Parent = this.btnRemoveAll;
            this.btnRemoveAll.CustomImages.Parent = this.btnRemoveAll;
            this.btnRemoveAll.FillColor = System.Drawing.Color.LightCoral;
            this.btnRemoveAll.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAll.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAll.HoverState.Parent = this.btnRemoveAll;
            this.btnRemoveAll.Location = new System.Drawing.Point(10, 7);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.ShadowDecoration.Parent = this.btnRemoveAll;
            this.btnRemoveAll.Size = new System.Drawing.Size(187, 60);
            this.btnRemoveAll.TabIndex = 31;
            this.btnRemoveAll.Text = "REMOVE ALL";
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 20;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.SkyBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(421, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(187, 60);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlGrv
            // 
            this.pnlGrv.Controls.Add(this.grvListQuestion);
            this.pnlGrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrv.Location = new System.Drawing.Point(0, 72);
            this.pnlGrv.Name = "pnlGrv";
            this.pnlGrv.Size = new System.Drawing.Size(656, 681);
            this.pnlGrv.TabIndex = 31;
            // 
            // grvListQuestion
            // 
            this.grvListQuestion.AllowUserToAddRows = false;
            this.grvListQuestion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grvListQuestion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grvListQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvListQuestion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvListQuestion.BackgroundColor = System.Drawing.Color.White;
            this.grvListQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvListQuestion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvListQuestion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvListQuestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grvListQuestion.ColumnHeadersHeight = 20;
            this.grvListQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvListQuestion.DefaultCellStyle = dataGridViewCellStyle9;
            this.grvListQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvListQuestion.EnableHeadersVisualStyles = false;
            this.grvListQuestion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListQuestion.Location = new System.Drawing.Point(0, 0);
            this.grvListQuestion.Name = "grvListQuestion";
            this.grvListQuestion.ReadOnly = true;
            this.grvListQuestion.RowHeadersVisible = false;
            this.grvListQuestion.RowHeadersWidth = 51;
            this.grvListQuestion.RowTemplate.Height = 24;
            this.grvListQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvListQuestion.Size = new System.Drawing.Size(656, 681);
            this.grvListQuestion.TabIndex = 31;
            this.grvListQuestion.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grvListQuestion.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grvListQuestion.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grvListQuestion.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListQuestion.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grvListQuestion.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvListQuestion.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grvListQuestion.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grvListQuestion.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvListQuestion.ThemeStyle.HeaderStyle.Height = 20;
            this.grvListQuestion.ThemeStyle.ReadOnly = true;
            this.grvListQuestion.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grvListQuestion.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvListQuestion.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grvListQuestion.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grvListQuestion.ThemeStyle.RowsStyle.Height = 24;
            this.grvListQuestion.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvListQuestion.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grvListQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvListQuestion_CellContentDoubleClick);
            this.grvListQuestion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvListQuestion_CellContentDoubleClick);
            this.grvListQuestion.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvListQuestion_CellContentDoubleClick);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Gray;
            this.pnlTitle.Controls.Add(this.panel2);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.ForeColor = System.Drawing.Color.Gray;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(656, 72);
            this.pnlTitle.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(204, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 5);
            this.panel2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 72);
            this.label1.TabIndex = 14;
            this.label1.Text = "List Question";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(17, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(168, 60);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Gray;
            this.pnlRight.Controls.Add(this.panel9);
            this.pnlRight.Controls.Add(this.panel8);
            this.pnlRight.Controls.Add(this.pnlAnswerGroup);
            this.pnlRight.Controls.Add(this.panel7);
            this.pnlRight.Controls.Add(this.panel5);
            this.pnlRight.Location = new System.Drawing.Point(659, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(630, 753);
            this.pnlRight.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.btnEdit);
            this.panel9.Controls.Add(this.btnRefresh);
            this.panel9.Controls.Add(this.btnAddQuestion);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 677);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(630, 76);
            this.panel9.TabIndex = 52;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.SandyBrown;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(210, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(187, 60);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BorderRadius = 20;
            this.btnAddQuestion.CheckedState.Parent = this.btnAddQuestion;
            this.btnAddQuestion.CustomImages.Parent = this.btnAddQuestion;
            this.btnAddQuestion.FillColor = System.Drawing.Color.LightGreen;
            this.btnAddQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAddQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestion.HoverState.Parent = this.btnAddQuestion;
            this.btnAddQuestion.Location = new System.Drawing.Point(425, 7);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.ShadowDecoration.Parent = this.btnAddQuestion;
            this.btnAddQuestion.Size = new System.Drawing.Size(187, 60);
            this.btnAddQuestion.TabIndex = 24;
            this.btnAddQuestion.Text = "ADD";
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtTopicInfor);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 542);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(630, 135);
            this.panel8.TabIndex = 51;
            // 
            // txtTopicInfor
            // 
            this.txtTopicInfor.BorderRadius = 30;
            this.txtTopicInfor.BorderThickness = 0;
            this.txtTopicInfor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTopicInfor.DefaultText = "";
            this.txtTopicInfor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTopicInfor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTopicInfor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTopicInfor.DisabledState.Parent = this.txtTopicInfor;
            this.txtTopicInfor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTopicInfor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTopicInfor.FocusedState.Parent = this.txtTopicInfor;
            this.txtTopicInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtTopicInfor.ForeColor = System.Drawing.Color.Black;
            this.txtTopicInfor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTopicInfor.HoverState.Parent = this.txtTopicInfor;
            this.txtTopicInfor.Location = new System.Drawing.Point(17, 9);
            this.txtTopicInfor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTopicInfor.Multiline = true;
            this.txtTopicInfor.Name = "txtTopicInfor";
            this.txtTopicInfor.PasswordChar = '\0';
            this.txtTopicInfor.PlaceholderText = "Type topic information of the question...";
            this.txtTopicInfor.SelectedText = "";
            this.txtTopicInfor.ShadowDecoration.Parent = this.txtTopicInfor;
            this.txtTopicInfor.Size = new System.Drawing.Size(554, 108);
            this.txtTopicInfor.TabIndex = 27;
            // 
            // pnlAnswerGroup
            // 
            this.pnlAnswerGroup.Controls.Add(this.ucAnswerBoxA);
            this.pnlAnswerGroup.Controls.Add(this.ucAnswerBoxB);
            this.pnlAnswerGroup.Controls.Add(this.ucAnswerBoxC);
            this.pnlAnswerGroup.Controls.Add(this.ucAnswerBoxD);
            this.pnlAnswerGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswerGroup.Location = new System.Drawing.Point(0, 192);
            this.pnlAnswerGroup.Name = "pnlAnswerGroup";
            this.pnlAnswerGroup.Size = new System.Drawing.Size(630, 350);
            this.pnlAnswerGroup.TabIndex = 50;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.txtContent);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 72);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(630, 120);
            this.panel7.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 120);
            this.panel1.TabIndex = 23;
            // 
            // txtId
            // 
            this.txtId.BorderRadius = 20;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.Parent = this.txtId;
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.FocusedState.Parent = this.txtId;
            this.txtId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.HoverState.Parent = this.txtId;
            this.txtId.Location = new System.Drawing.Point(5, 26);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "Type ID";
            this.txtId.SelectedText = "";
            this.txtId.ShadowDecoration.Parent = this.txtId;
            this.txtId.Size = new System.Drawing.Size(80, 59);
            this.txtId.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.BorderRadius = 30;
            this.txtContent.BorderThickness = 0;
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.DefaultText = "";
            this.txtContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.DisabledState.Parent = this.txtContent;
            this.txtContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.FocusedState.Parent = this.txtContent;
            this.txtContent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.Black;
            this.txtContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.HoverState.Parent = this.txtContent;
            this.txtContent.Location = new System.Drawing.Point(91, 0);
            this.txtContent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.PlaceholderText = "Type your question...";
            this.txtContent.SelectedText = "";
            this.txtContent.ShadowDecoration.Parent = this.txtContent;
            this.txtContent.Size = new System.Drawing.Size(480, 120);
            this.txtContent.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(630, 72);
            this.panel5.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(193, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 5);
            this.panel6.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 57);
            this.label2.TabIndex = 26;
            this.label2.Text = "Create Question";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucAnswerBoxD
            // 
            this.ucAnswerBoxD.BackColor = System.Drawing.Color.Transparent;
            this.ucAnswerBoxD.Content = "";
            this.ucAnswerBoxD.isAnswerCorrect = false;
            this.ucAnswerBoxD.Location = new System.Drawing.Point(69, 273);
            this.ucAnswerBoxD.Name = "ucAnswerBoxD";
            this.ucAnswerBoxD.Size = new System.Drawing.Size(502, 71);
            this.ucAnswerBoxD.TabIndex = 44;
            // 
            // ucAnswerBoxC
            // 
            this.ucAnswerBoxC.BackColor = System.Drawing.Color.Transparent;
            this.ucAnswerBoxC.Content = "";
            this.ucAnswerBoxC.isAnswerCorrect = false;
            this.ucAnswerBoxC.Location = new System.Drawing.Point(69, 187);
            this.ucAnswerBoxC.Name = "ucAnswerBoxC";
            this.ucAnswerBoxC.Size = new System.Drawing.Size(502, 71);
            this.ucAnswerBoxC.TabIndex = 45;
            // 
            // ucAnswerBoxB
            // 
            this.ucAnswerBoxB.BackColor = System.Drawing.Color.Transparent;
            this.ucAnswerBoxB.Content = "";
            this.ucAnswerBoxB.isAnswerCorrect = false;
            this.ucAnswerBoxB.Location = new System.Drawing.Point(69, 100);
            this.ucAnswerBoxB.Name = "ucAnswerBoxB";
            this.ucAnswerBoxB.Size = new System.Drawing.Size(502, 71);
            this.ucAnswerBoxB.TabIndex = 46;
            // 
            // ucAnswerBoxA
            // 
            this.ucAnswerBoxA.BackColor = System.Drawing.Color.Transparent;
            this.ucAnswerBoxA.Content = "";
            this.ucAnswerBoxA.isAnswerCorrect = false;
            this.ucAnswerBoxA.Location = new System.Drawing.Point(69, 9);
            this.ucAnswerBoxA.Name = "ucAnswerBoxA";
            this.ucAnswerBoxA.Size = new System.Drawing.Size(502, 71);
            this.ucAnswerBoxA.TabIndex = 47;
            // 
            // QuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1283, 753);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "QuanLyCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Câu Hỏi";
            this.Load += new System.EventHandler(this.QuestionManagement_Load);
            this.ClientSizeChanged += new System.EventHandler(this.QuestionManagement_ClientSizeChanged);
            this.pnlLeft.ResumeLayout(false);
            this.pnlBtnGroup.ResumeLayout(false);
            this.pnlGrv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvListQuestion)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnlAnswerGroup.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBtnGroup;
        private System.Windows.Forms.Panel pnlGrv;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView grvListQuestion;
        private Guna.UI2.WinForms.Guna2Button btnRemoveAll;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnAddQuestion;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2TextBox txtTopicInfor;
        private System.Windows.Forms.Panel pnlAnswerGroup;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2TextBox txtContent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private UCAnswerBox ucAnswerBoxA;
        private UCAnswerBox ucAnswerBoxB;
        private UCAnswerBox ucAnswerBoxC;
        private UCAnswerBox ucAnswerBoxD;
    }
}

