<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581435/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T597204)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DesignerSample/Form1.cs) (VB: [Form1.vb](./VB/DesignerSample/Form1.vb))
* [Program.cs](./CS/DesignerSample/Program.cs) (VB: [Program.vb](./VB/DesignerSample/Program.vb))
<!-- default file list end -->

# Dashboard for WinForms - How to use a custom format for axis labels in the Chart Item

**UPDATE:** Starting with version **18.2**, we introduced the capability to format any Numeric or Date-Time Value. So, you can set formats demonstrated in this example via the Dashboard Designer's UI using the following settings without writing additional code:  
[Numeric Format X-Axis Settings](https://docs.devexpress.com/Dashboard/15155/create-dashboards/create-dashboards-in-the-winforms-designer/designing-dashboard-items/chart/axes/x-axis#numeric-format-x-axis-settings)  
[Numeric Format Y-Axis Settings](https://docs.devexpress.com/Dashboard/15156/create-dashboards/create-dashboards-in-the-winforms-designer/designing-dashboard-items/chart/axes/y-axis)  
However, you can still use approaches demonstrated in this example if you wish to implement your custom formatting not supported by the control.

Although our Dashboards do not provide a way to use custom formats and specify formats for axis labels in certain case, there is a way to format axis labels manually. This example illustrates how to format axis labels in a custom manner. For this access the underlying Chart Control in the [DashboardItemControlCreated](https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlCreated.event) event handler and handle the [CustomDrawAxisLabel](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawAxisLabel.event) event to modify the axis labels' content directly.  

---
**Note** that printed or exported documents containing a dashboard/dashboard item do not reflect appearance settings applied using the events for accessing of underlying controls.  

See also:  
- [Access to Underlying Controls](https://documentation.devexpress.com/Dashboard/18019/Building-the-Designer-and-Viewer-Applications/WinForms-Viewer/Access-to-Underlying-Controls) 
- [Web Dashboards - How to use a custom format for axis labels in the Chart Item](https://www.devexpress.com/Support/Center/p/T602710)  
---

The following three most frequently asked scenarios are represented in this example:  

**1. Add the currency sign.**  

![screenshot](/media/5fb249b9-5c53-44f8-ad06-5cf65a5fecf9.png)

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

**2. Use the ones unit format**

![screenshot](/media/4c608077-a264-4f03-a8fb-b18bd653b42c.png)


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

**3. Remove the decimal part of numbers.**

![screenshot](/media/df327637-cb42-444e-91eb-4d7a56c42ce9.png)

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
