using CommunityToolkit.Maui.Views;

namespace Alfabet;
public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    Random rnd = new Random();
    public int number;
    public int temp;
    public int w69 = 0;

    private void OnAClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 5);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var a0 = new a0();
                    this.ShowPopup(a0);
                    break;
                }
            case 1:
                {
                    var a1 = new a1();
                    this.ShowPopup(a1);
                    break;
                }
            case 2:
                {
                    var a2 = new a2();
                    this.ShowPopup(a2);
                    break;
                }
            case 3:
                {
                    var a3 = new a3();
                    this.ShowPopup(a3);
                    break;
                }
            case 4:
                {
                    var a4 = new a4();
                    this.ShowPopup(a4);
                    break;
                }
        }
    }
    private void OnBClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var b0 = new b0();
                    this.ShowPopup(b0);
                    break;
                }
            case 1:
                {
                    var b1 = new b1();
                    this.ShowPopup(b1);
                    break;
                }
            case 2:
                {
                    var b2 = new b2();
                    this.ShowPopup(b2);
                    break;
                }
            case 3:
                {
                    var b3 = new b3();
                    this.ShowPopup(b3);
                    break;
                }
        }
    }

    private void OnCClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var c0 = new c0();
                    this.ShowPopup(c0);
                    break;
                }
            case 1:
                {
                    var c1 = new c1();
                    this.ShowPopup(c1);
                    break;
                }
            case 2:
                {
                    var c2 = new c2();
                    this.ShowPopup(c2);
                    break;
                }
            case 3:
                {
                    var c3 = new c3();
                    this.ShowPopup(c3);
                    break;
                }
        }
    }

    private void OnDClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var d1 = new d1();
                    this.ShowPopup(d1);
                    break;
                }
            case 1:
                {
                    var d1 = new d1();
                    this.ShowPopup(d1);
                    break;
                }
            case 2:
                {
                    var d2 = new d2();
                    this.ShowPopup(d2);
                    break;
                }
            case 3:
                {
                    var d3 = new d3();
                    this.ShowPopup(d3);
                    break;
                }
        }
    }

    private void OnEClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var e0 = new e0();
                    this.ShowPopup(e0);
                    break;
                }
            case 1:
                {
                    var e1 = new e1();
                    this.ShowPopup(e1);
                    break;
                }
            case 2:
                {
                    var e2 = new e2();
                    this.ShowPopup(e2);
                    break;
                }
            case 3:
                {
                    var e3 = new e3();
                    this.ShowPopup(e3);
                    break;
                }
        }
    }

    private void OnFClicked(object sender, EventArgs e)
    {
        w69++;

        if (w69 == 10)
        {
            var falubaz = new falubaz();
            this.ShowPopup(falubaz);
            w69 = 0;
        }
        else
        {
            while (number == temp)
            {
                number = rnd.Next(0, 4);
            }
            temp = number;

            switch (number)
            {
                case 0:
                    {
                        var f0 = new f0();
                        this.ShowPopup(f0);
                        break;
                    }
                case 1:
                    {
                        var f1 = new f1();
                        this.ShowPopup(f1);
                        break;
                    }
                case 2:
                    {
                        var f2 = new f2();
                        this.ShowPopup(f2);
                        break;
                    }
                case 3:
                    {
                        var f3 = new f3();
                        this.ShowPopup(f3);
                        break;
                    }
            }
        }
    }
    private void OnGClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var g0 = new g0();
                    this.ShowPopup(g0);
                    break;
                }
            case 1:
                {
                    var g1 = new g1();
                    this.ShowPopup(g1);
                    break;
                }
            case 2:
                {
                    var g2 = new g2();
                    this.ShowPopup(g2);
                    break;
                }
            case 3:
                {
                    var g3 = new g3();
                    this.ShowPopup(g3);
                    break;
                }
        }
    }
    private void OnHClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var h0 = new h0();
                    this.ShowPopup(h0);
                    break;
                }
            case 1:
                {
                    var h1 = new h1();
                    this.ShowPopup(h1);
                    break;
                }
            case 2:
                {
                    var h2 = new h2();
                    this.ShowPopup(h2);
                    break;
                }
            case 3:
                {
                    var h3 = new h3();
                    this.ShowPopup(h3);
                    break;
                }
        }
    }
    private void OnIClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var i0 = new i0();
                    this.ShowPopup(i0);
                    break;
                }
            case 1:
                {
                    var i1 = new i1();
                    this.ShowPopup(i1);
                    break;
                }
            case 2:
                {
                    var i2 = new i2();
                    this.ShowPopup(i2);
                    break;
                }
            case 3:
                {
                    var i3 = new i3();
                    this.ShowPopup(i3);
                    break;
                }
        }
    }
    private void OnJClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var j0 = new j0();
                    this.ShowPopup(j0);
                    break;
                }
            case 1:
                {
                    var j1 = new j1();
                    this.ShowPopup(j1);
                    break;
                }
            case 2:
                {
                    var j2 = new j2();
                    this.ShowPopup(j2);
                    break;
                }
            case 3:
                {
                    var j3 = new j3();
                    this.ShowPopup(j3);
                    break;
                }
        }
    }
    private void OnKClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 5);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var k0 = new k0();
                    this.ShowPopup(k0);
                    break;
                }
            case 1:
                {
                    var k1 = new k1();
                    this.ShowPopup(k1);
                    break;
                }
            case 2:
                {
                    var k2 = new k2();
                    this.ShowPopup(k2);
                    break;
                }
            case 3:
                {
                    var k3 = new k3();
                    this.ShowPopup(k3);
                    break;
                }
            case 4:
                {
                    var k4 = new k4();
                    this.ShowPopup(k4);
                    break;
                }
        }
    }
    private void OnLClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var l0 = new l0();
                    this.ShowPopup(l0);
                    break;
                }
            case 1:
                {
                    var l1 = new l1();
                    this.ShowPopup(l1);
                    break;
                }
            case 2:
                {
                    var l2 = new l2();
                    this.ShowPopup(l2);
                    break;
                }
            case 3:
                {
                    var l3 = new l3();
                    this.ShowPopup(l3);
                    break;
                }
        }
    }
    private void OnMClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 5);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var m0 = new m0();
                    this.ShowPopup(m0);
                    break;
                }
            case 1:
                {
                    var m1 = new m1();
                    this.ShowPopup(m1);
                    break;
                }
            case 2:
                {
                    var m2 = new m2();
                    this.ShowPopup(m2);
                    break;
                }
            case 3:
                {
                    var m3 = new m3();
                    this.ShowPopup(m3);
                    break;
                }
            case 4:
                {
                    var m4 = new m4();
                    this.ShowPopup(m4);
                    break;
                }
        }
    }
    private void OnNClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var n0 = new n0();
                    this.ShowPopup(n0);
                    break;
                }
            case 1:
                {
                    var n1 = new n1();
                    this.ShowPopup(n1);
                    break;
                }
            case 2:
                {
                    var n2 = new n2();
                    this.ShowPopup(n2);
                    break;
                }
            case 3:
                {
                    var n3 = new n3();
                    this.ShowPopup(n3);
                    break;
                }
        }
    }
    private void OnOClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 5);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var o0 = new o0();
                    this.ShowPopup(o0);
                    break;
                }
            case 1:
                {
                    var o1 = new o1();
                    this.ShowPopup(o1);
                    break;
                }
            case 2:
                {
                    var o2 = new o2();
                    this.ShowPopup(o2);
                    break;
                }
            case 3:
                {
                    var o3 = new o3();
                    this.ShowPopup(o3);
                    break;
                }
            case 4:
                {
                    var o4 = new o4();
                    this.ShowPopup(o4);
                    break;
                }
        }
    }
    private void OnPClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var p0 = new p0();
                    this.ShowPopup(p0);
                    break;
                }
            case 1:
                {
                    var p1 = new p1();
                    this.ShowPopup(p1);
                    break;
                }
            case 2:
                {
                    var p2 = new p2();
                    this.ShowPopup(p2);
                    break;
                }
            case 3:
                {
                    var p3 = new p3();
                    this.ShowPopup(p3);
                    break;
                }
        }
    }
    private void OnRClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var r0 = new r0();
                    this.ShowPopup(r0);
                    break;
                }
            case 1:
                {
                    var r1 = new r1();
                    this.ShowPopup(r1);
                    break;
                }
            case 2:
                {
                    var r2 = new r2();
                    this.ShowPopup(r2);
                    break;
                }
            case 3:
                {
                    var r3 = new r3();
                    this.ShowPopup(r3);
                    break;
                }
        }
    }
    private void OnSClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 5);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var s0 = new s0();
                    this.ShowPopup(s0);
                    break;
                }
            case 1:
                {
                    var s1 = new s1();
                    this.ShowPopup(s1);
                    break;
                }
            case 2:
                {
                    var s2 = new s2();
                    this.ShowPopup(s2);
                    break;
                }
            case 3:
                {
                    var s3 = new s3();
                    this.ShowPopup(s3);
                    break;
                }
            case 4:
                {
                    var s4 = new s4();
                    this.ShowPopup(s4);
                    break;
                }
        }
    }
    private void OnTClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 5);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var t0 = new t0();
                    this.ShowPopup(t0);
                    break;
                }
            case 1:
                {
                    var t1 = new t1();
                    this.ShowPopup(t1);
                    break;
                }
            case 2:
                {
                    var t2 = new t2();
                    this.ShowPopup(t2);
                    break;
                }
            case 3:
                {
                    var t3 = new t3();
                    this.ShowPopup(t3);
                    break;
                }
            case 4:
                {
                    var t4 = new t4();
                    this.ShowPopup(t4);
                    break;
                }
        }
    }
    private void OnUClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var u0 = new u0();
                    this.ShowPopup(u0);
                    break;
                }
            case 1:
                {
                    var u1 = new u1();
                    this.ShowPopup(u1);
                    break;
                }
            case 2:
                {
                    var u2 = new u2();
                    this.ShowPopup(u2);
                    break;
                }
            case 3:
                {
                    var u3 = new u3();
                    this.ShowPopup(u3);
                    break;
                }
        }
    }
    private void OnWClicked(object sender, EventArgs e)
    {
        while (number == temp)
        {
            number = rnd.Next(0, 5);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var w0 = new w0();
                    this.ShowPopup(w0);
                    break;
                }
            case 1:
                {
                    var w1 = new w1();
                    this.ShowPopup(w1);
                    break;
                }
            case 2:
                {
                    var w2 = new w2();
                    this.ShowPopup(w2);
                    break;
                }
            case 3:
                {
                    var w3 = new w3();
                    this.ShowPopup(w3);
                    break;
                }
            case 4:
                {
                    var w4 = new w4();
                    this.ShowPopup(w4);
                    break;
                }
        }
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
        while (number == temp)
        {
            number = rnd.Next(0, 4);
        }
        temp = number;

        switch (number)
        {
            case 0:
                {
                    var z0 = new z0();
                    this.ShowPopup(z0);
                    break;
                }
            case 1:
                {
                    var z1 = new z1();
                    this.ShowPopup(z1);
                    break;
                }
            case 2:
                {
                    var z2 = new z2();
                    this.ShowPopup(z2);
                    break;
                }
            case 3:
                {
                    var z3 = new z3();
                    this.ShowPopup(z3);
                    break;
                }
        }
    }
}

