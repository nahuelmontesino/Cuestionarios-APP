﻿
namespace UI
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblUserNameData = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtSeg = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.lblQustionNumber = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(12, 466);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(73, 29);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "Player:";
            this.lblPlayer.UseWaitCursor = true;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Transparent;
            this.lblGame.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.White;
            this.lblGame.Location = new System.Drawing.Point(338, 9);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(93, 35);
            this.lblGame.TabIndex = 2;
            this.lblGame.Text = "Game";
            this.lblGame.UseWaitCursor = true;
            // 
            // lblUserNameData
            // 
            this.lblUserNameData.AutoSize = true;
            this.lblUserNameData.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNameData.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameData.Location = new System.Drawing.Point(100, 472);
            this.lblUserNameData.Name = "lblUserNameData";
            this.lblUserNameData.Size = new System.Drawing.Size(22, 23);
            this.lblUserNameData.TabIndex = 5;
            this.lblUserNameData.Text = "...";
            this.lblUserNameData.UseWaitCursor = true;
            this.lblUserNameData.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(757, 244);
            this.txtMin.Multiline = true;
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(42, 27);
            this.txtMin.TabIndex = 6;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtSeg
            // 
            this.txtSeg.Location = new System.Drawing.Point(805, 244);
            this.txtSeg.Multiline = true;
            this.txtSeg.Name = "txtSeg";
            this.txtSeg.ReadOnly = true;
            this.txtSeg.Size = new System.Drawing.Size(41, 27);
            this.txtSeg.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.White;
            this.btnOption1.FlatAppearance.BorderSize = 0;
            this.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.ForeColor = System.Drawing.Color.Black;
            this.btnOption1.Location = new System.Drawing.Point(187, 146);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(404, 60);
            this.btnOption1.TabIndex = 18;
            this.btnOption1.Text = "Option 1";
            this.btnOption1.UseVisualStyleBackColor = false;
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.White;
            this.btnOption2.FlatAppearance.BorderSize = 0;
            this.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.ForeColor = System.Drawing.Color.Black;
            this.btnOption2.Location = new System.Drawing.Point(187, 212);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(404, 60);
            this.btnOption2.TabIndex = 19;
            this.btnOption2.Text = "Option2";
            this.btnOption2.UseVisualStyleBackColor = false;
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.White;
            this.btnOption3.FlatAppearance.BorderSize = 0;
            this.btnOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.ForeColor = System.Drawing.Color.Black;
            this.btnOption3.Location = new System.Drawing.Point(187, 278);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(404, 61);
            this.btnOption3.TabIndex = 20;
            this.btnOption3.Text = "Option 3";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.Color.White;
            this.btnOption4.FlatAppearance.BorderSize = 0;
            this.btnOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.ForeColor = System.Drawing.Color.Black;
            this.btnOption4.Location = new System.Drawing.Point(187, 345);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(404, 61);
            this.btnOption4.TabIndex = 21;
            this.btnOption4.Text = "Option 4";
            this.btnOption4.UseVisualStyleBackColor = false;
            // 
            // lblQustionNumber
            // 
            this.lblQustionNumber.AutoSize = true;
            this.lblQustionNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblQustionNumber.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQustionNumber.Location = new System.Drawing.Point(127, 86);
            this.lblQustionNumber.Name = "lblQustionNumber";
            this.lblQustionNumber.Size = new System.Drawing.Size(22, 24);
            this.lblQustionNumber.TabIndex = 4;
            this.lblQustionNumber.Text = "...";
            this.lblQustionNumber.UseWaitCursor = true;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(776, 205);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(56, 29);
            this.Time.TabIndex = 22;
            this.Time.Text = "Time";
            this.Time.UseWaitCursor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(25, 81);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(96, 29);
            this.lblQuestion.TabIndex = 23;
            this.lblQuestion.Text = "Question:";
            this.lblQuestion.UseWaitCursor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 504);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.txtSeg);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblUserNameData);
            this.Controls.Add(this.lblQustionNumber);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.lblPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblUserNameData;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtSeg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Label lblQustionNumber;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label lblQuestion;
    }
}