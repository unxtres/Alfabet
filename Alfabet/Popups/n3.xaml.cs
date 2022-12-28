using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class n3 : CommunityToolkit.Maui.Views.Popup
{
    public n3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}