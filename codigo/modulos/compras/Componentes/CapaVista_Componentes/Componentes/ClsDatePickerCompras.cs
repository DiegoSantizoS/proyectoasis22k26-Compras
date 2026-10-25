using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Componentes.Componentes
{
    [ToolboxItem(true)]
    [DefaultProperty("Value")]
    [DefaultEvent("ValueChanged")]
    public class ClsDatePickerCompras : DateTimePicker
    {
        public ClsDatePickerCompras()
        {
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BackColor = ClsTemaCompras.FondoGeneral;
            ForeColor = ClsTemaCompras.PrincipalNavegador;
            CalendarFont = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CalendarMonthBackground = ClsTemaCompras.FondoGeneral;
            CalendarForeColor = ClsTemaCompras.PrincipalNavegador;
            CalendarTitleBackColor = ClsTemaCompras.PrincipalNavegador;
            CalendarTitleForeColor = ClsTemaCompras.FondoGeneral;
            CalendarTrailingForeColor = ClsTemaCompras.AcentoNavegador;
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "dd/MM/yyyy";
            Margin = new Padding(4, 6, 4, 6);
            Size = new Size(200, PreferredHeight);
        }
    }
}
