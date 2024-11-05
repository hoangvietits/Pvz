using System;
using Pvz.Properties;
using System.Resources;
using System.Media;
using System.Drawing.Imaging;
using System.Net.Http.Headers;
using Pvz.Entities;
using System.Runtime.CompilerServices;
using Pvz.Entities.GameObject;
namespace Pvz
{
    public partial class Form1 : Form
    {
        static TimeManager Timer;
        static SoundPlayer soundPlayer;
        static public bool musicPlaying;
        static public int gameScore;
        //static public Form parent;
        Bitmap B;
        System.Windows.Forms.Timer timer1;

        public Form1()
        {
            InitializeComponent();
        }
        public void ResetGame()
        {
            BotSpawn.zombiespawned = 0;
            GameManager.state = GameManager.GameState.playing;

            gameScore = GameManager.Score;
            GameManager.turn = 0;

            ChangeBtn("");
            if (GameManager.Debug)
            {
                hpBtn.Enabled = true;
                hitboxBtn.Enabled = true;
                hitboxBtn.Visible = true;
                hpBtn.Visible = true;
            }
            else
            {
                hpBtn.Enabled = false;
                hitboxBtn.Enabled = false;
                hitboxBtn.Visible = false;
                hpBtn.Visible = false;
            }
            B = new Bitmap(1024, 640, PixelFormat.Format24bppRgb);
            pictureBox1.Image = B;
            GameManager.Monitor = Graphics.FromImage(B);

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);


            GameManager.Sprites = new SpriteManager();


            timer1.Start();
            GameManager.Height = pictureBox1.Height;
            GameManager.Entities.Add(new SpawnEntities());

            soundPlayer = new SoundPlayer(Properties.Resources.grasswalk);
            soundPlayer.Play();
            musicPlaying = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer = new TimeManager();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(GameLoop);
            timer1.Interval = 50;
            timer1.Enabled = true;
            ResetGame();
        }

        private void ChangeBtn(string s)
        {
            if (s == "")
            {
                menuBtn.Enabled = false;
                menuBtn.Visible = false;
                ActionBtn.Enabled = false;
                ActionBtn.Visible = false;
            }
            else
            {
                menuBtn.Enabled = true;
                menuBtn.Visible = true;
                ActionBtn.Enabled = true;
                ActionBtn.Visible = true;
                if (s == "win")
                {
                    ActionBtn.Text = "Next Round";
                }
                else
                {
                    ActionBtn.Text = "Retry";
                }
            }



        }
        void GameLoop(Object myObject, EventArgs myEventArgs)
        {

            if (GameManager.Entities.Count(entity => entity.Tags.Contains("Zombie")) == 0 && GameManager.turn > 200)
            {
                GameManager.state = GameManager.GameState.win;
            }

            if (GameManager.state == GameManager.GameState.playing)
            {
                GameManager.DeltaTime = Timer.GetDeltaTime() / 1000;
                MainLoop.DoSomeThing();
                Draw();
                GameManager.turn++;
                pictureBox1.Invalidate();
                pictureBox1.Update();

            }
            if (GameManager.state == GameManager.GameState.loose)
            {
                GameManager.Sprites.Get("loose").DrawtoScreen(300, 150);
                ChangeBtn("loose");
                GameManager.Sun = 1000;

                pictureBox1.Invalidate();
                pictureBox1.Update();
                GameManager.state = GameManager.GameState.pending;
                timer1.Stop();
            }
            if (GameManager.state == GameManager.GameState.win)
            {
                GameManager.Sprites.Get("Win").DrawtoScreen(100, 150);
                pictureBox1.Invalidate();
                pictureBox1.Update();
                ChangeBtn("win");
                GameManager.Score += GameManager.Sun;
                GameManager.Sun = 1000;
                GameManager.Round++;
                GameManager.SaveGame();

                GameManager.state = GameManager.GameState.pending;
                timer1.Stop();
            }
        }

        private void Draw()
        {
            GameManager.Sprites.Get("decor").DrawtoScreen(0, 0);
            MainLoop.ShowObj();
            scoreLabel.Text = "Score: " + gameScore;
            sunLabel.Text = "Sun: " + GameManager.Sun;
            roundLabel.Text = "Round: " + GameManager.Round;
            playerLabel.Text = "Player: " + GameManager.Name;
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Timer.PaintFinished();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int y = GameManager.Height - e.Y;
            Pvz.MouseClick.Event(e.X, y);
        }

        #region button

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.Pea;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.DoublePea;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.SunFlower;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.GelPea;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.Noix;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            GameManager.Button = GameManager.Creature.Shovel;
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            if (musicPlaying)
            {
                soundPlayer.Stop();
                musicPlaying = false;
            }
            else
            {
                musicPlaying = true;
                soundPlayer.Play();
            }
        }

        private void hpBtn_Click(object sender, EventArgs e)
        {
            GameManager.DisplayHP = !GameManager.DisplayHP;
        }

        private void hitboxBtn_Click(object sender, EventArgs e)
        {
            GameManager.DrawHitBox = !GameManager.DrawHitBox;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            GameManager.Entities.Clear();
            pictureBox1.Invalidate();
            pictureBox1.Update();
            ChangeBtn("");
            ResetGame();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            soundPlayer.Stop();

        }
    }
}

