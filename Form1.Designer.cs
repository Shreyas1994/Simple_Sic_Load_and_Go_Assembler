namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.SYMBOLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.opcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnemoniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSSEMBLERDataSet = new WindowsFormsApplication1.ASSEMBLERDataSet();
            this.mnemoniTableAdapter = new WindowsFormsApplication1.ASSEMBLERDataSetTableAdapters.MnemoniTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.aSSEMBLERDataSet1 = new WindowsFormsApplication1.ASSEMBLERDataSet1();
            this.readpgmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.read_pgmTableAdapter = new WindowsFormsApplication1.ASSEMBLERDataSet1TableAdapters.read_pgmTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnemoniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSEMBLERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSEMBLERDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readpgmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview1
            // 
            this.datagridview1.AllowUserToAddRows = false;
            this.datagridview1.AllowUserToDeleteRows = false;
            this.datagridview1.AllowUserToResizeColumns = false;
            this.datagridview1.AllowUserToResizeRows = false;
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagridview1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SYMBOLE,
            this.ADDRESS});
            this.datagridview1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridview1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datagridview1.Location = new System.Drawing.Point(12, 12);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.ReadOnly = true;
            this.datagridview1.RowHeadersVisible = false;
            this.datagridview1.Size = new System.Drawing.Size(169, 318);
            this.datagridview1.TabIndex = 1;
            this.datagridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SYMBOLE
            // 
            this.SYMBOLE.HeaderText = "SYMBOLE";
            this.SYMBOLE.Name = "SYMBOLE";
            this.SYMBOLE.ReadOnly = true;
            this.SYMBOLE.Width = 83;
            // 
            // ADDRESS
            // 
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            this.ADDRESS.Width = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "FILE ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "select file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opcodeDataGridViewTextBoxColumn,
            this.valDataGridViewTextBoxColumn});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.DataSource = this.mnemoniBindingSource;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(737, -1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(171, 420);
            this.dataGridView2.TabIndex = 10;
            // 
            // opcodeDataGridViewTextBoxColumn
            // 
            this.opcodeDataGridViewTextBoxColumn.DataPropertyName = "opcode";
            this.opcodeDataGridViewTextBoxColumn.HeaderText = "opcode";
            this.opcodeDataGridViewTextBoxColumn.Name = "opcodeDataGridViewTextBoxColumn";
            this.opcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valDataGridViewTextBoxColumn
            // 
            this.valDataGridViewTextBoxColumn.DataPropertyName = "val";
            this.valDataGridViewTextBoxColumn.HeaderText = "val";
            this.valDataGridViewTextBoxColumn.Name = "valDataGridViewTextBoxColumn";
            this.valDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnemoniBindingSource
            // 
            this.mnemoniBindingSource.DataMember = "Mnemoni";
            this.mnemoniBindingSource.DataSource = this.aSSEMBLERDataSet;
            // 
            // aSSEMBLERDataSet
            // 
            this.aSSEMBLERDataSet.DataSetName = "ASSEMBLERDataSet";
            this.aSSEMBLERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mnemoniTableAdapter
            // 
            this.mnemoniTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // aSSEMBLERDataSet1
            // 
            this.aSSEMBLERDataSet1.DataSetName = "ASSEMBLERDataSet1";
            this.aSSEMBLERDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readpgmBindingSource
            // 
            this.readpgmBindingSource.DataMember = "read_pgm";
            this.readpgmBindingSource.DataSource = this.aSSEMBLERDataSet1;
            // 
            // read_pgmTableAdapter
            // 
            this.read_pgmTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(920, 431);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridview1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "SIC LOAD AND GO ASSEMBLER";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnemoniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSEMBLERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSEMBLERDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readpgmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYMBOLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ASSEMBLERDataSet aSSEMBLERDataSet;
        private System.Windows.Forms.BindingSource mnemoniBindingSource;
        private ASSEMBLERDataSetTableAdapters.MnemoniTableAdapter mnemoniTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valDataGridViewTextBoxColumn;
        private ASSEMBLERDataSet1 aSSEMBLERDataSet1;
        private System.Windows.Forms.BindingSource readpgmBindingSource;
        private ASSEMBLERDataSet1TableAdapters.read_pgmTableAdapter read_pgmTableAdapter;
    }
}

