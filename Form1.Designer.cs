namespace BurgerKiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAppName = new System.Windows.Forms.Label();
            this.rdoHamBurger = new System.Windows.Forms.RadioButton();
            this.rdoBulgogiBurger = new System.Windows.Forms.RadioButton();
            this.rdoChickenBurger = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkPotato = new System.Windows.Forms.CheckBox();
            this.chkCola = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkSauce = new System.Windows.Forms.CheckBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.grpOption = new System.Windows.Forms.GroupBox();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblGuide = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btninit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.grpOption.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAppName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAppName.Location = new System.Drawing.Point(12, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(373, 40);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            this.rdoHamBurger.AutoSize = true;
            this.rdoHamBurger.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoHamBurger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoHamBurger.Location = new System.Drawing.Point(23, 49);
            this.rdoHamBurger.Name = "rdoHamBurger";
            this.rdoHamBurger.Size = new System.Drawing.Size(120, 32);
            this.rdoHamBurger.TabIndex = 1;
            this.rdoHamBurger.TabStop = true;
            this.rdoHamBurger.Text = "햄버거";
            this.rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            this.rdoBulgogiBurger.AutoSize = true;
            this.rdoBulgogiBurger.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoBulgogiBurger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoBulgogiBurger.Location = new System.Drawing.Point(23, 171);
            this.rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            this.rdoBulgogiBurger.Size = new System.Drawing.Size(178, 32);
            this.rdoBulgogiBurger.TabIndex = 2;
            this.rdoBulgogiBurger.TabStop = true;
            this.rdoBulgogiBurger.Text = "불고기버거";
            this.rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            this.rdoChickenBurger.AutoSize = true;
            this.rdoChickenBurger.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoChickenBurger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoChickenBurger.Location = new System.Drawing.Point(23, 300);
            this.rdoChickenBurger.Name = "rdoChickenBurger";
            this.rdoChickenBurger.Size = new System.Drawing.Size(149, 32);
            this.rdoChickenBurger.TabIndex = 3;
            this.rdoChickenBurger.TabStop = true;
            this.rdoChickenBurger.Text = "치킨버거";
            this.rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(200, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(200, 274);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // chkPotato
            // 
            this.chkPotato.AutoSize = true;
            this.chkPotato.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkPotato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkPotato.Location = new System.Drawing.Point(17, 62);
            this.chkPotato.Name = "chkPotato";
            this.chkPotato.Size = new System.Drawing.Size(128, 27);
            this.chkPotato.TabIndex = 7;
            this.chkPotato.Text = "감자튀김";
            this.chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            this.chkCola.AutoSize = true;
            this.chkCola.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkCola.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkCola.Location = new System.Drawing.Point(17, 151);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(80, 27);
            this.chkCola.TabIndex = 8;
            this.chkCola.Text = "콜라";
            this.chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkCheese.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkCheese.Location = new System.Drawing.Point(17, 240);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(136, 27);
            this.chkCheese.TabIndex = 9;
            this.chkCheese.Text = "치즈 추가";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            this.chkSauce.AutoSize = true;
            this.chkSauce.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkSauce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkSauce.Location = new System.Drawing.Point(17, 329);
            this.chkSauce.Name = "chkSauce";
            this.chkSauce.Size = new System.Drawing.Size(136, 27);
            this.chkSauce.TabIndex = 10;
            this.chkSauce.Text = "소스 추가";
            this.chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.pictureBox2);
            this.grpMenu.Controls.Add(this.rdoHamBurger);
            this.grpMenu.Controls.Add(this.rdoBulgogiBurger);
            this.grpMenu.Controls.Add(this.rdoChickenBurger);
            this.grpMenu.Controls.Add(this.pictureBox1);
            this.grpMenu.Controls.Add(this.pictureBox3);
            this.grpMenu.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpMenu.ForeColor = System.Drawing.Color.Red;
            this.grpMenu.Location = new System.Drawing.Point(3, 64);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(348, 425);
            this.grpMenu.TabIndex = 11;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "메뉴 선택";
            // 
            // grpOption
            // 
            this.grpOption.Controls.Add(this.chkPotato);
            this.grpOption.Controls.Add(this.chkCola);
            this.grpOption.Controls.Add(this.chkSauce);
            this.grpOption.Controls.Add(this.chkCheese);
            this.grpOption.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpOption.ForeColor = System.Drawing.Color.Red;
            this.grpOption.Location = new System.Drawing.Point(357, 64);
            this.grpOption.Name = "grpOption";
            this.grpOption.Size = new System.Drawing.Size(166, 425);
            this.grpOption.TabIndex = 12;
            this.grpOption.TabStop = false;
            this.grpOption.Text = "추가 옵션";
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblGuide);
            this.grpOrder.Controls.Add(this.lblTotalCost);
            this.grpOrder.Controls.Add(this.lstOrder);
            this.grpOrder.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpOrder.ForeColor = System.Drawing.Color.Red;
            this.grpOrder.Location = new System.Drawing.Point(529, 64);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(368, 345);
            this.grpOrder.TabIndex = 13;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "주문 내역";
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGuide.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblGuide.Location = new System.Drawing.Point(17, 311);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(0, 20);
            this.lblGuide.TabIndex = 2;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalCost.Location = new System.Drawing.Point(16, 274);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(185, 28);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 27;
            this.lstOrder.Location = new System.Drawing.Point(21, 38);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(339, 220);
            this.lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOrder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrder.Location = new System.Drawing.Point(569, 428);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(116, 52);
            this.btnOrder.TabIndex = 14;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btninit
            // 
            this.btninit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btninit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btninit.Location = new System.Drawing.Point(746, 428);
            this.btninit.Name = "btninit";
            this.btninit.Size = new System.Drawing.Size(116, 52);
            this.btninit.TabIndex = 15;
            this.btninit.Text = "초기화";
            this.btninit.UseVisualStyleBackColor = false;
            this.btninit.Click += new System.EventHandler(this.btninit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 513);
            this.Controls.Add(this.btninit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpOption);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblAppName);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Burger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.grpOption.ResumeLayout(false);
            this.grpOption.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.RadioButton rdoHamBurger;
        private System.Windows.Forms.RadioButton rdoBulgogiBurger;
        private System.Windows.Forms.RadioButton rdoChickenBurger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chkPotato;
        private System.Windows.Forms.CheckBox chkCola;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkSauce;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.GroupBox grpOption;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btninit;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblGuide;
    }
}

