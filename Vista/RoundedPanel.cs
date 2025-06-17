using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    private int borderRadius = 20;

    public int BorderRadius
    {
        get => borderRadius;
        set
        {
            borderRadius = value;
            this.Invalidate(); // Redibujar el control
        }
    }

    public RoundedPanel()
    {
        this.BackColor = Color.White;
        this.DoubleBuffered = true; // Mejora el renderizado
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = GetRoundedRectanglePath(this.ClientRectangle, borderRadius))
        using (Pen pen = new Pen(this.BackColor, 1))
        {
            this.Region = new Region(path);
            e.Graphics.DrawPath(pen, path);
        }
    }

    private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();

        int diameter = radius * 2;
        Size size = new Size(diameter, diameter);
        Rectangle arc = new Rectangle(rect.Location, size);

        // Top left
        path.AddArc(arc, 180, 90);

        // Top right
        arc.X = rect.Right - diameter;
        path.AddArc(arc, 270, 90);

        // Bottom right
        arc.Y = rect.Bottom - diameter;
        path.AddArc(arc, 0, 90);

        // Bottom left
        arc.X = rect.Left;
        path.AddArc(arc, 90, 90);

        path.CloseFigure();
        return path;
    }
}
