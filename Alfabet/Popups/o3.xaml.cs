using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class o3 : CommunityToolkit.Maui.Views.Popup
{
    public o3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}