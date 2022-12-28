using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class e3 : CommunityToolkit.Maui.Views.Popup
{
    public e3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}