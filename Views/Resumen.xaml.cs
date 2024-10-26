using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kvargasExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen()
    {
		InitializeComponent();
    }
    public Resumen(string usuario, string nombre, string apellido, string voltiamperio, string fecha, string ciudad, double montoInicial, double cuotaMensual, double pagoTotal)
    {
        InitializeComponent();
        lblUsuario.Text = usuario;
        txtNombre.Text = nombre;
        txtApellido.Text = apellido;
        txtVoltiamperio.Text = voltiamperio;
        txtFecha.Text = fecha;
        txtCiudad.Text = ciudad;
        txtMonIni.Text = montoInicial.ToString();
        txtCuoMen.Text = cuotaMensual.ToString();
        txtPagTot.Text = pagoTotal.ToString();
    }

    private void btnCerSes_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}