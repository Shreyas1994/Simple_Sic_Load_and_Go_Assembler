namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
 /*       protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.aSSEMBLERDataSet1 = new WindowsFormsApplication1.ASSEMBLERDataSet1();
            this.readpgmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.read_pgmTableAdapter = new WindowsFormsApplication1.ASSEMBLERDataSet1TableAdapters.read_pgmTableAdapter();
            this.readpgmBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.readpgmBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sYMBOLTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSSEMBLERDataSet = new WindowsFormsApplication1.ASSEMBLERDataSet();
            this.sYMBOL_TABLETableAdapter = new WindowsFormsApplication1.ASSEMBLERDataSetTableAdapters.SYMBOL_TABLETableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.mnemoniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mnemoniTableAdapter = new WindowsFormsApplication1.ASSEMBLERDataSetTableAdapters.MnemoniTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aSSEMBLERDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readpgmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readpgmBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readpgmBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYMBOLTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSEMBLERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnemoniBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // readpgmBindingSource1
            // 
            this.readpgmBindingSource1.DataMember = "read_pgm";
            this.readpgmBindingSource1.DataSource = this.aSSEMBLERDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(462, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // readpgmBindingSource2
            // 
            this.readpgmBindingSource2.DataMember = "read_pgm";
            this.readpgmBindingSource2.DataSource = this.aSSEMBLERDataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(490, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView2.Size = new System.Drawing.Size(244, 304);
            this.dataGridView2.TabIndex = 2;
            // 
            // sYMBOLTABLEBindingSource
            // 
            this.sYMBOLTABLEBindingSource.DataMember = "SYMBOL TABLE";
            this.sYMBOLTABLEBindingSource.DataSource = this.aSSEMBLERDataSet;
            // 
            // aSSEMBLERDataSet
            // 
            this.aSSEMBLERDataSet.DataSetName = "ASSEMBLERDataSet";
            this.aSSEMBLERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sYMBOL_TABLETableAdapter
            // 
            this.sYMBOL_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(755, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.Size = new System.Drawing.Size(229, 365);
            this.dataGridView3.TabIndex = 3;
            // 
            // mnemoniBindingSource
            // 
            this.mnemoniBindingSource.DataMember = "Mnemoni";
            this.mnemoniBindingSource.DataSource = this.aSSEMBLERDataSet;
            // 
            // mnemoniTableAdapter
            // 
            this.mnemoniTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 511);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aSSEMBLERDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readpgmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readpgmBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readpgmBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYMBOLTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSEMBLERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnemoniBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ASSEMBLERDataSet1 aSSEMBLERDataSet1;
        private System.Windows.Forms.BindingSource readpgmBindingSource;
        private ASSEMBLERDataSet1TableAdapters.read_pgmTableAdapter read_pgmTableAdapter;
        private System.Windows.Forms.BindingSource readpgmBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private ASSEMBLERDataSet aSSEMBLERDataSet;
        private System.Windows.Forms.BindingSource sYMBOLTABLEBindingSource;
        private ASSEMBLERDataSetTableAdapters.SYMBOL_TABLETableAdapter sYMBOL_TABLETableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource mnemoniBindingSource;
        private ASSEMBLERDataSetTableAdapters.MnemoniTableAdapter mnemoniTableAdapter;
        public System.Windows.Forms.BindingSource readpgmBindingSource2;
        public System.Windows.Forms.DataGridView dataGridView2;
    }
}