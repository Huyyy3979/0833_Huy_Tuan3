namespace _0833_Huy_Tuan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                txtLast.Text = item.SubItems[0].Text;
                txtFirst.Text = item.SubItems[1].Text;
                txtPhone.Text = item.SubItems[2].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtLast.Text);
            item.SubItems.Add(txtFirst.Text);
            item.SubItems.Add(txtPhone.Text);

            listView1.Items.Add(item);

            txtLast.Clear();
            txtFirst.Clear();
            txtPhone.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Last Name", 120);
            listView1.Columns.Add("First Name", 120);
            listView1.Columns.Add("Phone", 100);
        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
