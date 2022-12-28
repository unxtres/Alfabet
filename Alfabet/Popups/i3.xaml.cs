using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class i3 : CommunityToolkit.Maui.Views.Popup
{
    public i3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}