using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class s2 : CommunityToolkit.Maui.Views.Popup
{
    public s2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}