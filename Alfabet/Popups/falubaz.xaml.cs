using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class falubaz : CommunityToolkit.Maui.Views.Popup
{
    public falubaz()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}