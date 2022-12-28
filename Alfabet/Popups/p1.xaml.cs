using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class p1 : CommunityToolkit.Maui.Views.Popup
{
    public p1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}