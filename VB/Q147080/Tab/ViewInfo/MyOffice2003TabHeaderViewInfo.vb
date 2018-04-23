Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTab.Drawing

Namespace DxSample.Tab.ViewInfo
    Public Class MyOffice2003TabHeaderViewInfo
        Inherits Office2003TabHeaderViewInfo

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
End Namespace
