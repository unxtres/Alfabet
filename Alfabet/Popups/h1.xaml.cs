using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class h1 : CommunityToolkit.Maui.Views.Popup
{
    public h1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}