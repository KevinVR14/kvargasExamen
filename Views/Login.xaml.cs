namespace kvargasExamen.Views;

public partial class Login : ContentPage
{
    private List<(string Usuario, string Contraseña)> usuarios = new List<(string, string)>
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
            DisplayAlert("Alerta", "Debe ingresar un usuario y una contraseña", "Cerrar");
        }
        else
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            if(!usuarios.Exists(u => u.Usuario == usuario && u.Contraseña == password))
            {
                DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
            }
            else
            {
                Navigation.PushAsync(new Registro(usuario));
            }
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Aviso", "Esta aplicación ha sido creada por Kevin Vargas", "OK");
    }
}