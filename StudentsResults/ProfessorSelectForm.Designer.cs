namespace StudentsResults
{
    partial class ProfessorSelectForm
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
            label7 = new Label();
            ProfNameFilterBox = new TextBox();
            label8 = new Label();
            ProfCodeFilterBox = new TextBox();
            ProfdataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProfdataGridView).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 69);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 8;
            label7.Text = "ФИО:";
            // 
            // ProfNameFilterBox
            // 
            ProfNameFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ProfNameFilterBox.Location = new Point(121, 66);
            ProfNameFilterBox.Name = "ProfNameFilterBox";
            ProfNameFilterBox.Size = new Size(131, 27);
            ProfNameFilterBox.TabIndex = 7;
            ProfNameFilterBox.TextChanged += ProfNameFilterBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 36);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 6;
            label8.Text = "Код:";
            // 
            // ProfCodeFilterBox
            // 
            ProfCodeFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ProfCodeFilterBox.Location = new Point(121, 33);
            ProfCodeFilterBox.Name = "ProfCodeFilterBox";
            ProfCodeFilterBox.Size = new Size(132, 27);
            ProfCodeFilterBox.TabIndex = 4;
            ProfCodeFilterBox.TextChanged += ProfCodeFilterBox_TextChanged;
            // 
            // ProfdataGridView
            // 
            ProfdataGridView.AllowUserToAddRows = false;
            ProfdataGridView.AllowUserToDeleteRows = false;
            ProfdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ProfdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProfdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProfdataGridView.Location = new Point(259, -1);
            ProfdataGridView.Name = "ProfdataGridView";
            ProfdataGridView.ReadOnly = true;
            ProfdataGridView.RowTemplate.Height = 25;
            ProfdataGridView.Size = new Size(542, 451);
            ProfdataGridView.TabIndex = 5;
            ProfdataGridView.CellClick += ProfdataGridView_CellClick;
            // 
            // ProfessorSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(ProfNameFilterBox);
            Controls.Add(label8);
            Controls.Add(ProfCodeFilterBox);
            Controls.Add(ProfdataGridView);
            Name = "ProfessorSelectForm";
            Text = "Выберете преподавателя";
            ((System.ComponentModel.ISupportInitialize)ProfdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox ProfNameFilterBox;
        private Label label8;
        private TextBox ProfCodeFilterBox;
        private DataGridView ProfdataGridView;
    }
}