
namespace readCSV
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
            this.button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.daeguBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.daeguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daeguBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upjongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jibunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daeguBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daeguBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daeguBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button.Location = new System.Drawing.Point(223, 21);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(346, 44);
            this.button.TabIndex = 1;
            this.button.Text = "대구 상권 조회";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.upjongDataGridViewTextBoxColumn,
            this.sidoDataGridViewTextBoxColumn,
            this.jibunDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.daeguBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(51, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(705, 340);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // daeguBindingSource2
            // 
            this.daeguBindingSource2.DataSource = typeof(readCSV.Daegu);
            // 
            // daeguBindingSource
            // 
            this.daeguBindingSource.DataSource = typeof(readCSV.Daegu);
            // 
            // daeguBindingSource1
            // 
            this.daeguBindingSource1.DataSource = typeof(readCSV.Daegu);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(readCSV.Student);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // upjongDataGridViewTextBoxColumn
            // 
            this.upjongDataGridViewTextBoxColumn.DataPropertyName = "upjong";
            this.upjongDataGridViewTextBoxColumn.HeaderText = "upjong";
            this.upjongDataGridViewTextBoxColumn.Name = "upjongDataGridViewTextBoxColumn";
            // 
            // sidoDataGridViewTextBoxColumn
            // 
            this.sidoDataGridViewTextBoxColumn.DataPropertyName = "sido";
            this.sidoDataGridViewTextBoxColumn.HeaderText = "sido";
            this.sidoDataGridViewTextBoxColumn.Name = "sidoDataGridViewTextBoxColumn";
            // 
            // jibunDataGridViewTextBoxColumn
            // 
            this.jibunDataGridViewTextBoxColumn.DataPropertyName = "jibun";
            this.jibunDataGridViewTextBoxColumn.HeaderText = "jibun";
            this.jibunDataGridViewTextBoxColumn.Name = "jibunDataGridViewTextBoxColumn";
            this.jibunDataGridViewTextBoxColumn.Width = 300;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daeguBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daeguBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daeguBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.BindingSource daeguBindingSource;
        private System.Windows.Forms.BindingSource daeguBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource daeguBindingSource2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upjongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jibunDataGridViewTextBoxColumn;
    }
}