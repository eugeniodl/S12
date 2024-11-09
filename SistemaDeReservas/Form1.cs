namespace SistemaDeReservas
{
    public partial class Form1 : Form
    {
        bool isMenuVisible = false;
        FormReservar? formReservar;

        public Form1()
        {
            InitializeComponent();
        }

        private void AlternarVisibilidad(object sender, EventArgs e)
        {
            isMenuVisible = !isMenuVisible;
            panelMenu.Visible = isMenuVisible;
        }

        private void Reservar(object sender, EventArgs e)
        {
            if (formReservar == null)
            {
                formReservar = new FormReservar();
            }
            MostrarFormularioEnTabPage(formReservar, tabPage1);
        }

        private void VerReservas(object sender, EventArgs e)
        {
            var formVerReservas = new FormVerReservas();
            MostrarFormularioEnTabPage(formVerReservas, tabPage2);
        }

        private void MostrarFormularioEnTabPage(Form formulario, TabPage tabPage)
        {
            tabPage.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            tabPage.Controls.Add(formulario);
            formulario.Show();

            tabControlCentral.SelectedTab = tabPage;
        }

    }
}
