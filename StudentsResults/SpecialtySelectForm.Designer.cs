namespace StudentsResults
{
    partial class SpecialtySelectForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            SpdataGridView = new DataGridView();
            label2 = new Label();
            SpNameFilterBox = new TextBox();
            label3 = new Label();
            SpCodeFilterBox = new TextBox();
            _SS_Code = new DataGridViewTextBoxColumn();
            _SName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)SpdataGridView).BeginInit();
            SuspendLayout();
            // 
            // SpdataGridView
            // 
            SpdataGridView.AllowUserToAddRows = false;
            SpdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SpdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SpdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SpdataGridView.Columns.AddRange(new DataGridViewColumn[] { _SS_Code, _SName });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            SpdataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            SpdataGridView.Location = new Point(253, 12);
            SpdataGridView.Name = "SpdataGridView";
            SpdataGridView.RowTemplate.Height = 25;
            SpdataGridView.Size = new Size(555, 438);
            SpdataGridView.TabIndex = 4;
            SpdataGridView.CellDoubleClick += SpdataGridView_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(-4, 48);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 8;
            label2.Text = "Наименование:";
            // 
            // SpNameFilterBox
            // 
            SpNameFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SpNameFilterBox.Location = new Point(116, 45);
            SpNameFilterBox.Name = "SpNameFilterBox";
            SpNameFilterBox.Size = new Size(131, 27);
            SpNameFilterBox.TabIndex = 7;
            SpNameFilterBox.TextChanged += SpNameFilterBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(-4, 15);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 6;
            label3.Text = "Код:";
            // 
            // SpCodeFilterBox
            // 
            SpCodeFilterBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SpCodeFilterBox.Location = new Point(115, 12);
            SpCodeFilterBox.Name = "SpCodeFilterBox";
            SpCodeFilterBox.Size = new Size(132, 27);
            SpCodeFilterBox.TabIndex = 5;
            SpCodeFilterBox.TextChanged += SpCodeFilterBox_TextChanged;
            // 
            // _SS_Code
            // 
            _SS_Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            _SS_Code.HeaderText = "Код";
            _SS_Code.Name = "_SS_Code";
            _SS_Code.ReadOnly = true;
            _SS_Code.Width = 52;
            // 
            // _SName
            // 
            _SName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _SName.HeaderText = "Наименование";
            _SName.Name = "_SName";
            _SName.ReadOnly = true;
            // 
            // SpecialtySelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SpdataGridView);
            Controls.Add(label2);
            Controls.Add(SpNameFilterBox);
            Controls.Add(label3);
            Controls.Add(SpCodeFilterBox);
            Name = "SpecialtySelectForm";
            Text = "Выберете направление подготовки";
            ((System.ComponentModel.ISupportInitialize)SpdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SpdataGridView;
        private Label label2;
        private TextBox SpNameFilterBox;
        private Label label3;
        private TextBox SpCodeFilterBox;
        private DataGridViewTextBoxColumn _SS_Code;
        private DataGridViewTextBoxColumn _SName;
    }
}