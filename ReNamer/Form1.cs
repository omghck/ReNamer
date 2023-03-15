namespace ReNamer
{

    public partial class ReNamer : Form
    {
        RenTools ren;
        List<string> filenames;
        string workingpath;
        public ReNamer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ren = new RenTools();
            filenames = new List<string>();
            workingpath = "";

            lboxFiles.AllowDrop = true;
            lboxFiles.DragDrop += lboxFiles_DragDrop;
            lboxFiles.DragEnter += lboxFiles_DragEnter;



        }
        private void lboxFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void lboxFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            lboxFiles.Items.Clear();
            filenames.Clear();


            foreach (string file in files)
            {
                workingpath = "";
                filenames.Add(file);
                string[] path = file.Split('\\');
                for (int i = 0; i < path.Length - 1; i++)
                {
                    workingpath += path[i] + "\\";
                }
                lboxFiles.Items.Add(path[path.Length - 1]);
            }
            txtPath.Text = workingpath;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            txtProgress.Text = "In progress...";
            ren.setOptions(this.chkSpaces.Checked, this.chkNumbers.Checked, this.chkLowercase.Checked, this.chkUppercase.Checked);
            this.chkSpaces.Checked = false;
            this.chkNumbers.Checked = false;
            this.chkLowercase.Checked = false;
            this.chkUppercase.Checked = false;
            lboxFiles = ren.doWork(lboxFiles, txtSearchfor.Text.Trim(), txtReplacewith.Text.Trim(), chkRegex.Checked, workingpath, pbarProgress);
            pbarProgress.Value = 0;
            txtProgress.Text = "IDLE...";
        }

        private void ReNamer_Shown(object sender, EventArgs e)
        {

        }

        private void txtSearchfor_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if(this.txtSearchfor.Text.Length > 3)
            {
                txtProgress.Text = "In progress...";
                ren.setOptions(this.chkSpaces.Checked, this.chkNumbers.Checked, this.chkLowercase.Checked, this.chkUppercase.Checked);
                lboxFiles = ren.doWork(lboxFiles, txtSearchfor.Text.Trim(), txtReplacewith.Text.Trim(), chkRegex.Checked, workingpath, pbarProgress);
                pbarProgress.Value = 0;
                txtProgress.Text = "IDLE...";  
            }
            
        }
    }
}