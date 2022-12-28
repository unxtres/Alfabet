using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class g2 : CommunityToolkit.Maui.Views.Popup
{
    public g2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}