using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class p0 : CommunityToolkit.Maui.Views.Popup
{
    public p0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}