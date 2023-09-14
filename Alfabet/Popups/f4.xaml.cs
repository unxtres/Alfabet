using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class f4 : CommunityToolkit.Maui.Views.Popup
{
    public f4()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}