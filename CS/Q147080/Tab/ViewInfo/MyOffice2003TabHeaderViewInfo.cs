using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab.Drawing;

namespace DxSample.Tab.ViewInfo {
    public class MyOffice2003TabHeaderViewInfo : Office2003TabHeaderViewInfo {
        public MyOffice2003TabHeaderViewInfo(BaseTabControlViewInfo viewInfo) : base(viewInfo) { }
        private MyTabRowViewInfoCollection rows = new MyTabRowViewInfoCollection();
        public override BaseTabRowViewInfoCollection Rows { get { return rows; } }
        protected override bool UpdateFillPageBounds() { return false; }
    }
}
