using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class g3 : CommunityToolkit.Maui.Views.Popup
{
    public g3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}