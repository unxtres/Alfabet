using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class k3 : CommunityToolkit.Maui.Views.Popup
{
    public k3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}