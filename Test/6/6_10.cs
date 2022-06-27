using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Test._6
{
    class User
    {
        private string uid;
        private string name;
        private string hp;
        private int age;

        public string Uid { get { return uid; } set { uid = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Hp { get { return hp; } set { hp = value; } }
        public int Age { get { return age; } set { age = value; } }
    }

    class DataManager
    {
        private const string SERVER = "127.0.0.1";
        private const string PORT = "3306";
        private const string USERNAME = "tester";
        private const string PASSWORD = "1q2w3e";
        private const string DATABASE = "testdb";
        private const string TABLE = "user2";

        private static DataManager instance = new DataManager();
        public static DataManager Instance { get { return instance; } }
        private DataManager() { }

        public MySqlConnection Connect()
        {
            string strConn = $"server={SERVER};" +
                             $"port={PORT};" +
                             $"username={USERNAME};" +
                             $"password={PASSWORD};" +
                             $"database={DATABASE};";

            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        public int InsertUser()
        {
            Console.Write("아이디 : ");
            string uid = Console.ReadLine();

            Console.Write("이름 : ");
            string name = Console.ReadLine();

            Console.Write("휴대폰 : ");
            string hp = Console.ReadLine();

            Console.Write("나이 : ");
            string age = Console.ReadLine();

            MySqlConnection conn = null;
            int count = 0;

            try
            {
                conn = Connect();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO `{TABLE}' " +
                                  $"VALUES ('{uid}', '{name}', '{hp}', {age})";
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return count;
        }
        public User SelectUserAll()
        {
            Console.Write("이름검색 : ");
            string name = Console.ReadLine();

            User user = null;
            MySqlConnection conn = null;

            try
            {
                conn = Connect();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `{TABLE}` WHERE `name` = '{name}'";

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = int.Parse(reader[3].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return user;
        }

        public List<User> SelectUser()
        {
            List<User> users = new List<User>();
            MySqlConnection conn = null;

            try
            {
                conn = Connect();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `{TABLE}`";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = int.Parse(reader[3].ToString());

                    users.Add(user);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return users;
        }

        public int DeleteUser()
        {
            Console.Write("이름 삭제 : ");
            string name = Console.ReadLine();

            MySqlConnection conn = null;
            int count = 0;

            try
            {
                conn = Connect();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM `{TABLE}` WHERE `name`='{name}'";
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return count;
        }
    }
    internal class _6_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("데이터 매니저 프로그램 v2.0");
            Console.WriteLine("***********************************");

            DataManager dm = DataManager.Instance;

            while (true)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("종료:0, 입력:1, 전체조회:2, 이름조회:3, 삭제:4");
                Console.Write("선택 : ");

                int answer = 
            }
        }
    }
}
*/