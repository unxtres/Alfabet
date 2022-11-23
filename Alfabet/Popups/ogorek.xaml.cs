using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class ogorek : CommunityToolkit.Maui.Views.Popup
{
    public ogorek()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}