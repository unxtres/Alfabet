using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class d2 : CommunityToolkit.Maui.Views.Popup
{
    public d2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}