using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class n2 : CommunityToolkit.Maui.Views.Popup
{
    public n2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}