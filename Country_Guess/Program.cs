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

        private string[] countries = { "Sahara Desert", "Kalahari Desert", "Nile River", "Congo River", "Zambezi River" }; // Add more countries as needed
        // private string[] countries_link = {@"C:\Users\sethr\OneDrive\Desktop\Screenshot Sahara Desert.png", @"C:\Users\sethr\OneDrive\Desktop\Screenshot Kalahari Desert.png", @"C:\Users\sethr\OneDrive\Desktop\Screenshot Nile River.png", @"C:\Users\sethr\OneDrive\Desktop\Screenshot Congo River.png", @"C:\Users\sethr\OneDrive\Desktop\Screenshot Zambezi River.png"};
        private string[] countries_link = {@"Screenshot Sahara Desert.png", @"Screenshot Kalahari Desert.png", @"Screenshot Nile River.png", @"Screenshot Congo River.png", @"Screenshot Zambezi River.png"};
        private Random random = new Random();
        private int currentCountryIndex = 0;

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
            string imagePath = countries_link[currentCountryIndex];
            
            countryPictureBox.Image = Image.FromFile(imagePath);

            guessTextBox.Text = "";
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string guess = guessTextBox.Text.Trim();

            if (guess.Equals(countries[currentCountryIndex], StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Congratulations! You guessed it right.", "Guess Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                currentCountryIndex += 1;
                if (currentCountryIndex >= 5)
                {
                    Environment.Exit(0);
                }
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
