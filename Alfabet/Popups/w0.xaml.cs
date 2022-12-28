using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class w0 : CommunityToolkit.Maui.Views.Popup
{
    public w0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}