namespace StudentsResults
{
    partial class MarkSelectForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            MarkdataGridView = new DataGridView();
            _MM_Code = new DataGridViewTextBoxColumn();
            _MName = new DataGridViewTextBoxColumn();
            label9 = new Label();
            MarkNameFilterBox = new TextBox();
            label10 = new Label();
            MarkCodeFilterBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)MarkdataGridView).BeginInit();
            SuspendLayout();
            // 
            // MarkdataGridView
            // 
            MarkdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MarkdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MarkdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MarkdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MarkdataGridView.Columns.AddRange(new DataGridViewColumn[] { _MM_Code, _MName });
            MarkdataGridView.Location = new Point(252, 1);
            MarkdataGridView.Name = "MarkdataGridView";
            MarkdataGridView.RowTemplate.Height = 25;
            MarkdataGridView.Size = new Size(546, 448);
            MarkdataGridView.TabIndex = 4;
            MarkdataGridView.CellDoubleClick += MarkdataGridView_CellDoubleClick;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(-4, 48);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 8;
            label9.Text = "Наименование:";
            // 
            // MarkNameFilterBox
            // 
            MarkNameFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MarkNameFilterBox.Location = new Point(114, 45);
            MarkNameFilterBox.Name = "MarkNameFilterBox";
            MarkNameFilterBox.Size = new Size(131, 27);
            MarkNameFilterBox.TabIndex = 7;
            MarkNameFilterBox.TextChanged += MarkNameFilterBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(-4, 15);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 6;
            label10.Text = "Код:";
            // 
            // MarkCodeFilterBox
            // 
            MarkCodeFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MarkCodeFilterBox.Location = new Point(114, 12);
            MarkCodeFilterBox.Name = "MarkCodeFilterBox";
            MarkCodeFilterBox.Size = new Size(132, 27);
            MarkCodeFilterBox.TabIndex = 5;
            MarkCodeFilterBox.TextChanged += MarkCodeFilterBox_TextChanged;
            // 
            // MarkSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MarkdataGridView);
            Controls.Add(label9);
            Controls.Add(MarkNameFilterBox);
            Controls.Add(label10);
            Controls.Add(MarkCodeFilterBox);
            Name = "MarkSelectForm";
            Text = "Выберете оценку";
            ((System.ComponentModel.ISupportInitialize)MarkdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MarkdataGridView;
        private DataGridViewTextBoxColumn _MM_Code;
        private DataGridViewTextBoxColumn _MName;
        private Label label9;
        private TextBox MarkNameFilterBox;
        private Label label10;
        private TextBox MarkCodeFilterBox;
    }
}