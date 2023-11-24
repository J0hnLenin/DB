namespace StudentsResults
{
    partial class RB_Form
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
            Line_DataGridView = new DataGridView();
            L_Code = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            DisciplineName = new DataGridViewTextBoxColumn();
            MarkName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ProfessorName = new DataGridViewTextBoxColumn();
            M_Code = new DataGridViewTextBoxColumn();
            D_Code = new DataGridViewTextBoxColumn();
            SpecialtyNameLabel = new Label();
            SpecialtyNameBox = new TextBox();
            NameLabel = new Label();
            NameBox = new TextBox();
            CodeLabel = new Label();
            CodeBox = new TextBox();
            DisciplineCodeLabel = new Label();
            DisciplineCodeBox = new TextBox();
            TableLable = new Label();
            label1 = new Label();
            AVG_Ball = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Line_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // Line_DataGridView
            // 
            Line_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Line_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Line_DataGridView.Columns.AddRange(new DataGridViewColumn[] { L_Code, Number, DisciplineName, MarkName, Date, ProfessorName, M_Code, D_Code });
            Line_DataGridView.Dock = DockStyle.Bottom;
            Line_DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            Line_DataGridView.Location = new Point(0, 212);
            Line_DataGridView.Name = "Line_DataGridView";
            Line_DataGridView.RowTemplate.Height = 25;
            Line_DataGridView.Size = new Size(800, 278);
            Line_DataGridView.TabIndex = 0;
            Line_DataGridView.CellDoubleClick += Line_DataGridView_CellDoubleClick;
            Line_DataGridView.UserDeletedRow += Line_DataGridView_UserDeletedRow;
            // 
            // L_Code
            // 
            L_Code.HeaderText = "L_Code";
            L_Code.Name = "L_Code";
            L_Code.ReadOnly = true;
            L_Code.Visible = false;
            // 
            // Number
            // 
            Number.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Number.HeaderText = "№";
            Number.Name = "Number";
            Number.ReadOnly = true;
            Number.Width = 45;
            // 
            // DisciplineName
            // 
            DisciplineName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DisciplineName.HeaderText = "Дисциплина";
            DisciplineName.Name = "DisciplineName";
            DisciplineName.ReadOnly = true;
            DisciplineName.Width = 101;
            // 
            // MarkName
            // 
            MarkName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MarkName.HeaderText = "Оценка";
            MarkName.Name = "MarkName";
            MarkName.ReadOnly = true;
            MarkName.Width = 73;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Date.HeaderText = "Дата\nэкзамена";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 83;
            // 
            // ProfessorName
            // 
            ProfessorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProfessorName.HeaderText = "Преподаватель";
            ProfessorName.Name = "ProfessorName";
            ProfessorName.ReadOnly = true;
            // 
            // M_Code
            // 
            M_Code.HeaderText = "M_Code";
            M_Code.Name = "M_Code";
            M_Code.ReadOnly = true;
            M_Code.Visible = false;
            // 
            // D_Code
            // 
            D_Code.HeaderText = "D_Code";
            D_Code.Name = "D_Code";
            D_Code.ReadOnly = true;
            D_Code.Visible = false;
            // 
            // SpecialtyNameLabel
            // 
            SpecialtyNameLabel.AutoSize = true;
            SpecialtyNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SpecialtyNameLabel.Location = new Point(12, 87);
            SpecialtyNameLabel.Name = "SpecialtyNameLabel";
            SpecialtyNameLabel.Size = new Size(216, 20);
            SpecialtyNameLabel.TabIndex = 11;
            SpecialtyNameLabel.Text = "Наименование направления:";
            // 
            // SpecialtyNameBox
            // 
            SpecialtyNameBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SpecialtyNameBox.Location = new Point(236, 84);
            SpecialtyNameBox.Name = "SpecialtyNameBox";
            SpecialtyNameBox.ReadOnly = true;
            SpecialtyNameBox.Size = new Size(131, 27);
            SpecialtyNameBox.TabIndex = 10;
            SpecialtyNameBox.Click += SpecialtyNameBox_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(16, 17);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(45, 20);
            NameLabel.TabIndex = 9;
            NameLabel.Text = "ФИО:";
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(236, 14);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(460, 27);
            NameBox.TabIndex = 8;
            NameBox.Validated += NameBox_Validated;
            // 
            // CodeLabel
            // 
            CodeLabel.AutoSize = true;
            CodeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CodeLabel.Location = new Point(12, 50);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(172, 20);
            CodeLabel.TabIndex = 7;
            CodeLabel.Text = "Номер зачётной книги:";
            // 
            // CodeBox
            // 
            CodeBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CodeBox.Location = new Point(236, 47);
            CodeBox.Name = "CodeBox";
            CodeBox.ReadOnly = true;
            CodeBox.Size = new Size(132, 27);
            CodeBox.TabIndex = 6;
            // 
            // DisciplineCodeLabel
            // 
            DisciplineCodeLabel.AutoSize = true;
            DisciplineCodeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DisciplineCodeLabel.Location = new Point(12, 120);
            DisciplineCodeLabel.Name = "DisciplineCodeLabel";
            DisciplineCodeLabel.Size = new Size(135, 20);
            DisciplineCodeLabel.TabIndex = 13;
            DisciplineCodeLabel.Text = "Код направления:";
            // 
            // DisciplineCodeBox
            // 
            DisciplineCodeBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DisciplineCodeBox.Location = new Point(237, 117);
            DisciplineCodeBox.Name = "DisciplineCodeBox";
            DisciplineCodeBox.ReadOnly = true;
            DisciplineCodeBox.Size = new Size(131, 27);
            DisciplineCodeBox.TabIndex = 12;
            DisciplineCodeBox.Click += SpecialtyCodeBox_Click;
            // 
            // TableLable
            // 
            TableLable.AutoSize = true;
            TableLable.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TableLable.Location = new Point(16, 189);
            TableLable.Name = "TableLable";
            TableLable.Size = new Size(287, 20);
            TableLable.TabIndex = 14;
            TableLable.Text = "Результаты промежуточной аттестации:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 153);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 16;
            label1.Text = "Средний балл:";
            // 
            // AVG_Ball
            // 
            AVG_Ball.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AVG_Ball.Location = new Point(236, 150);
            AVG_Ball.Name = "AVG_Ball";
            AVG_Ball.ReadOnly = true;
            AVG_Ball.Size = new Size(131, 27);
            AVG_Ball.TabIndex = 15;
            // 
            // RB_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(label1);
            Controls.Add(AVG_Ball);
            Controls.Add(TableLable);
            Controls.Add(DisciplineCodeLabel);
            Controls.Add(DisciplineCodeBox);
            Controls.Add(SpecialtyNameLabel);
            Controls.Add(SpecialtyNameBox);
            Controls.Add(NameLabel);
            Controls.Add(NameBox);
            Controls.Add(CodeLabel);
            Controls.Add(CodeBox);
            Controls.Add(Line_DataGridView);
            Name = "RB_Form";
            Text = "Зачётная книга";
            FormClosed += RB_Form_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Line_DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Line_DataGridView;
        private Label SpecialtyNameLabel;
        private TextBox SpecialtyNameBox;
        private Label NameLabel;
        private TextBox NameBox;
        private Label CodeLabel;
        private TextBox CodeBox;
        private Label DisciplineCodeLabel;
        private TextBox DisciplineCodeBox;
        private Label TableLable;
        private DataGridViewTextBoxColumn L_Code;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn DisciplineName;
        private DataGridViewTextBoxColumn MarkName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn ProfessorName;
        private DataGridViewTextBoxColumn M_Code;
        private DataGridViewTextBoxColumn D_Code;
        private Label label1;
        private TextBox AVG_Ball;
    }
}