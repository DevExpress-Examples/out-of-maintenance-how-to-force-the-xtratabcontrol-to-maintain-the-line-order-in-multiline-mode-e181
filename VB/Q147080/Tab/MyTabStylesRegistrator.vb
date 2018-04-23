Imports DevExpress.XtraTab.Registrator
Imports DxSample.Tab.Styles

Namespace DxSample.Tab
    Public NotInheritable Class MyTabStylesRegistrator

        Private Sub New()
        End Sub

        Public Shared Sub Register()
            PaintStyleCollection.DefaultPaintStyles.Remove("Flat")
            PaintStyleCollection.DefaultPaintStyles.Add(New MyFlatViewInfoRegistrator())
            PaintStyleCollection.DefaultPaintStyles.Remove("Office2003")
            PaintStyleCollection.DefaultPaintStyles.Add(New MyOffice2003ViewInfoRegistrator())
            PaintStyleCollection.DefaultPaintStyles.Remove("WindowsXP")
            PaintStyleCollection.DefaultPaintStyles.Add(New MyWindowsXPViewInfoRegistrator())
            PaintStyleCollection.DefaultPaintStyles.Remove("Skin")
            PaintStyleCollection.DefaultPaintStyles.Add(New MySkinViewInfoRegistrator())
        End Sub
    End Class
End Namespace
