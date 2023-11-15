namespace StudentsResults
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
            MainControl = new TabControl();
            MainMenu = new TabPage();
            RecordBook = new TabPage();
            splitContainer1 = new SplitContainer();
            DisciplineFilterLabel = new Label();
            DisciplineFilterBox = new TextBox();
            NameFilterLabel = new Label();
            NameFilterBox = new TextBox();
            CodeFilterLabel = new Label();
            CodeFilterBox = new TextBox();
            RB_DataGridView = new DataGridView();
            Specialty = new TabPage();
            Discipline = new TabPage();
            Professor = new TabPage();
            Mark = new TabPage();
            IconImageList = new ImageList(components);
            MainControl.SuspendLayout();
            RecordBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RB_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // MainControl
            // 
            MainControl.Controls.Add(MainMenu);
            MainControl.Controls.Add(RecordBook);
            MainControl.Controls.Add(Specialty);
            MainControl.Controls.Add(Discipline);
            MainControl.Controls.Add(Professor);
            MainControl.Controls.Add(Mark);
            MainControl.Dock = DockStyle.Fill;
            MainControl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MainControl.ImageList = IconImageList;
            MainControl.ItemSize = new Size(114, 40);
            MainControl.Location = new Point(0, 0);
            MainControl.Name = "MainControl";
            MainControl.SelectedIndex = 0;
            MainControl.Size = new Size(1083, 450);
            MainControl.TabIndex = 0;
            // 
            // MainMenu
            // 
            MainMenu.ImageIndex = 0;
            MainMenu.Location = new Point(4, 44);
            MainMenu.Name = "MainMenu";
            MainMenu.Padding = new Padding(3);
            MainMenu.Size = new Size(1075, 402);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "Главное меню";
            MainMenu.UseVisualStyleBackColor = true;
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
            DisciplineFilterLabel.Location = new Point(8, 102);
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
            NameFilterLabel.Location = new Point(8, 69);
            NameFilterLabel.Name = "NameFilterLabel";
            NameFilterLabel.Size = new Size(45, 20);
            NameFilterLabel.TabIndex = 3;
            NameFilterLabel.Text = "ФИО:";
            NameFilterLabel.Click += label1_Click;
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
            CodeFilterLabel.Location = new Point(8, 36);
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
            RB_DataGridView.AllowUserToAddRows = false;
            RB_DataGridView.AllowUserToDeleteRows = false;
            RB_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RB_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RB_DataGridView.Dock = DockStyle.Fill;
            RB_DataGridView.Location = new Point(0, 0);
            RB_DataGridView.Name = "RB_DataGridView";
            RB_DataGridView.ReadOnly = true;
            RB_DataGridView.RowTemplate.Height = 25;
            RB_DataGridView.Size = new Size(815, 402);
            RB_DataGridView.TabIndex = 0;
            RB_DataGridView.CellContentClick += RB_DataGridView_CellContentClick;
            // 
            // Specialty
            // 
            Specialty.ImageIndex = 2;
            Specialty.Location = new Point(4, 44);
            Specialty.Name = "Specialty";
            Specialty.Size = new Size(1075, 402);
            Specialty.TabIndex = 2;
            Specialty.Text = "Направления подготовки";
            Specialty.UseVisualStyleBackColor = true;
            // 
            // Discipline
            // 
            Discipline.ImageIndex = 3;
            Discipline.Location = new Point(4, 44);
            Discipline.Name = "Discipline";
            Discipline.Size = new Size(1075, 402);
            Discipline.TabIndex = 3;
            Discipline.Text = "Дисциплины";
            Discipline.UseVisualStyleBackColor = true;
            // 
            // Professor
            // 
            Professor.ImageIndex = 4;
            Professor.Location = new Point(4, 44);
            Professor.Name = "Professor";
            Professor.Size = new Size(1075, 402);
            Professor.TabIndex = 4;
            Professor.Text = "Преподаватели";
            Professor.UseVisualStyleBackColor = true;
            // 
            // Mark
            // 
            Mark.ImageIndex = 5;
            Mark.Location = new Point(4, 44);
            Mark.Name = "Mark";
            Mark.Size = new Size(1075, 402);
            Mark.TabIndex = 5;
            Mark.Text = "Виды оценок";
            Mark.UseVisualStyleBackColor = true;
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
            MainControl.ResumeLayout(false);
            RecordBook.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RB_DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainControl;
        private TabPage MainMenu;
        private TabPage RecordBook;
        private TabPage Specialty;
        private TabPage Discipline;
        private TabPage Professor;
        private TabPage Mark;
        private ImageList IconImageList;
        private DataGridView RB_DataGridView;
        private SplitContainer splitContainer1;
        private Label CodeFilterLabel;
        private TextBox CodeFilterBox;
        private Label NameFilterLabel;
        private TextBox NameFilterBox;
        private Label DisciplineFilterLabel;
        private TextBox DisciplineFilterBox;
    }
}