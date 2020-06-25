using N_Queen.Models;
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

namespace N_Queen
{
    public partial class frmMain : Form
    {
        Bitmap bitmap;
        public static Panel pnl;
        Graphics g;
        static Dictionary<string, CustomControl> boardData = new Dictionary<string, CustomControl>();
        int N = -1;
        public frmMain()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            pnl = pnlBoard;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormSettings();
            AddHandlers();
        }
        private void FormSettings()
        {
            pnlGroupHC.Height = 25;
            pnlGroupLBS.Height = 25;
            pnlGroupSA.Height = 25;
           // CreateBoard();
        }
        private void AddHandlers()
        {
            btnHillCilmbing.Click += BtnHillCilmbing_Click;
            btnLocalBeamSearch.Click += BtnLocalBeamSearch_Click;
            btnSimulatedAnnealing.Click += BtnSimulatedAnnealing_Click;
            pnlBoard.Paint += PnlBoard_Paint;
            btnRunHC.Click += BtnRunHC_Click;
            btnRunLBS.Click += BtnRunLBS_Click;
            btnRunSA.Click += BtnRunSA_Click;
            btnCreateMap.Click += BtnCreateMap_Click;
        }

        private void BtnCreateMap_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(txtNumberOfQueen.Text);
            CreateBoard();
            pnlBoard.Invalidate();
        }

        private void BtnRunSA_Click(object sender, EventArgs e)
        {
            //TestSimulatedAnnealing();
            CreateBoard();

            (int[] result,int iteration,int cost)= Algorithms.SimulatedAnnealing(N, Convert.ToInt32(txtMaxIterationSA.Text), Convert.ToDouble(txtTempreture.Text), Convert.ToDouble(txtCoolingFactor.Text));
            if (cost == 0)
            {
                MessageBox.Show("Solution Found. Number of Iteration: " + iteration.ToString());
            }
            else
            {
                MessageBox.Show("Solution NOT Found!!! Best found solution will be print.");

            }
            SetArray2Map(result);
            pnlBoard.Invalidate();

        }

        private void BtnRunLBS_Click(object sender, EventArgs e)
        {
            //TestLocalBeamSearch();
            CreateBoard();

            (int[] result,int iteration,int cost) = Algorithms.LocalBeamSearch(N, Convert.ToInt32(txtMaxIterationLBS.Text), Convert.ToInt32(txtStatesLBS.Text));
            if (cost == 0)
            {
                MessageBox.Show("Solution Found. Number of Iteration: " + iteration.ToString());
            }
            else
            {
                MessageBox.Show("Solution NOT Found!!! Best found solution will be print.");

            }
            SetArray2Map(result);
            pnlBoard.Invalidate();
        }
        private void BtnRunHC_Click(object sender, EventArgs e)
        {
            //TestHillClimbing();
            CreateBoard();
            (int[] result,int iteration,int cost) = Algorithms.HillClimbing(N, Convert.ToInt32(txtMaxIterationHC.Text));
            if (cost == 0)
            {
                MessageBox.Show("Solution Found. Number of Iteration: " + iteration.ToString());
            }
            else
            {
                MessageBox.Show("Solution NOT Found!!! Best found solution will be print.");

            }
            SetArray2Map(result);
            pnlBoard.Invalidate();
        }

        private void TestHillClimbing()
        {
            int sum = 0;
            int failed = 0;
            for (int i = 0; i < 100; ++i)
            {
                (int[] result, int iteration, int cost) = Algorithms.HillClimbing(8, 100000);
                if (cost == 0)
                {
                    sum += iteration;
                }
                else
                {
                    sum += iteration;
                    failed++;
                }
            }
            MessageBox.Show((sum / 100).ToString() + "," + failed.ToString());
        }
        private void TestLocalBeamSearch()
        {
            int sum = 0;
            int failed = 0;
            for (int i = 0; i < 100; ++i)
            {
                (int[] result, int iteration, int cost) = Algorithms.LocalBeamSearch(20, 100000,5);
                if (cost == 0)
                {
                    sum += iteration;
                }
                else
                {
                    sum += iteration;
                    failed++;
                }
            }
            MessageBox.Show((sum / 100).ToString() + "," + failed.ToString());
        }
        private void TestSimulatedAnnealing()
        {
            int sum = 0;
            int failed = 0;
            for (int i = 0; i < 100; ++i)
            {
                (int[] result, int iteration, int cost) = Algorithms.SimulatedAnnealing(20, 100000, 20,0.9);
                if (cost == 0)
                {
                    sum += iteration;
                }
                else
                {
                    sum += iteration;
                    failed++;
                }
            }
            MessageBox.Show((sum / 100).ToString() + "," + failed.ToString());
        }

       
        public static void SetArray2Map(int[] result)
        {
            boardData.Values.ToList().ForEach(x => { x.IsQueen = false; });
            for (int i = 0; i < result.Length; ++i)
            {
                string key = i.ToString() + "," + result[i].ToString();
                boardData[key].IsQueen = true;
            }

        }

        private void PnlBoard_Paint(object sender, PaintEventArgs e)
        {
            if (N != -1)
            {
                string a = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                g.Clear(Color.Transparent);
                //pnlMain.Controls.Clear();
                foreach (CustomControl c in boardData.Values)
                {
                    if (c.Color == 'R')
                    {
                        g.FillRectangle(Brushes.IndianRed, new RectangleF(c.Location, c.Size));
                        g.DrawRectangle(Pens.Black, new Rectangle(c.Location, c.Size));
                        if (c.IsQueen)
                        {
                            Bitmap q = new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Icons\queen.png");
                            g.DrawImage(q, new Rectangle(c.Location, c.Size));
                        }


                    }
                    else if (c.Color == 'W')
                    {
                        g.FillRectangle(Brushes.MintCream, new RectangleF(c.Location, c.Size));
                        g.DrawRectangle(Pens.Black, new Rectangle(c.Location, c.Size));
                        if (c.IsQueen)
                        {
                            Bitmap q = new Bitmap(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Icons\queen.png");
                            g.DrawImage(q, new Rectangle(c.Location, c.Size));
                        }
                    }
                }
                picBoard.Image = bitmap;
            }
            
        }

        private void BtnSimulatedAnnealing_Click(object sender, EventArgs e)
        {
            if (pnlGroupSA.Height == 25)
            {
                pnlGroupHC.Height = 25;
                pnlGroupLBS.Height = 25;
                pnlGroupSA.Height = 25 * 7 + 20;
            }
            else
            {
                pnlGroupSA.Height = 25;
            }
        }

        private void BtnLocalBeamSearch_Click(object sender, EventArgs e)
        {
            if (pnlGroupLBS.Height == 25)
            {
                pnlGroupHC.Height = 25;
                pnlGroupSA.Height = 25;
                pnlGroupLBS.Height = 25 * 5 + 20;
            }
            else
            {
                pnlGroupLBS.Height = 25;
            }
        }

        private void BtnHillCilmbing_Click(object sender, EventArgs e)
        {
            if (pnlGroupHC.Height == 25)
            {
                pnlGroupLBS.Height = 25;
                pnlGroupSA.Height = 25;
                pnlGroupHC.Height = 25 * 4 + 5;
            }
            else
            {
                pnlGroupHC.Height = 25;
            }
        }
        private void CreateBoard()
        {
            N = Convert.ToInt32(txtNumberOfQueen.Text);
            boardData.Clear();
            float width = pnlBoard.Size.Width;
            float height = pnlBoard.Size.Height;
            bitmap = new Bitmap(pnlBoard.Size.Width, pnlBoard.Size.Height);
            g = Graphics.FromImage(bitmap);

            int rec_width = Convert.ToInt32(pnlBoard.Size.Width / N);
            int rec_height = Convert.ToInt32(pnlBoard.Size.Height / N);
            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        CustomControl custom = new CustomControl { IsQueen = false, Color = 'W', col = i, row = j, Size = new Size(rec_width, rec_height), Location = new Point(i * rec_width, j * rec_height) };
                        custom.Rect = new RectangleF(custom.Location, custom.Size);
                        boardData.Add($"{i},{j}", custom);
                    }
                    else
                    {
                        CustomControl custom = new CustomControl { IsQueen = false, Color = 'R', col = i, row = j, Size = new Size(rec_width, rec_height), Location = new Point(i * rec_width, j * rec_height) };
                        custom.Rect = new RectangleF(custom.Location, custom.Size);

                        boardData.Add($"{i},{j}", custom);
                    }
                }
            }
        }
    }
}
