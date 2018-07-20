using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_de_clases;

namespace ConsultaTratos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            tb_rut.Text = "";
            tb_numero.Text = "";
            dt_fecha.Text = "";
            tb_monto.Text = "";
            cb_estado.SelectedIndex = 0;
            cb_tipoTrato.SelectedIndex = 0;
            tb_cantidad.Text = "";
            tb_montoTotal.Text = "";
        }

        private void btn_restablecer_Click(object sender, EventArgs e)
        {
            Limpiar();
            l_mensajes.Text = "";
            tb_rut.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_rut.Text = string.Empty;
            l_mensajes.Text = string.Empty;
            tb_rut.Focus();
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            l_mensajes.Text = "";

            if ("".Equals(tb_rut.Text))
            {
                l_mensajes.Text = "Debe ingresar el RUT del empleado";
                tb_rut.Focus();
            }
            else
            {
                int numero;

                if (int.TryParse(tb_numero.Text, out numero))
                {
                    if (numero > 0)
                    {
                        if ("".Equals(dt_fecha.Text))
                        {
                            l_mensajes.Text = "Debe elegir una fecha";
                            dt_fecha.Focus();
                        }
                        else
                        {


                            int monto;
                            if (int.TryParse(tb_monto.Text, out monto))
                            {
                                if (monto > 1)
                                {
                                    if (cb_estado.SelectedIndex > 0)
                                    {
                                        string estado = cb_estado.SelectedItem.ToString();
                                        Trato nuevoTrato = new Trato(numero, dt_fecha.Value, monto, estado);
                                        Empleado empleado = new Empleado();
                                        empleado.Rut = tb_rut.Text;
                                       
                                        empleado.agregarTrato(nuevoTrato);

                                        l_mensajes.Text = "Trato agregado!";

                                        Limpiar();

                                    }
                                    else
                                    {
                                        l_mensajes.Text = "El monto debe ser mayor a 1";
                                        tb_monto.Focus();
                                    }
                                }
                                else
                                {
                                    l_mensajes.Text = "El monto debe ser mayor a 1";
                                    tb_monto.Focus();
                                }
                            }
                            else
                            {
                                l_mensajes.Text = "Debe escribir el monto del trato";
                                tb_monto.Focus();
                            }
                        }
                    }
                }
                else
                {
                    l_mensajes.Text = "Debe ingresar un número de trato";
                    tb_numero.Focus();
                }
            }
        }

        private void cb_tipoTrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_mensajes.Text = "";

            if ("".Equals(tb_rut.Text))
            {
                l_mensajes.Text = "Debe ingresar el RUT del empleado";
                tb_rut.Focus();
            }
            else
            {
                if (cb_estado.SelectedIndex > 0)
                {
                    string estado = cb_estado.SelectedItem.ToString();
                }
                else
                {
                    l_mensajes.Text = "Debe seleccionar el estado del trato";
                    cb_estado.Focus();
                }
            }
        }
    }
}
