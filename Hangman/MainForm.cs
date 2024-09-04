using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    /// <summary>
    /// Represents part of the main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        private string guessedLetters;
        private string secretPhrase;
        private int lives;
        private int correctGuesses;
        private int secretPhraseLength;
        private List<string> pastWords = new List<string>();
        private Random random = new Random();

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Subscribe to Events
            this.btnSubmitGuess.Click += BtnSubmitGuess_Click;
            this.txtLetterGuess.TextChanged += TxtLetterGuess_TextChanged;
            this.txtLetterGuess.KeyPress += TxtLetterGuess_KeyPress;
            this.mnuNewWord.Click += MnuNewWord_Click;
            this.mnuExit.Click += MnuExit_Click;
            this.mnuHint.Click += MnuHint_Click;
            this.mnuHowToPlay.Click += MnuHowToPlay_Click;
            this.mnuAboutDeveloper.Click += MnuAboutDeveloper_Click;

            // Stylings
            this.Text = "Hangman";
            this.StartPosition = FormStartPosition.CenterScreen;
            // Makes it so form is not resizable.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Makes it so you cannot click maximize button and maximize form.
            this.MaximizeBox = false;
            this.flpAlphabet.BorderStyle = BorderStyle.FixedSingle;
            this.AcceptButton = this.btnSubmitGuess;
            this.txtLetterGuess.MaxLength = 1;

            this.errorProvider.SetIconPadding(txtLetterGuess, 3);
            this.errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            StartGame();
        }

        /// <summary>
        /// Handles the Click event of the new word menu item.
        /// </summary>
        private void MnuNewWord_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The past word was: '{this.secretPhrase}'");

            StartGame();
        }

        /// <summary>
        /// Handles the Click event of the exit menu item.
        /// </summary>
        private void MnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the Click event of the hint menu item.
        /// </summary>
        private void MnuHint_Click(object sender, EventArgs e)
        {
            string letter = String.Empty;
            int number = this.random.Next(this.secretPhrase.Length);
            letter = this.secretPhrase[number].ToString();

            while (this.guessedLetters.Contains(letter) && this.secretPhrase.Contains(letter))
            {
                number = this.random.Next(this.secretPhrase.Length);
                letter = this.secretPhrase[number].ToString();
            }

            GuessValidLetter(letter);
        }

        /// <summary>
        /// Handles the Click event of the how to play menu item.
        /// </summary>
        private void MnuHowToPlay_Click(object sender, EventArgs e)
        {
            string message = "Player or players take turns guessing one letter at a time to figure out the hidden word or phrase" +
                "\n\nIf a guessed letter is correct, it is filled in the appropriate blanks; if incorrect, a part of the stick figure is drawn." +
                "\n\nThe game continues until the word is fully guessed (player/s win) or the stick figure is completely drawn (computer wins).";
            MessageBox.Show(message, "How to Play Hangman");
        }

        /// <summary>
        /// Handles the Click event of the about developer menu item.
        /// </summary>
        private void MnuAboutDeveloper_Click(object sender, EventArgs e)
        {
            AboutDev aboutDevForm = new AboutDev();

            aboutDevForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Key Press event of the letter guess text box.
        /// </summary>
        private void TxtLetterGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        /// <summary>
        /// Handles the Text Changed event of the letter guess text box.
        /// </summary>
        private void TxtLetterGuess_TextChanged(object sender, EventArgs e)
        {
            this.btnSubmitGuess.Enabled = this.txtLetterGuess.Text.Length == 1;
        }

        /// <summary>
        /// Handles the Click event of the submit button.
        /// </summary>
        private void BtnSubmitGuess_Click(object sender, EventArgs e)
        {
            if (this.guessedLetters.Contains(this.txtLetterGuess.Text.ToLower()))
            {
                this.errorProvider.SetError(txtLetterGuess, "You have already guessed this letter, pick another.");
            }
            else
            {
                GuessValidLetter(this.txtLetterGuess.Text.ToLower());
            }

            this.txtLetterGuess.Text = String.Empty;
        }

        /// <summary>
        /// Begins the game.
        /// </summary>
        /// <remarks>
        /// Including clearing screen, getting new word, and verifying that new word hasn't yet been used in current game play session.
        /// </remarks>
        private void StartGame()
        {
            this.btnSubmitGuess.Enabled = false;
            ClearForm();
            
            string word = GetNewWord().ToLower();
            while (this.pastWords.Contains(word))
            {
                word = GetNewWord().ToLower();
            }

            this.pastWords.Add(word);
            this.secretPhrase = word;

            this.secretPhraseLength = new String(this.secretPhrase.Distinct().ToArray()).Length;

            PrintSecretPhrase();
        }

        /// <summary>
        /// Runs the methods to update the gameboard when the player makes a correct guess.
        /// </summary>
        /// <param name="letter">The valid letter that has been guessed.</param>
        private void GuessValidLetter(string letter)
        {
            this.errorProvider.Clear();
            this.guessedLetters = this.guessedLetters + letter;

            if (this.secretPhrase.Contains(letter))
            {
                this.correctGuesses += 1;
                PrintSecretPhrase();
            }
            else
            {
                this.lives -= 1;
                AddToHangman();
            }

            PrintAlphabet();
            CheckWinOrLose();
        }

        /// <summary>
        /// Displays underscores in symbolizing letters in secret phrase on screen and updates them to the letters as players guesses correctly.
        /// </summary>
        private void PrintSecretPhrase()
        {
            string test = String.Empty;
            foreach (char letter in this.secretPhrase)
            {
                int testLength = test.Length;

                foreach (char guess in this.guessedLetters)
                {
                    if (letter == guess)
                    {
                        test += $"{letter} ";
                    }
                }

                if (testLength == test.Length)
                {
                    test += "_ ";
                }
            }

            this.lblTest.Text = test;
        }

        /// <summary>
        /// Prints alphabet to screen with updates on background color, if any.
        /// </summary>
        private void PrintAlphabet()
        {
            // Removes contents from panel.
            this.flpAlphabet.Controls.Clear();

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (char letter in alphabet)
            {
                Label lblLetter = new Label();
                // Need ToString() here since it is a char type.
                lblLetter.Name = letter.ToString();
                lblLetter.Text = letter.ToString();
                lblLetter.TextAlign = ContentAlignment.MiddleCenter;
                lblLetter.Font = new Font("Arial", 12f, FontStyle.Bold);
                lblLetter.Size = new Size(38, 38);
                lblLetter.BorderStyle = BorderStyle.FixedSingle;

                if (this.guessedLetters.ToUpper().Contains(letter))
                {
                    lblLetter.BackColor = Color.DarkGray;
                }

                // Adds to the controls of the panel.
                this.flpAlphabet.Controls.Add(lblLetter);
            }
        }

        /// <summary>
        /// Updates the hangman drawing to visually show lives left in game.
        /// </summary>
        private void AddToHangman()
        {
            if (this.lives == 7)
            {
                picHangman.Image = Hangman.Properties.Resources.stand;
            }
            else if (this.lives == 6)
            {
                picHangman.Image = Hangman.Properties.Resources.head;
            }
            else if (this.lives == 5)
            {
                picHangman.Image = Hangman.Properties.Resources.body;
            }
            else if (this.lives == 4)
            {
                picHangman.Image = Hangman.Properties.Resources.arm1;
            }
            else if (this.lives == 3)
            {
                picHangman.Image = Hangman.Properties.Resources.arm2;
            }
            else if (this.lives == 2)
            {
                picHangman.Image = Hangman.Properties.Resources.leg1;
            }
            else if (this.lives == 1)
            {
                picHangman.Image = Hangman.Properties.Resources.leg2;
            }
            else if (this.lives == 8)
            {
                picHangman.Image = Hangman.Properties.Resources._base;
            }
        }

        /// <summary>
        /// Checks whether the player has won or lost the game.
        /// 
        /// If neither the game continues.
        /// </summary>
        private void CheckWinOrLose()
        {
            string message = String.Empty;

            if (this.lives == 0 || this.correctGuesses == this.secretPhraseLength)
            {
                if (this.lives == 0)
                {
                    message = $"You Died. The word was {this.secretPhrase}\nWant to play again?";
                }
                else
                {
                    message = "Congratulations! You won!\nWant to play again?";
                }

                DialogResult answer = MessageBox.Show(message, this.Text, MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    StartGame();
                }
                else
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Resets the form to the start to begin a new game.
        /// </summary>
        private void ClearForm()
        {
            this.guessedLetters = String.Empty;
            this.secretPhrase = String.Empty;
            this.lives = 8;
            this.correctGuesses = 0;
            AddToHangman();
            PrintAlphabet();
        }

        /// <summary>
        /// Gets a new word to be used as secret phrase.
        /// </summary>
        /// <returns>A new word.</returns>
        private string GetNewWord()
        {
            string newWord = String.Empty;
            
            string dictionaryPath = "C:\\Users\\larsa\\Documents\\programming\\c-sharp\\Hangman\\Hangman\\dictionary.txt";
            StreamReader sr = new StreamReader(dictionaryPath);

            int number = this.random.Next(1022);

            for (int x = 0; x <= number; x++)
            {
                if (x == number)
                {
                    newWord = sr.ReadLine();
                }

                sr.ReadLine();
            }

            sr.Close();

            return newWord;
        }
    }
}
