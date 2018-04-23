Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.ViewInfo
Imports DxSample.Tab.ViewInfo

Namespace DxSample.Tab.Styles
    Public Class MyFlatViewInfoRegistrator
        Inherits FlatViewInfoRegistrator

        Public Sub New()
            MyBase.New()
        End Sub
        Public Overrides Function CreateHeaderViewInfo(ByVal viewInfo As BaseTabControlViewInfo) As BaseTabHeaderViewInfo
            Return New MyFlatTabHeaderViewInfo(viewInfo)
        End Function
    End Class
End Namespace
