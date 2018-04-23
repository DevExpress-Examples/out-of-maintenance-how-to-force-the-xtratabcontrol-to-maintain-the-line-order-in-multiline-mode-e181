using DevExpress.XtraTab.ViewInfo;
using System.Drawing;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab;

namespace DXSample {
    public class MyXtraTabControl : XtraTabControl {
        public MyXtraTabControl() : base() { }
        private MySkinViewInfoRegistrator view;
        public override BaseViewInfoRegistrator View { get { return view; } }
        protected override void CheckInfo() {
            view = new MySkinViewInfoRegistrator();
            view.UpdateInternal();
            CreateView();
        }
    }

    public class MySkinTabHeaderViewInfo : SkinTabHeaderViewInfo {
        public MySkinTabHeaderViewInfo(BaseTabControlViewInfo viewInfo) : base(viewInfo) { }
        private MyTabRowViewInfoCollection rows = new MyTabRowViewInfoCollection();
        public override BaseTabRowViewInfoCollection Rows { get { return rows; } }
        protected override bool UpdateFillPageBounds() { return false; }
    }

    public class MySkinViewInfoRegistrator : SkinViewInfoRegistrator {
        public MySkinViewInfoRegistrator() : base() { }
        public override BaseTabHeaderViewInfo CreateHeaderViewInfo(BaseTabControlViewInfo viewInfo) {
            return new MySkinTabHeaderViewInfo(viewInfo);
        }
        internal void UpdateInternal() { base.Update(); }
    }

    public class MyTabRowViewInfoCollection : BaseTabRowViewInfoCollection {
        public MyTabRowViewInfoCollection() : base() { }
        public override void MakeSelectedRowLast() { }
    }
}