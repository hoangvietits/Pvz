using Pvz.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz
{
     class GameManager
    {
        static public SpriteManager Sprites;
        static public Graphics Monitor;
        static public int Height;
        static public int Sun = 1000;
        static public int Round;
        static public int Score;
        static public int turn;
        static public double DeltaTime;
        static public int zombieTotal = 1;
        static public Creature Button;
        static public GameState state;
        static public bool Debug;
        static public string Name;
        static public string Role;
        static public bool DrawHitBox { get; set; }
        static public bool DisplayHP { get; set; }

        public enum GameState { win, loose, playing, pending};
        public enum Creature
        {
            Zombie, ZombieCone, ZombieSot, Pea, SunFlower, Noix, DoublePea,
            GelPea, Shovel
        }
        static public Dictionary<Creature, int> Cost = new Dictionary<Creature, int>()
        {
            { Creature.Pea,100},
            { Creature.SunFlower,50 },
            { Creature.Noix,50 },
            { Creature.DoublePea,200 },
            { Creature.GelPea,175}

        };
        static public Dictionary<Creature, int> Cooldowns = new Dictionary<Creature, int>()
        {
            { Creature.Pea,100},
            { Creature.SunFlower,50},
            { Creature.Noix,50},
            { Creature.DoublePea,100 },
            { Creature.GelPea,100}
        };
        static public List<GameObj> Entities = new List<GameObj>();
        static public Dictionary<GameManager.Creature, int> plantsCoolDowns = new Dictionary<GameManager.Creature, int>();
        static private Random randNum = new Random();
        public static int Random(int min, int max)
        {
            return randNum.Next(min, max+1);
        }

        public static bool Login(string username, string password)
        {

            string connection = @"Server = DESKTOP-TU4C4IS\GODMODE; Database = Pvz; Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT UserName, Score, Round, Role FROM [dbo].Player WHERE Username ='{username}' AND Password ='{password}'";
                    var cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteReader();
                    if(result.Read())
                    {
                        Name = result["UserName"].ToString();
                        Score = Convert.ToInt32(result["Score"]);
                        Round = Convert.ToInt32(result["Round"]);
                        Role = result["Role"].ToString();
                        if (Role == "Admin")
                        {
                            Debug = true;

                        }
                        else Debug = false;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password");
                        return false;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error");
                    return false;
                }
            }
        }
        public static void SaveGame()
        {
            string connection = @"Server = DESKTOP-TU4C4IS\GODMODE; Database = Pvz; Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = $"UPDATE [dbo].Player SET Score = '{GameManager.Score}', Round = '{GameManager.Round}' WHERE UserName = '{GameManager.Name}'";
                    var cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Connection Error");
                }
               
            }

        }
        public static bool AddUser(string username, string password)
        {
            string connection = @"Server = DESKTOP-TU4C4IS\GODMODE; Database = Pvz; Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT COUNT (*) FROM [dbo].Player WHERE UserName = '{username}'";
                    var cmd = new SqlCommand(query, conn);
                    var result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        MessageBox.Show("Username has been used");
                        conn.Close();
                        conn.Dispose();
                        return false;
                    }
                    else
                    {
                        query = $"INSERT INTO [dbo].Player VALUES ('{username}','{password}',0,1,'Player')";
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        conn.Dispose();
                        return true;
                    }

                }
                catch (SqlException ex) 
                {
                    return false;
                }
            }
        }

    }
}
