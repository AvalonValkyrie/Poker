
namespace Baldwin_Asg4_Poker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxCard1 = new System.Windows.Forms.PictureBox();
            this.imgListCards = new System.Windows.Forms.ImageList(this.components);
            this.buttonPlaceBet = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonMaxBet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxCredits = new System.Windows.Forms.TextBox();
            this.textBoxWin = new System.Windows.Forms.TextBox();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxCard2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard5 = new System.Windows.Forms.PictureBox();
            this.checkBoxHold1 = new System.Windows.Forms.CheckBox();
            this.checkBoxHold2 = new System.Windows.Forms.CheckBox();
            this.checkBoxHold3 = new System.Windows.Forms.CheckBox();
            this.checkBoxHold4 = new System.Windows.Forms.CheckBox();
            this.checkBoxHold5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCard1
            // 
            this.pictureBoxCard1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCard1.Image")));
            this.pictureBoxCard1.Location = new System.Drawing.Point(22, 12);
            this.pictureBoxCard1.MaximumSize = new System.Drawing.Size(60, 80);
            this.pictureBoxCard1.MinimumSize = new System.Drawing.Size(50, 70);
            this.pictureBoxCard1.Name = "pictureBoxCard1";
            this.pictureBoxCard1.Size = new System.Drawing.Size(60, 80);
            this.pictureBoxCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCard1.TabIndex = 12;
            this.pictureBoxCard1.TabStop = false;
            this.pictureBoxCard1.Click += new System.EventHandler(this.pictureBoxCard1_Click);
            // 
            // imgListCards
            // 
            this.imgListCards.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCards.ImageStream")));
            this.imgListCards.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCards.Images.SetKeyName(0, "Ace_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(1, "Ace_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(2, "Ace_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(3, "Ace_Spades.bmp");
            this.imgListCards.Images.SetKeyName(4, "2_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(5, "2_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(6, "2_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(7, "2_Spades.bmp");
            this.imgListCards.Images.SetKeyName(8, "3_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(9, "3_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(10, "3_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(11, "3_Spades.bmp");
            this.imgListCards.Images.SetKeyName(12, "4_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(13, "4_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(14, "4_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(15, "4_Spades.bmp");
            this.imgListCards.Images.SetKeyName(16, "5_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(17, "5_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(18, "5_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(19, "5_Spades.bmp");
            this.imgListCards.Images.SetKeyName(20, "6_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(21, "6_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(22, "6_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(23, "6_Spades.bmp");
            this.imgListCards.Images.SetKeyName(24, "7_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(25, "7_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(26, "7_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(27, "7_Spades.bmp");
            this.imgListCards.Images.SetKeyName(28, "8_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(29, "8_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(30, "8_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(31, "8_Spades.bmp");
            this.imgListCards.Images.SetKeyName(32, "9_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(33, "9_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(34, "9_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(35, "9_Spades.bmp");
            this.imgListCards.Images.SetKeyName(36, "10_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(37, "10_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(38, "10_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(39, "10_Spades.bmp");
            this.imgListCards.Images.SetKeyName(40, "Jack_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(41, "Jack_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(42, "Jack_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(43, "Jack_Spades.bmp");
            this.imgListCards.Images.SetKeyName(44, "Queen_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(45, "Queen_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(46, "Queen_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(47, "Queen_Spades.bmp");
            this.imgListCards.Images.SetKeyName(48, "King_Clubs.bmp");
            this.imgListCards.Images.SetKeyName(49, "King_Diamonds.bmp");
            this.imgListCards.Images.SetKeyName(50, "King_Hearts.bmp");
            this.imgListCards.Images.SetKeyName(51, "King_Spades.bmp");
            this.imgListCards.Images.SetKeyName(52, "Backface_Blue.bmp");
            this.imgListCards.Images.SetKeyName(53, "Backface_Red.bmp");
            // 
            // buttonPlaceBet
            // 
            this.buttonPlaceBet.Location = new System.Drawing.Point(12, 146);
            this.buttonPlaceBet.Name = "buttonPlaceBet";
            this.buttonPlaceBet.Size = new System.Drawing.Size(106, 29);
            this.buttonPlaceBet.TabIndex = 22;
            this.buttonPlaceBet.Text = "Place Bet";
            this.buttonPlaceBet.UseVisualStyleBackColor = true;
            this.buttonPlaceBet.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 180);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(106, 29);
            this.buttonDraw.TabIndex = 23;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonMaxBet
            // 
            this.buttonMaxBet.Location = new System.Drawing.Point(12, 215);
            this.buttonMaxBet.Name = "buttonMaxBet";
            this.buttonMaxBet.Size = new System.Drawing.Size(106, 29);
            this.buttonMaxBet.TabIndex = 24;
            this.buttonMaxBet.Text = "Max Bet";
            this.buttonMaxBet.UseVisualStyleBackColor = true;
            this.buttonMaxBet.Click += new System.EventHandler(this.buttonMaxBet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Credits:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(189, 224);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(163, 20);
            this.textBoxMessage.TabIndex = 26;
            // 
            // textBoxCredits
            // 
            this.textBoxCredits.Location = new System.Drawing.Point(232, 146);
            this.textBoxCredits.Name = "textBoxCredits";
            this.textBoxCredits.Size = new System.Drawing.Size(120, 20);
            this.textBoxCredits.TabIndex = 27;
            // 
            // textBoxWin
            // 
            this.textBoxWin.Location = new System.Drawing.Point(232, 198);
            this.textBoxWin.Name = "textBoxWin";
            this.textBoxWin.Size = new System.Drawing.Size(120, 20);
            this.textBoxWin.TabIndex = 28;
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.Location = new System.Drawing.Point(232, 172);
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBet.TabIndex = 29;
            this.numericUpDownBet.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Bet:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Win:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxCard2
            // 
            this.pictureBoxCard2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCard2.Image")));
            this.pictureBoxCard2.Location = new System.Drawing.Point(88, 12);
            this.pictureBoxCard2.MaximumSize = new System.Drawing.Size(60, 80);
            this.pictureBoxCard2.MinimumSize = new System.Drawing.Size(50, 70);
            this.pictureBoxCard2.Name = "pictureBoxCard2";
            this.pictureBoxCard2.Size = new System.Drawing.Size(60, 80);
            this.pictureBoxCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCard2.TabIndex = 32;
            this.pictureBoxCard2.TabStop = false;
            this.pictureBoxCard2.Click += new System.EventHandler(this.pictureBoxCard2_Click);
            // 
            // pictureBoxCard3
            // 
            this.pictureBoxCard3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCard3.Image")));
            this.pictureBoxCard3.Location = new System.Drawing.Point(154, 12);
            this.pictureBoxCard3.MaximumSize = new System.Drawing.Size(60, 80);
            this.pictureBoxCard3.MinimumSize = new System.Drawing.Size(50, 70);
            this.pictureBoxCard3.Name = "pictureBoxCard3";
            this.pictureBoxCard3.Size = new System.Drawing.Size(60, 80);
            this.pictureBoxCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCard3.TabIndex = 33;
            this.pictureBoxCard3.TabStop = false;
            this.pictureBoxCard3.Click += new System.EventHandler(this.pictureBoxCard3_Click);
            // 
            // pictureBoxCard4
            // 
            this.pictureBoxCard4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCard4.Image")));
            this.pictureBoxCard4.Location = new System.Drawing.Point(220, 12);
            this.pictureBoxCard4.MaximumSize = new System.Drawing.Size(60, 80);
            this.pictureBoxCard4.MinimumSize = new System.Drawing.Size(50, 70);
            this.pictureBoxCard4.Name = "pictureBoxCard4";
            this.pictureBoxCard4.Size = new System.Drawing.Size(60, 80);
            this.pictureBoxCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCard4.TabIndex = 34;
            this.pictureBoxCard4.TabStop = false;
            this.pictureBoxCard4.Click += new System.EventHandler(this.pictureBoxCard4_Click);
            // 
            // pictureBoxCard5
            // 
            this.pictureBoxCard5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCard5.Image")));
            this.pictureBoxCard5.Location = new System.Drawing.Point(286, 12);
            this.pictureBoxCard5.MaximumSize = new System.Drawing.Size(60, 80);
            this.pictureBoxCard5.MinimumSize = new System.Drawing.Size(50, 70);
            this.pictureBoxCard5.Name = "pictureBoxCard5";
            this.pictureBoxCard5.Size = new System.Drawing.Size(60, 80);
            this.pictureBoxCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCard5.TabIndex = 35;
            this.pictureBoxCard5.TabStop = false;
            this.pictureBoxCard5.Click += new System.EventHandler(this.pictureBoxCard5_Click);
            // 
            // checkBoxHold1
            // 
            this.checkBoxHold1.AutoSize = true;
            this.checkBoxHold1.Location = new System.Drawing.Point(29, 105);
            this.checkBoxHold1.Name = "checkBoxHold1";
            this.checkBoxHold1.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHold1.TabIndex = 17;
            this.checkBoxHold1.Text = "Hold";
            this.checkBoxHold1.UseVisualStyleBackColor = true;
            this.checkBoxHold1.Visible = false;
            // 
            // checkBoxHold2
            // 
            this.checkBoxHold2.AutoSize = true;
            this.checkBoxHold2.Location = new System.Drawing.Point(95, 105);
            this.checkBoxHold2.Name = "checkBoxHold2";
            this.checkBoxHold2.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHold2.TabIndex = 18;
            this.checkBoxHold2.Text = "Hold";
            this.checkBoxHold2.UseVisualStyleBackColor = true;
            this.checkBoxHold2.Visible = false;
            // 
            // checkBoxHold3
            // 
            this.checkBoxHold3.AutoSize = true;
            this.checkBoxHold3.Location = new System.Drawing.Point(161, 105);
            this.checkBoxHold3.Name = "checkBoxHold3";
            this.checkBoxHold3.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHold3.TabIndex = 19;
            this.checkBoxHold3.Text = "Hold";
            this.checkBoxHold3.UseVisualStyleBackColor = true;
            this.checkBoxHold3.Visible = false;
            // 
            // checkBoxHold4
            // 
            this.checkBoxHold4.AutoSize = true;
            this.checkBoxHold4.Location = new System.Drawing.Point(228, 105);
            this.checkBoxHold4.Name = "checkBoxHold4";
            this.checkBoxHold4.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHold4.TabIndex = 20;
            this.checkBoxHold4.Text = "Hold";
            this.checkBoxHold4.UseVisualStyleBackColor = true;
            this.checkBoxHold4.Visible = false;
            // 
            // checkBoxHold5
            // 
            this.checkBoxHold5.AutoSize = true;
            this.checkBoxHold5.Location = new System.Drawing.Point(294, 105);
            this.checkBoxHold5.Name = "checkBoxHold5";
            this.checkBoxHold5.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHold5.TabIndex = 21;
            this.checkBoxHold5.Text = "Hold";
            this.checkBoxHold5.UseVisualStyleBackColor = true;
            this.checkBoxHold5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 281);
            this.Controls.Add(this.pictureBoxCard5);
            this.Controls.Add(this.pictureBoxCard4);
            this.Controls.Add(this.pictureBoxCard3);
            this.Controls.Add(this.pictureBoxCard2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownBet);
            this.Controls.Add(this.textBoxWin);
            this.Controls.Add(this.textBoxCredits);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMaxBet);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonPlaceBet);
            this.Controls.Add(this.checkBoxHold5);
            this.Controls.Add(this.checkBoxHold4);
            this.Controls.Add(this.checkBoxHold3);
            this.Controls.Add(this.checkBoxHold2);
            this.Controls.Add(this.checkBoxHold1);
            this.Controls.Add(this.pictureBoxCard1);
            this.Name = "Form1";
            this.Text = "Baldwin-Asg4-Poker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCard1;
        private System.Windows.Forms.ImageList imgListCards;
        private System.Windows.Forms.Button buttonPlaceBet;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonMaxBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxCredits;
        private System.Windows.Forms.TextBox textBoxWin;
        private System.Windows.Forms.NumericUpDown numericUpDownBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxCard2;
        private System.Windows.Forms.PictureBox pictureBoxCard3;
        private System.Windows.Forms.PictureBox pictureBoxCard4;
        private System.Windows.Forms.PictureBox pictureBoxCard5;
        private System.Windows.Forms.CheckBox checkBoxHold1;
        private System.Windows.Forms.CheckBox checkBoxHold2;
        private System.Windows.Forms.CheckBox checkBoxHold3;
        private System.Windows.Forms.CheckBox checkBoxHold4;
        private System.Windows.Forms.CheckBox checkBoxHold5;
    }
}

