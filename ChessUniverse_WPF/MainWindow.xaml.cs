using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChessUniverse_WPF;

public partial class MainWindow : Window
{
    private bool _t;
    private int _imgDownX;
    private int _imgDownY;
    private int _imgUpX;
    private int _imgUpY;

    private System.Windows.Point _ptLast = new System.Windows.Point();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void MouseDown(object sender, MouseEventArgs e)
    {
        _t = true;
        var img = (System.Windows.Controls.Image)sender;

        _ptLast = e.GetPosition(img);

        Mouse.Capture(img);
        StackPanel.SetZIndex(img, 1);

        label1.Content = "X: " + img.Margin.Left.ToString();
        label2.Content = "Y: " + img.Margin.Top.ToString();

        _imgDownX = (int)img.Margin.Left;
        _imgDownY = (int)img.Margin.Top;
    }

    private void MouseUp(object sender, MouseEventArgs e)
    {
        _t = false;
        var img = (System.Windows.Controls.Image)sender;

        int x = (int)(img.Margin.Left + 28.5) / 57;
        int y = (int)(img.Margin.Top + 28.5) / 57;

        Mouse.Capture(null);
        StackPanel.SetZIndex(img, 0);

        switch (img.Tag.ToString())
        {
            case "pawn":
                img.Margin = new Thickness(57 * x + 10, 57 * y + 2, 0, 0);
                break;
            case "bpawn":
                img.Margin = new Thickness(57 * x + 10, 57 * y + 2, 0, 0);
                break;
            case "rook":
                img.Margin = new Thickness(57 * x + 6, 57 * y + 4, 0, 0);
                break;
            case "knight":
                img.Margin = new Thickness(57 * x + 3, 57 * y + 3, 0, 0);
                break;
            case "bishop":
                img.Margin = new Thickness(57 * x + 7, 57 * y + 3, 0, 0);
                break;
            case "queen":
                img.Margin = new Thickness(57 * x + 4, 57 * y + 10, 0, 0);
                break;
            case "king":
                img.Margin = new Thickness(57 * x + 4, 57 * y + 7, 0, 0);
                break;
        }

        _imgUpX = (int)(img.Margin.Left);
        _imgUpY = (int)(img.Margin.Top);

        label3.Content = "M: " + img.Margin.Left.ToString() + " " + img.Margin.Top.ToString();

        RookStep(img, _imgDownX, _imgDownY, _imgUpX, _imgUpY);
    }

    private void MouseMove(object sender, MouseEventArgs e)
    {
        if (_t)
        {
            var img = (System.Windows.Controls.Image)sender;
            var ptNew = new System.Windows.Point();

            ptNew.X = img.Margin.Left;
            ptNew.Y = img.Margin.Top;

            img.Margin = new Thickness(ptNew.X + (e.GetPosition(img).X - _ptLast.X),
                ptNew.Y + (e.GetPosition(img).Y - _ptLast.Y), 0, 0);
        }
    }

    private void RookStep(Image img, int imgDownx, int imgDowny, int imgUpx, int imgUpy)
    {

        if (img.Tag.ToString() == "rook" && !(imgDownx == imgUpx || imgDowny == imgUpy))
            img.Margin = new Thickness(imgDownx, imgDowny, 0, 0);
    }
}