namespace N_Queen
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlGroupSA = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCoolingFactor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTempreture = new System.Windows.Forms.TextBox();
            this.btnRunSA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxIterationSA = new System.Windows.Forms.TextBox();
            this.btnSimulatedAnnealing = new System.Windows.Forms.Button();
            this.pnlGroupLBS = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatesLBS = new System.Windows.Forms.TextBox();
            this.btnRunLBS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxIterationLBS = new System.Windows.Forms.TextBox();
            this.btnLocalBeamSearch = new System.Windows.Forms.Button();
            this.pnlGroupHC = new System.Windows.Forms.Panel();
            this.btnRunHC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxIterationHC = new System.Windows.Forms.TextBox();
            this.btnHillCilmbing = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumberOfQueen = new System.Windows.Forms.TextBox();
            this.btnCreateMap = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlGroupSA.SuspendLayout();
            this.pnlGroupLBS.SuspendLayout();
            this.pnlGroupHC.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBoard);
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(958, 604);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBoard
            // 
            this.pnlBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBoard.Controls.Add(this.picBoard);
            this.pnlBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(720, 601);
            this.pnlBoard.TabIndex = 1;
            // 
            // picBoard
            // 
            this.picBoard.Location = new System.Drawing.Point(4, 4);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(100, 50);
            this.picBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoard.TabIndex = 0;
            this.picBoard.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.pnlGroupSA);
            this.pnlMenu.Controls.Add(this.pnlGroupLBS);
            this.pnlMenu.Controls.Add(this.pnlGroupHC);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(729, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(229, 604);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlGroupSA
            // 
            this.pnlGroupSA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGroupSA.Controls.Add(this.label6);
            this.pnlGroupSA.Controls.Add(this.txtCoolingFactor);
            this.pnlGroupSA.Controls.Add(this.label5);
            this.pnlGroupSA.Controls.Add(this.txtTempreture);
            this.pnlGroupSA.Controls.Add(this.btnRunSA);
            this.pnlGroupSA.Controls.Add(this.label3);
            this.pnlGroupSA.Controls.Add(this.txtMaxIterationSA);
            this.pnlGroupSA.Controls.Add(this.btnSimulatedAnnealing);
            this.pnlGroupSA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGroupSA.Location = new System.Drawing.Point(0, 247);
            this.pnlGroupSA.Name = "pnlGroupSA";
            this.pnlGroupSA.Size = new System.Drawing.Size(225, 195);
            this.pnlGroupSA.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cooling Factor";
            // 
            // txtCoolingFactor
            // 
            this.txtCoolingFactor.Location = new System.Drawing.Point(10, 142);
            this.txtCoolingFactor.Name = "txtCoolingFactor";
            this.txtCoolingFactor.Size = new System.Drawing.Size(201, 20);
            this.txtCoolingFactor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Temprature";
            // 
            // txtTempreture
            // 
            this.txtTempreture.Location = new System.Drawing.Point(10, 92);
            this.txtTempreture.Name = "txtTempreture";
            this.txtTempreture.Size = new System.Drawing.Size(201, 20);
            this.txtTempreture.TabIndex = 4;
            // 
            // btnRunSA
            // 
            this.btnRunSA.Location = new System.Drawing.Point(77, 168);
            this.btnRunSA.Name = "btnRunSA";
            this.btnRunSA.Size = new System.Drawing.Size(75, 23);
            this.btnRunSA.TabIndex = 3;
            this.btnRunSA.Text = "Run";
            this.btnRunSA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max Iteration:";
            // 
            // txtMaxIterationSA
            // 
            this.txtMaxIterationSA.Location = new System.Drawing.Point(10, 47);
            this.txtMaxIterationSA.Name = "txtMaxIterationSA";
            this.txtMaxIterationSA.Size = new System.Drawing.Size(201, 20);
            this.txtMaxIterationSA.TabIndex = 1;
            // 
            // btnSimulatedAnnealing
            // 
            this.btnSimulatedAnnealing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSimulatedAnnealing.Location = new System.Drawing.Point(0, 0);
            this.btnSimulatedAnnealing.Name = "btnSimulatedAnnealing";
            this.btnSimulatedAnnealing.Size = new System.Drawing.Size(223, 23);
            this.btnSimulatedAnnealing.TabIndex = 0;
            this.btnSimulatedAnnealing.Text = "Simulated Annealing";
            this.btnSimulatedAnnealing.UseVisualStyleBackColor = true;
            // 
            // pnlGroupLBS
            // 
            this.pnlGroupLBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGroupLBS.Controls.Add(this.label4);
            this.pnlGroupLBS.Controls.Add(this.txtStatesLBS);
            this.pnlGroupLBS.Controls.Add(this.btnRunLBS);
            this.pnlGroupLBS.Controls.Add(this.label2);
            this.pnlGroupLBS.Controls.Add(this.txtMaxIterationLBS);
            this.pnlGroupLBS.Controls.Add(this.btnLocalBeamSearch);
            this.pnlGroupLBS.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGroupLBS.Location = new System.Drawing.Point(0, 100);
            this.pnlGroupLBS.Name = "pnlGroupLBS";
            this.pnlGroupLBS.Size = new System.Drawing.Size(225, 147);
            this.pnlGroupLBS.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of States:";
            // 
            // txtStatesLBS
            // 
            this.txtStatesLBS.Location = new System.Drawing.Point(10, 86);
            this.txtStatesLBS.Name = "txtStatesLBS";
            this.txtStatesLBS.Size = new System.Drawing.Size(201, 20);
            this.txtStatesLBS.TabIndex = 4;
            // 
            // btnRunLBS
            // 
            this.btnRunLBS.Location = new System.Drawing.Point(77, 112);
            this.btnRunLBS.Name = "btnRunLBS";
            this.btnRunLBS.Size = new System.Drawing.Size(75, 23);
            this.btnRunLBS.TabIndex = 3;
            this.btnRunLBS.Text = "Run";
            this.btnRunLBS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Iteration:";
            // 
            // txtMaxIterationLBS
            // 
            this.txtMaxIterationLBS.Location = new System.Drawing.Point(10, 47);
            this.txtMaxIterationLBS.Name = "txtMaxIterationLBS";
            this.txtMaxIterationLBS.Size = new System.Drawing.Size(201, 20);
            this.txtMaxIterationLBS.TabIndex = 1;
            // 
            // btnLocalBeamSearch
            // 
            this.btnLocalBeamSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocalBeamSearch.Location = new System.Drawing.Point(0, 0);
            this.btnLocalBeamSearch.Name = "btnLocalBeamSearch";
            this.btnLocalBeamSearch.Size = new System.Drawing.Size(223, 23);
            this.btnLocalBeamSearch.TabIndex = 0;
            this.btnLocalBeamSearch.Text = "Local Beam Search";
            this.btnLocalBeamSearch.UseVisualStyleBackColor = true;
            // 
            // pnlGroupHC
            // 
            this.pnlGroupHC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGroupHC.Controls.Add(this.btnRunHC);
            this.pnlGroupHC.Controls.Add(this.label1);
            this.pnlGroupHC.Controls.Add(this.txtMaxIterationHC);
            this.pnlGroupHC.Controls.Add(this.btnHillCilmbing);
            this.pnlGroupHC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGroupHC.Location = new System.Drawing.Point(0, 0);
            this.pnlGroupHC.Name = "pnlGroupHC";
            this.pnlGroupHC.Size = new System.Drawing.Size(225, 100);
            this.pnlGroupHC.TabIndex = 0;
            // 
            // btnRunHC
            // 
            this.btnRunHC.Location = new System.Drawing.Point(77, 72);
            this.btnRunHC.Name = "btnRunHC";
            this.btnRunHC.Size = new System.Drawing.Size(75, 23);
            this.btnRunHC.TabIndex = 3;
            this.btnRunHC.Text = "Run";
            this.btnRunHC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Iteration:";
            // 
            // txtMaxIterationHC
            // 
            this.txtMaxIterationHC.Location = new System.Drawing.Point(8, 42);
            this.txtMaxIterationHC.Name = "txtMaxIterationHC";
            this.txtMaxIterationHC.Size = new System.Drawing.Size(201, 20);
            this.txtMaxIterationHC.TabIndex = 1;
            // 
            // btnHillCilmbing
            // 
            this.btnHillCilmbing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHillCilmbing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHillCilmbing.Location = new System.Drawing.Point(0, 0);
            this.btnHillCilmbing.Name = "btnHillCilmbing";
            this.btnHillCilmbing.Size = new System.Drawing.Size(223, 23);
            this.btnHillCilmbing.TabIndex = 0;
            this.btnHillCilmbing.Text = "Hill Climbing";
            this.btnHillCilmbing.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateMap);
            this.panel1.Controls.Add(this.txtNumberOfQueen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 100);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Number Of Queen:";
            // 
            // txtNumberOfQueen
            // 
            this.txtNumberOfQueen.Location = new System.Drawing.Point(9, 19);
            this.txtNumberOfQueen.Name = "txtNumberOfQueen";
            this.txtNumberOfQueen.Size = new System.Drawing.Size(201, 20);
            this.txtNumberOfQueen.TabIndex = 1;
            // 
            // btnCreateMap
            // 
            this.btnCreateMap.Location = new System.Drawing.Point(78, 45);
            this.btnCreateMap.Name = "btnCreateMap";
            this.btnCreateMap.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMap.TabIndex = 4;
            this.btnCreateMap.Text = "Create Board";
            this.btnCreateMap.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 604);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "N-Queen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlBoard.ResumeLayout(false);
            this.pnlBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlGroupSA.ResumeLayout(false);
            this.pnlGroupSA.PerformLayout();
            this.pnlGroupLBS.ResumeLayout(false);
            this.pnlGroupLBS.PerformLayout();
            this.pnlGroupHC.ResumeLayout(false);
            this.pnlGroupHC.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlGroupHC;
        private System.Windows.Forms.Button btnRunHC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxIterationHC;
        private System.Windows.Forms.Button btnHillCilmbing;
        private System.Windows.Forms.Panel pnlGroupSA;
        private System.Windows.Forms.Button btnRunSA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxIterationSA;
        private System.Windows.Forms.Button btnSimulatedAnnealing;
        private System.Windows.Forms.Panel pnlGroupLBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatesLBS;
        private System.Windows.Forms.Button btnRunLBS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxIterationLBS;
        private System.Windows.Forms.Button btnLocalBeamSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCoolingFactor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTempreture;
        private System.Windows.Forms.PictureBox picBoard;
        public System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumberOfQueen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateMap;
    }
}

