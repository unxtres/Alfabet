using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class t3 : CommunityToolkit.Maui.Views.Popup
{
    public t3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}