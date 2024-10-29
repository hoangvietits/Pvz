using System;
using Pvz.Properties;
using System.Resources;
using System.Media;
using System.Drawing.Imaging;
using System.Net.Http.Headers;
namespace Pvz
{
    public partial class Form1 : Form
    {
        static TimeManager Timer;
        static SoundPlayer soundPlayer;
        static int ZombieCount = 0;
        static int ZombieTotal = GameManager.Round * 5 + 10;
        Bitmap B;
        System.Windows.Forms.Timer timer1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            B = new Bitmap(1024, 640, PixelFormat.Format24bppRgb);
            pictureBox1.Image = B;
            GameManager.Monitor = Graphics.FromImage(B);

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            Timer = new TimeManager();
            GameManager.Sprites = new SpriteManager();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += EventHandler(GameLoop);
            timer1.Interval = 50;
            timer1.Enabled = true;
            timer1.Start();

            GameManager.Height = pictureBox1.Height;
            GameManager.Entities.Add(new SpawnEntity());

            soundPlayer = new SoundPlayer(Properties.Resources.grasswalk);
            soundPlayer.Play();
        }

        void GameLoop(Object sender, EventArgs e)
        {
            if(ZombieCount == ZombieTotal)
            {
                GameManager.state = GameManager.GameState.win;
            }
            if(GameManager.state != GameManager.GameState.loose)
            {
                GameLoop.DoSomeThing();
               
            }
        }

        }
    } 
}
