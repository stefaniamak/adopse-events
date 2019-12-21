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
    public partial class EventMiniView : UserControl
    {
        public EventMiniView()
        {
            InitializeComponent();
        }

        public EventMiniView(Image eventImage, Color categoryColor) : this()
        {
            eventPictureBox.Image = eventImage;
            categoryColorControl.BackColor = categoryColor;
        }
    }
}