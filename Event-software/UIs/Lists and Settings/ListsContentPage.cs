﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.valentina
{
    public partial class ListsContentPage : UserControl
    {
        public ListsContentPage()
        {
            InitializeComponent();
        }      


        private void ListsContentPage_Load(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.ListsContentPageLoad();
        }
    }
}
