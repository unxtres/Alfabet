using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class traktor : CommunityToolkit.Maui.Views.Popup
{
    public traktor()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}