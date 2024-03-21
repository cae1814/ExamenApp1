namespace ExamenApp1.Pages;

public partial class Rectangulo : ContentPage
{
	public Rectangulo()
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
                txtResultado.Text = $"El area del rectangulo es : {op.AreaRectangulo(Double.Parse(txtAltura.Text), Double.Parse(txtBase.Text))}";
            }
        } catch(Exception ex) {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }
    }

    private void BtnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtAltura.Text = "";
        txtBase.Text = "";
        txtResultado.Text = "";
    }

    private bool Validar()
    {
        if (txtAltura.Text == null || txtAltura.Text == "")
        {
            DisplayAlert("Advertencia", "No se ingreso un valor valido para la altura", "Aceptar");
            return false;
        }
        else if (txtBase.Text == null || txtBase.Text == "")
        {
            DisplayAlert("Advertencia", "No se ingreso un valor valido para la Base", "Aceptar");
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
        txtAltura.Focus();
    }
}