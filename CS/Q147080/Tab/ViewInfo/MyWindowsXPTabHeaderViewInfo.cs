﻿using DevExpress.XtraTab.ViewInfo;

namespace DxSample.Tab.ViewInfo {
    public class MyWindowsXPTabHeaderViewInfo : WindowsXPTabHeaderViewInfo {
        public MyWindowsXPTabHeaderViewInfo(BaseTabControlViewInfo viewInfo) : base(viewInfo) { }
        private MyTabRowViewInfoCollection rows = new MyTabRowViewInfoCollection();
        public override BaseTabRowViewInfoCollection Rows { get { return rows; } }
        protected override bool UpdateFillPageBounds() { return false; }
    }
}
