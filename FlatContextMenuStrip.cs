using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

internal class FlatContextMenuStrip : ContextMenuStrip
{
    public class TColorTable : ProfessionalColorTable
    {
        private Color CheckedColor;

        private Color BorderColor;

        [Category("Colors")]
        public Color _CheckedColor
        {
            get
            {
                return CheckedColor;
            }
            set
            {
                CheckedColor = value;
            }
        }

        [Category("Colors")]
        public Color _BorderColor
        {
            get
            {
                return BorderColor;
            }
            set
            {
                BorderColor = value;
            }
        }

        public override Color ButtonSelectedBorder => Color.Red;

        public override Color CheckBackground => CheckedColor;

        public override Color CheckPressedBackground => CheckedColor;

        public override Color CheckSelectedBackground => CheckedColor;

        public override Color ImageMarginGradientBegin => CheckedColor;

        public override Color ImageMarginGradientEnd => CheckedColor;

        public override Color ImageMarginGradientMiddle => CheckedColor;

        public override Color MenuBorder => BorderColor;

        public override Color MenuItemBorder => BorderColor;

        public override Color MenuItemSelected => CheckedColor;

        public override Color SeparatorDark => BorderColor;

        public override Color ToolStripDropDownBackground => Color.FromArgb(43, 47, 48);

        public TColorTable()
        {
            CheckedColor = Color.FromArgb(57, 62, 63); 
            BorderColor = Color.FromArgb(53, 64, 78);
        }
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }

    public FlatContextMenuStrip()
    {
        base.Renderer = new ToolStripProfessionalRenderer(new TColorTable());
        base.ShowImageMargin = false;
        base.ForeColor = Color.FromArgb(147, 157, 160);
        Font = new Font("Segoe UI", 8f);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
    }
}
