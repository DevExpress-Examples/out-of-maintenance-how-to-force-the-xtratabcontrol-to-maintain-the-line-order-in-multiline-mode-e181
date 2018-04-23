Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTab.Registrator
Imports DxSample.Tab.ViewInfo

Namespace DxSample.Tab.Styles
    Public Class MySkinViewInfoRegistrator
        Inherits SkinViewInfoRegistrator

        Public Sub New()
            MyBase.New()
        End Sub
        Public Overrides Function CreateHeaderViewInfo(ByVal viewInfo As BaseTabControlViewInfo) As BaseTabHeaderViewInfo
            Return New MySkinTabHeaderViewInfo(viewInfo)
        End Function
    End Class
End Namespace
