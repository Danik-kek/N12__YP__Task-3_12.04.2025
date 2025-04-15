namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedItem == "black")
            {
                txt.BackColor = Color.Black;
                txt.ForeColor = Color.White;
            }
            else if (lst.SelectedItem == "red")
            {
                txt.BackColor = Color.Red;
                txt.ForeColor = Color.Black;
            }
            else if (lst.SelectedItem == "blue")
            {
                txt.BackColor = Color.Blue;
                txt.ForeColor = Color.White;
            }
            else if (lst.SelectedItem == "green")
            {
                txt.BackColor = Color.Green;
                txt.ForeColor = Color.Black;
            }
        }
    }
}