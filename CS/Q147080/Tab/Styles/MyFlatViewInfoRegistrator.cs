using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.ViewInfo;
using DxSample.Tab.ViewInfo;

namespace DxSample.Tab.Styles {
    public class MyFlatViewInfoRegistrator : FlatViewInfoRegistrator {
        public MyFlatViewInfoRegistrator() : base() { }
        public override BaseTabHeaderViewInfo CreateHeaderViewInfo(BaseTabControlViewInfo viewInfo) {
            return new MyFlatTabHeaderViewInfo(viewInfo);
        }
    }
}
