using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace proektnaya1488
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
           


        }


        private const string FileName = "cumplimentation.txt";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication();
            using (StreamWriter Write = new StreamWriter(FileName, false, Encoding.Default))
            {
                Write.Write("admin;admin;1");
            }
        }
        private void Authentication()
        {
            if (!File.Exists(FileName))
            {
                MessageBox.Show("Файл не существует."
                    ,
                    "Помилка");

                using (StreamWriter Write = new StreamWriter(FileName, false, Encoding.Default))
                {
                    Write.Write("admin;admin;1");
                }

                MessageBox.Show("Запись добавлена.",
                    "Решение"
                    );
            }
            else
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    CheckRights();
                }
                else
                {
                    Class1.error.PlayLooping();
                    MessageBox.Show("Увага!!! На вас не виявлено трусів!",
                        "Error No.1337");
                    Class1.error.Stop();
                    Class1.sound_fon.PlayLooping();
                }
            }
        }

        private void CheckRights()
        {
            Authority NewAuthority = new Authority(FileName, textBox1.Text, textBox2.Text);

            var X = NewAuthority.IncorrectInput();

            if (X.Count() != 0)
            {
                foreach (var Row in X)
                {
                    if (Row.Role == 1)
                    {
                        MessageBox.Show($"Вход членов S.E.E.L.E.  ({Row.User}).");
                        Class1.Krol = "1";
                       
                        
                        //this.Close();
                    }
                    if (Row.Role == 2)
                    {
                        MessageBox.Show($"Вход для пилота Евы ({Row.User}).");
                        Class1.Krol = "2";
                       
                        this.Close();
                    }
                    if (Class1.Krol == "1")
                    {
                        pictureBox1.Visible = true;
                        label4.Visible = true;
                        MessageBox.Show("SEELE is power"+
                            "Nerv");
                        this.Close();
                    }
                    if (Class1.Krol == "2")
                    {
                        pictureBox1.Visible = false;
                        label4.Visible = false;
                    }


                }

            }
            else
            {

                Class1.error.PlayLooping();
                MessageBox.Show("Неверный логин или пароль. Наденьте трусы для входа.",
                    "NERV");
                Class1.error.Stop();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

    public class Authority
    {
        private readonly string _FileName;

        private readonly string _Login;

        private readonly string _Password;

        public Authority(string FileName, string Login, string Password)
        {
            this._FileName = FileName;

            this._Login = Login;

            this._Password = Password;
        }

        public List<Authentication> IncorrectInput()
        {
            string[] Data = File.ReadAllLines(_FileName);

            List<Authentication> Lst = new List<Authentication>();

            for (int i = 0; i < Data.Length; i++)
            {
                Authentication Auth = new Authentication();

                string[] Row = Data[i].Split(';');

                Auth.User = Row[0];

                Auth.Password = Row[1];

                Auth.Role = Convert.ToInt32(Row[2]);

                Lst.Add(Auth);
            }

            return Lst.Where(w => w.User == _Login && w.Password == _Password).ToList();
        }
    }

    public struct Authentication
    {
        public string User { get; set; }

        public string Password { get; set; }

        public int Role { get; set; }
    }
}







