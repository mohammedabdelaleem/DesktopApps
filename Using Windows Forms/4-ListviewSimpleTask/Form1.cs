namespace Listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTimePicker date = new DateTimePicker();
        Random random = new Random();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName1.Text == null) return;

            string fileType = null;
            ListViewItem item = new ListViewItem(txtName1.Text.Trim());
            item.SubItems.Add(date.Value.ToString()); //Date Modified
            fileType = GetType(txtName1.Text.Trim());
            item.SubItems.Add(fileType); //Folder Type
            item.SubItems.Add(GetRandomSize()); //Size

            item.ImageIndex = GetImageIconIndex(fileType);
            listView1.Items.Add(item);

            txtName1.Clear();
            txtName1.Focus();
        }

        private byte GetImageIconIndex(string type)
        {
            switch (type)
            {
                case "File Folder":
                    return 0;

                case "pdf":
                    return 1;

                case "png":
                    return 2;

                case "txt":
                    return 3;
            }
            return 0;

        }

        private string GetRandomSize() => random.Next(1, 1000).ToString() + " KB";
        private string GetType(string folderName) => (folderName.Contains(".")) ? folderName.Substring(folderName.IndexOf(".") + 1).ToLower() : "File Folder";


        private void Form1_Load(object sender, EventArgs e)
        {
            txtName1.Focus();
            rbDetails.Checked = true;
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbLargeIcons_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbSmallIcons_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbTiles_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private string GetRandomFileName()
        {
            string[] strFileTypes = { "", "pdf", "png", "txt" };
             string result = "Random."+strFileTypes[random.Next(0, 4)];
            return (result[result.Length-1]=='.')? result.Substring(0, result.Length - 1):result ;
        }
        private void btnAddRandom_Click(object sender, EventArgs e)
        {
            string fileName = null;
            string fileType = null;

            for (int i = 0; i < 10; i++)
            {
                fileName = GetRandomFileName();
                ListViewItem item = new ListViewItem(fileName);
                item.SubItems.Add(date.Value.ToString()); //Date Modified
                fileType = GetType(fileName);
                item.SubItems.Add(fileType); //Folder Type
                item.SubItems.Add(GetRandomSize()); //Size

                item.ImageIndex = GetImageIconIndex(fileType);
                listView1.Items.Add(item);

                txtName1.Clear();
                txtName1.Focus();
            }
        }
    }
}
