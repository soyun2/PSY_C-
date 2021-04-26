﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dealSmListView = new System.Windows.Forms.ListView();
            this.dealSmCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmSellName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmRealPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmExit = new Sunny.UI.UISymbolButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
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
            this.dealSmListView.Location = new System.Drawing.Point(11, 100);
            this.dealSmListView.Name = "dealSmListView";
            this.dealSmListView.Size = new System.Drawing.Size(755, 154);
            this.dealSmListView.TabIndex = 1;
            this.dealSmListView.TileSize = new System.Drawing.Size(1, 1);
            this.dealSmListView.UseCompatibleStateImageBehavior = false;
            this.dealSmListView.View = System.Windows.Forms.View.Details;
            // 
            // dealSmCount
            // 
            this.dealSmCount.Text = "번호";
            this.dealSmCount.Width = 80;
            // 
            // dealSmModel
            // 
            this.dealSmModel.Text = "차종";
            this.dealSmModel.Width = 110;
            // 
            // dealSmPrice
            // 
            this.dealSmPrice.Text = "차량가격";
            this.dealSmPrice.Width = 110;
            // 
            // dealSmCustName
            // 
            this.dealSmCustName.Text = "구매고객";
            this.dealSmCustName.Width = 110;
            // 
            // dealSmSellName
            // 
            this.dealSmSellName.Text = "판매자";
            this.dealSmSellName.Width = 110;
            // 
            // dealSmDate
            // 
            this.dealSmDate.Text = "거래날짜";
            this.dealSmDate.Width = 110;
            // 
            // dealSmRealPrice
            // 
            this.dealSmRealPrice.Text = "실거래가";
            this.dealSmRealPrice.Width = 110;
            // 
            // dealSmExit
            // 
            this.dealSmExit.BackColor = System.Drawing.Color.Transparent;
            this.dealSmExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealSmExit.FillColor = System.Drawing.Color.Teal;
            this.dealSmExit.FillDisableColor = System.Drawing.Color.Red;
            this.dealSmExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dealSmExit.FillPressColor = System.Drawing.Color.BlanchedAlmond;
            this.dealSmExit.FillSelectedColor = System.Drawing.Color.Transparent;
            this.dealSmExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dealSmExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dealSmExit.ForeHoverColor = System.Drawing.Color.Red;
            this.dealSmExit.IsCircle = true;
            this.dealSmExit.Location = new System.Drawing.Point(733, 44);
            this.dealSmExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.dealSmExit.Name = "dealSmExit";
            this.dealSmExit.RectColor = System.Drawing.Color.Transparent;
            this.dealSmExit.RectHoverColor = System.Drawing.Color.Transparent;
            this.dealSmExit.RectPressColor = System.Drawing.Color.Transparent;
            this.dealSmExit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.dealSmExit.Size = new System.Drawing.Size(43, 40);
            this.dealSmExit.Style = Sunny.UI.UIStyle.Custom;
            this.dealSmExit.Symbol = 61453;
            this.dealSmExit.SymbolSize = 40;
            this.dealSmExit.TabIndex = 2;
            this.dealSmExit.Click += new System.EventHandler(this.dealSmExit_Click);
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(11, 282);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.RowTemplate.Height = 29;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = true;
            this.uiDataGridView1.Size = new System.Drawing.Size(755, 154);
            this.uiDataGridView1.TabIndex = 3;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(11, 257);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(143, 21);
            this.uiSymbolLabel2.Symbol = 61717;
            this.uiSymbolLabel2.TabIndex = 5;
            this.uiSymbolLabel2.Text = "거래상세 정보";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(11, 73);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(143, 21);
            this.uiSymbolLabel3.Symbol = 61717;
            this.uiSymbolLabel3.TabIndex = 6;
            this.uiSymbolLabel3.Text = "고객거래 정보";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(281, 32);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(233, 21);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61442;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiSymbolLabel1.TabIndex = 7;
            this.uiSymbolLabel1.Text = "차량 고객 관리 정보";
            // 
            // DealView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.dealSmExit);
            this.Controls.Add(this.dealSmListView);
            this.Name = "DealView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.DealView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView dealSmListView;
        private Sunny.UI.UISymbolButton dealSmExit;
        private System.Windows.Forms.ColumnHeader dealSmCount;
        private System.Windows.Forms.ColumnHeader dealSmModel;
        private System.Windows.Forms.ColumnHeader dealSmPrice;
        private System.Windows.Forms.ColumnHeader dealSmCustName;
        private System.Windows.Forms.ColumnHeader dealSmSellName;
        private System.Windows.Forms.ColumnHeader dealSmDate;
        private System.Windows.Forms.ColumnHeader dealSmRealPrice;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}