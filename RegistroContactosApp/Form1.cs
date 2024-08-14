namespace RegistroContactosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
        string.IsNullOrWhiteSpace(TextBoxTelefono.Text) ||
        string.IsNullOrWhiteSpace(TextBoxEmail.Text))
            {
                LabelEstado.Text = "Por favor, complete todos los campos.";
                LabelEstado.ForeColor = Color.Red;
            }
            else
            {
                // Agregar el contacto al ListBox
                string contacto = $"{TextBoxNombre.Text} - {TextBoxTelefono.Text} - {TextBoxEmail.Text}";
                ListBoxContactos.Items.Add(contacto);

                LabelEstado.Text = "Contacto agregado correctamente.";
                LabelEstado.ForeColor = Color.Green;

                // Limpiar campos después de agregar el contacto
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            TextBoxNombre.Clear();
            TextBoxTelefono.Clear();
            TextBoxEmail.Clear();
            LabelEstado.Text = string.Empty;
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LabelEstado.Text = "Campos limpiados.";
            LabelEstado.ForeColor = Color.Blue;
        }
    }
}
