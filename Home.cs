using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoelGame
{
    public partial class Home : Form
    {
        static int user_x_default = 0;
        static int user_y_default = 0;

        static int rockX = 0;
        static int rockY = 0;

        static int thong1X = 0;
        static int thong1Y = 0;

        static int thong2X = 0;
        static int thong2Y = 0;

        static int score = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            user_x_default = users.Location.X;
            user_y_default= users.Location.Y;

            rockX = rock.Location.X;
            rockY = rock.Location.Y;

            thong1X = thong1.Location.X;
            thong1Y = thong1.Location.Y;

            thong2X = thong2.Location.X;
            thong2Y = thong2.Location.Y;



            rockLeft();

            bgTree();

        }

        private bool CheckRockTouch()
        {

            return (users.Location.Y + users.Height > rock.Location.Y) && (users.Location.Y < rock.Location.Y + rock.Height) && (rock.Location.X + rock.Width > users.Location.X) && (rock.Location.X < users.Location.X + users.Width);

        }

      //  bool checkRockX()
     //   {
        //    return (rock.Location.X + rock.Width > users.Location.X) && (rock.Location.X < users.Location.X + users.Width);
       // }



        static int xUp = 0;
        async void spaceUp()
        {
            await Task.Delay(10);
            xUp += 1;
            users.Location = new Point(user_x_default, users.Location.Y - 20);
            users.Refresh(); 
            if (xUp<20) { spaceUp(); }
            else { spaceDown(); }
            
        }

        async void spaceDown()
        {
            await Task.Delay(10);
            xUp -= 1;
            users.Location = new Point(user_x_default, users.Location.Y + 20);
            users.Refresh();
            if (xUp > 0) { spaceDown(); } else {
                users.Location = new Point(user_x_default, user_y_default);
                users.Refresh();
            }
        }
        private void Home_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                spaceUp();
                realeaseMemory();
            }

        }

        async void rockLeft()
        {
                await Task.Delay(10);

            rock.Left -= 20;
           if(CheckRockTouch())
            {
                MessageBox.Show("Game lost!");
                realeaseMemory();
                rock.Location = new Point(rockX, rockY);
                rock.Refresh();
                score = 0;
                lbScore.Text = "Score: " + score.ToString();
                rockLeft();
            } else
            {
                if (rock.Location.X + rock.Width < 0)
                {
                    rock.Location = new Point(rockX, rockY);
                    rock.Refresh();
                    score += 1;
                    if (score >= 50)
                    {
                        MessageBox.Show("You win!");
                        score = 0;
                    }
                    lbScore.Text = "Score: " + score.ToString();
                    rockLeft();
                }
                else
                {
                    rockLeft();
                }


            }
           
        }

        async void bgTree()
        {
            if (score < 10)
            {
                await Task.Delay(50);
            }
            else if (score < 20)
            {
                await Task.Delay(40);
            }
            else if (score < 30)
            {
                await Task.Delay(30);
            }
            else if (score < 40)
            {
                await Task.Delay(20);
            }
            //Cay thong1
            thong1.Left -= 10;
            if (thong1.Location.X + thong1.Width < 0)
            {
                thong1.Location = new Point(thong1X, thong1Y);
                thong1.Refresh();
            } 
            //Caythong2
            thong2.Left -= 10;
            if (thong2.Location.X + thong2.Width < 0)
            {
                thong2.Location = new Point(thong2X, thong2Y);
                thong2.Refresh();
            }
            bgTree();
        }


            private static void realeaseMemory()
        {


            GC.Collect();
            GC.WaitForPendingFinalizers();
        }




    }
}
