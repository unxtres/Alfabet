using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class f3 : CommunityToolkit.Maui.Views.Popup
{
    public f3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}