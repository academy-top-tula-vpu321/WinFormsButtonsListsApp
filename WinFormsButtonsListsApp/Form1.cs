namespace WinFormsButtonsListsApp
{
    public partial class Form1 : Form
    {
        List<string> users;

        public Form1()
        {
            InitializeComponent();

            textBox1.Enabled = false;
            btnAddCity.Enabled = false;

            lstCities.SelectionMode = SelectionMode.MultiExtended;

            lstCities.Items.Add("Владивосток");

            users = new List<string>() { "Bobby", "Jimmy", "Tommy" };
            lstUsers.DataSource = users;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rdb)
                if (rdb.Checked)
                    MessageBox.Show(rdb.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
                btnAddCity.Enabled = false;
            else
                btnAddCity.Enabled = true;
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "")
            {
                lstCities.Items.Add(textBox2.Text);
                textBox2.Text = "";
            }

        }

        private void btnDelCity_Click(object sender, EventArgs e)
        {
            if (lstCities.SelectedItem is not null)
            {
                int index = lstCities.SelectedIndex;
                lstCities.Items.Remove(lstCities.SelectedItem);
                if (lstCities.Items.Count > 0)
                {
                    if (index >= lstCities.Items.Count)
                        index = lstCities.Items.Count - 1;
                    lstCities.SelectedItem = lstCities.Items[index];
                }
            }
        }

        private void btnViewCities_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (var c in lstCities.SelectedItems)
                str += c.ToString() + '\n';
            MessageBox.Show(str);
        }

        private void lstCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (var c in lstCities.SelectedItems)
                str += c.ToString() + '\n';
            MessageBox.Show(str);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            users.Add("Sammy");

            string str = "";
            foreach (var u in users)
                str += u + '\n';
            MessageBox.Show(str);

        }
    }
}
