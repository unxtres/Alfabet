using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class z2 : CommunityToolkit.Maui.Views.Popup
{
    public z2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}