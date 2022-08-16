using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparaFechas
{
    /* Recursos 
     * https://www.iteramos.com/pregunta/10760/como-comparar-solo-la-fecha-sin-la-hora-en-los-tipos-datetime-en-linq-to-sql-con-entity-framework
     * https://www.delftstack.com/es/howto/csharp/how-to-convert-a-string-to-datetime-in-csharp/
     * https://es.acervolima.com/metodo-datetime-compare-en-c/
     
     */
    public partial class Form1 : Form
    {
        int resultado;
        string fecha1;
        string fecha2;
        public Form1()
        {
            InitializeComponent();
            compararFechas();
        }


        private void btnComparar_Click(object sender, EventArgs e)
        {
            compararFechas();
        }

        private void compararFechas()
        {
            //fecha1 = selecFecha1.Value.ToString("yyyy/dd/MM");
           // fecha2 = selecFecha2.Value.ToString("yyyy/dd/MM");
            resultado = DateTime.Compare(selecFecha1.Value.Date, selecFecha2.Value.Date);
            if (resultado<0)
            {
                lbResultado.Text = "Fecha 1 es menor que fecha 2";
            }
            else
            {

                if (resultado == 0)
                {
                    lbResultado.Text = "Ambas fechas son iguales";
                }
                else
                {
                    lbResultado.Text = "La fecha 1 es mayor que la fecha 2";
                }
                
            }
        }

        
    }
}
