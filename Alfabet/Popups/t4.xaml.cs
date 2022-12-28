using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class t4 : CommunityToolkit.Maui.Views.Popup
{
    public t4()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}