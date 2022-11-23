using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class dynia : CommunityToolkit.Maui.Views.Popup
{
    public dynia()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}