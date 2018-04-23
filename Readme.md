# WinForms Dashboards - How to use a custom format for axis labels in the Chart Item


<p>Although our Dashboards do not provide a way to use custom formats and specify formats for axis labels in certain case, there is a way to format axis labels manually. This example illustrates how to format axis labels in a custom manner. For this access the underlying Chart Control in the <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlCreated.event">DashboardItemControlCreated</a> event handler and handle the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawAxisLabel.event">CustomDrawAxisLabel</a> event to modify the axis labels' content directly.<br> <br><strong>Note</strong> that printed or exported documents containing a dashboard/dashboard item do not reflect appearance settings applied using the events for accessing of underlying controls.<br><br>See also:<br><a href="https://documentation.devexpress.com/Dashboard/18019/Building-the-Designer-and-Viewer-Applications/WinForms-Viewer/Access-to-Underlying-Controls">Access to Underlying Controls</a><br><a href="https://www.devexpress.com/Support/Center/p/T602710">Web Dashboards - How to use a custom format for axis labels in the Chart Item</a><br><br>The following three most frequently asked scenarios are represented in this example:<br><br><strong>1. Add the currency sign.<br><br></strong><img src="https://raw.githubusercontent.com/DevExpress-Examples/winforms-dashboards-how-to-use-a-custom-format-for-axis-labels-in-the-chart-item-t597204/16.1.4+/media/5fb249b9-5c53-44f8-ad06-5cf65a5fecf9.png"></p>


```cs
        private void dashboardDesigner1_DashboardItemControlCreated(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e)
        {
            ...
            e.ChartControl.CustomDrawAxisLabel += ChartControl_CustomDrawAxisLabel1;
            ...
            }
         private void ChartControl_CustomDrawAxisLabel1(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e)
        {
            if (e.Item.Axis is SecondaryAxisY)
                e.Item.Text = "$" + e.Item.Text;
        }
 

```


<p> </p>
<p><strong>2. Use the ones unit format <br></strong><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/winforms-dashboards-how-to-use-a-custom-format-for-axis-labels-in-the-chart-item-t597204/16.1.4+/media/4c608077-a264-4f03-a8fb-b18bd653b42c.png"></p>


```cs
        private void dashboardDesigner1_DashboardItemControlCreated(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e)
        {
            ...
            e.ChartControl.CustomDrawAxisLabel += ChartControl_CustomDrawAxisLabel2;
            ...
        }
         private void ChartControl_CustomDrawAxisLabel2(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e)
        {
            if (e.Item.Axis is SecondaryAxisY)
                e.Item.Text = ((double)e.Item.AxisValue).ToString("n0");
        }

```


<p> </p>
<p> </p>
<p> </p>
<p><br><strong>3. Remove the decimal part of numbers.<br></strong><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/winforms-dashboards-how-to-use-a-custom-format-for-axis-labels-in-the-chart-item-t597204/16.1.4+/media/df327637-cb42-444e-91eb-4d7a56c42ce9.png"></p>


```cs
private void dashboardDesigner1_DashboardItemControlCreated(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e)
        {
            ...
            e.ChartControl.CustomDrawAxisLabel += ChartControl_CustomDrawAxisLabel3;
            ...
        }
        private void ChartControl_CustomDrawAxisLabel3(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e)
        {
            if (e.Item.Axis is AxisX)
                e.Item.Text = ((double)e.Item.AxisValue).ToString("n0");
        }
```



<br/>


