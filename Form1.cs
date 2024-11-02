
using System.Windows.Forms;

namespace Mp3_player
{
    public partial class Form1 : Form
    {
       public OpenFileDialog fileDialog = new OpenFileDialog();
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = filename;
            player.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "MP3|*.mp3|All files (*.*)|*.* ";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
             filename = fileDialog.FileName;
            button1.Visible= true;
            button2.Visible= true;
          
        }
    }
}
