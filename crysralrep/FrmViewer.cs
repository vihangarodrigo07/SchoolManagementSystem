﻿using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;

namespace crysralrep
{
    public partial class FrmViewer : Form
    {
        public FrmViewer()
        {
            InitializeComponent();
        }

        private void FrmViewer_Load(object sender, EventArgs e)
        {
            
        }

        public void SetReport(object Rep)
        {
            this.CrViewer.ReportSource = Rep;
            this.Show();
        }
    }
}
