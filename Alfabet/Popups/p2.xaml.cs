using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class p2 : CommunityToolkit.Maui.Views.Popup
{
    public p2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}