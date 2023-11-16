namespace StudentsResults
{
    partial class DisciplineSelectForm
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
            DisdataGridView = new DataGridView();
            label4 = new Label();
            DisProfessorFilterBox = new TextBox();
            label5 = new Label();
            DisNameFilterBox = new TextBox();
            label6 = new Label();
            DisCodeFilterBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DisdataGridView).BeginInit();
            SuspendLayout();
            // 
            // DisdataGridView
            // 
            DisdataGridView.AllowUserToAddRows = false;
            DisdataGridView.AllowUserToDeleteRows = false;
            DisdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DisdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisdataGridView.Location = new Point(280, 3);
            DisdataGridView.Name = "DisdataGridView";
            DisdataGridView.ReadOnly = true;
            DisdataGridView.RowTemplate.Height = 25;
            DisdataGridView.Size = new Size(617, 447);
            DisdataGridView.TabIndex = 6;
            DisdataGridView.CellClick += DisdataGridView_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 12;
            label4.Text = "Преподаватель:";
            // 
            // DisProfessorFilterBox
            // 
            DisProfessorFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DisProfessorFilterBox.Location = new Point(143, 83);
            DisProfessorFilterBox.Name = "DisProfessorFilterBox";
            DisProfessorFilterBox.Size = new Size(131, 27);
            DisProfessorFilterBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 53);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 10;
            label5.Text = "Наименование:";
            // 
            // DisNameFilterBox
            // 
            DisNameFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DisNameFilterBox.Location = new Point(142, 50);
            DisNameFilterBox.Name = "DisNameFilterBox";
            DisNameFilterBox.Size = new Size(131, 27);
            DisNameFilterBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 24);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 8;
            label6.Text = "Код:";
            // 
            // DisCodeFilterBox
            // 
            DisCodeFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DisCodeFilterBox.Location = new Point(142, 17);
            DisCodeFilterBox.Name = "DisCodeFilterBox";
            DisCodeFilterBox.Size = new Size(132, 27);
            DisCodeFilterBox.TabIndex = 7;
            // 
            // DisciplineSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(DisdataGridView);
            Controls.Add(label4);
            Controls.Add(DisProfessorFilterBox);
            Controls.Add(label5);
            Controls.Add(DisNameFilterBox);
            Controls.Add(label6);
            Controls.Add(DisCodeFilterBox);
            Name = "DisciplineSelectForm";
            Text = "Выберете дисциплину";
            ((System.ComponentModel.ISupportInitialize)DisdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DisdataGridView;
        private Label label4;
        private TextBox DisProfessorFilterBox;
        private Label label5;
        private TextBox DisNameFilterBox;
        private Label label6;
        private TextBox DisCodeFilterBox;
    }
}