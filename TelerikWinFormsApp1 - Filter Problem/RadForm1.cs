using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace TelerikWinFormsApp1___Filter_Problem
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // Enabling Excel-like filtering 
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
            this.radGridView1.MasterTemplate.ShowFilteringRow = false;

            // Filling RadGridView
            int i = 1;
            radGridView1.DataSource = 
                new List<double> { 12, 24, 500, 1000, 1000.34, 43,455, 55, 43, 55, 666, 10 }.Select(x => new
                {
                    Product = string.Format("Product {0}", i++),
                    Amount = x
                });

            // Set FormatString to Dutch
            radGridView1.Columns[1].FormatInfo = new System.Globalization.CultureInfo("nl-NL");
            radGridView1.Columns[1].FormatString = "{0:€ #,###.00}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            radGridView1.FilterDescriptors.Clear();
        }
    }
}
