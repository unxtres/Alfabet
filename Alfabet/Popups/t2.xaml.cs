using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class t2 : CommunityToolkit.Maui.Views.Popup
{
    public t2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}