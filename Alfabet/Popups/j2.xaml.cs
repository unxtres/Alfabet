using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class j2 : CommunityToolkit.Maui.Views.Popup
{
    public j2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}