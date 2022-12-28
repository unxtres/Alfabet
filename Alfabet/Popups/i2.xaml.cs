using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class i2 : CommunityToolkit.Maui.Views.Popup
{
    public i2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}