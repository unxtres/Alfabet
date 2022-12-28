using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class h2 : CommunityToolkit.Maui.Views.Popup
{
    public h2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}