using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КубикиИгра
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Count = 5, UserScore = 0, AIScore = 0;

        public void FillCube(int Cube, PictureBox pb)
        {
            switch (Cube)
            {
                case 1:
                    pb.Image = Image.FromFile("Images/1.png");break;
                case 2:
                    pb.Image = Image.FromFile("Images/2.png");break;
                case 3:
                    pb.Image = Image.FromFile("Images/3.png");break;
                case 4:
                    pb.Image = Image.FromFile("Images/4.png");break;
                case 5:
                    pb.Image = Image.FromFile("Images/5.png");break;
                case 6:
                    pb.Image = Image.FromFile("Images/6.png");break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Count > 0)
            {
                Random R = new Random();

                int UserCube = R.Next(1, 7), AICube = R.Next(1, 7);
                FillCube(UserCube, pictureBox1);
                FillCube(AICube, pictureBox2);
                PictureBox UserBox = groupBox1.Controls["UserPB" + Count] as PictureBox;
                PictureBox AIBox = groupBox1.Controls["AIPB" + Count] as PictureBox;
                FillCube(UserCube, UserBox);
                FillCube(AICube, AIBox);
                UserScore += UserCube; label4.Text = "Игрок: " + UserScore;
                AIScore += AICube; label5.Text = "Компьютер: " + AIScore;
                Count--;
                label3.Text = "Осталось попыток: " + Count;
                if (Count == 0)
                {
                    if (UserScore > AIScore)
                    {
                        MessageBox.Show("Победил игрок\n" + "Счет игрока " + UserScore + "\n" + "Счет компьютера " + AIScore, "Результат игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (AIScore > UserScore)
                    {
                        MessageBox.Show("Победил Компьютер\n"+ "Счет игрока "+ UserScore + "\n" + "Счет компьютера "+AIScore, "Результат игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Ничья!\n" + "Счет игрока " + UserScore + "\n" + "Счет компьютера " + AIScore, "Результат игры", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                
            }
            else
            {
                DialogResult rezult = MessageBox.Show("Попытки закончились\nХотите ли вы начать новую игру?",
                      "Бросок кубика невозможен", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rezult == DialogResult.Yes)
                {
                    button2.PerformClick();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Count = 5;
            label3.Text = "Осталось поппыток " + Count;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            UserScore = 0; AIScore = 0;
            label4.Text = "Игрок: " + UserScore;
            label5.Text = "Компьютер: " + AIScore;
            for (int i = 1; i < 6; i++)
            {
                PictureBox pb = groupBox1.Controls["UserPb" + i] as PictureBox;
                pb.Image = null;
                pb = groupBox1.Controls["AIPb" + i] as PictureBox;
                pb.Image = null;
            }
        }
    }
}
