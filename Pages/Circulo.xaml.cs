namespace ExamenApp1.Pages;

public partial class Circulo : ContentPage
{
	public Circulo()
	{
		InitializeComponent();
	}

    private void BtnEjecutar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Operaciones op = new Operaciones();

            if (Validar())
            {
                txtResultado.Text = "El area de un circulo de "+ txtRadio.Text+" es : "+op.AreaCirculo(Double.Parse(txtRadio.Text));
            }
        } catch(Exception ex) {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }
    }

    private void BtnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtRadio.Text = "";
        txtResultado.Text = "";
    }

    private bool Validar()
    {
        if (txtRadio.Text == null || txtRadio.Text == "")
        {
            DisplayAlert("Advertencia", "No se ingreso un valor valido para el radio", "Aceptar");
            return false;
        }
        else
        {
            return true;
        }
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        txtRadio.Focus();
    }
}