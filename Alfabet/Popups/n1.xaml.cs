using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class n1 : CommunityToolkit.Maui.Views.Popup
{
    public n1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}