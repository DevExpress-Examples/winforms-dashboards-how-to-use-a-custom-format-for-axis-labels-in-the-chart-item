Imports DevExpress.XtraCharts
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DesignerSample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			dashboardDesigner1.CreateRibbon()
			dashboardDesigner1.LoadDashboard("..\..\Data\T597204.xml")
		End Sub

		Private Sub dashboardDesigner1_DashboardItemControlCreated(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) Handles dashboardDesigner1.DashboardItemControlCreated
			Select Case e.DashboardItemName
				'1. Chart with the Currency Format (Y Axis)
				Case "chartDashboardItem1"
					AddHandler e.ChartControl.CustomDrawAxisLabel, AddressOf ChartControl_CustomDrawAxisLabel1
				'2. Chart with the Number Format and the Ones Unit (Y Axis)
				Case "chartDashboardItem2"
					AddHandler e.ChartControl.CustomDrawAxisLabel, AddressOf ChartControl_CustomDrawAxisLabel2
				'3. Chart with Whole Number Format (X Axis)
				Case "chartDashboardItem3"
					AddHandler e.ChartControl.CustomDrawAxisLabel, AddressOf ChartControl_CustomDrawAxisLabel3
			End Select
		End Sub

		'1. Chart with the Currency Format (Y Axis)
		Private Sub ChartControl_CustomDrawAxisLabel1(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs)
			If TypeOf e.Item.Axis Is SecondaryAxisY Then
				e.Item.Text = "$" & e.Item.Text
			End If
		End Sub
		'2. Chart with the Number Format and the Ones Unit (Y Axis)
		Private Sub ChartControl_CustomDrawAxisLabel2(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs)
			If TypeOf e.Item.Axis Is SecondaryAxisY Then
				e.Item.Text = DirectCast(e.Item.AxisValue, Double).ToString("n0")
			End If
		End Sub
		'3. Chart with Whole Number Format (X Axis)
		Private Sub ChartControl_CustomDrawAxisLabel3(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs)
			If TypeOf e.Item.Axis Is AxisX Then
				e.Item.Text = DirectCast(e.Item.AxisValue, Double).ToString("n0")
			End If
		End Sub

		Private Sub dashboardDesigner1_DashboardItemBeforeControlDisposed(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) Handles dashboardDesigner1.DashboardItemBeforeControlDisposed
			Select Case e.DashboardItemName
				'1. Chart with the Currency Format (Y Axis)
				Case "chartDashboardItem1"
					RemoveHandler e.ChartControl.CustomDrawAxisLabel, AddressOf ChartControl_CustomDrawAxisLabel1
				'2. Chart with the Number Format and the Ones Unit (Y Axis)
				Case "chartDashboardItem2"
					RemoveHandler e.ChartControl.CustomDrawAxisLabel, AddressOf ChartControl_CustomDrawAxisLabel2
				'3. Chart with Whole Number Format (X Axis)
				Case "chartDashboardItem3"
					RemoveHandler e.ChartControl.CustomDrawAxisLabel, AddressOf ChartControl_CustomDrawAxisLabel3

			End Select

		End Sub
	End Class
End Namespace
