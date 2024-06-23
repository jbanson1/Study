using System.Data;

namespace NoteTakingApplication
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 150;
        }

        private void New_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessages.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessages.Text);

            txtTitle.Clear();
            txtMessages.Clear();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessages.Text = table.Rows[index].ItemArray[1].ToString();
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}