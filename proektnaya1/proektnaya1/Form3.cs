using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proektnaya1488
{
    public partial class Form3 : Form
    {
        private const string FileName = "cumplimentation.txt";
        StringBuilder Data = new StringBuilder();
        public Form3()
        {

            InitializeComponent();
            
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
            if (Class1.Krol == "1")
            {
                listBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void vhod_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox1.Text)
            {
                if (textBox1.TextLength >= 6 && textBox1.TextLength <= 32 && textBox2.TextLength >= 2 && textBox2.TextLength <= 32)
                {
                    string i1 = "";
                    using (StreamWriter Write = new StreamWriter(FileName, false, Encoding.Default))
                    {
                        Write.Write("admin;admin;1");
                    }
                    string i = string.Join(";", textBox2.Text, textBox1.Text);
                    if (listBox1.Text == "Админ")
                    {
                        i1 = string.Join(";", "1");
                    }
                    if (listBox1.Text == "Студент")
                    {
                        i1 = string.Join(";", "2");
                    }
                    else
                    {
                        i1 = string.Join(";", "2");
                    }
                    string qwe = i + ";" + i1;
                    Data.AppendLine(qwe);



                    File.WriteAllText("C:\\Users\\Димасик\\source\\repos\\proektnaya1488\\proektnaya1488\\bin\\Debug\\cumplimentation.txt", Data.ToString());
                }
                else
                { MessageBox.Show("Nesootvetstvie!!! Parol dolzhen soderzhat ot 6 do 32 znakov, Login - ot 2"); }
                   
                
            }
            else
            { MessageBox.Show("paroli ne sovpadayut"); }
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Shown(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
