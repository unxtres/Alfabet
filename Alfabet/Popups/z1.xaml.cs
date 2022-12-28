using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class z1 : CommunityToolkit.Maui.Views.Popup
{
    public z1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}