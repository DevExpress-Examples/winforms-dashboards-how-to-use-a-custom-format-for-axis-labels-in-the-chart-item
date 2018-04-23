using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignerSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            dashboardDesigner1.LoadDashboard(@"..\..\Data\T597204.xml");
        }

        private void dashboardDesigner1_DashboardItemControlCreated(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e)
        {
            switch (e.DashboardItemName)
            {
                //1. Chart with the Currency Format (Y Axis)
                case "chartDashboardItem1":
                    e.ChartControl.CustomDrawAxisLabel += ChartControl_CustomDrawAxisLabel1;
                    break;
                //2. Chart with the Number Format and the Ones Unit (Y Axis)
                case "chartDashboardItem2":
                    e.ChartControl.CustomDrawAxisLabel += ChartControl_CustomDrawAxisLabel2;
                    break;
                //3. Chart with Whole Number Format (X Axis)
                case "chartDashboardItem3":
                    e.ChartControl.CustomDrawAxisLabel += ChartControl_CustomDrawAxisLabel3;
                    break;
            }
        }

        //1. Chart with the Currency Format (Y Axis)
        private void ChartControl_CustomDrawAxisLabel1(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e)
        {
            if (e.Item.Axis is SecondaryAxisY)
            {
                e.Item.Text = "$" + e.Item.Text;
            }
        }
        //2. Chart with the Number Format and the Ones Unit (Y Axis)
        private void ChartControl_CustomDrawAxisLabel2(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e)
        {
            if (e.Item.Axis is SecondaryAxisY)
            {
                e.Item.Text = ((double)e.Item.AxisValue).ToString("n0");
            }
        }
        //3. Chart with Whole Number Format (X Axis)
        private void ChartControl_CustomDrawAxisLabel3(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e)
        {
            if (e.Item.Axis is AxisX)
            {
                e.Item.Text = ((double)e.Item.AxisValue).ToString("n0");
            }
        }

        private void dashboardDesigner1_DashboardItemBeforeControlDisposed(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e)
        {
            switch (e.DashboardItemName)
            {
                //1. Chart with the Currency Format (Y Axis)
                case "chartDashboardItem1":
                    e.ChartControl.CustomDrawAxisLabel -= ChartControl_CustomDrawAxisLabel1;
                    break;
                //2. Chart with the Number Format and the Ones Unit (Y Axis)
                case "chartDashboardItem2":
                    e.ChartControl.CustomDrawAxisLabel -= ChartControl_CustomDrawAxisLabel2;
                    break;
                //3. Chart with Whole Number Format (X Axis)
                case "chartDashboardItem3":
                    e.ChartControl.CustomDrawAxisLabel -= ChartControl_CustomDrawAxisLabel3;
                    break;

            }

        }
    }
}
