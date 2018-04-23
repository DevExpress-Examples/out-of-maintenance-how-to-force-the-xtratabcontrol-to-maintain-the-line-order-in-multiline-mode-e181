using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab.Registrator;
using DxSample.Tab.ViewInfo;

namespace DxSample.Tab.Styles {
    public class MySkinViewInfoRegistrator : SkinViewInfoRegistrator {
        public MySkinViewInfoRegistrator() : base() { }
        public override BaseTabHeaderViewInfo CreateHeaderViewInfo(BaseTabControlViewInfo viewInfo) {
            return new MySkinTabHeaderViewInfo(viewInfo);
        }
    }
}
