﻿using Cuestionarios.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CurrentUser : UserControl
    {
        public CurrentUser(String userName)
        {
            InitializeComponent();
            this.lblUserData.Text = userName;
        }
    }
}
