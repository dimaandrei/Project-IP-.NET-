using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProxyInterfaceManager
{
    public class ProxyInterfaceManager
    {
        #region Private Fields
        private static ProxyInterfaceManager _proxyInstance = null;
        private List<User> _users;
        private List<string> _levels;
        private const string Path = "Secure\\";
        private User _currentUser;
        #endregion
        #region Structures
        /// <summary>
        /// Structura cu informatii legate User
        /// </summary>
        public struct User
        {
            public readonly string Name;
            public readonly string PassHash;
            public readonly int AccessLevel;

            public User(string name, string passHash, int accessLevel)
            {
                Name = name;
                PassHash = passHash;
                AccessLevel = accessLevel;
            }
            public override string ToString()
            {
                return Name.ToString() + "\t" + PassHash.ToString() + "\t" + AccessLevel.ToString() + "\r\n";
            }
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Constructor ProxyDocumentManager
        /// </summary>
        private ProxyInterfaceManager()
        {
            try
            {
                _levels = new List<string>();
                StreamReader sr = new StreamReader(Path + "niveluri.txt");
                string[] lvls = sr.ReadToEnd().Split(" \t\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                sr.Close();

                for (int i = 0; i < lvls.Length; i++)
                    _levels.Add(lvls[i]);

                _users = new List<User>();
                sr = new StreamReader(Path + "utilizatori.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] toks = line.Split('\t');
                    User user = new User(toks[0], toks[1], Convert.ToInt32(toks[2]));
                    _users.Add(user);
                }
                sr.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion
        #region Getters
        /// <summary>
        /// Getter Levels
        /// </summary>
        public List<string> Levels
        {
            get { return _levels; }
        }
        /// <summary>
        /// Getter CurrentAccesLevel
        /// </summary>
        public int CurrentAccessLevel
        {
            get { return _currentUser.AccessLevel; }
        }

        #endregion
        #region Methods
        /// <summary>
        /// Metoda de Login in interfata
        /// </summary>
        /// <param name="username">Numele utilizatorului</param>
        /// <param name="password">Parola utilizatorului</param>
        /// <returns></returns>
        public bool Login(in string username, in string password)
        {

            foreach (User u in _users)
            {
                //MessageBox.Show(username + " " + Cryptography.HashString(password) + "\n" + u.Name + " " + u.PassHash);
                if (u.Name == username && u.PassHash == Cryptography.Cryptography.HashString(password))
                {
                    _currentUser = u;
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Metoda ce faciliteaza adaugarea unui nou utilizator
        /// </summary>
        /// <param name="user">Numele utilizatorului</param>
        /// <param name="pass">Parola aleasa</param>
        /// <param name="level">Nivelul de acces</param>
        public void AddUser(in string user, in string pass, in int level)
        {
            _users.Add(new User(user, Cryptography.Cryptography.HashString(pass), level));
            SaveUsers();
        }
        /// <summary>
        /// Prin aceasta metoda se salveaza utilizatorii in baza de date(fisiere in acest caz)
        /// </summary>
        private void SaveUsers()
        {

            File.WriteAllText(Path + "utilizatori.txt", String.Empty);
            using (StreamWriter sw = new StreamWriter(Path + "utilizatori.txt"))
            {
                foreach (User u in _users)
                {
                    //MessageBox.Show(u.ToString());
                    sw.Write(u.ToString());
                }
                sw.Close();
            }

        }
        public static ProxyInterfaceManager GetInstance()
        {
            if (_proxyInstance == null)
                _proxyInstance = new ProxyInterfaceManager();
            return _proxyInstance;
        }
        #endregion
    }
}
