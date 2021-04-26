
namespace CustCar0415.UI
{
    partial class DealView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dealSmListView = new System.Windows.Forms.ListView();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.dealSmExit = new Sunny.UI.UISymbolButton();
            this.dealSmCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmSellName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmRealPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dealSmListView
            // 
            this.dealSmListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dealSmCount,
            this.dealSmModel,
            this.dealSmPrice,
            this.dealSmCustName,
            this.dealSmSellName,
            this.dealSmDate,
            this.dealSmRealPrice});
            this.dealSmListView.FullRowSelect = true;
            this.dealSmListView.HideSelection = false;
            this.dealSmListView.Location = new System.Drawing.Point(33, 95);
            this.dealSmListView.Name = "dealSmListView";
            this.dealSmListView.Size = new System.Drawing.Size(728, 178);
            this.dealSmListView.TabIndex = 0;
            this.dealSmListView.UseCompatibleStateImageBehavior = false;
            this.dealSmListView.View = System.Windows.Forms.View.Details;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(33, 296);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.uiDataGridView1.RowTemplate.Height = 29;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = true;
            this.uiDataGridView1.Size = new System.Drawing.Size(728, 178);
            this.uiDataGridView1.TabIndex = 1;
            // 
            // dealSmExit
            // 
            this.dealSmExit.BackColor = System.Drawing.Color.Transparent;
            this.dealSmExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealSmExit.FillColor = System.Drawing.Color.Red;
            this.dealSmExit.FillHoverColor = System.Drawing.Color.Transparent;
            this.dealSmExit.FillPressColor = System.Drawing.Color.Transparent;
            this.dealSmExit.FillSelectedColor = System.Drawing.Color.Transparent;
            this.dealSmExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dealSmExit.IsCircle = true;
            this.dealSmExit.Location = new System.Drawing.Point(702, 28);
            this.dealSmExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.dealSmExit.Name = "dealSmExit";
            this.dealSmExit.RectColor = System.Drawing.Color.OrangeRed;
            this.dealSmExit.RectDisableColor = System.Drawing.Color.Transparent;
            this.dealSmExit.RectHoverColor = System.Drawing.Color.Transparent;
            this.dealSmExit.Size = new System.Drawing.Size(59, 48);
            this.dealSmExit.Style = Sunny.UI.UIStyle.Custom;
            this.dealSmExit.Symbol = 61453;
            this.dealSmExit.SymbolSize = 35;
            this.dealSmExit.TabIndex = 2;
            this.dealSmExit.Click += new System.EventHandler(this.dealSmExit_Click);
            // 
            // dealSmCount
            // 
            this.dealSmCount.Text = "번호";
            this.dealSmCount.Width = 70;
            // 
            // dealSmModel
            // 
            this.dealSmModel.Text = "차종";
            this.dealSmModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dealSmModel.Width = 110;
            // 
            // dealSmPrice
            // 
            this.dealSmPrice.Text = "차량가격";
            this.dealSmPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dealSmPrice.Width = 115;
            // 
            // dealSmCustName
            // 
            this.dealSmCustName.Text = "구매고객";
            this.dealSmCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dealSmCustName.Width = 90;
            // 
            // dealSmSellName
            // 
            this.dealSmSellName.Text = "판매자";
            this.dealSmSellName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dealSmSellName.Width = 110;
            // 
            // dealSmDate
            // 
            this.dealSmDate.Text = "거래일";
            this.dealSmDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dealSmDate.Width = 110;
            // 
            // dealSmRealPrice
            // 
            this.dealSmRealPrice.Text = "실거래가";
            this.dealSmRealPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dealSmRealPrice.Width = 115;
            // 
            // DealView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.dealSmExit);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.dealSmListView);
            this.Name = "DealView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DealView";
            this.Load += new System.EventHandler(this.DealView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dealSmListView;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UISymbolButton dealSmExit;
        private System.Windows.Forms.ColumnHeader dealSmCount;
        private System.Windows.Forms.ColumnHeader dealSmModel;
        private System.Windows.Forms.ColumnHeader dealSmPrice;
        private System.Windows.Forms.ColumnHeader dealSmCustName;
        private System.Windows.Forms.ColumnHeader dealSmSellName;
        private System.Windows.Forms.ColumnHeader dealSmDate;
        private System.Windows.Forms.ColumnHeader dealSmRealPrice;
    }
}