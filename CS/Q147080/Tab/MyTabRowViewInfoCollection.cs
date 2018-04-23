using DevExpress.XtraTab.ViewInfo;

namespace DxSample.Tab {
    public class MyTabRowViewInfoCollection : BaseTabRowViewInfoCollection {
        public MyTabRowViewInfoCollection() : base() { }
        public override void MakeSelectedRowLast() { }
    }
}
