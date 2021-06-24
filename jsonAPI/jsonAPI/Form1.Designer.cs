
namespace jsonAPI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_write = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_sabeon = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_sabeon = new System.Windows.Forms.TextBox();
            this.button_open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_json_api = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.drwtNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwtNo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwtNo3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwtNo4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwtNo5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwtNo6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnusNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drwNoDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lottoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabeonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sabeonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(455, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(514, 45);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(98, 23);
            this.button_write.TabIndex = 1;
            this.button_write.Text = "데이터 추가";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(514, 107);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(101, 23);
            this.button_read.TabIndex = 2;
            this.button_read.Text = "데이터 읽기";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(631, 48);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "이름";
            // 
            // label_sabeon
            // 
            this.label_sabeon.AutoSize = true;
            this.label_sabeon.Location = new System.Drawing.Point(631, 85);
            this.label_sabeon.Name = "label_sabeon";
            this.label_sabeon.Size = new System.Drawing.Size(29, 12);
            this.label_sabeon.TabIndex = 4;
            this.label_sabeon.Text = "사번";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(707, 45);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_sabeon
            // 
            this.textBox_sabeon.Location = new System.Drawing.Point(707, 82);
            this.textBox_sabeon.Name = "textBox_sabeon";
            this.textBox_sabeon.Size = new System.Drawing.Size(100, 21);
            this.textBox_sabeon.TabIndex = 6;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(514, 136);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(101, 20);
            this.button_open.TabIndex = 7;
            this.button_open.Text = "dialog";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_json_api
            // 
            this.button_json_api.Location = new System.Drawing.Point(269, 413);
            this.button_json_api.Name = "button_json_api";
            this.button_json_api.Size = new System.Drawing.Size(109, 20);
            this.button_json_api.TabIndex = 7;
            this.button_json_api.Text = "json_api";
            this.button_json_api.UseVisualStyleBackColor = true;
            this.button_json_api.Click += new System.EventHandler(this.button_json_api_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drwtNo1DataGridViewTextBoxColumn,
            this.drwtNo2DataGridViewTextBoxColumn,
            this.drwtNo3DataGridViewTextBoxColumn,
            this.drwtNo4DataGridViewTextBoxColumn,
            this.drwtNo5DataGridViewTextBoxColumn,
            this.drwtNo6DataGridViewTextBoxColumn,
            this.bnusNoDataGridViewTextBoxColumn,
            this.drwNoDataGridViewTextBoxColumn,
            this.drwNoDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lottoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(22, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(590, 164);
            this.dataGridView2.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(633, 122);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(395, 345);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // drwtNo1DataGridViewTextBoxColumn
            // 
            this.drwtNo1DataGridViewTextBoxColumn.DataPropertyName = "drwtNo1";
            this.drwtNo1DataGridViewTextBoxColumn.HeaderText = "drwtNo1";
            this.drwtNo1DataGridViewTextBoxColumn.Name = "drwtNo1DataGridViewTextBoxColumn";
            this.drwtNo1DataGridViewTextBoxColumn.Width = 50;
            // 
            // drwtNo2DataGridViewTextBoxColumn
            // 
            this.drwtNo2DataGridViewTextBoxColumn.DataPropertyName = "drwtNo2";
            this.drwtNo2DataGridViewTextBoxColumn.HeaderText = "drwtNo2";
            this.drwtNo2DataGridViewTextBoxColumn.Name = "drwtNo2DataGridViewTextBoxColumn";
            this.drwtNo2DataGridViewTextBoxColumn.Width = 50;
            // 
            // drwtNo3DataGridViewTextBoxColumn
            // 
            this.drwtNo3DataGridViewTextBoxColumn.DataPropertyName = "drwtNo3";
            this.drwtNo3DataGridViewTextBoxColumn.HeaderText = "drwtNo3";
            this.drwtNo3DataGridViewTextBoxColumn.Name = "drwtNo3DataGridViewTextBoxColumn";
            this.drwtNo3DataGridViewTextBoxColumn.Width = 50;
            // 
            // drwtNo4DataGridViewTextBoxColumn
            // 
            this.drwtNo4DataGridViewTextBoxColumn.DataPropertyName = "drwtNo4";
            this.drwtNo4DataGridViewTextBoxColumn.HeaderText = "drwtNo4";
            this.drwtNo4DataGridViewTextBoxColumn.Name = "drwtNo4DataGridViewTextBoxColumn";
            this.drwtNo4DataGridViewTextBoxColumn.Width = 50;
            // 
            // drwtNo5DataGridViewTextBoxColumn
            // 
            this.drwtNo5DataGridViewTextBoxColumn.DataPropertyName = "drwtNo5";
            this.drwtNo5DataGridViewTextBoxColumn.HeaderText = "drwtNo5";
            this.drwtNo5DataGridViewTextBoxColumn.Name = "drwtNo5DataGridViewTextBoxColumn";
            this.drwtNo5DataGridViewTextBoxColumn.Width = 50;
            // 
            // drwtNo6DataGridViewTextBoxColumn
            // 
            this.drwtNo6DataGridViewTextBoxColumn.DataPropertyName = "drwtNo6";
            this.drwtNo6DataGridViewTextBoxColumn.HeaderText = "drwtNo6";
            this.drwtNo6DataGridViewTextBoxColumn.Name = "drwtNo6DataGridViewTextBoxColumn";
            this.drwtNo6DataGridViewTextBoxColumn.Width = 50;
            // 
            // bnusNoDataGridViewTextBoxColumn
            // 
            this.bnusNoDataGridViewTextBoxColumn.DataPropertyName = "bnusNo";
            this.bnusNoDataGridViewTextBoxColumn.HeaderText = "bnusNo";
            this.bnusNoDataGridViewTextBoxColumn.Name = "bnusNoDataGridViewTextBoxColumn";
            this.bnusNoDataGridViewTextBoxColumn.Width = 50;
            // 
            // drwNoDataGridViewTextBoxColumn
            // 
            this.drwNoDataGridViewTextBoxColumn.DataPropertyName = "drwNo";
            this.drwNoDataGridViewTextBoxColumn.HeaderText = "drwNo";
            this.drwNoDataGridViewTextBoxColumn.Name = "drwNoDataGridViewTextBoxColumn";
            // 
            // drwNoDateDataGridViewTextBoxColumn
            // 
            this.drwNoDateDataGridViewTextBoxColumn.DataPropertyName = "drwNoDate";
            this.drwNoDateDataGridViewTextBoxColumn.HeaderText = "drwNoDate";
            this.drwNoDateDataGridViewTextBoxColumn.Name = "drwNoDateDataGridViewTextBoxColumn";
            // 
            // lottoBindingSource
            // 
            this.lottoBindingSource.DataSource = typeof(jsonAPI.Lotto);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sabeonDataGridViewTextBoxColumn
            // 
            this.sabeonDataGridViewTextBoxColumn.DataPropertyName = "sabeon";
            this.sabeonDataGridViewTextBoxColumn.HeaderText = "sabeon";
            this.sabeonDataGridViewTextBoxColumn.Name = "sabeonDataGridViewTextBoxColumn";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(jsonAPI.Doctor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 479);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_json_api);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.textBox_sabeon);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_sabeon);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.button_write);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lottoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabeonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_sabeon;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_sabeon;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_json_api;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource lottoBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwtNo6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnusNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drwNoDateDataGridViewTextBoxColumn;
    }
}

