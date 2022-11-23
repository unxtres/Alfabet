using CommunityToolkit.Maui.Views;

namespace Alfabet;
public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }


    private void OnAClicked(object sender, EventArgs e)
    {
        var auto = new auto();

        this.ShowPopup(auto);
    }

    private void OnBClicked(object sender, EventArgs e)
    {
        var banan = new banan();

        this.ShowPopup(banan);

    }

    private void OnCClicked(object sender, EventArgs e)
    {
        var cytryna = new cytryna();

        this.ShowPopup(cytryna);
    }

    private void OnDClicked(object sender, EventArgs e)
    {
        var dynia = new dynia();

        this.ShowPopup(dynia);
    }

    private void OnEClicked(object sender, EventArgs e)
    {
        var eskimos = new eskimos();

        this.ShowPopup(eskimos);
    }

    private void OnFClicked(object sender, EventArgs e)
    {
        var falubaz = new falubaz();

        this.ShowPopup(falubaz);
    }
    private void OnGClicked(object sender, EventArgs e)
    {
        var gruszka = new gruszka();

        this.ShowPopup(gruszka);
    }
    private void OnHClicked(object sender, EventArgs e)
    {
        var helikopter = new helikopter();

        this.ShowPopup(helikopter);
    }
    private void OnIClicked(object sender, EventArgs e)
    {
        var iglo = new iglo();

        this.ShowPopup(iglo);
    }
    private void OnJClicked(object sender, EventArgs e)
    {
        var jajo = new jajo();

        this.ShowPopup(jajo);
    }
    private void OnKClicked(object sender, EventArgs e)
    {
        var krokodyl = new krokodyl();

        this.ShowPopup(krokodyl);
    }
    private void OnLClicked(object sender, EventArgs e)
    {
        var lew = new lew();

        this.ShowPopup(lew);
    }
    private void OnMClicked(object sender, EventArgs e)
    {
        var malpa = new malpa();

        this.ShowPopup(malpa);
    }
    private void OnNClicked(object sender, EventArgs e)
    {
        var nosorozec = new nosorozec();

        this.ShowPopup(nosorozec);
    }
    private void OnOClicked(object sender, EventArgs e)
    {
        var ogorek = new ogorek();

        this.ShowPopup(ogorek);
    }
    private void OnPClicked(object sender, EventArgs e)
    {
        var pies = new pies();

        this.ShowPopup(pies);
    }
    private void OnRClicked(object sender, EventArgs e)
    {
        var rower = new rower();

        this.ShowPopup(rower);
    }
    private void OnSClicked(object sender, EventArgs e)
    {
        var slon = new slon();

        this.ShowPopup(slon);
    }
    private void OnTClicked(object sender, EventArgs e)
    {
        var traktor = new traktor();

        this.ShowPopup(traktor);
    }
    private void OnUClicked(object sender, EventArgs e)
    {
        var ucho = new ucho();

        this.ShowPopup(ucho);
    }
    private void OnWClicked(object sender, EventArgs e)
    {
        var waz = new waz();

        this.ShowPopup(waz);
    }
    private void OnXClicked(object sender, EventArgs e)
    {
        var xylofon = new xylofon();

        this.ShowPopup(xylofon);
    }
    private void OnYClicked(object sender, EventArgs e)
    {
        var yeti = new yeti();

        this.ShowPopup(yeti);
    }
    private void OnZClicked(object sender, EventArgs e)
    {
        var zebra = new zebra();

        this.ShowPopup(zebra);
    }
}

