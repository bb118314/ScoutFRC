﻿namespace WindowsFormsApp1
{
    partial class FRC_Statistics
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Event ID");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Match ID");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Team ID");
            this.lViewAutonomous = new System.Windows.Forms.ListView();
            this.lViewDriver = new System.Windows.Forms.ListView();
            this.tbScoutReport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lViewEndgame = new System.Windows.Forms.ListView();
            this.BtnNextMatch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lViewLogIn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lViewAutonomous
            // 
            this.lViewAutonomous.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lViewAutonomous.Location = new System.Drawing.Point(214, 122);
            this.lViewAutonomous.Name = "lViewAutonomous";
            this.lViewAutonomous.Size = new System.Drawing.Size(163, 236);
            this.lViewAutonomous.TabIndex = 1;
            this.lViewAutonomous.UseCompatibleStateImageBehavior = false;
            // 
            // lViewDriver
            // 
            this.lViewDriver.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lViewDriver.Location = new System.Drawing.Point(405, 122);
            this.lViewDriver.Name = "lViewDriver";
            this.lViewDriver.Size = new System.Drawing.Size(163, 236);
            this.lViewDriver.TabIndex = 2;
            this.lViewDriver.UseCompatibleStateImageBehavior = false;
            // 
            // tbScoutReport
            // 
            this.tbScoutReport.Location = new System.Drawing.Point(714, 41);
            this.tbScoutReport.Name = "tbScoutReport";
            this.tbScoutReport.Size = new System.Drawing.Size(74, 20);
            this.tbScoutReport.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(678, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scouting Report (1-10)";
            // 
            // lViewEndgame
            // 
            this.lViewEndgame.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lViewEndgame.Location = new System.Drawing.Point(591, 122);
            this.lViewEndgame.Name = "lViewEndgame";
            this.lViewEndgame.Size = new System.Drawing.Size(164, 236);
            this.lViewEndgame.TabIndex = 3;
            this.lViewEndgame.UseCompatibleStateImageBehavior = false;
            // 
            // BtnNextMatch
            // 
            this.BtnNextMatch.Location = new System.Drawing.Point(692, 394);
            this.BtnNextMatch.Name = "BtnNextMatch";
            this.BtnNextMatch.Size = new System.Drawing.Size(96, 44);
            this.BtnNextMatch.TabIndex = 6;
            this.BtnNextMatch.Text = "Next Match";
            this.BtnNextMatch.UseVisualStyleBackColor = true;
            this.BtnNextMatch.Click += new System.EventHandler(this.BtnNextMatch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autonomous Stats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Driver Controlled Stats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Endgame Stats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Log";
            // 
            // lViewLogIn
            // 
            this.lViewLogIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lViewLogIn.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lViewLogIn.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lViewLogIn.Location = new System.Drawing.Point(26, 122);
            this.lViewLogIn.Name = "lViewLogIn";
            this.lViewLogIn.Size = new System.Drawing.Size(167, 236);
            this.lViewLogIn.TabIndex = 0;
            this.lViewLogIn.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event ID";
            // 
            // FRC_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lViewLogIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNextMatch);
            this.Controls.Add(this.lViewEndgame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbScoutReport);
            this.Controls.Add(this.lViewDriver);
            this.Controls.Add(this.lViewAutonomous);
            this.Name = "FRC_Statistics";
            this.Text = "FRC_Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lViewAutonomous;
        private System.Windows.Forms.ListView lViewDriver;
        private System.Windows.Forms.TextBox tbScoutReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lViewEndgame;
        private System.Windows.Forms.Button BtnNextMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lViewLogIn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}