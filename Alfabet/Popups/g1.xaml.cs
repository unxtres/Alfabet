using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class g1 : CommunityToolkit.Maui.Views.Popup
{
    public g1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}