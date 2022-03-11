namespace image_process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "jpg Files (*.jpg)|*.jpg|gif Files (*.gif)|*.gif|png Files (*.png)|*.png |bmp Files (*.bmp)|*.bmp";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.picorg.Image = new Bitmap(ofile.FileName);
                
            }
        }

        private void btngrey_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picorg.Image);
            process.ConvertToGray(copy);
            this.picres.Image = copy;
        }
    }
}