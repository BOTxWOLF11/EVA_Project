using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proektnaya1488
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;
        public Form1()
        {
            InitializeComponent();
            sp = new SoundPlayer();
            
        }

        public void phonk(object sender, EventArgs e)
        {

            Class1.sound_fon.PlayLooping();

            MessageBox.Show("Dobro pozhalovat' v NERV!",
                "Tokyo-3");
        }
        private void пР1ToolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void пР1ToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void вЫЙТИИЗПРОГРАММЫToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected void MDIChildNew_Click(object sender, System.EventArgs e)
        {
            if (Class1.Krol == "1")
            {
                Form5 edit = ActiveMdiChild as Form5;
                if (edit != null) edit.Save();
                /* Form4 newMDIChild = new Form4();

                 newMDIChild.MdiParent = this;
                 newMDIChild.Show();
                */
            }

        }

        private void вХОДToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();

            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        private void frr(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Violet;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void regestration(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();

            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void пР1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              
                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\1 Отчёт по практической 1.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
           
        }

        private void пР1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\5 Отчёт по практической 5.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }
        private bool isPlaying = true;
        private void button1_Click(object sender, EventArgs e)
        {


            if (isPlaying)
                Class1.sound_fon.Stop();
            else
                Class1.sound_fon.Play();
            isPlaying = !isPlaying;



        }

        private void вЫХОДИЗПОЛЬЗОВАТЕЛЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.Krol = "0";
        }

        private void ИНДПРToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Class1.Krol == "2")
            {
                try
                {
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\source\\repos\\Photokartochki(albom)1\\Photokartochki(albom)1\\bin\\Debug\\Photokartochkci.exe");

                }
                catch
                {

                    Class1.error.PlayLooping();
                    MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                        "Error No.1488");

                    Class1.error.Stop();

                    Class1.sound_fon.PlayLooping();

                }
            }

            if (Class1.Krol == "1")
            {
                DialogResult result2 = MessageBox.Show("Желаете ли вы открыть работу в режиме редактирования?",
               "NERV interface",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    try
                    {
                        System.Diagnostics.Process.Start("C:\\Users\\Димасик\\source\\repos\\Photokartochki(albom)1\\Photokartochki(albom)1.sln");

                    }
                    catch
                    {

                        Class1.error.PlayLooping();
                        MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                            "Error No.1488");

                        Class1.error.Stop();

                        Class1.sound_fon.PlayLooping();

                    }
                }
                if (result2 == DialogResult.No)
                {
                    try
                    {
                        System.Diagnostics.Process.Start("C:\\Users\\Димасик\\source\\repos\\Photokartochki(albom)1\\Photokartochki(albom)1\\bin\\Debug\\Photokartochkci.exe");

                    }
                    catch
                    {

                        Class1.error.PlayLooping();
                        MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                            "Error No.1488");

                        Class1.error.Stop();

                        Class1.sound_fon.PlayLooping();
                    }
                }


            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          /*  if (Class1.Krol == "1")
                toolStripTextBox1.Text = "Добро пожаловать, админ!";
            if (Class1.Krol == "2")
                toolStripTextBox1.Text = "Добро пожаловать, студент!";
          */
            if (Class1.Krol == "1")
          
            {
                иНДПРToolStripMenuItem.Enabled = true;
                вСТАВИТЬToolStripMenuItem.Enabled = true;
                вЫРЕЗАТЬToolStripMenuItem.Enabled = true;
                сОХРАНИТЬToolStripMenuItem.Enabled = true;

            }
            else
            {
                иНДПРToolStripMenuItem.Enabled = false;
                вСТАВИТЬToolStripMenuItem.Enabled = false;
                вЫРЕЗАТЬToolStripMenuItem.Enabled = false;
                сОХРАНИТЬToolStripMenuItem.Enabled = false;
            }
        }

        private void ВСТАВИТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ew = ActiveMdiChild as Form5;
            if (ew == null) return;
            ew.Paste();
        }

        private void ФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Class1.Krol == "1")
            {
                иНДПРToolStripMenuItem.Enabled = true;
                вСТАВИТЬToolStripMenuItem.Enabled = true;
                вЫРЕЗАТЬToolStripMenuItem.Enabled = true;
                сОХРАНИТЬToolStripMenuItem.Enabled = true;

            }
            else
            {
                иНДПРToolStripMenuItem.Enabled = false;
                вСТАВИТЬToolStripMenuItem.Enabled = false;
                вЫРЕЗАТЬToolStripMenuItem.Enabled = false;
                сОХРАНИТЬToolStripMenuItem.Enabled = false;
            }
        }

        private void ПравкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Class1.Krol == "1")
            {
                иНДПРToolStripMenuItem.Enabled = true;
                вСТАВИТЬToolStripMenuItem.Enabled = true;
                вЫРЕЗАТЬToolStripMenuItem.Enabled = true;
                сОХРАНИТЬToolStripMenuItem.Enabled = true;

            }
            else
            {
                иНДПРToolStripMenuItem.Enabled = false;
                вСТАВИТЬToolStripMenuItem.Enabled = false;
                вЫРЕЗАТЬToolStripMenuItem.Enabled = false;
                сОХРАНИТЬToolStripMenuItem.Enabled = false;
            }
        }

        private void МенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Class1.Krol == "1")
            {
                иНДПРToolStripMenuItem.Enabled = true;
                вСТАВИТЬToolStripMenuItem.Enabled = true;
                вЫРЕЗАТЬToolStripMenuItem.Enabled = true;
                сОХРАНИТЬToolStripMenuItem.Enabled = true;

            }
            else
            {
                иНДПРToolStripMenuItem.Enabled = false;
                вСТАВИТЬToolStripMenuItem.Enabled = false;
                вЫРЕЗАТЬToolStripMenuItem.Enabled = false;
                сОХРАНИТЬToolStripMenuItem.Enabled = false;
            }
        }

        private void пР1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\практика 2 задание 1\\Program.cs");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
               

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

               
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\практика 2 задание 2\\Program.cs");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharaga3.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharaga4.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharaga5.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {

                
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharagapractika4.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharagapractika41.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
               

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {

                
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharagapractica6.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharagapractika62.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
               

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharagapractika63.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
               

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {

              
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharagapractika72.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {

         
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharagapractika7.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание3ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {

             
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharagapractika73.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\massivsortir.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
               

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void сортировкаВключениемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\error.txt");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void сортировкаОбменомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\error.txt");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void двоичныйПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\dvoichniypoisk.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
                

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void задание1ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\praktikastrok.sln");
                else
                {
                    Class1.error.PlayLooping();
                    MessageBox.Show("Kuda Lezem?",
                            "prav.net");
                    Class1.error.Stop();

                    Class1.sound_fon.PlayLooping();
                }

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void задание2ToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\error.txt");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\1 Отчёт по практической 1.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\2 Отчёт по практической 2.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\3 Отчёт по практической 3.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\4 Отчёт по практической 4.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\5 Отчёт по практической 5.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\6 Отчёт по практической 6.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\7 Отчёт по практической 7.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\8 Отчёт по практической 8.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\9 Отчёт по практической 9.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void пР1ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Sharagapractika10.sln");

                else
                {
                    Class1.error.PlayLooping();
                    MessageBox.Show("Kuda Lezem?",
                            "prav.net");
                    Class1.error.Stop();

                    Class1.sound_fon.PlayLooping();
                }
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\10 Отчёт по практической 10.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\11 Отчёт по практической 11.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void пР1ToolStripMenuItem11_Click(object sender, EventArgs e)
        {/*
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\error.txt");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            */
        }
       
        private void пР1ToolStripMenuItem12_Click(object sender, EventArgs e)
        {/*
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\error.txt");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }*/
        }

        private void пР1ToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\error.txt");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\formacala\\formacala.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void запускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\formacala\\bin\\Release\\Russcalc.exe");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void редактированиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void редактированиеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\SLOVO1\\SLOVO1.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void запускToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\SLOVO1\\SLOVO1\\bin\\Release\\SLOVO.exe");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void редактированиеToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Slovo lite\\Slovo lite.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void запускToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Slovo lite\\Slovo lite\\bin\\Release\\Slovo_Lite.exe");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void грекоримскаяБорьбаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\risunok\\risunok\\bin\\Debug\\risunok.exe");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void редактированиеToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Paint app\\Paint app.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void запускToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\Paint app\\Paint app\\bin\\Release\\POKRASKA.exe");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void оТКРЫТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            otkrit(true);
        }
        void otkrit(bool open)
        {
            if (this.MdiChildren.Length < 3)
            {
                Form5 ew = new Form5();
                ew.Closing += Zakrit;
                ew.MdiParent = this;
                ew.Show();
                if (open) ew.Open();
                оТКРЫТЬToolStripMenuItem.Enabled = MdiChildren.Length != 0;
            }
            else
                MessageBox.Show("Pomilka! Vy otkrili mnoga bukav, uberite starye, chtob otkrit novye"); 
        }
        private void zakrit(Object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("До скорой встречи на рабочем месте!",
              "Пишущая машина системы MAGI",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information,
      MessageBoxDefaultButton.Button1,
      MessageBoxOptions.DefaultDesktopOnly);
            e.Cancel = false;
        }
        void Zakrit(object sender, CancelEventArgs e)
        {
           
                Form5 ew = sender as Form5;
                if (ew.Saved) return;
            /*    
            if (Class1.Krol == "1")
            {
                
                if (ew.ch)
                {
                    switch (
                        MessageBox.Show(string.Format("Сохранить правки в документе\r\n{0}", ew.FilePath), "Пишущая машина системы MAGI",
                            MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Cancel:

                            e.Cancel = true;
                            break;
                        case DialogResult.Yes:

                            ew.Save();
                            break;
                        case DialogResult.No:

                            e.Cancel = false;
                            break;
                    }
                    сОХРАНИТЬToolStripMenuItem.Enabled = e.Cancel;
                }
                else 
                {
                    ew.Save();
                }
                    
            }
            */
           
        }

        private void вЫРЕЗАТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ew = ActiveMdiChild as Form5;
            if (ew == null) return;
            ew.Cut();
        }

        private void кОПИРToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ew = ActiveMdiChild as Form5;
            if (ew == null) return;
            ew.Copy();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otkrit(false);
        }

        private void оТМЕНАДЕЙСТВИЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ew = ActiveMdiChild as Form5;
            if (ew == null) return;
            ew.nazad();
        }

        private void вОЗВРАТДЕЙСТВИЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ew = ActiveMdiChild as Form5;
            if (ew == null) return;
            ew.povtor();
        }

        private void редактированиеToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\4445\\ConsoleApp1.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\ОТЧЕТ О ВЫПОЛНЕНИИ №12.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void запускToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\4445\\ConsoleApp1\\bin\\Debug\\ConsoleApp1.exe");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Class1.Krol == "1")
                    System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\ConsoleApp4\\ConsoleApp4.sln");
                else
                    Class1.error.PlayLooping();
                MessageBox.Show("Kuda Lezem?",
                        "prav.net");
                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();
            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void отчётToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\ОТЧЕТ О ВЫПОЛНЕНИИ №13.docx");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void запускToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Process.Start("C:\\Users\\Димасик\\Desktop\\faily proekta\\практика\\ConsoleApp4\\ConsoleApp4\\bin\\Debug\\ConsoleApp4.exe");

            }
            catch
            {

                Class1.error.PlayLooping();
                MessageBox.Show("VNIMANIE!!!NA VAS NE OBNARUZHENO TRUSOV!!!",
                    "Error No.1488");

                Class1.error.Stop();

                Class1.sound_fon.PlayLooping();

            }
        }

        private void зАКРЫТЬToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ew = ActiveMdiChild as Form5;
            if (ew == null) return;
            ew.Close();
        }
    }
}
