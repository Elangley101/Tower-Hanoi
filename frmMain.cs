using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerHanoi
{
    public partial class frmMain : Form
    {
        private SoundPlayer sound = new SoundPlayer(@"soundexample.wav");
        private int steps = 0;
        private const int SLEEP_TIME = 50;
        private CancellationTokenSource tokenSource = null;


        public frmMain()
        {
            InitializeComponent();
            btnCancelSolution.Enabled = false;
            btnStopPlayingMusic.Enabled = false;

        }
        /// <summary>
        /// Start solving the Hanoi Tower
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnStartHanoiTower_Click(object sender, EventArgs e)
        {
            int totalDisks;
            if (!int.TryParse(txtTotalDisks.Text, out totalDisks) || totalDisks < 1)
            {
                MessageBox.Show("Wrong number of disk");
                txtTotalDisks.Text = "";
                txtTotalDisks.Focus();
                return;
            }
            steps = (int)(Math.Pow(2, totalDisks) - 1);
            btnCancelSolution.Enabled = true;
            tokenSource = new CancellationTokenSource();
            CancellationToken ct = tokenSource.Token;

            var progress = new Progress<int>(percent =>
            {
                pbCurrentProgress.Value = percent;
                lblPercent.Text = $"{percent}%";
            });
            txtMoves.Text = "";
            var progresssolveTowers = new Progress<string>(result =>
            {
                txtMoves.Text += result+Environment.NewLine;
            });

            try
            {
                bool isCompleted = false;
                var doProgressTask = Task.Run(() =>
                {
                    isCompleted = doProgress(progress, ct, steps);
                });

                char startPeg = 'A'; // start tower in output
                char endPeg = 'C'; // end tower in output
                char tempPeg = 'B'; // temporary tower in output
                var solveTowersTask = Task.Run(() =>
                {
                    isCompleted = solveTowers(progresssolveTowers, ct, totalDisks, startPeg, endPeg, tempPeg);
                });

                await Task.WhenAll(doProgressTask,solveTowersTask);

                if (isCompleted)
                {
                    lblPercent.Text = "Completed";
                }
                else
                {
                    lblPercent.Text = "Cancelled";
                }
                btnCancelSolution.Enabled = false;
            }
            catch (OperationCanceledException ex)
            {
                lblPercent.Text = "Cancelled";
                btnCancelSolution.Enabled = false;
            }
            finally
            {
                tokenSource.Dispose();
            }
        }
        /// <summary>
        /// do rogress
        /// </summary>
        /// <param name="progress"></param>
        /// <param name="token"></param>
        /// <param name="steps"></param>
        /// <returns></returns>
        private bool doProgress(IProgress<int> progress, CancellationToken token, int steps)
        {
            if (token.IsCancellationRequested)
            {
                return false;
            }
            for (int i = 0; i <= steps; ++i)
            {
                Thread.Sleep(SLEEP_TIME);
                var percent = (i * 100) / steps;
                if (progress != null)
                {
                    progress.Report(percent);
                }
                if (token.IsCancellationRequested)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// solve Towers
        /// </summary>
        /// <param name="progress"></param>
        /// <param name="token"></param>
        /// <param name="n"></param>
        /// <param name="startPeg"></param>
        /// <param name="endPeg"></param>
        /// <param name="tempPeg"></param>
        /// <returns></returns>
        private bool solveTowers(IProgress<string> progress, CancellationToken token, int n, char startPeg, char endPeg, char tempPeg)
        {
            if (token.IsCancellationRequested)
            {
                return false;
            }
            if (n > 0)
            {
                solveTowers(progress, token, n - 1, startPeg, tempPeg, endPeg);
                Thread.Sleep(SLEEP_TIME);
                if (progress != null)
                {
                    progress.Report($"Move disk from {startPeg} to {endPeg}");
                }
                if (token.IsCancellationRequested)
                {
                    return false;
                }
                solveTowers(progress, token,n - 1, tempPeg, endPeg, startPeg);
            }
            return true;
            
        }

        /// <summary>
        /// Cancel the solution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelSolution_Click(object sender, EventArgs e)
        {
            try
            {
                tokenSource.Cancel();
                tokenSource.Dispose();
                lblPercent.Text = "Cancelled";
                btnCancelSolution.Enabled = false;
            }
            catch (OperationCanceledException ex)
            {
                lblPercent.Text = "Cancelled";
                btnCancelSolution.Enabled = false;
                tokenSource.Dispose();
            }

        }
        /// <summary>
        /// Start Playing the music
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartPlayingMusic_Click(object sender, EventArgs e)
        {
            sound.Play();
            btnStopPlayingMusic.Enabled = true;
        }
        /// <summary>
        /// Stop Playing Music
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopPlayingMusic_Click(object sender, EventArgs e)
        {
            sound.Stop();
            btnStopPlayingMusic.Enabled = false;
        }
    }
}
