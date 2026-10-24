using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista_MovimientosProveedores; 
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        FrmMovimientosProveedores movimientos = new FrmMovimientosProveedores();
        public Form1()
        {
            InitializeComponent();
            movimientos.Show();
        }
    }
}
