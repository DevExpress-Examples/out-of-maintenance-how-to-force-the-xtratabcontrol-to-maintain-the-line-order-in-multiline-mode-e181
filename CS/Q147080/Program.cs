using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DxSample.Tab;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace Q147080 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.Style = LookAndFeelStyle.Office2003;
            MyTabStylesRegistrator.Register();
            Application.Run(new MainForm());
        }
    }
}