using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class p3 : CommunityToolkit.Maui.Views.Popup
{
    public p3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}