
namespace ReadWriteXML
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
            this.button_readXML = new System.Windows.Forms.Button();
            this.button_writeXML = new System.Windows.Forms.Button();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_age = new System.Windows.Forms.TextBox();
            this.tB_hakbeon = new System.Windows.Forms.TextBox();
            this.tB_hakgwa = new System.Windows.Forms.TextBox();
            this.cB_gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_API = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.durNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durCompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hakbeonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hakgwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_readXML
            // 
            this.button_readXML.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.button_readXML.Location = new System.Drawing.Point(33, 242);
            this.button_readXML.Name = "button_readXML";
            this.button_readXML.Size = new System.Drawing.Size(75, 23);
            this.button_readXML.TabIndex = 1;
            this.button_readXML.Text = "읽기";
            this.button_readXML.UseVisualStyleBackColor = true;
            this.button_readXML.Click += new System.EventHandler(this.button_readXML_Click);
            // 
            // button_writeXML
            // 
            this.button_writeXML.Location = new System.Drawing.Point(168, 242);
            this.button_writeXML.Name = "button_writeXML";
            this.button_writeXML.Size = new System.Drawing.Size(75, 23);
            this.button_writeXML.TabIndex = 1;
            this.button_writeXML.Text = "쓰기";
            this.button_writeXML.UseVisualStyleBackColor = true;
            this.button_writeXML.Click += new System.EventHandler(this.button_writeXML_Click);
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(33, 283);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(131, 21);
            this.tB_name.TabIndex = 2;
            // 
            // tB_age
            // 
            this.tB_age.Location = new System.Drawing.Point(172, 283);
            this.tB_age.Name = "tB_age";
            this.tB_age.Size = new System.Drawing.Size(131, 21);
            this.tB_age.TabIndex = 2;
            // 
            // tB_hakbeon
            // 
            this.tB_hakbeon.Location = new System.Drawing.Point(314, 283);
            this.tB_hakbeon.Name = "tB_hakbeon";
            this.tB_hakbeon.Size = new System.Drawing.Size(131, 21);
            this.tB_hakbeon.TabIndex = 2;
            // 
            // tB_hakgwa
            // 
            this.tB_hakgwa.Location = new System.Drawing.Point(457, 283);
            this.tB_hakgwa.Name = "tB_hakgwa";
            this.tB_hakgwa.Size = new System.Drawing.Size(131, 21);
            this.tB_hakgwa.TabIndex = 2;
            // 
            // cB_gender
            // 
            this.cB_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_gender.FormattingEnabled = true;
            this.cB_gender.Items.AddRange(new object[] {
            "남",
            "여"});
            this.cB_gender.Location = new System.Drawing.Point(597, 283);
            this.cB_gender.Name = "cB_gender";
            this.cB_gender.Size = new System.Drawing.Size(121, 20);
            this.cB_gender.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "나이";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "학번";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "학과";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "성별";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.hakbeonDataGridViewTextBoxColumn,
            this.hakgwaDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(33, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(711, 215);
            this.dataGridView1.TabIndex = 6;
            // 
            // button_API
            // 
            this.button_API.Location = new System.Drawing.Point(33, 320);
            this.button_API.Name = "button_API";
            this.button_API.Size = new System.Drawing.Size(115, 23);
            this.button_API.TabIndex = 7;
            this.button_API.Text = "API당겨오기";
            this.button_API.UseVisualStyleBackColor = true;
            this.button_API.Click += new System.EventHandler(this.button_API_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.durNameDataGridViewTextBoxColumn,
            this.durIDDataGridViewTextBoxColumn,
            this.durCompDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.drugBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(33, 350);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(930, 309);
            this.dataGridView2.TabIndex = 8;
            // 
            // durNameDataGridViewTextBoxColumn
            // 
            this.durNameDataGridViewTextBoxColumn.DataPropertyName = "DurName";
            this.durNameDataGridViewTextBoxColumn.HeaderText = "DurName";
            this.durNameDataGridViewTextBoxColumn.Name = "durNameDataGridViewTextBoxColumn";
            // 
            // durIDDataGridViewTextBoxColumn
            // 
            this.durIDDataGridViewTextBoxColumn.DataPropertyName = "DurID";
            this.durIDDataGridViewTextBoxColumn.HeaderText = "DurID";
            this.durIDDataGridViewTextBoxColumn.Name = "durIDDataGridViewTextBoxColumn";
            // 
            // durCompDataGridViewTextBoxColumn
            // 
            this.durCompDataGridViewTextBoxColumn.DataPropertyName = "DurComp";
            this.durCompDataGridViewTextBoxColumn.HeaderText = "DurComp";
            this.durCompDataGridViewTextBoxColumn.Name = "durCompDataGridViewTextBoxColumn";
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataSource = typeof(ReadWriteXML.Drug);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "나이";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // hakbeonDataGridViewTextBoxColumn
            // 
            this.hakbeonDataGridViewTextBoxColumn.DataPropertyName = "hakbeon";
            this.hakbeonDataGridViewTextBoxColumn.HeaderText = "학번";
            this.hakbeonDataGridViewTextBoxColumn.Name = "hakbeonDataGridViewTextBoxColumn";
            // 
            // hakgwaDataGridViewTextBoxColumn
            // 
            this.hakgwaDataGridViewTextBoxColumn.DataPropertyName = "hakgwa";
            this.hakgwaDataGridViewTextBoxColumn.HeaderText = "학과";
            this.hakgwaDataGridViewTextBoxColumn.Name = "hakgwaDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "성별";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataSource = typeof(ReadWriteXML.Student);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(ReadWriteXML.Student);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 671);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_API);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cB_gender);
            this.Controls.Add(this.tB_hakgwa);
            this.Controls.Add(this.tB_hakbeon);
            this.Controls.Add(this.tB_age);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.button_writeXML);
            this.Controls.Add(this.button_readXML);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_readXML;
        private System.Windows.Forms.Button button_writeXML;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_age;
        private System.Windows.Forms.TextBox tB_hakbeon;
        private System.Windows.Forms.TextBox tB_hakgwa;
        private System.Windows.Forms.ComboBox cB_gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakbeonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakgwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_API;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn durNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durCompDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource drugBindingSource;
    }
}

