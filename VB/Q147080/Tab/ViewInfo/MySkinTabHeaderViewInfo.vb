Imports DevExpress.XtraTab.ViewInfo

Namespace DxSample.Tab.ViewInfo
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
End Namespace
