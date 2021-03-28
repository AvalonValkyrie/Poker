using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baldwin_Asg4_Poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxCard1.BackColor = Color.White;
            pictureBoxCard2.BackColor = Color.White;
            pictureBoxCard3.BackColor = Color.White;
            pictureBoxCard4.BackColor = Color.White;
            pictureBoxCard5.BackColor = Color.White;
            buttonDraw.Enabled = false;
            textBoxCredits.Text = game.Credits.ToString();
            textBoxCredits.ReadOnly = true;
            textBoxMessage.ReadOnly = true;
            textBoxWin.ReadOnly = true;
        }

        //Misc def area start
        List<Card> playerHand = new List<Card>();
        public Game game = new Game();
        public Deck deck = new Deck();

        //Misc def area end
        //method def area start

        public void cardClick(CheckBox checkBox, PictureBox pictureBox)
        {
            if (checkBox.Checked == false)
            {
                checkBox.Checked = true;
                pictureBox.BackColor = Color.LightGreen;
            }
            else
            {
                checkBox.Checked = false;
                pictureBox.BackColor = Color.White;
            }
        }

        public void displayCards()
        {
            playerHand = game.getPlayerHand();
            int imageIndex = 0;

            imageIndex = playerHand[0].ImageListIndex;
            pictureBoxCard1.Image = imgListCards.Images[imageIndex];

            imageIndex = playerHand[1].ImageListIndex;
            pictureBoxCard2.Image = imgListCards.Images[imageIndex];

            imageIndex = playerHand[2].ImageListIndex;
            pictureBoxCard3.Image = imgListCards.Images[imageIndex];

            imageIndex = playerHand[3].ImageListIndex;
            pictureBoxCard4.Image = imgListCards.Images[imageIndex];

            imageIndex = playerHand[4].ImageListIndex;
            pictureBoxCard5.Image = imgListCards.Images[imageIndex];
        }

        private void redrawCards()
        {
            game.reloadHand();
            playerHand = game.getPlayerHand();
        }

        private List<Card> determineHeldCards()
        {
            List<Card> heldCards = new List<Card>();

            if (checkBoxHold1.Checked == true)
            {
                heldCards.Add(playerHand[0]);
            }
            if (checkBoxHold2.Checked == true)
            {
                heldCards.Add(playerHand[1]);
            }
            if (checkBoxHold3.Checked == true)
            {
                heldCards.Add(playerHand[2]);
            }
            if (checkBoxHold4.Checked == true)
            {
                heldCards.Add(playerHand[3]);
            }
            if (checkBoxHold5.Checked == true)
            {
                heldCards.Add(playerHand[4]);
            }

            return heldCards;
        }

        private void resetSelectedCards()
        {
            pictureBoxCard1.BackColor = Color.White;
            pictureBoxCard2.BackColor = Color.White;
            pictureBoxCard3.BackColor = Color.White;
            pictureBoxCard4.BackColor = Color.White;
            pictureBoxCard5.BackColor = Color.White;
            checkBoxHold1.Checked = false;
            checkBoxHold2.Checked = false;
            checkBoxHold3.Checked = false;
            checkBoxHold4.Checked = false;
            checkBoxHold5.Checked = false;
        }

        //method def area end
        //button area start
        private void pictureBoxCard1_Click(object sender, EventArgs e)
        {
            cardClick(checkBoxHold1, pictureBoxCard1);
        }

        private void pictureBoxCard2_Click(object sender, EventArgs e)
        {
            cardClick(checkBoxHold2, pictureBoxCard2);
        }

        private void pictureBoxCard3_Click(object sender, EventArgs e)
        {
            cardClick(checkBoxHold3, pictureBoxCard3);
        }

        private void pictureBoxCard4_Click(object sender, EventArgs e)
        {
            cardClick(checkBoxHold4, pictureBoxCard4);
        }

        private void pictureBoxCard5_Click(object sender, EventArgs e)
        {
            cardClick(checkBoxHold5, pictureBoxCard5);
        }

        private void buttonDeal_Click(object sender, EventArgs e)//Now called buttonPlaceBet
        {//There were errors when I tried to rename it
            buttonDraw.Enabled = true;
            buttonPlaceBet.Enabled = false;
            buttonMaxBet.Enabled = false;
            numericUpDownBet.Enabled = false;

            game.Bet = (int)numericUpDownBet.Value;
            redrawCards();
            displayCards();
            
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            buttonPlaceBet.Enabled = true;
            buttonDraw.Enabled = false;
            buttonMaxBet.Enabled = true;
            numericUpDownBet.Enabled = true;

            List<Card> heldCards = new List<Card>();
            heldCards = determineHeldCards();
            List<int> indexPlayerList = new List<int>();
            List<int> indexheldCards = new List<int>();

            if (heldCards.Count != 0 || heldCards != null)
            {
                foreach (Card card in heldCards)
                {
                    int cardIndex = playerHand.IndexOf(card);
                    indexPlayerList.Add(cardIndex);
                    cardIndex = heldCards.IndexOf(card);
                    indexheldCards.Add(cardIndex);
                }
                redrawCards();
                int count = 0;
                foreach(int index in indexPlayerList)
                {
                    playerHand[index] = heldCards[count];
                    count++;
                }
            }
            else
            {
                redrawCards();
            }
            displayCards();
            

            String rs1 = playerHand[0].getRankSuit(playerHand[0]);
            String rs2 = playerHand[1].getRankSuit(playerHand[1]);
            String rs3 = playerHand[2].getRankSuit(playerHand[2]);
            String rs4 = playerHand[3].getRankSuit(playerHand[3]);
            String rs5 = playerHand[4].getRankSuit(playerHand[4]);

            PokerScore pokerScore = new PokerScore(rs1, rs2, rs3, rs4, rs5);
            String scoreInfo = pokerScore.scoreHand();

            int payOut = pokerScore.getPayoffRatio();
            int winAmount = payOut * game.Bet;

            textBoxMessage.Text = scoreInfo;
            textBoxWin.Text = winAmount.ToString();
            game.Credits += winAmount;
            textBoxCredits.Text = game.Credits.ToString();
            resetSelectedCards();
            numericUpDownBet.Focus();
        }

        private void buttonMaxBet_Click(object sender, EventArgs e)
        {
            if (game.Bet <= 100)
            {
                game.Bet = 100;
            }
            else
            {
                game.Bet = game.Credits;
            }
            numericUpDownBet.Value = game.Bet;
        }

        //button area end
    }
}
