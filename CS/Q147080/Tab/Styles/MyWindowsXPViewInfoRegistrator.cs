using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.ViewInfo;
using DxSample.Tab.ViewInfo;

namespace DxSample.Tab.Styles {
    public class MyWindowsXPViewInfoRegistrator : WindowsXPViewInfoRegistrator {
        public MyWindowsXPViewInfoRegistrator() : base() { }
        public override BaseTabHeaderViewInfo CreateHeaderViewInfo(BaseTabControlViewInfo viewInfo) {
            return new MyWindowsXPTabHeaderViewInfo(viewInfo);
        }
    }
}
