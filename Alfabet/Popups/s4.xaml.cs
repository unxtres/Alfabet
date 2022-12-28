using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class s4 : CommunityToolkit.Maui.Views.Popup
{
    public s4()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}