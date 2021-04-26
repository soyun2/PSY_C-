
namespace CustCar0415
{
    partial class MainWin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RandDataAdd = new Sunny.UI.UISymbolButton();
            this.RandDataDel = new Sunny.UI.UISymbolButton();
            this.DataView = new Sunny.UI.UISymbolButton();
            this.DataAdd = new Sunny.UI.UISymbolButton();
            this.DataUpdate = new Sunny.UI.UISymbolButton();
            this.DataDel = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.help = new Sunny.UI.UISymbolButton();
            this.mainTitle = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CustCar0415.Properties.Resources._977fc5b4e8a6c26e334581559d274df9;
            this.pictureBox1.Location = new System.Drawing.Point(12, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RandDataAdd
            // 
            this.RandDataAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandDataAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.RandDataAdd.Location = new System.Drawing.Point(477, 88);
            this.RandDataAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.RandDataAdd.Name = "RandDataAdd";
            this.RandDataAdd.Size = new System.Drawing.Size(179, 56);
            this.RandDataAdd.TabIndex = 1;
            this.RandDataAdd.Text = "랜덤 데이터 추가";
            this.RandDataAdd.Click += new System.EventHandler(this.RandDataAdd_Click);
            // 
            // RandDataDel
            // 
            this.RandDataDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandDataDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.RandDataDel.Location = new System.Drawing.Point(522, 160);
            this.RandDataDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.RandDataDel.Name = "RandDataDel";
            this.RandDataDel.Size = new System.Drawing.Size(179, 56);
            this.RandDataDel.TabIndex = 2;
            this.RandDataDel.Text = "랜덤 데이터 삭제";
            this.RandDataDel.Click += new System.EventHandler(this.RandDataDel_Click);
            // 
            // DataView
            // 
            this.DataView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DataView.Location = new System.Drawing.Point(588, 232);
            this.DataView.MinimumSize = new System.Drawing.Size(1, 1);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(179, 56);
            this.DataView.TabIndex = 3;
            this.DataView.Text = "데이터 보기";
            this.DataView.Click += new System.EventHandler(this.DataView_Click);
            // 
            // DataAdd
            // 
            this.DataAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DataAdd.Location = new System.Drawing.Point(588, 305);
            this.DataAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.DataAdd.Name = "DataAdd";
            this.DataAdd.Size = new System.Drawing.Size(179, 56);
            this.DataAdd.TabIndex = 4;
            this.DataAdd.Text = "데이터 추가";
            this.DataAdd.Click += new System.EventHandler(this.DataAdd_Click);
            // 
            // DataUpdate
            // 
            this.DataUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DataUpdate.Location = new System.Drawing.Point(522, 379);
            this.DataUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.DataUpdate.Name = "DataUpdate";
            this.DataUpdate.Size = new System.Drawing.Size(179, 56);
            this.DataUpdate.TabIndex = 5;
            this.DataUpdate.Text = "데이터 수정";
            this.DataUpdate.Click += new System.EventHandler(this.DataUpdate_Click);
            // 
            // DataDel
            // 
            this.DataDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DataDel.Location = new System.Drawing.Point(477, 451);
            this.DataDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.DataDel.Name = "DataDel";
            this.DataDel.Size = new System.Drawing.Size(179, 56);
            this.DataDel.TabIndex = 6;
            this.DataDel.Text = "데이터 삭제";
            this.DataDel.Click += new System.EventHandler(this.DataDel_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.OrangeRed;
            this.mainExit.FillDisableColor = System.Drawing.Color.Transparent;
            this.mainExit.FillHoverColor = System.Drawing.Color.Transparent;
            this.mainExit.FillPressColor = System.Drawing.Color.Transparent;
            this.mainExit.FillSelectedColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.ForeHoverColor = System.Drawing.Color.Black;
            this.mainExit.IsCircle = true;
            this.mainExit.Location = new System.Drawing.Point(731, 34);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.Size = new System.Drawing.Size(57, 48);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61457;
            this.mainExit.SymbolSize = 40;
            this.mainExit.TabIndex = 7;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.FillColor = System.Drawing.Color.Chartreuse;
            this.help.FillDisableColor = System.Drawing.Color.Transparent;
            this.help.FillHoverColor = System.Drawing.Color.Transparent;
            this.help.FillPressColor = System.Drawing.Color.Transparent;
            this.help.FillSelectedColor = System.Drawing.Color.Transparent;
            this.help.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.help.ForeColor = System.Drawing.Color.Black;
            this.help.IsCircle = true;
            this.help.Location = new System.Drawing.Point(668, 34);
            this.help.MinimumSize = new System.Drawing.Size(1, 1);
            this.help.Name = "help";
            this.help.RectColor = System.Drawing.Color.Transparent;
            this.help.Size = new System.Drawing.Size(57, 48);
            this.help.Style = Sunny.UI.UIStyle.Custom;
            this.help.Symbol = 61799;
            this.help.SymbolSize = 40;
            this.help.TabIndex = 8;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // mainTitle
            // 
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainTitle.ForeColor = System.Drawing.Color.LavenderBlush;
            this.mainTitle.Location = new System.Drawing.Point(-1, 23);
            this.mainTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(209, 35);
            this.mainTitle.Style = Sunny.UI.UIStyle.Custom;
            this.mainTitle.Symbol = 61881;
            this.mainTitle.SymbolColor = System.Drawing.Color.White;
            this.mainTitle.TabIndex = 9;
            this.mainTitle.Text = "고객 차량 관리 앱 v1.1";
            this.mainTitle.Click += new System.EventHandler(this.mainTitle_Click);
            // 
            // MainWin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.DataDel);
            this.Controls.Add(this.DataUpdate);
            this.Controls.Add(this.DataAdd);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.RandDataDel);
            this.Controls.Add(this.RandDataAdd);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton RandDataAdd;
        private Sunny.UI.UISymbolButton RandDataDel;
        private Sunny.UI.UISymbolButton DataView;
        private Sunny.UI.UISymbolButton DataAdd;
        private Sunny.UI.UISymbolButton DataUpdate;
        private Sunny.UI.UISymbolButton DataDel;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton help;
        private Sunny.UI.UISymbolLabel mainTitle;
    }
}

