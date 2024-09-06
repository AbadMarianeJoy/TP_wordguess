using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP
{
    public partial class Form1 : Form
    {
        private string wordToGuess;
        private int attempts;
        private const int maxAttempts = 5;
        private List<string> wrongGuesses = new List<string>();


        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            // Initialize game variables
            Random random = new Random();
            wordToGuess = "CARBONARA";
            attempts = 0;
            wrongGuesses.Clear();
            listBoxWrongGuesses.Items.Clear();
            labelfeedback.Text = "";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Handle the button click event
            string userGuess = textBoxGuess.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(userGuess))
            {


                labelfeedback.Text = "Please enter a valid word.";
                return;
            }

            if (userGuess == wordToGuess)
            {
                labelfeedback.Text = $"Congratulations! \nYou guessed the word '{wordToGuess}' correctly!";

            }
            else
            {
                if (wrongGuesses.Contains(userGuess))
                {
                    labelfeedback.Text = "You've already guessed that word. Try a different one.";
                }
                else
                {
                    wrongGuesses.Add(userGuess);
                    listBoxWrongGuesses.Items.Add(userGuess);
                    attempts++;

                    if (attempts >= maxAttempts)
                    {
                        labelfeedback.Text = $"Sorry, you've used all your attempts. The word was '{wordToGuess}'.";
                        StartNewGame();
                    }
                    else
                    {
                        labelfeedback.Text = $"Incorrect guess! \nYou have {maxAttempts - attempts} attempts left.";
                    }
                }
            }

            textBoxGuess.Clear();
        }

        private void labelInstruction_Click(object sender, EventArgs e)
        {
            // Optionally handle label click event if needed
        }

        private void textBoxGuess_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text changed event if needed
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Optionally handle form load event if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
