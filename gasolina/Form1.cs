using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gasolina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double TotalLitrosVendidos1;
        double TotalLitrosVendidos2;
        double TotalPremium1;
        double TotalMagna1;
        double TotalDiesel1;
        double TotalPremium2;
        double TotalMagna2;
        double TotalDiesel2;
        double IngresoGeneralDesp1;
        double IngresoGeneralDesp2;
        int ClientesAtendidosDespachador1;
        int ClientesAtendidosDespachador2;
        double Pago;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double LitADin = double.Parse(textBox1.Text);
            double DinALit = double.Parse(textBox1.Text);

            if (comboBox2.Text == "Despachador 1")
            {
                if (comboBox3.Text == "LITROS-DINERO" && comboBox1.Text == "Premium")
                {
                    Pago = LitADin * 23.40;
                    TotalPremium1 += LitADin;
                    TotalLitrosVendidos1 += LitADin;
                    IngresoGeneralDesp1 += Pago;
                    ClientesAtendidosDespachador1++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }

                if (comboBox3.Text == "LITROS-DINERO" && comboBox1.Text == "Magna")
                {
                    Pago = LitADin * 22.80;
                    TotalMagna1 += LitADin;
                    TotalLitrosVendidos1 += LitADin;
                    IngresoGeneralDesp1 += Pago;
                    ClientesAtendidosDespachador1++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }
                if (comboBox3.Text == "LITROS-DINERO" && comboBox1.Text == "Diesel")
                {
                    Pago = LitADin * 24.60;
                    TotalDiesel1 += LitADin;
                    TotalLitrosVendidos1 += LitADin;
                    IngresoGeneralDesp1 += Pago;
                    ClientesAtendidosDespachador1++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }



                if (comboBox3.Text == "DINERO-LITROS" && comboBox1.Text == "Premium")
                {
                    Pago = DinALit;
                    TotalPremium1 += DinALit / 23.40;
                    TotalLitrosVendidos1 += TotalPremium1;
                    IngresoGeneralDesp1 += Pago;
                    ClientesAtendidosDespachador1++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }

                if (comboBox3.Text == "DINERO-LITROS" && comboBox1.Text == "Magna")
                {
                    Pago = DinALit;
                    TotalMagna1 += DinALit / 23.40;
                    TotalLitrosVendidos1 += TotalMagna1;
                    IngresoGeneralDesp1 += Pago;
                    ClientesAtendidosDespachador1++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }

                if (comboBox3.Text == "DINERO-LITROS" && comboBox1.Text == "Diesel")
                {
                    Pago = DinALit;
                    TotalDiesel1 += DinALit / 23.40;
                    TotalLitrosVendidos1 += TotalPremium1;
                    IngresoGeneralDesp1 += Pago;
                    ClientesAtendidosDespachador1++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }
            }

            if (comboBox2.Text == "Despachador 2")
            {
                if (comboBox3.Text == "LITROS-DINERO" && comboBox1.Text == "Premium")
                {
                    Pago = LitADin * 23.40;
                    TotalPremium2 += LitADin;
                    TotalLitrosVendidos2 += LitADin;
                    IngresoGeneralDesp2 += Pago;
                    ClientesAtendidosDespachador2++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }

                if (comboBox3.Text == "LITROS-DINERO" && comboBox1.Text == "Magna")
                {
                    Pago = LitADin * 22.80;
                    TotalMagna2 += LitADin;
                    TotalLitrosVendidos2 += LitADin;
                    IngresoGeneralDesp2 += Pago;
                    ClientesAtendidosDespachador2++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }
                if (comboBox3.Text == "LITROS-DINERO" && comboBox1.Text == "Diesel")
                {
                    Pago = LitADin * 24.60;
                    TotalDiesel2 += LitADin;
                    TotalLitrosVendidos2 += LitADin;
                    IngresoGeneralDesp2 += Pago;
                    ClientesAtendidosDespachador2++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }



                if (comboBox3.Text == "DINERO-LITROS" && comboBox1.Text == "Premium")
                {
                    Pago = DinALit;
                    TotalPremium2 += DinALit / 23.40;
                    TotalLitrosVendidos2 += TotalPremium2;
                    IngresoGeneralDesp2 += Pago;
                    ClientesAtendidosDespachador2++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }

                if (comboBox3.Text == "DINERO-LITROS" && comboBox1.Text == "Magna")
                {
                    Pago = DinALit;
                    TotalMagna2 += DinALit / 23.40;
                    TotalLitrosVendidos2 += TotalMagna2;
                    IngresoGeneralDesp2 += Pago;
                    ClientesAtendidosDespachador2++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }

                if (comboBox3.Text == "DINERO-LITROS" && comboBox1.Text == "Diesel")
                {
                    Pago = DinALit;
                    TotalDiesel2 += DinALit / 23.40;
                    TotalLitrosVendidos2 += TotalPremium2;
                    IngresoGeneralDesp2 += Pago;
                    ClientesAtendidosDespachador2++;
                    MessageBox.Show("El cliente deberá pagar: " + Pago);
                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            double TotalLitrosFinal = TotalLitrosVendidos1 + TotalLitrosVendidos2;
            double TotalPremium = TotalPremium1 + TotalPremium2;
            double TotalMagna = TotalMagna1 + TotalMagna2;
            double TotalDiessel = TotalDiesel1 + TotalDiesel2;
            double IngresoGeneral = IngresoGeneralDesp1 + IngresoGeneralDesp2;

            if (ClientesAtendidosDespachador1 > ClientesAtendidosDespachador2)
            {

                MessageBox.Show("INFORME DE GASOLINERIA"+
                    "El total de litros vendidos por el despachador 1 es: " + TotalLitrosVendidos1
                    + "\nEl total de litros vendidos por el despachador 2 es: " + TotalLitrosVendidos2
                    + "\nEl despachador 1 vendio: " + TotalPremium1 + " litros de Premium"
                    + "\nEl despachador 2 vendio: " + TotalPremium2 + " litros de Premium"
                    + "\nEl despachador 1 vendio: " + TotalMagna1 + " litros de Magna"
                    + "\nEl despachador 2 vendio: " + TotalMagna2 + " litros de Magna"
                    + "\nEl despachador 1 vendio: " + TotalDiesel1 + " litros de Diesel"
                    + "\nEl despachador 2 vendio: " + TotalDiesel2 + " litros de Diesel"
                    + "\nEl despachador 1 atendio:" + ClientesAtendidosDespachador1 + " clientes"
                    + "\nEl despachador 2 atendio:" + ClientesAtendidosDespachador2 + " clientes"
                    + "\nEl ingreso general es de: " + IngresoGeneral+"\n"
                    + "El despachador 1 obtuvo más venta");
            }
            else
            {
                MessageBox.Show("INFORME DE GASOLINERIA"+
                    "El total de litros vendidos por el despachador 1 es: " + TotalLitrosVendidos1
                    + "\nEl total de litros vendidos por el despachador 2 es: " + TotalLitrosVendidos2
                    + "\nEl despachador 1 vendio: " + TotalPremium1 + " litros de  Premium"
                    + "\nEl despachador 2 vendio: " + TotalPremium2 + " litros de  Premium"
                    + "\nEl despachador 1 vendio: " + TotalMagna1 + " litros de Magna"
                    + "\nEl despachador 2 vendio: " + TotalMagna2 + " litros de  Magna"
                    + "\nEl despachador 1 vendio: " + TotalDiesel1 + " litros de  Diesel"
                    + "\nEl despachador 2 vendio: " + TotalDiesel2 + " litros de  Diesel"
                    + "\nEl despachador 1 atendio:" + ClientesAtendidosDespachador1 + " clientes"
                    + "\nEl despachador 2 atendio:" + ClientesAtendidosDespachador2 + " clientes"
                    + "\nEl despachador 1 vendio:" + IngresoGeneralDesp1
                    + "\nEl despachador 2 vendio:" + IngresoGeneralDesp2
                    + "\nEl ingreso general es de: " + IngresoGeneral
                    + "\nEl despachador 2 obtuvo más venta");

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
