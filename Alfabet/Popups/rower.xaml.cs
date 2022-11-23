using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class rower : CommunityToolkit.Maui.Views.Popup
{
    public rower()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}