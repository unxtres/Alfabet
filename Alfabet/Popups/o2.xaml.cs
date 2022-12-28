using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class o2 : CommunityToolkit.Maui.Views.Popup
{
    public o2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}