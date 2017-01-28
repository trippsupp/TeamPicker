namespace TeamPicker
{
    partial class Frame
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
            this.lbPlayerPool = new System.Windows.Forms.ListBox();
            this.lbTeam1 = new System.Windows.Forms.ListBox();
            this.lbTeam2 = new System.Windows.Forms.ListBox();
            this.lblPlayerPool = new System.Windows.Forms.Label();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblWhosTurn = new System.Windows.Forms.Label();
            this.butPick = new System.Windows.Forms.Button();
            this.butClearAll = new System.Windows.Forms.Button();
            this.butStartOver = new System.Windows.Forms.Button();
            this.flTeam1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flTeam2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.flTeam1.SuspendLayout();
            this.flTeam2.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlayerPool
            // 
            this.lbPlayerPool.FormattingEnabled = true;
            this.lbPlayerPool.Location = new System.Drawing.Point(66, 141);
            this.lbPlayerPool.Name = "lbPlayerPool";
            this.lbPlayerPool.Size = new System.Drawing.Size(155, 173);
            this.lbPlayerPool.TabIndex = 0;
            this.lbPlayerPool.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbTeam1
            // 
            this.lbTeam1.FormattingEnabled = true;
            this.lbTeam1.Location = new System.Drawing.Point(15, 16);
            this.lbTeam1.Name = "lbTeam1";
            this.lbTeam1.Size = new System.Drawing.Size(155, 173);
            this.lbTeam1.TabIndex = 1;
            // 
            // lbTeam2
            // 
            this.lbTeam2.FormattingEnabled = true;
            this.lbTeam2.Location = new System.Drawing.Point(15, 16);
            this.lbTeam2.Name = "lbTeam2";
            this.lbTeam2.Size = new System.Drawing.Size(155, 173);
            this.lbTeam2.TabIndex = 2;
            // 
            // lblPlayerPool
            // 
            this.lblPlayerPool.AutoSize = true;
            this.lblPlayerPool.Location = new System.Drawing.Point(66, 122);
            this.lblPlayerPool.Name = "lblPlayerPool";
            this.lblPlayerPool.Size = new System.Drawing.Size(60, 13);
            this.lblPlayerPool.TabIndex = 3;
            this.lblPlayerPool.Text = "Player Pool";
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Location = new System.Drawing.Point(15, 0);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(80, 13);
            this.lblTeam1.TabIndex = 4;
            this.lblTeam1.Text = "Team 1 Players";
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Location = new System.Drawing.Point(15, 0);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(80, 13);
            this.lblTeam2.TabIndex = 5;
            this.lblTeam2.Text = "Team 2 Players";
            // 
            // lblWhosTurn
            // 
            this.lblWhosTurn.AutoSize = true;
            this.lblWhosTurn.BackColor = System.Drawing.Color.Salmon;
            this.lblWhosTurn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWhosTurn.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhosTurn.Location = new System.Drawing.Point(218, 43);
            this.lblWhosTurn.Name = "lblWhosTurn";
            this.lblWhosTurn.Size = new System.Drawing.Size(413, 36);
            this.lblWhosTurn.TabIndex = 6;
            this.lblWhosTurn.Text = "It is Team 1\'s turn to choose";
            // 
            // butPick
            // 
            this.butPick.Location = new System.Drawing.Point(17, 19);
            this.butPick.Name = "butPick";
            this.butPick.Size = new System.Drawing.Size(75, 23);
            this.butPick.TabIndex = 7;
            this.butPick.Text = "Pick";
            this.butPick.UseVisualStyleBackColor = true;
            this.butPick.Click += new System.EventHandler(this.butPick_Click);
            // 
            // butClearAll
            // 
            this.butClearAll.Location = new System.Drawing.Point(17, 147);
            this.butClearAll.Name = "butClearAll";
            this.butClearAll.Size = new System.Drawing.Size(75, 23);
            this.butClearAll.TabIndex = 8;
            this.butClearAll.Text = "Clear all";
            this.butClearAll.UseVisualStyleBackColor = true;
            this.butClearAll.Click += new System.EventHandler(this.butClearAll_Click);
            // 
            // butStartOver
            // 
            this.butStartOver.Location = new System.Drawing.Point(17, 118);
            this.butStartOver.Name = "butStartOver";
            this.butStartOver.Size = new System.Drawing.Size(75, 23);
            this.butStartOver.TabIndex = 9;
            this.butStartOver.Text = "Start over";
            this.butStartOver.UseVisualStyleBackColor = true;
            this.butStartOver.Click += new System.EventHandler(this.butStartOver_Click);
            // 
            // flTeam1
            // 
            this.flTeam1.BackColor = System.Drawing.Color.LightGreen;
            this.flTeam1.Controls.Add(this.lblTeam1);
            this.flTeam1.Controls.Add(this.lbTeam1);
            this.flTeam1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flTeam1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flTeam1.Location = new System.Drawing.Point(411, 122);
            this.flTeam1.Name = "flTeam1";
            this.flTeam1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.flTeam1.Size = new System.Drawing.Size(186, 209);
            this.flTeam1.TabIndex = 10;
            // 
            // flTeam2
            // 
            this.flTeam2.Controls.Add(this.lblTeam2);
            this.flTeam2.Controls.Add(this.lbTeam2);
            this.flTeam2.Location = new System.Drawing.Point(617, 122);
            this.flTeam2.Name = "flTeam2";
            this.flTeam2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.flTeam2.Size = new System.Drawing.Size(184, 209);
            this.flTeam2.TabIndex = 11;
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.butClearAll);
            this.gbButtons.Controls.Add(this.butStartOver);
            this.gbButtons.Controls.Add(this.butPick);
            this.gbButtons.Location = new System.Drawing.Point(257, 138);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(113, 176);
            this.gbButtons.TabIndex = 12;
            this.gbButtons.TabStop = false;
            this.gbButtons.Text = "Controls";
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(855, 508);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.flTeam2);
            this.Controls.Add(this.flTeam1);
            this.Controls.Add(this.lblWhosTurn);
            this.Controls.Add(this.lblPlayerPool);
            this.Controls.Add(this.lbPlayerPool);
            this.Name = "Frame";
            this.Text = "Vance Field | Team Picker";
            this.Load += new System.EventHandler(this.Frame_Load);
            this.flTeam1.ResumeLayout(false);
            this.flTeam1.PerformLayout();
            this.flTeam2.ResumeLayout(false);
            this.flTeam2.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlayerPool;
        private System.Windows.Forms.ListBox lbTeam1;
        private System.Windows.Forms.ListBox lbTeam2;
        private System.Windows.Forms.Label lblPlayerPool;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblWhosTurn;
        private System.Windows.Forms.Button butPick;
        private System.Windows.Forms.Button butClearAll;
        private System.Windows.Forms.Button butStartOver;
        private System.Windows.Forms.FlowLayoutPanel flTeam1;
        private System.Windows.Forms.FlowLayoutPanel flTeam2;
        private System.Windows.Forms.GroupBox gbButtons;
    }
}

