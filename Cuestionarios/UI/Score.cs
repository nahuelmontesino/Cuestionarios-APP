﻿using Cuestionarios.Controllers;
using Cuestionarios.Models.Domain;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Score : Form
    {
        private readonly SessionController _sessionController;
        public Score(SessionController sessionController)
        {
            _sessionController = sessionController;

            InitializeComponent();

            try
            {
                dataGridView1.DataSource = _sessionController.GetHighScores().Select(o => new
                { Username = o.User.Username, Score = o.Score, TimeOnSeconds = o.TotalTime, DateOfScore = o.Date }).ToList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Couldn't access highscores: ", exc.Message);
            }
        }

        private void brnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
