using System.Drawing.Drawing2D;

namespace win_crud.Forms;
public class CustomPanel : Panel
{
    public CustomPanel()
    {
        BackColor = Color.White;
        ForeColor = Color.Black;
        Size = new Size(350, 200);
    }

    #region Fileds
    private int borderRadius = 30;
    private float gradientAngle = 90F;
    private Color gradientTopColor = Color.DarkViolet;
    private Color gradientButtomColor = Color.Violet;
    #endregion

    #region Properties
    public int BorderRadius
    {
        get => borderRadius;
        set { borderRadius = value; Invalidate(); }
    }


    public float GradientAngle
    {
        get => gradientAngle;
        set { gradientAngle = value; Invalidate(); }
    }

    public Color GradientTopColor
    {
        get => gradientTopColor;
        set { gradientTopColor = value; Invalidate(); }
    }

    public Color GradientButtomColor
    {
        get => gradientButtomColor;
        set { gradientButtomColor = value; Invalidate(); }
    }
    #endregion

    #region Methods
    public static GraphicsPath GetPath(RectangleF rectangle, float radius)
    {
        GraphicsPath path = new GraphicsPath();
        float widthRadius = rectangle.Width - radius;
        float heightRadius = rectangle.Height - radius;

        path.StartFigure();
        path.AddArc(widthRadius, heightRadius, radius, radius, 0, 90);
        path.AddArc(rectangle.X, heightRadius, radius, radius, 90, 90);
        path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
        path.AddArc(widthRadius, rectangle.Y, radius, radius, 270, 90);
        path.CloseFigure();
        return path;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        //Gradient
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        LinearGradientBrush brush = new(ClientRectangle, GradientTopColor, GradientButtomColor, GradientAngle);
        Graphics graphics = e.Graphics;
        graphics.FillRectangle(brush, ClientRectangle);

        //BorderRadius
        RectangleF rectangleF = new(0, 0, Width, Height);
        if (borderRadius > 2)
        {
            using GraphicsPath graphicsPath = GetPath(rectangleF, borderRadius);
            using Pen pen = new(Parent.BackColor, 2);
            Region = new Region(graphicsPath);
            e.Graphics.DrawPath(pen, graphicsPath);
        }
        else Region = new Region(rectangleF);
    }
    #endregion
}
