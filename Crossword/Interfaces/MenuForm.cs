using Crossword.Interfaces;

namespace Crossword
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Program.startGame();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Program.stopGame();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
