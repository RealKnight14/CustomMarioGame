// Welcome to my Game Project i am doing as part of my course work at college. I will designing a basic platform game in style of Mario Super Bros, i will be using some of the characters, backgrounds,enemies and coins within the game to make it look nice
// and appealing to people who play my game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marios_Bros_Game
{
    public partial class Form1 : Form
    {


        bool goLeft, goRight, jumping, isGameOver;

        int jumpSpeed = 10;
        int force;
        int score = 0;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enenmyOneSpeed = 5;
        int enemyTwoSpeed = 3;

        int playerSpeed = 8;

        bool onPlatform = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            player.Top += jumpSpeed;


            
            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
            }
            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {

                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;
                            onPlatform = true;

                            if ((string)x.Name == "horizontalPlatform" && goLeft == false || (string)x.Name == "horizontalPlatform" && goRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }
                        }
                        else
                        {
                            onPlatform = false;

                        }
                        if ((string)x.Tag  == "en")
                        { 


                        }
                    }   
                }
            }
            
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {

        }


        private void RestartGame()
        {

            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;

            txtScore.Text = "Score: " + score;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }


            // Reset the position of player, platform and enemies 


            player.Left = 72;
            player.Top = 656;

            enemyOne.Left = 471;
            enemyTwo.Left = 360;

            horizontalPlatform.Left = 275;
            platform1.Left = 275;

            VerticalPlatform.Top = 581;
            platform3.Top = 581;

            GameTimer.Start();


        }

        private void MoveGameElements(string direction)
        {

        }
    }
}
