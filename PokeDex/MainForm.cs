namespace PokeDex
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
        int count = -1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                count++;
            }
            pictureBox1.Image = imageList1.Images[count];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if  (count > 0)
            {
                count --;
            }
            pictureBox1.Image = imageList1.Images[count];
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void editDeletePokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm f2 = new EditForm();
            f2.Show();
        }

        private void searchPokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm f2 = new SearchForm();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}