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
            timer1.Tick +=  new EventHandler(GameLoop);
            timer1.Interval = 50;
            timer1.Enabled = true;
            timer1.Start();

            GameManager.Height = pictureBox1.Height;
            GameManager.Entities.Add(new SpawnEntity());

            soundPlayer = new SoundPlayer(Properties.Resources.grasswalk);
            soundPlayer.Play();
        }

        void GameLoop(Object myObject, EventArgs myEventArgs)
        {
            if (ZombieCount == ZombieTotal)
            {
                GameManager.state = GameManager.GameState.win;
            }
            if (GameManager.state == GameManager.GameState.playing)
            {
                GameLoop.DoSomeThing();
                GameManager.turn++;
                pictureBox1.Invalidate();
                pictureBox1.Update();

            }
            if (GameManager.state == GameManager.GameState.loose)
            {
                GameManager.Sprites.Get("loose").DrawtoScreen(300, 150);
                pictureBox1.Invalidate();
                pictureBox1.Update();
            }
            if (GameManager.state == GameManager.GameState.win)
            {
                GameManager.Sprites.Get("win").DrawtoScreen(300, 150);
                pictureBox1.Invalidate();
                pictureBox1.Update();
            }
        }
        private void Draw()
        {
            GameManager.Sprites.Get("decor").DrawtoScreen(0, 0);
            MainLoop.ShowObj();
            scoreLabel.Text = "Score: " + GameManager.Score;
            sunLabel.Text = "Sun: " + GameManager.Sun;
            roundLabel.Text = "Round: " + GameManager.Round;
            playerLabel.Text = "Player: " + Player.Name;
        }
        private void Paint(Object sender, PaintEventArgs e)
        {
            Timer.PaintFinished();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int y = GameManager.Height - e.Y;
            Pvz.MouseClick.Event(e.X, y);
        }

        #region buttons
        private void button1_Click(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.Pea;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.DoublePea;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.SunFlower;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.Noix;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.GelPea;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.Shovel;
        }
        #endregion
    }
}

