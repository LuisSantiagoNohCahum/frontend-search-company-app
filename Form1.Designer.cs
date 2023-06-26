namespace frontend_app;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.ClientSize = new System.Drawing.Size(400, 200);
        this.Text = "BUSCADOR DE EMPRESAS POR RFC";

        /* Caja de texto para introducir RFC */
        txtInputRfc = new TextBox();
        txtInputRfc.Name = "txtInputRfc";
        txtInputRfc.Size = new System.Drawing.Size(170, 20);
        txtInputRfc.Location = new System.Drawing.Point(20,20);

        /* Boton que ejecuta la busqueda */
        btnSearch = new Button();
        btnSearch.Name = "btnSearch";
        btnSearch.Text = "Buscar";
        btnSearch.Size = new System.Drawing.Size(170, 25);
        btnSearch.Location = new System.Drawing.Point(210,20);
        btnSearch.Click += btnSearch_Click;

        /* Label del resultado */
        labelResult = new Label();
        labelResult.Name = "labelResult";
        labelResult.Font = new Font(labelResult.Font, FontStyle.Bold);
        labelResult.Location = new System.Drawing.Point(20,50);
        labelResult.Size = new System.Drawing.Size(360, 25);
        labelResult.TextAlign = ContentAlignment.MiddleCenter;

        labelNombre = new Label();
        labelNombre.Name = "labelNombre";
        labelNombre.Font = new Font("Arial",8,FontStyle.Bold);
        labelNombre.ForeColor = Color.Red;
        labelNombre.Location = new System.Drawing.Point(20,80);
        labelNombre.Size = new System.Drawing.Size(360, 20);
        labelNombre.TextAlign = ContentAlignment.MiddleCenter;

        labelRfc = new Label();
        labelRfc.Name = "labelRfc";
        labelRfc.Font = new Font("Arial",8,FontStyle.Bold);
        labelRfc.ForeColor = Color.Red;
        labelRfc.Location = new System.Drawing.Point(20,100);
        labelRfc.Size = new System.Drawing.Size(360, 20);
        labelRfc.TextAlign = ContentAlignment.MiddleCenter;

        labelFecha = new Label();
        labelFecha.Name = "labelFecha";
        labelFecha.Font = new Font("Arial",8,FontStyle.Bold);
        labelFecha.ForeColor = Color.Red;
        labelFecha.Location = new System.Drawing.Point(20,120);
        labelFecha.Size = new System.Drawing.Size(360, 20);
        labelFecha.TextAlign = ContentAlignment.MiddleCenter;

        labelDireccion = new Label();
        labelDireccion.Name = "labelDireccion";
        labelDireccion.Font = new Font("Arial",8,FontStyle.Bold);
        labelDireccion.ForeColor = Color.Red;
        labelDireccion.Location = new System.Drawing.Point(20,140);
        labelDireccion.Size = new System.Drawing.Size(360, 20);
        labelDireccion.TextAlign = ContentAlignment.MiddleCenter;

        labelEmail = new Label();
        labelEmail.Name = "labelEmail";
        labelEmail.Font = new Font("Arial",8,FontStyle.Bold);
        labelEmail.ForeColor = Color.Red;
        labelEmail.Location = new System.Drawing.Point(20,160);
        labelEmail.Size = new System.Drawing.Size(360, 20);
        labelEmail.TextAlign = ContentAlignment.MiddleCenter;

        this.Controls.Add(btnSearch);
        this.Controls.Add(txtInputRfc);
        this.Controls.Add(labelResult);
        this.Controls.Add(labelNombre);
        this.Controls.Add(labelRfc);
        this.Controls.Add(labelFecha);
        this.Controls.Add(labelDireccion);
        this.Controls.Add(labelEmail);

    }

    /* Create components */
    private Button btnSearch;
    private TextBox txtInputRfc;
    private Label labelResult;

    private Label labelNombre;
    private Label labelRfc;
    private Label labelFecha;
    private Label labelDireccion;
    private Label labelEmail;

    #endregion
}
