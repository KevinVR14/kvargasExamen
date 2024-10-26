namespace kvargasExamen.Views;

public partial class Login : ContentPage
{
    private List<(string Usuario, string Contrase�a)> usuarios = new List<(string, string)>
    {
        ("estudiante2024", "uisrael2024"),
        ("examen1", "parcial1"),
        ("NombreEstudiante", "2024")
    };

    public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            DisplayAlert("Alerta", "Debe ingresar un usuario y una contrase�a", "Cerrar");
        }
        else
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            if(!usuarios.Exists(u => u.Usuario == usuario && u.Contrase�a == password))
            {
                DisplayAlert("Alerta", "Usuario o contrase�a incorrectos", "Cerrar");
            }
            else
            {
                Navigation.PushAsync(new Registro(usuario));
            }
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Aviso", "Esta aplicaci�n ha sido creada por Kevin Vargas", "OK");
    }
}