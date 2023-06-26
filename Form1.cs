using frontend_app.ApiHelpers;
using System.Text.Json;
using static System.Console;

namespace frontend_app;

public partial class Form1 : Form
{
    /* Endpoint de empresas */
    String URL = "http://localhost/api/Empresas";

    record Empresa(int id, string nombre, string rfc, string fechaAlta, string direccion, string email);

    public Form1()
    {
        InitializeComponent();
    }

    private async void btnSearch_Click(object sender, EventArgs e){
        /* Validar que el campo no este vacio, si lo esta mostrar un mensaje de llenar */
        String rfc = txtInputRfc.Text.Trim();
        var isNumeric = int.TryParse(rfc, out _);
        
        if (rfc.Equals("") | isNumeric)
        {
            MessageBox.Show("Introduzca un RFC en el campo de texto", "Error");
            txtInputRfc.Text = "";
        }else
        {
            var empresa = await RestClient.GetByRfc<Empresa>($"{URL}/{rfc}");
            if (empresa.Success && empresa.Data is not null)
            {
                labelResult.Text = "DATOS DE LA EMPRESA:";
                labelNombre.Text = "NOMBRE: " + empresa.Data.nombre;
                labelRfc.Text = "RFC: " + empresa.Data.rfc;
                labelFecha.Text = "Alta: " + DateTime.Parse(empresa.Data.fechaAlta).ToString();
                labelDireccion.Text = "DIREC.: " + empresa.Data.direccion;
                labelEmail.Text = "EMAIL: " + empresa.Data.email;
            }else
            {
                labelResult.Text = "REALIZA OTRA CONSULTA";
                labelNombre.Text = "";
                labelRfc.Text = "";
                labelFecha.Text = "";
                labelDireccion.Text = "";
                labelEmail.Text = "";
                MessageBox.Show("No se encontro ninguna empresa con el RFC: " + rfc, "Not found");
            }
            /* Verificar que el rfc sea de 13 digitos si no no lo validara */
        }

    }
}
