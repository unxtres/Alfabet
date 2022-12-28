using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class e1 : CommunityToolkit.Maui.Views.Popup
{
    public e1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}