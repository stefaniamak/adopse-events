﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Common
{
    public partial class FriendsAttending : UserControl
    {
        public FriendsAttending()
        {
            InitializeComponent();
        }

        public FriendsAttending(Image friendProfilePicture, string friendName, string friendSurname, Color categoryColor)
        {
            InitializeComponent();

            friendPicOvalPictureBox.BackgroundImage = friendProfilePicture;
            friendnameLabel.Text = friendName; // Sundiase to onoma tou filou me to epitheto 
            colorControl.BackColor = categoryColor;
        }
    }
}
