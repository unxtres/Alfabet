using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class s1 : CommunityToolkit.Maui.Views.Popup
{
    public s1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}