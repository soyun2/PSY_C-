
namespace CustCar0415.UI
{
    partial class UcAddCar
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
            this.ucpictureBox2 = new System.Windows.Forms.PictureBox();
            this.ucpictureBox3 = new System.Windows.Forms.PictureBox();
            this.ucpictureBox4 = new System.Windows.Forms.PictureBox();
            this.ucpictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucaddCarReset = new Sunny.UI.UISymbolButton();
            this.ucaddCarOk = new Sunny.UI.UISymbolButton();
            this.infoPrice = new Sunny.UI.UISymbolLabel();
            this.infoColor = new Sunny.UI.UISymbolLabel();
            this.infoCompany = new Sunny.UI.UISymbolLabel();
            this.infoModel = new Sunny.UI.UISymbolLabel();
            this.uccomboPrice = new Sunny.UI.UIComboBox();
            this.uccomboColor = new Sunny.UI.UIComboBox();
            this.uccomboCompany = new Sunny.UI.UIComboBox();
            this.uccomboModel = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ucpictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucpictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucpictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucpictureBox2
            // 
            this.ucpictureBox2.Image = global::CustCar0415.Properties.Resources.gran_side;
            this.ucpictureBox2.Location = new System.Drawing.Point(404, 72);
            this.ucpictureBox2.Name = "ucpictureBox2";
            this.ucpictureBox2.Size = new System.Drawing.Size(322, 184);
            this.ucpictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucpictureBox2.TabIndex = 32;
            this.ucpictureBox2.TabStop = false;
            // 
            // ucpictureBox3
            // 
            this.ucpictureBox3.Image = global::CustCar0415.Properties.Resources.gran_back;
            this.ucpictureBox3.Location = new System.Drawing.Point(76, 262);
            this.ucpictureBox3.Name = "ucpictureBox3";
            this.ucpictureBox3.Size = new System.Drawing.Size(322, 184);
            this.ucpictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucpictureBox3.TabIndex = 31;
            this.ucpictureBox3.TabStop = false;
            // 
            // ucpictureBox4
            // 
            this.ucpictureBox4.Image = global::CustCar0415.Properties.Resources.gran_in;
            this.ucpictureBox4.Location = new System.Drawing.Point(404, 262);
            this.ucpictureBox4.Name = "ucpictureBox4";
            this.ucpictureBox4.Size = new System.Drawing.Size(322, 184);
            this.ucpictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucpictureBox4.TabIndex = 30;
            this.ucpictureBox4.TabStop = false;
            // 
            // ucpictureBox1
            // 
            this.ucpictureBox1.Image = global::CustCar0415.Properties.Resources.gran;
            this.ucpictureBox1.Location = new System.Drawing.Point(76, 72);
            this.ucpictureBox1.Name = "ucpictureBox1";
            this.ucpictureBox1.Size = new System.Drawing.Size(322, 184);
            this.ucpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucpictureBox1.TabIndex = 29;
            this.ucpictureBox1.TabStop = false;
            // 
            // ucaddCarReset
            // 
            this.ucaddCarReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucaddCarReset.FillColor = System.Drawing.Color.Teal;
            this.ucaddCarReset.FillHoverColor = System.Drawing.Color.Teal;
            this.ucaddCarReset.FillPressColor = System.Drawing.Color.Teal;
            this.ucaddCarReset.FillSelectedColor = System.Drawing.Color.Teal;
            this.ucaddCarReset.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucaddCarReset.Location = new System.Drawing.Point(413, 515);
            this.ucaddCarReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucaddCarReset.Name = "ucaddCarReset";
            this.ucaddCarReset.RectColor = System.Drawing.Color.Teal;
            this.ucaddCarReset.Size = new System.Drawing.Size(127, 36);
            this.ucaddCarReset.Style = Sunny.UI.UIStyle.Custom;
            this.ucaddCarReset.Symbol = 61473;
            this.ucaddCarReset.TabIndex = 28;
            this.ucaddCarReset.Text = "초기화";
            this.ucaddCarReset.Click += new System.EventHandler(this.ucaddCarReset_Click);
            // 
            // ucaddCarOk
            // 
            this.ucaddCarOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucaddCarOk.FillColor = System.Drawing.Color.Teal;
            this.ucaddCarOk.FillHoverColor = System.Drawing.Color.Teal;
            this.ucaddCarOk.FillPressColor = System.Drawing.Color.Teal;
            this.ucaddCarOk.FillSelectedColor = System.Drawing.Color.Teal;
            this.ucaddCarOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucaddCarOk.Location = new System.Drawing.Point(263, 515);
            this.ucaddCarOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucaddCarOk.Name = "ucaddCarOk";
            this.ucaddCarOk.RectColor = System.Drawing.Color.Teal;
            this.ucaddCarOk.Size = new System.Drawing.Size(127, 36);
            this.ucaddCarOk.Style = Sunny.UI.UIStyle.Custom;
            this.ucaddCarOk.TabIndex = 27;
            this.ucaddCarOk.Text = "확인";
            this.ucaddCarOk.Click += new System.EventHandler(this.ucaddCarOk_Click);
            // 
            // infoPrice
            // 
            this.infoPrice.BackColor = System.Drawing.Color.Transparent;
            this.infoPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoPrice.Location = new System.Drawing.Point(602, 469);
            this.infoPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoPrice.Name = "infoPrice";
            this.infoPrice.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoPrice.Size = new System.Drawing.Size(166, 29);
            this.infoPrice.Symbol = 61785;
            this.infoPrice.TabIndex = 26;
            this.infoPrice.Text = "가격";
            // 
            // infoColor
            // 
            this.infoColor.BackColor = System.Drawing.Color.Transparent;
            this.infoColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoColor.Location = new System.Drawing.Point(413, 469);
            this.infoColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoColor.Name = "infoColor";
            this.infoColor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoColor.Size = new System.Drawing.Size(166, 29);
            this.infoColor.Symbol = 61947;
            this.infoColor.TabIndex = 25;
            this.infoColor.Text = "색상";
            // 
            // infoCompany
            // 
            this.infoCompany.BackColor = System.Drawing.Color.Transparent;
            this.infoCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoCompany.Location = new System.Drawing.Point(224, 469);
            this.infoCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoCompany.Name = "infoCompany";
            this.infoCompany.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoCompany.Size = new System.Drawing.Size(166, 29);
            this.infoCompany.Symbol = 61869;
            this.infoCompany.TabIndex = 24;
            this.infoCompany.Text = "제조사";
            // 
            // infoModel
            // 
            this.infoModel.BackColor = System.Drawing.Color.Transparent;
            this.infoModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoModel.Location = new System.Drawing.Point(35, 469);
            this.infoModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoModel.Name = "infoModel";
            this.infoModel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoModel.Size = new System.Drawing.Size(166, 29);
            this.infoModel.Symbol = 61882;
            this.infoModel.TabIndex = 23;
            this.infoModel.Text = "모델명";
            // 
            // uccomboPrice
            // 
            this.uccomboPrice.FillColor = System.Drawing.Color.White;
            this.uccomboPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uccomboPrice.Items.AddRange(new object[] {
            "3천만원",
            "4천만원",
            "5천만원",
            "8천만원",
            "9천만원"});
            this.uccomboPrice.Location = new System.Drawing.Point(602, 22);
            this.uccomboPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uccomboPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.uccomboPrice.Name = "uccomboPrice";
            this.uccomboPrice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uccomboPrice.RectColor = System.Drawing.Color.Teal;
            this.uccomboPrice.Size = new System.Drawing.Size(166, 29);
            this.uccomboPrice.Style = Sunny.UI.UIStyle.Custom;
            this.uccomboPrice.TabIndex = 20;
            this.uccomboPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uccomboPrice.SelectedIndexChanged += new System.EventHandler(this.uccomboPrice_SelectedIndexChanged);
            // 
            // uccomboColor
            // 
            this.uccomboColor.FillColor = System.Drawing.Color.White;
            this.uccomboColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uccomboColor.Items.AddRange(new object[] {
            "검정",
            "흰색",
            "노랑",
            "파랑",
            "빨강"});
            this.uccomboColor.Location = new System.Drawing.Point(413, 22);
            this.uccomboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uccomboColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.uccomboColor.Name = "uccomboColor";
            this.uccomboColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uccomboColor.RectColor = System.Drawing.Color.Teal;
            this.uccomboColor.Size = new System.Drawing.Size(166, 29);
            this.uccomboColor.Style = Sunny.UI.UIStyle.Custom;
            this.uccomboColor.TabIndex = 21;
            this.uccomboColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uccomboColor.SelectedIndexChanged += new System.EventHandler(this.uccomboColor_SelectedIndexChanged);
            // 
            // uccomboCompany
            // 
            this.uccomboCompany.FillColor = System.Drawing.Color.White;
            this.uccomboCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uccomboCompany.Items.AddRange(new object[] {
            "현대",
            "기아",
            "삼성",
            "람보르기니"});
            this.uccomboCompany.Location = new System.Drawing.Point(224, 22);
            this.uccomboCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uccomboCompany.MinimumSize = new System.Drawing.Size(63, 0);
            this.uccomboCompany.Name = "uccomboCompany";
            this.uccomboCompany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uccomboCompany.RectColor = System.Drawing.Color.Teal;
            this.uccomboCompany.Size = new System.Drawing.Size(166, 29);
            this.uccomboCompany.Style = Sunny.UI.UIStyle.Custom;
            this.uccomboCompany.TabIndex = 22;
            this.uccomboCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uccomboCompany.SelectedIndexChanged += new System.EventHandler(this.uccomboCompany_SelectedIndexChanged);
            // 
            // uccomboModel
            // 
            this.uccomboModel.FillColor = System.Drawing.Color.White;
            this.uccomboModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uccomboModel.Items.AddRange(new object[] {
            "그랜저",
            "제네시스",
            "K8",
            "K7",
            "우루스"});
            this.uccomboModel.Location = new System.Drawing.Point(35, 22);
            this.uccomboModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uccomboModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.uccomboModel.Name = "uccomboModel";
            this.uccomboModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uccomboModel.RectColor = System.Drawing.Color.Teal;
            this.uccomboModel.Size = new System.Drawing.Size(166, 29);
            this.uccomboModel.Style = Sunny.UI.UIStyle.Custom;
            this.uccomboModel.TabIndex = 19;
            this.uccomboModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uccomboModel.SelectedIndexChanged += new System.EventHandler(this.uccomboModel_SelectedIndexChanged);
            // 
            // UcAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucpictureBox2);
            this.Controls.Add(this.ucpictureBox3);
            this.Controls.Add(this.ucpictureBox4);
            this.Controls.Add(this.ucpictureBox1);
            this.Controls.Add(this.ucaddCarReset);
            this.Controls.Add(this.ucaddCarOk);
            this.Controls.Add(this.infoPrice);
            this.Controls.Add(this.infoColor);
            this.Controls.Add(this.infoCompany);
            this.Controls.Add(this.infoModel);
            this.Controls.Add(this.uccomboPrice);
            this.Controls.Add(this.uccomboColor);
            this.Controls.Add(this.uccomboCompany);
            this.Controls.Add(this.uccomboModel);
            this.Name = "UcAddCar";
            this.Size = new System.Drawing.Size(815, 572);
            ((System.ComponentModel.ISupportInitialize)(this.ucpictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucpictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucpictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucpictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ucpictureBox2;
        private System.Windows.Forms.PictureBox ucpictureBox3;
        private System.Windows.Forms.PictureBox ucpictureBox4;
        private System.Windows.Forms.PictureBox ucpictureBox1;
        private Sunny.UI.UISymbolButton ucaddCarReset;
        private Sunny.UI.UISymbolButton ucaddCarOk;
        private Sunny.UI.UISymbolLabel infoPrice;
        private Sunny.UI.UISymbolLabel infoColor;
        private Sunny.UI.UISymbolLabel infoCompany;
        private Sunny.UI.UISymbolLabel infoModel;
        private Sunny.UI.UIComboBox uccomboPrice;
        private Sunny.UI.UIComboBox uccomboColor;
        private Sunny.UI.UIComboBox uccomboCompany;
        private Sunny.UI.UIComboBox uccomboModel;
    }
}
