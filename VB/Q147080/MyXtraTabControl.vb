Imports Microsoft.VisualBasic
Imports DevExpress.XtraTab.ViewInfo
Imports System.Drawing
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab

Namespace DXSample
	Public Class MyXtraTabControl
		Inherits XtraTabControl
		Public Sub New()
			MyBase.New()
		End Sub
		Private view_Renamed As MySkinViewInfoRegistrator
		Public Overrides ReadOnly Property View() As BaseViewInfoRegistrator
			Get
				Return view_Renamed
			End Get
		End Property
		Protected Overrides Sub CheckInfo()
			view_Renamed = New MySkinViewInfoRegistrator()
			view_Renamed.UpdateInternal()
			CreateView()
		End Sub
	End Class

	Public Class MySkinTabHeaderViewInfo
		Inherits SkinTabHeaderViewInfo
		Public Sub New(ByVal viewInfo As BaseTabControlViewInfo)
			MyBase.New(viewInfo)
		End Sub
		Private rows_Renamed As New MyTabRowViewInfoCollection()
		Public Overrides ReadOnly Property Rows() As BaseTabRowViewInfoCollection
			Get
				Return rows_Renamed
			End Get
		End Property
		Protected Overrides Function UpdateFillPageBounds() As Boolean
			Return False
		End Function
	End Class

	Public Class MySkinViewInfoRegistrator
		Inherits SkinViewInfoRegistrator
		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides Function CreateHeaderViewInfo(ByVal viewInfo As BaseTabControlViewInfo) As BaseTabHeaderViewInfo
			Return New MySkinTabHeaderViewInfo(viewInfo)
		End Function
		Friend Sub UpdateInternal()
			MyBase.Update()
		End Sub
	End Class

	Public Class MyTabRowViewInfoCollection
		Inherits BaseTabRowViewInfoCollection
		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides Sub MakeSelectedRowLast()
		End Sub
	End Class
End Namespace