namespace kvargasExamen.Views;

public partial class Registro : ContentPage
{
    string user;
    double montoInicial;
    double cuotaMensual;
    double pagoTotal;

    public Registro()
	{
		InitializeComponent();
    }

    public Registro(string usuario)
    {
        InitializeComponent();
        user = usuario;
        lblUsuario.Text = usuario;
        double costo = 300;
        double montoInicial = (15 * costo) / 100;
        txtMonIni.Text = montoInicial.ToString();
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double costo = 300;
        double montIni = (15 * costo) / 100;
        double restante = costo - montIni;
        double cuota = restante / 3;
        double inte = 5;
        double div = inte / 100;
        double interes = cuota * div;
        double cuotaFinal = cuota + interes;
        double cuotaTotal = cuotaFinal * 3;
        double pagTotal = cuotaTotal + montIni;

        txtCuoMen.Text = cuotaFinal.ToString();

        montoInicial = montIni;
        cuotaMensual = cuotaFinal;
        pagoTotal = pagTotal;
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string voltiamperio = pkVoltiamperio.Items[pkVoltiamperio.SelectedIndex].ToString();
        string fecha = dpFecha.Date.ToString();
        string ciudad = pkCiudad.Items[pkCiudad.SelectedIndex].ToString();
        Navigation.PushAsync(new Resumen(user, nombre, apellido, voltiamperio, fecha, ciudad, montoInicial, cuotaMensual, pagoTotal));
    }
}