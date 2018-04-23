Namespace DesignerSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dashboardDesigner1 = New DevExpress.DashboardWin.DashboardDesigner()
			Me.SuspendLayout()
			' 
			' dashboardDesigner1
			' 
			Me.dashboardDesigner1.DataSourceWizardSettings.AvailableDataSourceTypes = (CType((((((DevExpress.DashboardWin.DashboardDesignerDataSourceType.Sql Or DevExpress.DashboardWin.DashboardDesignerDataSourceType.Olap) Or DevExpress.DashboardWin.DashboardDesignerDataSourceType.Object) Or DevExpress.DashboardWin.DashboardDesignerDataSourceType.EF) Or DevExpress.DashboardWin.DashboardDesignerDataSourceType.Excel) Or DevExpress.DashboardWin.DashboardDesignerDataSourceType.Extract), DevExpress.DashboardWin.DashboardDesignerDataSourceType))
			Me.dashboardDesigner1.DataSourceWizardSettings.EnableCustomSql = True
			Me.dashboardDesigner1.DataSourceWizardSettings.QueryBuilderDiagramView = False
			Me.dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardDesigner1.Location = New System.Drawing.Point(0, 0)
			Me.dashboardDesigner1.Name = "dashboardDesigner1"
			Me.dashboardDesigner1.Size = New System.Drawing.Size(1299, 744)
			Me.dashboardDesigner1.TabIndex = 0
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.dashboardDesigner1.DashboardItemControlCreated += new DevExpress.DashboardWin.DashboardItemControlCreatedEventHandler(this.dashboardDesigner1_DashboardItemControlCreated);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.dashboardDesigner1.DashboardItemBeforeControlDisposed += new DevExpress.DashboardWin.DashboardItemBeforeControlDisposedEventHandler(this.dashboardDesigner1_DashboardItemBeforeControlDisposed);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1299, 744)
			Me.Controls.Add(Me.dashboardDesigner1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents dashboardDesigner1 As DevExpress.DashboardWin.DashboardDesigner
	End Class
End Namespace