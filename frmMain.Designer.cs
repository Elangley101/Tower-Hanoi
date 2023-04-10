
namespace TowerHanoi
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartHanoiTower = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalDisks = new System.Windows.Forms.TextBox();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.btnCancelSolution = new System.Windows.Forms.Button();
            this.btnStartPlayingMusic = new System.Windows.Forms.Button();
            this.btnStopPlayingMusic = new System.Windows.Forms.Button();
            this.pbCurrentProgress = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartHanoiTower
            // 
            this.btnStartHanoiTower.Location = new System.Drawing.Point(28, 413);
            this.btnStartHanoiTower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartHanoiTower.Name = "btnStartHanoiTower";
            this.btnStartHanoiTower.Size = new System.Drawing.Size(330, 53);
            this.btnStartHanoiTower.TabIndex = 3;
            this.btnStartHanoiTower.Text = "Start solving the &Hanoi Tower";
            this.btnStartHanoiTower.UseVisualStyleBackColor = true;
            this.btnStartHanoiTower.Click += new System.EventHandler(this.btnStartHanoiTower_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of disk:";
            // 
            // txtTotalDisks
            // 
            this.txtTotalDisks.Location = new System.Drawing.Point(274, 35);
            this.txtTotalDisks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalDisks.Name = "txtTotalDisks";
            this.txtTotalDisks.Size = new System.Drawing.Size(148, 26);
            this.txtTotalDisks.TabIndex = 1;
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(28, 75);
            this.txtMoves.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoves.Multiline = true;
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoves.Size = new System.Drawing.Size(668, 266);
            this.txtMoves.TabIndex = 2;
            // 
            // btnCancelSolution
            // 
            this.btnCancelSolution.Location = new System.Drawing.Point(366, 413);
            this.btnCancelSolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelSolution.Name = "btnCancelSolution";
            this.btnCancelSolution.Size = new System.Drawing.Size(330, 53);
            this.btnCancelSolution.TabIndex = 4;
            this.btnCancelSolution.Text = "&Cancel the Solution";
            this.btnCancelSolution.UseVisualStyleBackColor = true;
            this.btnCancelSolution.Click += new System.EventHandler(this.btnCancelSolution_Click);
            // 
            // btnStartPlayingMusic
            // 
            this.btnStartPlayingMusic.Location = new System.Drawing.Point(28, 479);
            this.btnStartPlayingMusic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartPlayingMusic.Name = "btnStartPlayingMusic";
            this.btnStartPlayingMusic.Size = new System.Drawing.Size(330, 53);
            this.btnStartPlayingMusic.TabIndex = 5;
            this.btnStartPlayingMusic.Text = "Start &Playing the Music";
            this.btnStartPlayingMusic.UseVisualStyleBackColor = true;
            this.btnStartPlayingMusic.Click += new System.EventHandler(this.btnStartPlayingMusic_Click);
            // 
            // btnStopPlayingMusic
            // 
            this.btnStopPlayingMusic.Location = new System.Drawing.Point(366, 479);
            this.btnStopPlayingMusic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopPlayingMusic.Name = "btnStopPlayingMusic";
            this.btnStopPlayingMusic.Size = new System.Drawing.Size(330, 53);
            this.btnStopPlayingMusic.TabIndex = 6;
            this.btnStopPlayingMusic.Text = "&Stop Playing the Music";
            this.btnStopPlayingMusic.UseVisualStyleBackColor = true;
            this.btnStopPlayingMusic.Click += new System.EventHandler(this.btnStopPlayingMusic_Click);
            // 
            // pbCurrentProgress
            // 
            this.pbCurrentProgress.Location = new System.Drawing.Point(28, 358);
            this.pbCurrentProgress.Name = "pbCurrentProgress";
            this.pbCurrentProgress.Size = new System.Drawing.Size(668, 37);
            this.pbCurrentProgress.TabIndex = 7;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(331, 367);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(32, 20);
            this.lblPercent.TabIndex = 0;
            this.lblPercent.Text = "0%";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 553);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.txtTotalDisks);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopPlayingMusic);
            this.Controls.Add(this.btnStartPlayingMusic);
            this.Controls.Add(this.btnCancelSolution);
            this.Controls.Add(this.btnStartHanoiTower);
            this.Controls.Add(this.pbCurrentProgress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower of Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartHanoiTower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalDisks;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Button btnCancelSolution;
        private System.Windows.Forms.Button btnStartPlayingMusic;
        private System.Windows.Forms.Button btnStopPlayingMusic;
        private System.Windows.Forms.ProgressBar pbCurrentProgress;
        private System.Windows.Forms.Label lblPercent;
    }
}

