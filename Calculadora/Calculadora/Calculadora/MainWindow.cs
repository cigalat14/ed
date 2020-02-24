using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    operaciones resultado = new operaciones();
    int contador;
    double a;
    double b;
    double result;
    String signo;
    int cont_punto;
    int cont_igual;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnCeroClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            pantalla.DeleteText(0, pantalla.Text.Length);
        }
        cont_punto = 0;
        cont_igual = 0;
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "0");
    }

    protected void OnUnoClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            pantalla.DeleteText(0, pantalla.Text.Length);
        }
        cont_punto = 0;
        cont_igual = 0;
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "1");
    }

    protected void OnDosClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            pantalla.DeleteText(0, pantalla.Text.Length);
        }
        cont_punto = 0;
        cont_igual = 0;
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "2");
    }

    protected void OnTresClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            pantalla.DeleteText(0, pantalla.Text.Length);
        }
        cont_punto = 0;
        cont_igual = 0;
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "3");
    }

    protected void OnCuatroClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            pantalla.DeleteText(0, pantalla.Text.Length);
        }
        cont_punto = 0;
        cont_igual = 0;
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "4");
    }

    protected void OnCincoClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            pantalla.DeleteText(0, pantalla.Text.Length);
        }
        cont_punto = 0;
        cont_igual = 0;
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "5");
    }

    protected void OnSeisClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            pantalla.DeleteText(0, pantalla.Text.Length);
        }
        cont_punto = 0;
        cont_igual = 0;
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "6");
    }

    protected void OnSieteClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            pantalla.DeleteText(0, pantalla.Text.Length);
        }
        cont_punto = 0;
        cont_igual = 0;
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "7");
    }

    protected void OnOchoClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            pantalla.DeleteText(0, pantalla.Text.Length);
        }
        cont_punto = 0;
        cont_igual = 0;
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "8");
    }

    protected void OnNueveClicked(object sender, EventArgs e)
    {
        if (cont_igual == 1)
        {
            pantalla.DeleteText(0, pantalla.Text.Length);
        }
        cont_punto = 0;
        cont_igual = 0;
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        pantalla.InsertText(display + "9");
    }

    protected void OnButton13Clicked(object sender, EventArgs e)
    {
        if (cont_punto==0)
        {
            String display = pantalla.Text.ToString();
            if (display.Equals(""))
            {
                pantalla.InsertText("0," + display);
                cont_punto++;
            }
            else
            {
                pantalla.DeleteText(0, pantalla.Text.Length);
                pantalla.InsertText(display + ",");
                cont_punto++;
            }
        }
    }

    protected void OnSumaClicked(object sender, EventArgs e)
    {
        a = Convert.ToDouble(pantalla.Text);
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        signo = "+";
    }

    protected void OnRestaClicked(object sender, EventArgs e)
    {
        a = Convert.ToDouble(pantalla.Text);
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        signo = "-";
    }

    protected void OnMultiplicacionClicked(object sender, EventArgs e)
    {
        a = Convert.ToDouble(pantalla.Text);
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        signo = "*";
    }

    protected void OnDivisionClicked(object sender, EventArgs e)
    {
        a = Convert.ToDouble(pantalla.Text);
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
        signo = "/";
    }
    //=
    protected void OnButton15Clicked(object sender, EventArgs e)
    {
        b = Convert.ToDouble(pantalla.Text);


        switch (signo)
        {
            case "/":
                result = resultado.division(a, b);
                this.pantalla.Text = (Convert.ToString(result));
                cont_igual++;
                break;
            case "*":
                result = resultado.multiplicacion(a, b);
                this.pantalla.Text = (Convert.ToString(result));
                cont_igual++;
                break;
            case "-":
                result = resultado.resta(a, b);
                this.pantalla.Text = (Convert.ToString(result));
                cont_igual++;
                break;
            case "+":
                result = resultado.suma(a, b);
                this.pantalla.Text = (Convert.ToString(result));
                cont_igual++;
                break;
        }
    }

    protected void OnCClicked(object sender, EventArgs e)
    {

        pantalla.DeleteText(pantalla.Text.Length - 1, pantalla.Text.Length);


    }

    protected void OnBvaciarClicked(object sender, EventArgs e)
    {
        String display = pantalla.Text.ToString();
        pantalla.DeleteText(0, pantalla.Text.Length);
    }
}
