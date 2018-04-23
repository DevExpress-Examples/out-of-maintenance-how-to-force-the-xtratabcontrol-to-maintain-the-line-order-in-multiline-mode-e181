using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.ViewInfo;
using DxSample.Tab.ViewInfo;

namespace DxSample.Tab.Styles {
    public class MyOffice2003ViewInfoRegistrator : Office2003ViewInfoRegistrator {
        public MyOffice2003ViewInfoRegistrator() : base() { }
        public override BaseTabHeaderViewInfo CreateHeaderViewInfo(BaseTabControlViewInfo viewInfo) {
            return new MyOffice2003TabHeaderViewInfo(viewInfo);
        }
    }
}
