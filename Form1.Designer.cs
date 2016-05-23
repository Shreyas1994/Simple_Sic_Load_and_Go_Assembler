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
            this.dBDataSet = new WindowsFormsApplication1.DBDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApplication1.DBDataSetTableAdapters.tableTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableservedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servedTableAdapter = new WindowsFormsApplication1.DBDataSetTableAdapters.servedTableAdapter();
            this.billTableAdapter = new WindowsFormsApplication1.DBDataSetTableAdapters.BillTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableservedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "table";
            this.tableBindingSource.DataSource = this.dBDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.billBindingSource;
            this.listBox1.DisplayMember = "table_no";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(750, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 238);
            this.listBox1.TabIndex = 0;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.dBDataSet;
            // 
            // tableservedBindingSource
            // 
            this.tableservedBindingSource.DataMember = "tableserved";
            this.tableservedBindingSource.DataSource = this.tableBindingSource;
            // 
            // servedTableAdapter
            // 
            this.servedTableAdapter.ClearBeforeFill = true;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableservedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DBDataSetTableAdapters.tableTableAdapter tableTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource tableservedBindingSource;
        private DBDataSetTableAdapters.servedTableAdapter servedTableAdapter;
        private System.Windows.Forms.BindingSource billBindingSource;
        private DBDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

