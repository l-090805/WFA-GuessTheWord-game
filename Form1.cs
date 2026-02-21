using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameFull
{
    public partial class GuessingGame : Form
    {
        //declarations
        private string[] wordList = { "car", "dog", "cat", "house", "city", "hospital", "happy", "hand", "bed", "river", "mountain", "red", "blue", "green", "yellow", "white"}; //hardcoded list of words
        private string secretWord;
        private Timer timer;
        int timeLeft = 120;
        private int elapsedTime = 0;
        private string currentHint;
        public GuessingGame()
        {
            InitializeComponent();
            secretWord = GetRandomWord();
            InitializeTimer();
            InitializeHint();
        }
        private string GetRandomWord()
        {
            Random random = new Random();
            int index = random.Next(wordList.Length);
            return wordList[index];
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; //set timer to 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializeHint()
        {
            currentHint = new string('_', secretWord.Length);
            lblHint.Text = $"Hint: {currentHint}";

        }

        // Timer tick event handler - updates the countdown each second
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            elapsedTime++;

            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            lblTimer.Text = $"Time left: {minutes}:{seconds:D2}"; // Update label with time left

            if (timeLeft <= 0)
            {
                timer.Stop();
                lblFeedback.Text = $"Time's up! The word was: {secretWord}";
                btnSubmitGuess.Enabled = false; // Disable the button when time is up
            }

            if(elapsedTime % 30 == 0)
            {
                RevealNextLetter();
            }


        }

        private void RevealNextLetter()
        {
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (currentHint[i] == '_')
                {
                    char[] hintArray = currentHint.ToCharArray();
                    hintArray[i] = secretWord[i];
                    currentHint = new string(hintArray);
                    lblHint.Text = $"Hint: {currentHint}";
                    break;
                }
            }
        }
        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text;
            if ( guess == secretWord)
            {
                lblFeedback.Text = "Good job, You guessed the secret word!";
                timer.Stop();//stop timer in correct guess
                btnSubmitGuess.Enabled = false;// dissable button after wining 
            }
            else
            {
                lblFeedback.Text = "Incorrect, try again!";
                txtGuess.Clear();
            }
        }
        private void btnReset_Click( object sender, EventArgs e)
        {
            //reset word
            secretWord = GetRandomWord();

            //reset timer
            timeLeft = 120;
            lblTimer.Text = "Time left: 2:00";

            // Reset feedback and input
            lblFeedback.Text = "";
            txtGuess.Clear();

            // Re-enable submit button and restart the timer
            btnSubmitGuess.Enabled = true;
            timer.Start();
            InitializeHint();


        }
        private void GuessingGame_Load(object sender, EventArgs e){}

        private void lblFeedback_Click(object sender, EventArgs e){}

        private void lblTimer_Click(object sender, EventArgs e){}
    }
}
