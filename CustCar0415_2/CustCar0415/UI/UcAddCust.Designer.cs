
namespace CustCar0415.UI
{
    partial class UcAddCust
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucAddCustWoman = new Sunny.UI.UIRadioButton();
            this.ucAddCustMan = new Sunny.UI.UIRadioButton();
            this.ucAddCustAddr = new Sunny.UI.UITextBox();
            this.ucAddCustTel = new Sunny.UI.UITextBox();
            this.ucAddCustAge = new Sunny.UI.UITextBox();
            this.ucAddCustName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.ucAddCustInit = new Sunny.UI.UISymbolButton();
            this.ucAddCustOk = new Sunny.UI.UISymbolButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // ucAddCustWoman
            // 
            this.ucAddCustWoman.BackColor = System.Drawing.Color.Transparent;
            this.ucAddCustWoman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCustWoman.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustWoman.Location = new System.Drawing.Point(457, 352);
            this.ucAddCustWoman.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustWoman.Name = "ucAddCustWoman";
            this.ucAddCustWoman.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ucAddCustWoman.RadioButtonColor = System.Drawing.Color.Teal;
            this.ucAddCustWoman.Size = new System.Drawing.Size(65, 34);
            this.ucAddCustWoman.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustWoman.TabIndex = 30;
            this.ucAddCustWoman.Text = "여";
            // ucAddCustMan
            // 
            this.ucAddCustMan.BackColor = System.Drawing.Color.Transparent;
            this.ucAddCustMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCustMan.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustMan.Location = new System.Drawing.Point(366, 352);
            this.ucAddCustMan.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustMan.Name = "ucAddCustMan";
            this.ucAddCustMan.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ucAddCustMan.RadioButtonColor = System.Drawing.Color.Teal;
            this.ucAddCustMan.Size = new System.Drawing.Size(65, 34);
            this.ucAddCustMan.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustMan.TabIndex = 31;
            this.ucAddCustMan.Text = "남";
            this.ucAddCustMan.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.ucAddCustMan_ValueChanged);
            // 
            // ucAddCustAddr
            // 
            this.ucAddCustAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustAddr.FillColor = System.Drawing.Color.White;
            this.ucAddCustAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustAddr.Location = new System.Drawing.Point(317, 302);
            this.ucAddCustAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustAddr.Maximum = 2147483647D;
            this.ucAddCustAddr.Minimum = -2147483648D;
            this.ucAddCustAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustAddr.Name = "ucAddCustAddr";
            this.ucAddCustAddr.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustAddr.RectColor = System.Drawing.Color.Teal;
            this.ucAddCustAddr.Size = new System.Drawing.Size(252, 29);
            this.ucAddCustAddr.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustAddr.TabIndex = 26;
            // 
            // ucAddCustTel
            // 
            this.ucAddCustTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustTel.FillColor = System.Drawing.Color.White;
            this.ucAddCustTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustTel.Location = new System.Drawing.Point(317, 250);
            this.ucAddCustTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustTel.Maximum = 2147483647D;
            this.ucAddCustTel.Minimum = -2147483648D;
            this.ucAddCustTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustTel.Name = "ucAddCustTel";
            this.ucAddCustTel.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustTel.RectColor = System.Drawing.Color.Teal;
            this.ucAddCustTel.Size = new System.Drawing.Size(252, 29);
            this.ucAddCustTel.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustTel.TabIndex = 27;
            // 
            // ucAddCustAge
            // 
            this.ucAddCustAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustAge.FillColor = System.Drawing.Color.White;
            this.ucAddCustAge.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustAge.Location = new System.Drawing.Point(317, 198);
            this.ucAddCustAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustAge.Maximum = 2147483647D;
            this.ucAddCustAge.Minimum = -2147483648D;
            this.ucAddCustAge.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustAge.Name = "ucAddCustAge";
            this.ucAddCustAge.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustAge.RectColor = System.Drawing.Color.Teal;
            this.ucAddCustAge.Size = new System.Drawing.Size(252, 29);
            this.ucAddCustAge.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustAge.TabIndex = 28;
            // 
            // ucAddCustName
            // 
            this.ucAddCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustName.FillColor = System.Drawing.Color.White;
            this.ucAddCustName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustName.Location = new System.Drawing.Point(317, 144);
            this.ucAddCustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustName.Maximum = 2147483647D;
            this.ucAddCustName.Minimum = -2147483648D;
            this.ucAddCustName.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustName.Name = "ucAddCustName";
            this.ucAddCustName.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustName.RectColor = System.Drawing.Color.Teal;
            this.ucAddCustName.Size = new System.Drawing.Size(252, 29);
            this.ucAddCustName.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustName.TabIndex = 29;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(169, 351);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(104, 35);
            this.uiSymbolLabel5.Symbol = 61543;
            this.uiSymbolLabel5.TabIndex = 21;
            this.uiSymbolLabel5.Text = "성   별";
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(169, 296);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(104, 35);
            this.uiSymbolLabel4.Symbol = 61543;
            this.uiSymbolLabel4.TabIndex = 22;
            this.uiSymbolLabel4.Text = "주   소";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(169, 244);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(104, 35);
            this.uiSymbolLabel3.Symbol = 61543;
            this.uiSymbolLabel3.TabIndex = 23;
            this.uiSymbolLabel3.Text = "전   화";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(169, 192);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(104, 35);
            this.uiSymbolLabel2.Symbol = 61543;
            this.uiSymbolLabel2.TabIndex = 24;
            this.uiSymbolLabel2.Text = "나   이";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(169, 138);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(104, 35);
            this.uiSymbolLabel1.Symbol = 61447;
            this.uiSymbolLabel1.TabIndex = 25;
            this.uiSymbolLabel1.Text = "이   름";
            // 
            // ucAddCustInit
            // 
            this.ucAddCustInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCustInit.FillColor = System.Drawing.Color.Teal;
            this.ucAddCustInit.FillHoverColor = System.Drawing.Color.Teal;
            this.ucAddCustInit.FillPressColor = System.Drawing.Color.Teal;
            this.ucAddCustInit.FillSelectedColor = System.Drawing.Color.Teal;
            this.ucAddCustInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustInit.Location = new System.Drawing.Point(374, 419);
            this.ucAddCustInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustInit.Name = "ucAddCustInit";
            this.ucAddCustInit.RectColor = System.Drawing.Color.Teal;
            this.ucAddCustInit.Size = new System.Drawing.Size(127, 36);
            this.ucAddCustInit.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustInit.Symbol = 61473;
            this.ucAddCustInit.TabIndex = 20;
            this.ucAddCustInit.Text = "초기화";
            this.ucAddCustInit.Click += new System.EventHandler(this.ucAddCustInit_Click);
            // 
            // ucAddCustOk
            // 
            this.ucAddCustOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCustOk.FillColor = System.Drawing.Color.Teal;
            this.ucAddCustOk.FillHoverColor = System.Drawing.Color.Teal;
            this.ucAddCustOk.FillPressColor = System.Drawing.Color.Teal;
            this.ucAddCustOk.FillSelectedColor = System.Drawing.Color.Teal;
            this.ucAddCustOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustOk.Location = new System.Drawing.Point(224, 419);
            this.ucAddCustOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustOk.Name = "ucAddCustOk";
            this.ucAddCustOk.RectColor = System.Drawing.Color.Teal;
            this.ucAddCustOk.Size = new System.Drawing.Size(127, 36);
            this.ucAddCustOk.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustOk.TabIndex = 19;
            this.ucAddCustOk.Text = "확인";
            this.ucAddCustOk.Click += new System.EventHandler(this.ucAddCustOk_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 30F);
            this.uiLabel1.Location = new System.Drawing.Point(119, 40);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(504, 67);
            this.uiLabel1.TabIndex = 32;
            this.uiLabel1.Text = "고객 정보 등록";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcAddCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.ucAddCustWoman);
            this.Controls.Add(this.ucAddCustMan);
            this.Controls.Add(this.ucAddCustAddr);
            this.Controls.Add(this.ucAddCustTel);
            this.Controls.Add(this.ucAddCustAge);
            this.Controls.Add(this.ucAddCustName);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.ucAddCustInit);
            this.Controls.Add(this.ucAddCustOk);
            this.Name = "UcAddCust";
            this.Size = new System.Drawing.Size(725, 519);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRadioButton ucAddCustWoman;
        private Sunny.UI.UIRadioButton ucAddCustMan;
        private Sunny.UI.UITextBox ucAddCustAddr;
        private Sunny.UI.UITextBox ucAddCustTel;
        private Sunny.UI.UITextBox ucAddCustAge;
        private Sunny.UI.UITextBox ucAddCustName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton ucAddCustInit;
        private Sunny.UI.UISymbolButton ucAddCustOk;
        private Sunny.UI.UILabel uiLabel1;
    }
}
