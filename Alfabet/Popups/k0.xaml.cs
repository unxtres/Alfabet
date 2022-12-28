using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class k0 : CommunityToolkit.Maui.Views.Popup
{
    public k0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}