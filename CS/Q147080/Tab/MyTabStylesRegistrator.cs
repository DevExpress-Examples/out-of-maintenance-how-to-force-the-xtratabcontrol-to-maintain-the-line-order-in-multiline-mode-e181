using DevExpress.XtraTab.Registrator;
using DxSample.Tab.Styles;

namespace DxSample.Tab {
    public static class MyTabStylesRegistrator {
        public static void Register() {
            PaintStyleCollection.DefaultPaintStyles.Remove("Flat");
            PaintStyleCollection.DefaultPaintStyles.Add(new MyFlatViewInfoRegistrator());
            PaintStyleCollection.DefaultPaintStyles.Remove("Office2003");
            PaintStyleCollection.DefaultPaintStyles.Add(new MyOffice2003ViewInfoRegistrator());
            PaintStyleCollection.DefaultPaintStyles.Remove("WindowsXP");
            PaintStyleCollection.DefaultPaintStyles.Add(new MyWindowsXPViewInfoRegistrator());
            PaintStyleCollection.DefaultPaintStyles.Remove("Skin");
            PaintStyleCollection.DefaultPaintStyles.Add(new MySkinViewInfoRegistrator());
        }
    }
}
