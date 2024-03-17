using System;
using System.Drawing;
using System.Windows.Forms;

namespace CountryGuessGame
{
    public partial class MainForm : Form
    {
        private PictureBox countryPictureBox;
        private TextBox guessTextBox;
        private Button checkButton;

        private string[] countries = { "France", "Germany", "Italy" }; // Add more countries as needed
        private string[] countries_link = {@"C:\Users\sethr\OneDrive\Pictures\Screenshots\Screenshot France.png", @"C:\Users\sethr\OneDrive\Pictures\Screenshots\Screenshot Germany.png", @"C:\Users\sethr\OneDrive\Pictures\Screenshots\Screenshot italy.png"};
        private Random random = new Random();
        private int currentCountryIndex;

        public MainForm()
        {
            InitializeComponent();
            LoadNextCountry();
        }

        private void InitializeComponent()
        {
            this.Text = "Country Guessing Game";
            this.Size = new Size(4000, 3000);

            countryPictureBox = new PictureBox();
            countryPictureBox.Dock = DockStyle.Top;
            countryPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(countryPictureBox);

            guessTextBox = new TextBox();
            guessTextBox.Dock = DockStyle.Top;
            this.Controls.Add(guessTextBox);

            checkButton = new Button();
            checkButton.Text = "Check Guess";
            checkButton.Dock = DockStyle.Top;
            checkButton.Click += CheckButton_Click;
            this.Controls.Add(checkButton);
        }

        private void LoadNextCountry()
        {
            currentCountryIndex = random.Next(0, countries.Length);

            string imagePath = countries_link[currentCountryIndex];
            
            countryPictureBox.Image = Image.FromFile(imagePath);

            guessTextBox.Text = "";
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string guess = guessTextBox.Text.Trim();

            if (guess.Equals(countries[currentCountryIndex], StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Congratulations! You guessed it right.", "Guess Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNextCountry();
            }
            else
            {
                MessageBox.Show("Incorrect guess. Try again!", "Guess Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
