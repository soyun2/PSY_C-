
namespace readCSV
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_readcsv = new System.Windows.Forms.Button();
            this.button_writeCSV = new System.Windows.Forms.Button();
            this.label_contents = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_age = new System.Windows.Forms.TextBox();
            this.tB_hakbeon = new System.Windows.Forms.TextBox();
            this.tB_hakgwa = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_hakbeon = new System.Windows.Forms.Label();
            this.label_hakgwa = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hakbeonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hakgwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGridviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_readcsv
            // 
            this.button_readcsv.Location = new System.Drawing.Point(31, 24);
            this.button_readcsv.Name = "button_readcsv";
            this.button_readcsv.Size = new System.Drawing.Size(120, 35);
            this.button_readcsv.TabIndex = 0;
            this.button_readcsv.Text = "CSV 읽기";
            this.button_readcsv.UseVisualStyleBackColor = true;
            this.button_readcsv.Click += new System.EventHandler(this.button_readcsv_Click);
            // 
            // button_writeCSV
            // 
            this.button_writeCSV.Location = new System.Drawing.Point(178, 26);
            this.button_writeCSV.Name = "button_writeCSV";
            this.button_writeCSV.Size = new System.Drawing.Size(111, 32);
            this.button_writeCSV.TabIndex = 1;
            this.button_writeCSV.Text = "CSV 쓰기";
            this.button_writeCSV.UseVisualStyleBackColor = true;
            this.button_writeCSV.Click += new System.EventHandler(this.button_writeCSV_Click);
            // 
            // label_contents
            // 
            this.label_contents.AutoSize = true;
            this.label_contents.Location = new System.Drawing.Point(31, 75);
            this.label_contents.Name = "label_contents";
            this.label_contents.Size = new System.Drawing.Size(11, 12);
            this.label_contents.TabIndex = 2;
            this.label_contents.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.hakbeonDataGridViewTextBoxColumn,
            this.hakgwaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentGridviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(648, 237);
            this.dataGridView1.TabIndex = 3;
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(402, 26);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(100, 21);
            this.tB_name.TabIndex = 4;
            // 
            // tB_age
            // 
            this.tB_age.Location = new System.Drawing.Point(402, 54);
            this.tB_age.Name = "tB_age";
            this.tB_age.Size = new System.Drawing.Size(100, 21);
            this.tB_age.TabIndex = 5;
            // 
            // tB_hakbeon
            // 
            this.tB_hakbeon.Location = new System.Drawing.Point(402, 82);
            this.tB_hakbeon.Name = "tB_hakbeon";
            this.tB_hakbeon.Size = new System.Drawing.Size(100, 21);
            this.tB_hakbeon.TabIndex = 6;
            // 
            // tB_hakgwa
            // 
            this.tB_hakgwa.Location = new System.Drawing.Point(402, 110);
            this.tB_hakgwa.Name = "tB_hakgwa";
            this.tB_hakgwa.Size = new System.Drawing.Size(100, 21);
            this.tB_hakgwa.TabIndex = 7;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(349, 29);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "이름";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(349, 57);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(29, 12);
            this.label_age.TabIndex = 9;
            this.label_age.Text = "나이";
            // 
            // label_hakbeon
            // 
            this.label_hakbeon.AutoSize = true;
            this.label_hakbeon.Location = new System.Drawing.Point(349, 85);
            this.label_hakbeon.Name = "label_hakbeon";
            this.label_hakbeon.Size = new System.Drawing.Size(29, 12);
            this.label_hakbeon.TabIndex = 9;
            this.label_hakbeon.Text = "학번";
            // 
            // label_hakgwa
            // 
            this.label_hakgwa.AutoSize = true;
            this.label_hakgwa.Location = new System.Drawing.Point(349, 113);
            this.label_hakgwa.Name = "label_hakgwa";
            this.label_hakgwa.Size = new System.Drawing.Size(29, 12);
            this.label_hakgwa.TabIndex = 9;
            this.label_hakgwa.Text = "학과";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hakbeonDataGridViewTextBoxColumn
            // 
            this.hakbeonDataGridViewTextBoxColumn.DataPropertyName = "hakbeon";
            this.hakbeonDataGridViewTextBoxColumn.HeaderText = "hakbeon";
            this.hakbeonDataGridViewTextBoxColumn.Name = "hakbeonDataGridViewTextBoxColumn";
            this.hakbeonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hakgwaDataGridViewTextBoxColumn
            // 
            this.hakgwaDataGridViewTextBoxColumn.DataPropertyName = "hakgwa";
            this.hakgwaDataGridViewTextBoxColumn.HeaderText = "hakgwa";
            this.hakgwaDataGridViewTextBoxColumn.Name = "hakgwaDataGridViewTextBoxColumn";
            this.hakgwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentGridviewBindingSource
            // 
            this.studentGridviewBindingSource.DataSource = typeof(readCSV.Student_Gridview);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_hakgwa);
            this.Controls.Add(this.label_hakbeon);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.tB_hakgwa);
            this.Controls.Add(this.tB_hakbeon);
            this.Controls.Add(this.tB_age);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_contents);
            this.Controls.Add(this.button_writeCSV);
            this.Controls.Add(this.button_readcsv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_readcsv;
        private System.Windows.Forms.Button button_writeCSV;
        private System.Windows.Forms.Label label_contents;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakbeonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakgwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentGridviewBindingSource;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_age;
        private System.Windows.Forms.TextBox tB_hakbeon;
        private System.Windows.Forms.TextBox tB_hakgwa;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_hakbeon;
        private System.Windows.Forms.Label label_hakgwa;
    }
}

