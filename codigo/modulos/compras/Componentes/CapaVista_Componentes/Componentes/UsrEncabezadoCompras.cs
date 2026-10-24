using System.ComponentModel;
using System.Windows.Forms;

namespace CapaVista_Componentes.Componentes
{
    [DefaultProperty("Titulo")]
    public partial class UsrEncabezadoCompras : UserControl
    {
        public UsrEncabezadoCompras()
        {
            InitializeComponent();
            DoubleBuffered = true;
            TabStop = false;
        }

        [Category("Compras")]
        [Description("T?tulo principal del encabezado.")]
        [Browsable(true)]
        [Bindable(true)]
        [Localizable(true)]
        [DefaultValue("Titulo")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Titulo
        {
            get => ComprasLblTitulo.Texto;
            set => ComprasLblTitulo.Texto = value ?? string.Empty;
        }

        [Category("Compras")]
        [Description("Descripci?n del formulario o proceso.")]
        [Browsable(true)]
        [Bindable(true)]
        [Localizable(true)]
        [DefaultValue("Descripcion")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Descripcion
        {
            get => ComprasLblDescripcion.Texto;
            set => ComprasLblDescripcion.Texto = value ?? string.Empty;
        }

        [Category("Compras")]
        [Description("C?digo del formulario de Compras, en el rango 6000?6999.")]
        [Browsable(true)]
        [Bindable(true)]
        [Localizable(true)]
        [DefaultValue("6000")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Codigo
        {
            get => ComprasLblCodModulo.Texto;
            set => ComprasLblCodModulo.Texto = value ?? string.Empty;
        }

    }
}
