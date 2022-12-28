using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class k2 : CommunityToolkit.Maui.Views.Popup
{
    public k2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}