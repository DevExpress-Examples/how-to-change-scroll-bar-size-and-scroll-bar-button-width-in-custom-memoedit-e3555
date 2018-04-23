﻿using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1
{
    public class MyMemoEditVScrollBar : DevExpress.XtraEditors.VScrollBar
    {
        public MyMemoEditVScrollBar() : base() { }

        protected override ScrollBarPainterBase CreateScrollBarPainter()
        {
            if (LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
                return new MyScrollBarPainter(LookAndFeel.ActiveLookAndFeel);
            else
                return base.CreateScrollBarPainter();
        }

        protected override ScrollBarViewInfo CreateScrollBarViewInfo()
        {
            return new MyMemoEditScrollBarViewInfo(this);
        }
        
        public new MyMemoEditScrollBarViewInfo ViewInfo
        {
            get
            {
                return base.ViewInfo as MyMemoEditScrollBarViewInfo;
            }
        }
    }
}
