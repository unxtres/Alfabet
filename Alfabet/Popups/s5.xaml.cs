using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class s5 : CommunityToolkit.Maui.Views.Popup
{
    public s5()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}