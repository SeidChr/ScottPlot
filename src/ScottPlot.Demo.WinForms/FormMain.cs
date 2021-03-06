﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottPlot.Demo.WinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormStartup_Load(object sender, EventArgs e)
        {
            versionLabel.Text = Tools.GetVersionString();
        }

        private void cookbookButton_Click(object sender, EventArgs e)
        {
            new FormCookbook().ShowDialog();
        }

        private void MouseTrackerButton_Click(object sender, EventArgs e)
        {
            new WinFormsDemos.MouseTracker().ShowDialog();
        }

        private void ToggleVisibilityButton_Click(object sender, EventArgs e)
        {
            new WinFormsDemos.ToggleVisibility().ShowDialog();
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            new WinFormsDemos.FormsPlotConfig().ShowDialog();
        }

        private void TransparentBackgroundButton_Click(object sender, EventArgs e)
        {
            new WinFormsDemos.TransparentBackground().ShowDialog();
        }

        private void LinkedAxesButton_Click(object sender, EventArgs e)
        {
            new WinFormsDemos.LinkedPlots().ShowDialog();
        }

        private void LiveData_Click(object sender, EventArgs e)
        {
            new WinFormsDemos.LiveDataUpdate().ShowDialog();
        }

        private void GrowingData_Click(object sender, EventArgs e)
        {
            new WinFormsDemos.LiveDataIncoming().ShowDialog();
        }

        private void btnShowOnHover_Click(object sender, EventArgs e)
        {
            new WinFormsDemos.ShowValueOnHover().ShowDialog();
        }
    }
}
