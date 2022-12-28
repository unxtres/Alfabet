using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class h3 : CommunityToolkit.Maui.Views.Popup
{
    public h3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}