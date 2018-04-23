Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.ViewInfo
Imports DxSample.Tab.ViewInfo

Namespace DxSample.Tab.Styles
    Public Class MyWindowsXPViewInfoRegistrator
        Inherits WindowsXPViewInfoRegistrator

        Public Sub New()
            MyBase.New()
        End Sub
        Public Overrides Function CreateHeaderViewInfo(ByVal viewInfo As BaseTabControlViewInfo) As BaseTabHeaderViewInfo
            Return New MyWindowsXPTabHeaderViewInfo(viewInfo)
        End Function
    End Class
End Namespace
