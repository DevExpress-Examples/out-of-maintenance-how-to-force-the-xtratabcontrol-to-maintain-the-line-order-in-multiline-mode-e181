Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.ViewInfo
Imports DxSample.Tab.ViewInfo

Namespace DxSample.Tab.Styles
    Public Class MyOffice2003ViewInfoRegistrator
        Inherits Office2003ViewInfoRegistrator

        Public Sub New()
            MyBase.New()
        End Sub
        Public Overrides Function CreateHeaderViewInfo(ByVal viewInfo As BaseTabControlViewInfo) As BaseTabHeaderViewInfo
            Return New MyOffice2003TabHeaderViewInfo(viewInfo)
        End Function
    End Class
End Namespace
