﻿namespace StudentsResults
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            IconImageList = new ImageList(components);
            Mark = new TabPage();
            splitContainer5 = new SplitContainer();
            label9 = new Label();
            MarkNameFilterBox = new TextBox();
            label10 = new Label();
            MarkCodeFilterBox = new TextBox();
            MarkdataGridView = new DataGridView();
            _MM_Code = new DataGridViewTextBoxColumn();
            _MName = new DataGridViewTextBoxColumn();
            Professor = new TabPage();
            splitContainer4 = new SplitContainer();
            label7 = new Label();
            ProfNameFilterBox = new TextBox();
            label8 = new Label();
            ProfCodeFilterBox = new TextBox();
            ProfdataGridView = new DataGridView();
            _PP_Code = new DataGridViewTextBoxColumn();
            _PName = new DataGridViewTextBoxColumn();
            Discipline = new TabPage();
            splitContainer3 = new SplitContainer();
            label4 = new Label();
            DisProfessorFilterBox = new TextBox();
            label5 = new Label();
            DisNameFilterBox = new TextBox();
            label6 = new Label();
            DisCodeFilterBox = new TextBox();
            DisdataGridView = new DataGridView();
            _DD_Code = new DataGridViewTextBoxColumn();
            _DName = new DataGridViewTextBoxColumn();
            _DProfessorName = new DataGridViewTextBoxColumn();
            _DFK_Professor = new DataGridViewTextBoxColumn();
            Specialty = new TabPage();
            splitContainer2 = new SplitContainer();
            label2 = new Label();
            SpNameFilterBox = new TextBox();
            label3 = new Label();
            SpCodeFilterBox = new TextBox();
            SpdataGridView = new DataGridView();
            _SS_Code = new DataGridViewTextBoxColumn();
            _SName = new DataGridViewTextBoxColumn();
            RecordBook = new TabPage();
            splitContainer1 = new SplitContainer();
            DisciplineFilterLabel = new Label();
            DisciplineFilterBox = new TextBox();
            NameFilterLabel = new Label();
            NameFilterBox = new TextBox();
            CodeFilterLabel = new Label();
            CodeFilterBox = new TextBox();
            RB_DataGridView = new DataGridView();
            _RRB_Code = new DataGridViewTextBoxColumn();
            _RName = new DataGridViewTextBoxColumn();
            _RSpecialtyName = new DataGridViewTextBoxColumn();
            MainControl = new TabControl();
            ReportPage = new TabPage();
            FIO_FilterBox = new TextBox();
            FIO_FilterLabel = new Label();
            MFilterLable = new Label();
            MFilterBox = new TextBox();
            SFilterBox = new TextBox();
            DFilterLable = new Label();
            DFilterBox = new TextBox();
            ReportComboBox = new ComboBox();
            ReportDataGridView = new DataGridView();
            Mark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MarkdataGridView).BeginInit();
            Professor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfdataGridView).BeginInit();
            Discipline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisdataGridView).BeginInit();
            Specialty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpdataGridView).BeginInit();
            RecordBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RB_DataGridView).BeginInit();
            MainControl.SuspendLayout();
            ReportPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).BeginInit();
            SuspendLayout();
            // 
            // IconImageList
            // 
            IconImageList.ColorDepth = ColorDepth.Depth32Bit;
            IconImageList.ImageStream = (ImageListStreamer)resources.GetObject("IconImageList.ImageStream");
            IconImageList.TransparentColor = Color.Transparent;
            IconImageList.Images.SetKeyName(0, "free-icon-home-3648679.png");
            IconImageList.Images.SetKeyName(1, "free-icon-open-book-760346.png");
            IconImageList.Images.SetKeyName(2, "free-icon-directional-sign-7276274.png");
            IconImageList.Images.SetKeyName(3, "free-icon-note-book-11092418.png");
            IconImageList.Images.SetKeyName(4, "free-icon-professor-6681350.png");
            IconImageList.Images.SetKeyName(5, "free-icon-5-stars-2355011.png");
            IconImageList.Images.SetKeyName(6, "free-icon-report-4371224.png");
            // 
            // Mark
            // 
            Mark.Controls.Add(splitContainer5);
            Mark.ImageIndex = 5;
            Mark.Location = new Point(4, 44);
            Mark.Name = "Mark";
            Mark.Size = new Size(1075, 402);
            Mark.TabIndex = 5;
            Mark.Text = "Виды оценок";
            Mark.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(label9);
            splitContainer5.Panel1.Controls.Add(MarkNameFilterBox);
            splitContainer5.Panel1.Controls.Add(label10);
            splitContainer5.Panel1.Controls.Add(MarkCodeFilterBox);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(MarkdataGridView);
            splitContainer5.Size = new Size(1075, 402);
            splitContainer5.SplitterDistance = 256;
            splitContainer5.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 69);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 3;
            label9.Text = "Наименование:";
            // 
            // MarkNameFilterBox
            // 
            MarkNameFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MarkNameFilterBox.Location = new Point(121, 66);
            MarkNameFilterBox.Name = "MarkNameFilterBox";
            MarkNameFilterBox.Size = new Size(131, 27);
            MarkNameFilterBox.TabIndex = 2;
            MarkNameFilterBox.TextChanged += MarkNameFilterBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 36);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 1;
            label10.Text = "Код:";
            // 
            // MarkCodeFilterBox
            // 
            MarkCodeFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MarkCodeFilterBox.Location = new Point(121, 33);
            MarkCodeFilterBox.Name = "MarkCodeFilterBox";
            MarkCodeFilterBox.Size = new Size(132, 27);
            MarkCodeFilterBox.TabIndex = 0;
            MarkCodeFilterBox.TextChanged += MarkCodeFilterBox_TextChanged;
            // 
            // MarkdataGridView
            // 
            MarkdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MarkdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MarkdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MarkdataGridView.Columns.AddRange(new DataGridViewColumn[] { _MM_Code, _MName });
            MarkdataGridView.Location = new Point(0, 0);
            MarkdataGridView.Name = "MarkdataGridView";
            MarkdataGridView.RowTemplate.Height = 25;
            MarkdataGridView.Size = new Size(815, 402);
            MarkdataGridView.TabIndex = 0;
            MarkdataGridView.CellValueChanged += MarkdataGridView_CellValueChanged;
            MarkdataGridView.UserDeletedRow += MarkdataGridView_UserDeletedRow;
            // 
            // _MM_Code
            // 
            _MM_Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _MM_Code.HeaderText = "Код";
            _MM_Code.Name = "_MM_Code";
            _MM_Code.ReadOnly = true;
            _MM_Code.Width = 60;
            // 
            // _MName
            // 
            _MName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _MName.HeaderText = "Оценка";
            _MName.Name = "_MName";
            // 
            // Professor
            // 
            Professor.Controls.Add(splitContainer4);
            Professor.ImageIndex = 4;
            Professor.Location = new Point(4, 44);
            Professor.Name = "Professor";
            Professor.Size = new Size(1075, 402);
            Professor.TabIndex = 4;
            Professor.Text = "Преподаватели";
            Professor.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label7);
            splitContainer4.Panel1.Controls.Add(ProfNameFilterBox);
            splitContainer4.Panel1.Controls.Add(label8);
            splitContainer4.Panel1.Controls.Add(ProfCodeFilterBox);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(ProfdataGridView);
            splitContainer4.Size = new Size(1075, 402);
            splitContainer4.SplitterDistance = 256;
            splitContainer4.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 69);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 3;
            label7.Text = "ФИО:";
            // 
            // ProfNameFilterBox
            // 
            ProfNameFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ProfNameFilterBox.Location = new Point(121, 66);
            ProfNameFilterBox.Name = "ProfNameFilterBox";
            ProfNameFilterBox.Size = new Size(131, 27);
            ProfNameFilterBox.TabIndex = 2;
            ProfNameFilterBox.TextChanged += ProfNameFilterBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 36);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 1;
            label8.Text = "Код:";
            // 
            // ProfCodeFilterBox
            // 
            ProfCodeFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ProfCodeFilterBox.Location = new Point(121, 33);
            ProfCodeFilterBox.Name = "ProfCodeFilterBox";
            ProfCodeFilterBox.Size = new Size(132, 27);
            ProfCodeFilterBox.TabIndex = 0;
            ProfCodeFilterBox.TextChanged += ProfCodeFilterBox_TextChanged;
            // 
            // ProfdataGridView
            // 
            ProfdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProfdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProfdataGridView.Columns.AddRange(new DataGridViewColumn[] { _PP_Code, _PName });
            ProfdataGridView.Dock = DockStyle.Fill;
            ProfdataGridView.Location = new Point(0, 0);
            ProfdataGridView.Name = "ProfdataGridView";
            ProfdataGridView.RowTemplate.Height = 25;
            ProfdataGridView.Size = new Size(815, 402);
            ProfdataGridView.TabIndex = 0;
            ProfdataGridView.CellValueChanged += ProfdataGridView_CellValueChanged;
            ProfdataGridView.UserDeletedRow += ProfdataGridView_UserDeletedRow;
            // 
            // _PP_Code
            // 
            _PP_Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _PP_Code.HeaderText = "Код";
            _PP_Code.Name = "_PP_Code";
            _PP_Code.ReadOnly = true;
            _PP_Code.Width = 60;
            // 
            // _PName
            // 
            _PName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _PName.HeaderText = "ФИО";
            _PName.MaxInputLength = 50;
            _PName.Name = "_PName";
            // 
            // Discipline
            // 
            Discipline.Controls.Add(splitContainer3);
            Discipline.ImageIndex = 3;
            Discipline.Location = new Point(4, 44);
            Discipline.Name = "Discipline";
            Discipline.Size = new Size(1075, 402);
            Discipline.TabIndex = 3;
            Discipline.Text = "Дисциплины";
            Discipline.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(label4);
            splitContainer3.Panel1.Controls.Add(DisProfessorFilterBox);
            splitContainer3.Panel1.Controls.Add(label5);
            splitContainer3.Panel1.Controls.Add(DisNameFilterBox);
            splitContainer3.Panel1.Controls.Add(label6);
            splitContainer3.Panel1.Controls.Add(DisCodeFilterBox);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(DisdataGridView);
            splitContainer3.Size = new Size(1075, 402);
            splitContainer3.SplitterDistance = 272;
            splitContainer3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 102);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 5;
            label4.Text = "Преподаватель:";
            // 
            // DisProfessorFilterBox
            // 
            DisProfessorFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DisProfessorFilterBox.Location = new Point(134, 99);
            DisProfessorFilterBox.Name = "DisProfessorFilterBox";
            DisProfessorFilterBox.Size = new Size(131, 27);
            DisProfessorFilterBox.TabIndex = 4;
            DisProfessorFilterBox.TextChanged += DisProfessorFilterBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 69);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 3;
            label5.Text = "Наименование:";
            // 
            // DisNameFilterBox
            // 
            DisNameFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DisNameFilterBox.Location = new Point(133, 66);
            DisNameFilterBox.Name = "DisNameFilterBox";
            DisNameFilterBox.Size = new Size(131, 27);
            DisNameFilterBox.TabIndex = 2;
            DisNameFilterBox.TextChanged += DisNameFilterBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 40);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 1;
            label6.Text = "Код:";
            // 
            // DisCodeFilterBox
            // 
            DisCodeFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DisCodeFilterBox.Location = new Point(133, 33);
            DisCodeFilterBox.Name = "DisCodeFilterBox";
            DisCodeFilterBox.Size = new Size(132, 27);
            DisCodeFilterBox.TabIndex = 0;
            DisCodeFilterBox.TextChanged += DisCodeFilterBox_TextChanged;
            // 
            // DisdataGridView
            // 
            DisdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DisdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisdataGridView.Columns.AddRange(new DataGridViewColumn[] { _DD_Code, _DName, _DProfessorName, _DFK_Professor });
            DisdataGridView.Location = new Point(0, 0);
            DisdataGridView.Name = "DisdataGridView";
            DisdataGridView.RowTemplate.Height = 25;
            DisdataGridView.Size = new Size(799, 402);
            DisdataGridView.TabIndex = 0;
            DisdataGridView.CellDoubleClick += DisdataGridView_CellDoubleClick;
            DisdataGridView.CellValueChanged += DisdataGridView_CellValueChanged;
            DisdataGridView.UserDeletedRow += DisdataGridView_UserDeletedRow;
            // 
            // _DD_Code
            // 
            _DD_Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _DD_Code.HeaderText = "Код";
            _DD_Code.Name = "_DD_Code";
            _DD_Code.ReadOnly = true;
            _DD_Code.Width = 60;
            // 
            // _DName
            // 
            _DName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _DName.HeaderText = "Наименование";
            _DName.MaxInputLength = 50;
            _DName.Name = "_DName";
            _DName.Width = 141;
            // 
            // _DProfessorName
            // 
            _DProfessorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _DProfessorName.HeaderText = "Преподаватель";
            _DProfessorName.Name = "_DProfessorName";
            _DProfessorName.ReadOnly = true;
            // 
            // _DFK_Professor
            // 
            _DFK_Professor.HeaderText = "FK_Professor";
            _DFK_Professor.Name = "_DFK_Professor";
            _DFK_Professor.ReadOnly = true;
            _DFK_Professor.Visible = false;
            // 
            // Specialty
            // 
            Specialty.Controls.Add(splitContainer2);
            Specialty.ImageIndex = 2;
            Specialty.Location = new Point(4, 44);
            Specialty.Name = "Specialty";
            Specialty.Size = new Size(1075, 402);
            Specialty.TabIndex = 2;
            Specialty.Text = "Направления подготовки";
            Specialty.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(SpNameFilterBox);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(SpCodeFilterBox);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(SpdataGridView);
            splitContainer2.Size = new Size(1075, 402);
            splitContainer2.SplitterDistance = 256;
            splitContainer2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 69);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 3;
            label2.Text = "Наименование:";
            // 
            // SpNameFilterBox
            // 
            SpNameFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SpNameFilterBox.Location = new Point(123, 66);
            SpNameFilterBox.Name = "SpNameFilterBox";
            SpNameFilterBox.Size = new Size(131, 27);
            SpNameFilterBox.TabIndex = 2;
            SpNameFilterBox.TextChanged += SpNameFilterBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 1;
            label3.Text = "Код:";
            // 
            // SpCodeFilterBox
            // 
            SpCodeFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SpCodeFilterBox.Location = new Point(122, 33);
            SpCodeFilterBox.Name = "SpCodeFilterBox";
            SpCodeFilterBox.Size = new Size(132, 27);
            SpCodeFilterBox.TabIndex = 0;
            SpCodeFilterBox.TextChanged += SpCodeFilterBox_TextChanged;
            // 
            // SpdataGridView
            // 
            SpdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SpdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SpdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SpdataGridView.Columns.AddRange(new DataGridViewColumn[] { _SS_Code, _SName });
            SpdataGridView.Location = new Point(0, 0);
            SpdataGridView.Name = "SpdataGridView";
            SpdataGridView.RowTemplate.Height = 25;
            SpdataGridView.Size = new Size(815, 402);
            SpdataGridView.TabIndex = 0;
            SpdataGridView.CellValueChanged += SpdataGridView_CellValueChanged;
            SpdataGridView.UserDeletedRow += SpdataGridView_UserDeletedRow;
            // 
            // _SS_Code
            // 
            _SS_Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _SS_Code.HeaderText = "Код";
            _SS_Code.Name = "_SS_Code";
            _SS_Code.ReadOnly = true;
            _SS_Code.Width = 60;
            // 
            // _SName
            // 
            _SName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _SName.HeaderText = "Наименование";
            _SName.Name = "_SName";
            // 
            // RecordBook
            // 
            RecordBook.Controls.Add(splitContainer1);
            RecordBook.ImageIndex = 1;
            RecordBook.Location = new Point(4, 44);
            RecordBook.Name = "RecordBook";
            RecordBook.Size = new Size(1075, 402);
            RecordBook.TabIndex = 1;
            RecordBook.Text = "Зачётные книги";
            RecordBook.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(DisciplineFilterLabel);
            splitContainer1.Panel1.Controls.Add(DisciplineFilterBox);
            splitContainer1.Panel1.Controls.Add(NameFilterLabel);
            splitContainer1.Panel1.Controls.Add(NameFilterBox);
            splitContainer1.Panel1.Controls.Add(CodeFilterLabel);
            splitContainer1.Panel1.Controls.Add(CodeFilterBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(RB_DataGridView);
            splitContainer1.Size = new Size(1075, 402);
            splitContainer1.SplitterDistance = 256;
            splitContainer1.TabIndex = 1;
            // 
            // DisciplineFilterLabel
            // 
            DisciplineFilterLabel.AutoSize = true;
            DisciplineFilterLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DisciplineFilterLabel.Location = new Point(3, 102);
            DisciplineFilterLabel.Name = "DisciplineFilterLabel";
            DisciplineFilterLabel.Size = new Size(107, 20);
            DisciplineFilterLabel.TabIndex = 5;
            DisciplineFilterLabel.Text = "Направление:";
            // 
            // DisciplineFilterBox
            // 
            DisciplineFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DisciplineFilterBox.Location = new Point(121, 99);
            DisciplineFilterBox.Name = "DisciplineFilterBox";
            DisciplineFilterBox.Size = new Size(131, 27);
            DisciplineFilterBox.TabIndex = 4;
            DisciplineFilterBox.TextChanged += DisciplineFilterBox_TextChanged;
            // 
            // NameFilterLabel
            // 
            NameFilterLabel.AutoSize = true;
            NameFilterLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NameFilterLabel.Location = new Point(3, 73);
            NameFilterLabel.Name = "NameFilterLabel";
            NameFilterLabel.Size = new Size(45, 20);
            NameFilterLabel.TabIndex = 3;
            NameFilterLabel.Text = "ФИО:";
            // 
            // NameFilterBox
            // 
            NameFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NameFilterBox.Location = new Point(121, 66);
            NameFilterBox.Name = "NameFilterBox";
            NameFilterBox.Size = new Size(131, 27);
            NameFilterBox.TabIndex = 2;
            NameFilterBox.TextChanged += NameFilterBox_TextChanged;
            // 
            // CodeFilterLabel
            // 
            CodeFilterLabel.AutoSize = true;
            CodeFilterLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CodeFilterLabel.Location = new Point(3, 40);
            CodeFilterLabel.Name = "CodeFilterLabel";
            CodeFilterLabel.Size = new Size(38, 20);
            CodeFilterLabel.TabIndex = 1;
            CodeFilterLabel.Text = "Код:";
            // 
            // CodeFilterBox
            // 
            CodeFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CodeFilterBox.Location = new Point(121, 33);
            CodeFilterBox.Name = "CodeFilterBox";
            CodeFilterBox.Size = new Size(132, 27);
            CodeFilterBox.TabIndex = 0;
            CodeFilterBox.TextChanged += CodeFilterBox_TextChanged;
            // 
            // RB_DataGridView
            // 
            RB_DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RB_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RB_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RB_DataGridView.Columns.AddRange(new DataGridViewColumn[] { _RRB_Code, _RName, _RSpecialtyName });
            RB_DataGridView.Location = new Point(0, 0);
            RB_DataGridView.Name = "RB_DataGridView";
            RB_DataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            RB_DataGridView.RowTemplate.Height = 25;
            RB_DataGridView.Size = new Size(815, 402);
            RB_DataGridView.TabIndex = 0;
            RB_DataGridView.CellDoubleClick += RB_DataGridView_CellDoubleClick;
            RB_DataGridView.UserDeletedRow += RB_DataGridView_UserDeletedRow;
            // 
            // _RRB_Code
            // 
            _RRB_Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _RRB_Code.HeaderText = "Код";
            _RRB_Code.Name = "_RRB_Code";
            _RRB_Code.ReadOnly = true;
            _RRB_Code.Width = 60;
            // 
            // _RName
            // 
            _RName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _RName.HeaderText = "ФИО";
            _RName.MaxInputLength = 50;
            _RName.Name = "_RName";
            _RName.ReadOnly = true;
            _RName.Width = 67;
            // 
            // _RSpecialtyName
            // 
            _RSpecialtyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _RSpecialtyName.HeaderText = "Направление подготовки";
            _RSpecialtyName.Name = "_RSpecialtyName";
            _RSpecialtyName.ReadOnly = true;
            // 
            // MainControl
            // 
            MainControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainControl.Controls.Add(RecordBook);
            MainControl.Controls.Add(Specialty);
            MainControl.Controls.Add(Discipline);
            MainControl.Controls.Add(Professor);
            MainControl.Controls.Add(Mark);
            MainControl.Controls.Add(ReportPage);
            MainControl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MainControl.ImageList = IconImageList;
            MainControl.ItemSize = new Size(114, 40);
            MainControl.Location = new Point(0, 0);
            MainControl.Name = "MainControl";
            MainControl.SelectedIndex = 0;
            MainControl.Size = new Size(1083, 450);
            MainControl.TabIndex = 0;
            MainControl.Selected += MainControl_Selected;
            // 
            // ReportPage
            // 
            ReportPage.Controls.Add(FIO_FilterBox);
            ReportPage.Controls.Add(FIO_FilterLabel);
            //ReportPage.Controls.Add(MFilterLable);
            ReportPage.Controls.Add(MFilterBox);
            ReportPage.Controls.Add(SFilterBox);
            //ReportPage.Controls.Add(DFilterLable);
            ReportPage.Controls.Add(DFilterBox);
            ReportPage.Controls.Add(ReportComboBox);
            ReportPage.Controls.Add(ReportDataGridView);
            ReportPage.ImageIndex = 6;
            ReportPage.Location = new Point(4, 44);
            ReportPage.Name = "ReportPage";
            ReportPage.Padding = new Padding(3);
            ReportPage.Size = new Size(1075, 402);
            ReportPage.TabIndex = 6;
            ReportPage.Text = "Отчёты";
            ReportPage.UseVisualStyleBackColor = true;
            // 
            // FIO_FilterBox
            // 
            FIO_FilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FIO_FilterBox.Location = new Point(121, 40);
            FIO_FilterBox.Name = "FIO_FilterBox";
            FIO_FilterBox.Size = new Size(185, 27);
            FIO_FilterBox.TabIndex = 13;
            FIO_FilterBox.TextChanged += FIO_FilterBox_TextChanged;
            // 
            // FIO_FilterLabel
            // 
            FIO_FilterLabel.AutoSize = true;
            FIO_FilterLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FIO_FilterLabel.Location = new Point(8, 43);
            FIO_FilterLabel.Name = "FIO_FilterLabel";
            FIO_FilterLabel.Size = new Size(45, 20);
            FIO_FilterLabel.TabIndex = 12;
            FIO_FilterLabel.Text = "ФИО:";
            // 
            // MFilterLable
            // 
            MFilterLable.AutoSize = true;
            MFilterLable.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MFilterLable.Location = new Point(8, 459);
            MFilterLable.Name = "MFilterLable";
            MFilterLable.Size = new Size(64, 20);
            MFilterLable.TabIndex = 11;
            MFilterLable.Text = "Оценка:";
            // 
            // MFilterBox
            // 
            MFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MFilterBox.Location = new Point(121, 456);
            MFilterBox.Name = "MFilterBox";
            MFilterBox.Size = new Size(185, 27);
            MFilterBox.TabIndex = 10;
            MFilterBox.Visible = false;
            MFilterBox.TextChanged += MFilterBox_TextChanged;
            // 
            // SFilterBox
            // 
            SFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SFilterBox.Location = new Point(121, 391);
            SFilterBox.Name = "SFilterBox";
            SFilterBox.Size = new Size(185, 27);
            SFilterBox.TabIndex = 8;
            SFilterBox.Visible = false;
            SFilterBox.TextChanged += SFilterBox_TextChanged;
            // 
            // DFilterLable
            // 
            DFilterLable.AutoSize = true;
            DFilterLable.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DFilterLable.Location = new Point(8, 427);
            DFilterLable.Name = "DFilterLable";
            DFilterLable.Size = new Size(99, 20);
            DFilterLable.TabIndex = 7;
            DFilterLable.Text = "Дисциплина:";
            // 
            // DFilterBox
            // 
            DFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DFilterBox.Location = new Point(121, 424);
            DFilterBox.Name = "DFilterBox";
            DFilterBox.Size = new Size(185, 27);
            DFilterBox.TabIndex = 6;
            DFilterBox.Visible = false;
            DFilterBox.TextChanged += DFilterBox_TextChanged;
            // 
            // ReportComboBox
            // 
            ReportComboBox.FormattingEnabled = true;
            ReportComboBox.Items.AddRange(new object[] { "Списочный отчёт об успеваемости", "Оценки по дисциплинам", "Средний бал экзаменов", "Количество студентов на направлениях", "Количество дисциплин за преподавателем" });
            ReportComboBox.Location = new Point(8, 6);
            ReportComboBox.Name = "ReportComboBox";
            ReportComboBox.Size = new Size(298, 28);
            ReportComboBox.TabIndex = 2;
            ReportComboBox.SelectedIndexChanged += ReportComboBox_SelectedIndexChanged;
            // 
            // ReportDataGridView
            // 
            ReportDataGridView.AllowUserToAddRows = false;
            ReportDataGridView.AllowUserToOrderColumns = true;
            ReportDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ReportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportDataGridView.Location = new Point(312, 3);
            ReportDataGridView.Name = "ReportDataGridView";
            ReportDataGridView.RowTemplate.Height = 25;
            ReportDataGridView.Size = new Size(760, 396);
            ReportDataGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 450);
            Controls.Add(MainControl);
            KeyPreview = true;
            Name = "MainForm";
            Text = "Успеваемость студентов";
            Mark.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MarkdataGridView).EndInit();
            Professor.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProfdataGridView).EndInit();
            Discipline.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DisdataGridView).EndInit();
            Specialty.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SpdataGridView).EndInit();
            RecordBook.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RB_DataGridView).EndInit();
            MainControl.ResumeLayout(false);
            ReportPage.ResumeLayout(false);
            ReportPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList IconImageList;
        private TabPage Mark;
        private SplitContainer splitContainer5;
        private Label label9;
        private TextBox MarkNameFilterBox;
        private Label label10;
        private TextBox MarkCodeFilterBox;
        private DataGridView MarkdataGridView;
        private TabPage Professor;
        private SplitContainer splitContainer4;
        private Label label7;
        private TextBox ProfNameFilterBox;
        private Label label8;
        private TextBox ProfCodeFilterBox;
        private DataGridView ProfdataGridView;
        private TabPage Discipline;
        private SplitContainer splitContainer3;
        private Label label4;
        private TextBox DisProfessorFilterBox;
        private Label label5;
        private TextBox DisNameFilterBox;
        private Label label6;
        private TextBox DisCodeFilterBox;
        private DataGridView DisdataGridView;
        private TabPage Specialty;
        private SplitContainer splitContainer2;
        private Label label2;
        private TextBox SpNameFilterBox;
        private Label label3;
        private TextBox SpCodeFilterBox;
        private DataGridView SpdataGridView;
        private TabPage RecordBook;
        private SplitContainer splitContainer1;
        private Label DisciplineFilterLabel;
        private TextBox DisciplineFilterBox;
        private Label NameFilterLabel;
        private TextBox NameFilterBox;
        private Label CodeFilterLabel;
        private TextBox CodeFilterBox;
        private DataGridView RB_DataGridView;
        private TabControl MainControl;
        private TabPage ReportPage;
        private ComboBox ReportComboBox;
        private DataGridView ReportDataGridView;
        private Label DFilterLable;
        private TextBox DFilterBox;
        private TextBox SFilterBox;
        private Label MFilterLable;
        private TextBox MFilterBox;
        private DataGridViewTextBoxColumn _PP_Code;
        private DataGridViewTextBoxColumn _PName;
        private DataGridViewTextBoxColumn _MM_Code;
        private DataGridViewTextBoxColumn _MName;
        private DataGridViewTextBoxColumn _SS_Code;
        private DataGridViewTextBoxColumn _SName;
        private DataGridViewTextBoxColumn _RRB_Code;
        private DataGridViewTextBoxColumn _RName;
        private DataGridViewTextBoxColumn _RSpecialtyName;
        private TextBox FIO_FilterBox;
        private Label FIO_FilterLabel;
        private DataGridViewTextBoxColumn _DD_Code;
        private DataGridViewTextBoxColumn _DName;
        private DataGridViewTextBoxColumn _DProfessorName;
        private DataGridViewTextBoxColumn _DFK_Professor;
    }
}