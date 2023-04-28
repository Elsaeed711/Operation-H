using System.Data.SqlClient;

namespace Operation_H
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\HqNw\\Desktop\\vs\\Operation-H\\Operation H\\Database1.mdf\";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT COUNT(*) FROM stdlogin WHERE id = " + textBox2.Text + " AND name = '" + textBox1.Text + "'" ;

            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            int count = (int)command.ExecuteScalar();
            conn.Close();

            if (count > 0)
            {
                MessageBox.Show("User exists!");
            }
            else
            {
                MessageBox.Show("User does not exist.");
            }
        }
    }
}