Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DxSample.Tab
Imports DevExpress.UserSkins
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace Q147080
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            BonusSkins.Register()
            SkinManager.EnableFormSkins()
            UserLookAndFeel.Default.Style = LookAndFeelStyle.Office2003
            MyTabStylesRegistrator.Register()
            Application.Run(New MainForm())
        End Sub
    End Class
End Namespace