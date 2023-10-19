using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showRulesbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Rock beats scissors and loses to paper.\n\n2. Scissors beat paper but loses to rock.\n\n3. Paper beats rock, but loses to scissors.\n\n4. Game ends when either player or computer reaches to 3.\n\n5. In order to make choice click on the pictures on the left.");
        }

        string playerChoice;
        string computerChoice;
        string[] choices = { "Rock", "Paper", "Scissors", "Rock", "Paper", "Scissors" };
        int computerScore;
        int playerScore;
        int rounds = 1;


        private void ShowChoices(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            playerChoice = (string)pictureBox.Tag;
            Random random = new Random();
            int choice = random.Next(0, 6);
            computerChoice = choices[choice];

            PlayerChoicelbl.Text = "Your choice : " + playerChoice;
            ComputerChoicelbl.Text = "Computer choice : " + computerChoice;

            PlayerChoicePicture.Image = pictureBox.Image;

            ShowComputerChoicePicture();
            ShowAllChoices();

            DefineScore();
            rounds++;
        }

        private void ShowComputerChoicePicture()
        {

            if (computerChoice == "Rock")
            {
                ComputerChoicePicture.Image = Properties.Resources.rock;
            }
            else if (computerChoice == "Scissors")
            {
                ComputerChoicePicture.Image = Properties.Resources.scissors;
            }
            else
            {
                ComputerChoicePicture.Image = Properties.Resources.paper;
            }

        }

        List<Label> labels = new List<Label>();

        private void ShowAllChoices()
        {
            int buttom = 240;

            for (int i = 1; i <= rounds; i++)
            {
                Label labelForRounds = new Label();
                labelForRounds.Text = $"{rounds}";
                labelForRounds.Location = new Point(330, buttom);
                labelForRounds.Font = new Font("Palatino Linotype", 12, FontStyle.Italic);
                labelForRounds.Size = new Size(32, 27);
                this.Controls.Add(labelForRounds);
                labels.Add(labelForRounds);


                Label labelForPlayerChoices = new Label();
                labelForPlayerChoices.Text = playerChoice;
                labelForPlayerChoices.Location = new Point(400, buttom);
                labelForPlayerChoices.Font = new Font("Palatino Linotype", 12, FontStyle.Italic);
                labelForPlayerChoices.Size = new Size(70, 30);
                this.Controls.Add(labelForPlayerChoices);
                labels.Add(labelForPlayerChoices);


                Label labelForComputerChoices = new Label();
                labelForComputerChoices.Text = computerChoice;
                labelForComputerChoices.Location = new Point(520, buttom);
                labelForComputerChoices.Font = new Font("Palatino Linotype", 12, FontStyle.Italic);
                labelForComputerChoices.Size = new Size(70, 30);
                this.Controls.Add(labelForComputerChoices);
                labels.Add(labelForComputerChoices);

                if (playerChoice == "Rock" && computerChoice == "Scissors" || playerChoice == "Paper" && computerChoice == "Rock" || playerChoice == "Scissors" && computerChoice == "Paper")
                {
                    labelForPlayerChoices.ForeColor = Color.DarkGreen;
                   
                }
                else if (computerChoice == "Rock" && playerChoice == "Scissors" || computerChoice == "Paper" && playerChoice == "Rock" || computerChoice == "Scissors" && playerChoice == "Paper")
                {
                    labelForComputerChoices.ForeColor = Color.DarkGreen;
                }



                buttom += 30;


            }


        }

        private void DefineScore()
        {
            if (playerChoice == "Rock" && computerChoice == "Scissors" || playerChoice == "Paper" && computerChoice == "Rock" || playerChoice == "Scissors" && computerChoice == "Paper")
            {
                playerScore++;
            }
            else if (computerChoice == "Rock" && playerChoice == "Scissors" || computerChoice == "Paper" && playerChoice == "Rock" || computerChoice == "Scissors" && playerChoice == "Paper")
            {
                computerScore++;
            }


            PlScorelbl.Text = $"{playerScore}";
            CompScorelbl.Text = $"{computerScore}";

            if (playerScore == 3)
            {
                MessageBox.Show("Player Won");

               
                ResetScore();



            }

            if (computerScore == 3)
            {
                MessageBox.Show("Computer Won");

                
                ResetScore();
            }
        }

        private void ResetScore()
        {
            playerScore = 0;
            PlScorelbl.Text = $"{playerScore}";
            computerScore = 0;
            CompScorelbl.Text = $"{computerScore}";
            PlayerChoicelbl.Text = "Your choice";
            ComputerChoicelbl.Text = "Computer choice";
            ComputerChoicePicture.Image = null;
            PlayerChoicePicture.Image = null;

            foreach (Label label in labels)
            {
                this.Controls.Remove(label);
                label.Dispose();
            }
            labels.Clear();
            rounds = 0;

        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            ResetScore();
        }

       
    }
}
