using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class f2 : CommunityToolkit.Maui.Views.Popup
{
    public f2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}