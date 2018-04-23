Imports DevExpress.XtraTab.ViewInfo

Namespace DxSample.Tab
    Public Class MyTabRowViewInfoCollection
        Inherits BaseTabRowViewInfoCollection

        Public Sub New()
            MyBase.New()
        End Sub
        Public Overrides Sub MakeSelectedRowLast()
        End Sub
    End Class
End Namespace
