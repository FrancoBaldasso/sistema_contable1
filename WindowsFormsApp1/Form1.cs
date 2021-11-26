using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        List<Cuentas> cuentas = new List<Cuentas>();
        int codigoCuenta = 1;

        List<Operacion> operaciones = new List<Operacion>();
        int nroOperacion = 0;
        int indiceCmb1;
        int indiceCmb2;
        int nOperacionElegida = 0;

        //Variables para los elementos dinamicos
        private int yItems = 193;
        private int yDetalle = 291;
        private int conteo = 2;

        ComboBox cmbAux = new ComboBox();
        TextBox txtDebeAux = new TextBox();
        TextBox txtHaberAux = new TextBox();
        TextBox txtDescAux = new TextBox();

        //Data Table para el DataGridView
        
        private DataTable dtAux = new DataTable();
        DataTable dt = new DataTable();
        DataTable dtLibroDiario = new DataTable();


        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
                    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtLibroDiario.Columns.Add("N°Asiento");
            dtLibroDiario.Columns.Add("Cuentas");
            dtLibroDiario.Columns.Add("Debe");
            dtLibroDiario.Columns.Add("Haber");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             indiceCmb1 = cmbItem1.SelectedIndex;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceCmb2 = cmbItem2.SelectedIndex;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*cmbItem1.Items.Add(txtCuentaNueva.Text);
            cmbItem2.Items.Add(txtCuentaNueva.Text);
            cmbAux.Items.Add(txtCuentaNueva.Text);
            
            Cuentas newCuenta = new Cuentas(txtCuentaNueva.Text);
            cuentas.Add(newCuenta);


            //textBox7.Text = newCuenta.Nombre;
            //textBox7.Text = cuenta[0].Nombre;
            */
        }

        
        private void button2_Click(object sender, EventArgs e)
        {

            double debeBandera = 0;
            double haberBandera = 0;
            
            debeBandera += Convert.ToDouble(txtDebe1.Text);
            haberBandera += Convert.ToDouble(txtHaber1.Text);
            debeBandera += Convert.ToDouble(txtDebe2.Text);
            haberBandera += Convert.ToDouble(txtHaber2.Text);

            int indiceConteo = 3;
            for (int i = 2; i < conteo; i++)
            {

                foreach (Control item in panelOperacion.Controls.OfType<TextBox>())
                {
                    if (item.Name == ("txtDebe" + indiceConteo))

                        debeBandera += Convert.ToDouble(item.Text);
                }

                foreach (Control item in panelOperacion.Controls.OfType<TextBox>())
                {
                    if (item.Name == ("txtHaber" + indiceConteo))

                        haberBandera += Convert.ToDouble(item.Text);
                }

                indiceConteo++;
            }

            if (debeBandera == haberBandera)
            {
                nroOperacion++;
                //Creacion de objeto operacion
                Operacion operacion = new Operacion();
          
                //Agrego las cuentas de la operacion

                operacion.Cuentas.Add(new Cuentas(cmbItem1.Text));
                cuentas[cmbItem1.SelectedIndex].DebeLista.Add(Convert.ToDouble(txtDebe1.Text));
                cuentas[cmbItem1.SelectedIndex].HaberLista.Add(Convert.ToDouble(txtHaber1.Text));


                operacion.Cuentas.Add(new Cuentas(cmbItem2.Text));
                cuentas[cmbItem2.SelectedIndex].DebeLista.Add(Convert.ToDouble(txtDebe2.Text));
                cuentas[cmbItem2.SelectedIndex].HaberLista.Add(Convert.ToDouble(txtHaber2.Text));


                operacion.fecha = dateTimeAsiento.Value;

                operacion.Numero = nroOperacion;
            
                //Debe y Haber
                operacion.Cuentas[0].Debe = Convert.ToDouble(txtDebe1.Text);
                operacion.Cuentas[0].Haber = Convert.ToDouble(txtHaber1.Text);
            
                operacion.Cuentas[1].Debe = Convert.ToDouble(txtDebe2.Text);
                operacion.Cuentas[1].Haber = Convert.ToDouble(txtHaber2.Text);

                indiceConteo = 3;

                for (int i = 2; i < conteo; i++)
                {
                    int indiceCmbAgregado=0;
                    foreach (ComboBox item in panelOperacion.Controls.OfType<ComboBox>())
                    {
                        if (item.Name == ("cmbItem" + indiceConteo))
                        operacion.Cuentas.Add(new Cuentas(item.Text));
                        
                        
                    }      
                    foreach (Control item1 in panelOperacion.Controls.OfType<TextBox>())
                    {
                        if (item1.Name == ("txtDebe" + indiceConteo))
                        {
                            operacion.Cuentas[i].Haber = Convert.ToDouble(item1.Text);

                            for (int j = 0; j < cuentas.Count(); j++)
                            {
                                if (cuentas[j].Nombre == operacion.Cuentas[i].Nombre)
                                {
                                    cuentas[j].DebeLista.Add(Convert.ToDouble(item1.Text));
                                }
                            }
                        }  
                              
                    }
                    foreach (Control item2 in panelOperacion.Controls.OfType<TextBox>())
                    {
                        if (item2.Name == ("txtHaber" + indiceConteo)) { 
                            operacion.Cuentas[i].Haber = Convert.ToDouble(item2.Text);
                            for (int j = 0; j < cuentas.Count(); j++)
                            {
                                if (cuentas[j].Nombre == operacion.Cuentas[i].Nombre)
                                {
                                    cuentas[j].HaberLista.Add(Convert.ToDouble(item2.Text));
                                }
                            }

                        }
                    }
                    
  
                     indiceConteo++;

                }

                /*
                cuentas[cmbAux.SelectedIndex].DebeLista.Add(Convert.ToDouble(txtDebeAux.Text));
                    cuentas[cmbAux.SelectedIndex].HaberLista.Add(Convert.ToDouble(txtHaberAux.Text));*/
            
             operaciones.Add(operacion);

                DataTable dtAgregarAsiento = new DataTable();

                dtAgregarAsiento.Columns.Add("N°Asiento");
                dtAgregarAsiento.Columns.Add("Cuentas");
                dtAgregarAsiento.Columns.Add("Debe");
                dtAgregarAsiento.Columns.Add("Haber");

                for (int i = 0; i < conteo; i++)
                {
                    DataRow row = dtLibroDiario.NewRow();
                    row["N°Asiento"] = (nroOperacion).ToString();
                    row["Cuentas"] = operacion.Cuentas[i].Nombre;
                    row["Debe"] = operacion.Cuentas[i].Debe.ToString();
                    row["Haber"] = operacion.Cuentas[i].Haber.ToString();

                    dtLibroDiario.Rows.Add(row);

                }
    /*
                foreach (DataRow row in dtAgregarAsiento.Rows)
                {
                    dtLibroDiario.Rows.Add(row);
                }
    */
                SLDocument s1 = new SLDocument(@"C:\Users\Franco\source\repos\WindowsFormsApp1\WindowsFormsApp1\Asientos.xlsx");

                s1.ImportDataTable(1, 1, dtLibroDiario, true);


                s1.SaveAs(@"C:\Users\Franco\source\repos\WindowsFormsApp1\WindowsFormsApp1\Asientos.xlsx");


                //conteo = 2;          

            }
            else
            {
                MessageBox.Show("El asiento no es equilibrado o los datos son invalidos. Por favor intente nuevamente");
            }
              
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void detHaber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nroOp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime fechaInicial = dateTimeFechaInicial.Value;
            DateTime fechaFinal = dateTimeFechaFinal.Value;
            
            
            DataTable dtDetalle = new DataTable();
            dtDetalle.Columns.Add("N°Asiento");
            dtDetalle.Columns.Add("Fecha");
            dtDetalle.Columns.Add("Cuentas");
            dtDetalle.Columns.Add("Debe");
            dtDetalle.Columns.Add("Haber");
            
             dgvDetalleAsiento.DataSource = dtDetalle;

            for (int i = 0; i < operaciones.Count(); i++)
            {
                if (operaciones[i].fecha >= fechaInicial.AddDays(-1) && operaciones[i].fecha <= fechaFinal)
                {

                    int nroDeCuentas = operaciones[i].Cuentas.Count();
                    
                    for (int j = 0; j < nroDeCuentas; j++)
                    {
                        DataRow row = dtDetalle.NewRow();
                        row["N°Asiento"] = operaciones[i].Numero.ToString();
                        row["Fecha"] = operaciones[i].fecha;
                        row["Cuentas"] = operaciones[i].Cuentas[j].Nombre;
                        row["Debe"] = operaciones[i].Cuentas[j].Debe.ToString();
                        row["Haber"] = operaciones[i].Cuentas[j].Haber.ToString();
               
                        dtDetalle.Rows.Add(row);
                    }

                }
            }
            
           
 
            
            

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //nOperacionElegida = cmbNOperacion.SelectedIndex;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conteo++;


            //Combobox
            ComboBox cmbTemp = new ComboBox();
            cmbTemp.Height = 13;
            cmbTemp.Width = 121;
            cmbTemp.Name = "cmbItem" +conteo.ToString();

            //Agregado de los items del primer combox
            for (int i = 0; i < cmbItem1.Items.Count; i++)
            {
                cmbTemp.Items.Add(cmbItem1.Items[i]);
            }
                

            //TextBoxs
            TextBox txtDebeItem = new TextBox();
            txtDebeItem.Height = 20;
            txtDebeItem.Width = 100;
            txtDebeItem.Name = "txtDebe" + conteo.ToString();

            TextBox txtHaberItem = new TextBox();
            txtHaberItem.Height = 20;
            txtHaberItem.Width = 100;
            txtHaberItem.Name = "txtHaber" + conteo.ToString();
            

            //Ubicacion elementos
            cmbTemp.Location = new Point(168, yItems);
            txtDebeItem.Location = new Point(327, yItems);
            txtHaberItem.Location = new Point(472, yItems);
        

            yItems += 20;

            //Agregacion de los elementos al forms
            
            panelOperacion.Controls.Add(cmbTemp);
            panelOperacion.Controls.Add(txtDebeItem);
            panelOperacion.Controls.Add(txtHaberItem);
          

            //Llenado de variables auxiliares para usar en otros metodos
            cmbAux = cmbTemp;
            txtDebeAux = txtDebeItem;
            txtHaberAux = txtHaberItem;

        }

        private void txtHaber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void detCuenta1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void detHaber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void detDebe1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDesc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHaber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDebe2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblDetalleOp_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            panelOperacion.Visible = true;
            btnLibrioDiario.Visible = false;
            btnLibroMayor.Visible = false;
            btnPlanDeCuentas.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelOperacion.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SLDocument s1 = new SLDocument(@"C:\Users\Franco\source\repos\WindowsFormsApp1\WindowsFormsApp1\Asientos.xlsx");

            int iR = 0;

            // s1.ImportDataTable(5, 5, dtAux, true);


            s1.SaveAs(@"C:\Users\Franco\source\repos\WindowsFormsApp1\WindowsFormsApp1\Asientos.xlsx");
            /*foreach (DataGridViewRow row in dgvDetalleAsiento.Rows)
            {
                s1.SetCellValue(iR, 0, row.Cells[0].Value.ToString());
                s1.SetCellValue(iR, 1, row.Cells[1].Value.ToString());
               // s1.SetCellValue(iR, 2, row.Cells[2].Value.ToString());
              //  s1.SetCellValue(iR, 3, row.Cells[3].Value.ToString());
                iR++;
               
            }*/
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelLibroPeriodo.Visible = false;
            btnLibroMayor.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelLibroPeriodo.Visible = false;
           
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panelDetalleAsiento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            panelOperacion.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelLibroPeriodo.Visible = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panelOperacion.Visible = false;
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            panelOperacion.Visible = false;
        }

        private void button6_Click_3(object sender, EventArgs e)
        {
            panelOperacion.Visible = false;
            btnLibroMayor.Visible = true;
            btnLibrioDiario.Visible = true;
            btnPlanDeCuentas.Visible = true;
        }

        private void button7_Click_2(object sender, EventArgs e)
        {

        }

        private void button7_Click_3(object sender, EventArgs e)
        {
            
            panelLibroPeriodo.Visible = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            DataTable dtAsiento = new DataTable();
            dgvAsiento.DataSource = dtAsiento;
            
            dtAsiento.Columns.Add("N°Asiento");
            dtAsiento.Columns.Add("Cuentas");
            dtAsiento.Columns.Add("Debe");
            dtAsiento.Columns.Add("Haber");

            Operacion operacion = new Operacion();

            
            //Agrego las cuentas de la operacion

            operacion.Cuentas.Add(new Cuentas(cmbItem1.Text));
            operacion.Cuentas.Add(new Cuentas(cmbItem2.Text));

            operacion.Numero = nroOperacion;


            //Debe y Haber
            operacion.Cuentas[0].Debe = Convert.ToDouble(txtDebe1.Text);
            operacion.Cuentas[0].Haber = Convert.ToDouble(txtHaber1.Text);

            operacion.Cuentas[1].Debe = Convert.ToDouble(txtDebe2.Text);
            operacion.Cuentas[1].Haber = Convert.ToDouble(txtHaber2.Text);

            int indiceConteo = 3;
            
            for (int i = 2; i < conteo; i++)
            {
                foreach (Control item in panelOperacion.Controls.OfType<ComboBox>())
                {
                    if (item.Name == ("cmbItem" + indiceConteo))
                        operacion.Cuentas.Add(new Cuentas(item.Text));
                }

                foreach (Control item in panelOperacion.Controls.OfType<TextBox>())
                {
                    if (item.Name == ("txtDebe" + indiceConteo))
                        operacion.Cuentas[i].Debe = Convert.ToDouble(item.Text);
                }

                foreach (Control item in panelOperacion.Controls.OfType<TextBox>())
                {
                    if (item.Name == ("txtHaber" + indiceConteo))
                        operacion.Cuentas[i].Haber = Convert.ToDouble(item.Text);
                }

                indiceConteo++;
            }


            

            for (int i = 0; i < conteo; i++)
            {
                DataRow row = dtAsiento.NewRow();
                row["N°Asiento"] = (nroOperacion + 1).ToString();
                row["Cuentas"] = operacion.Cuentas[i].Nombre;
                row["Debe"] = operacion.Cuentas[i].Debe.ToString();
                row["Haber"] = operacion.Cuentas[i].Haber.ToString();

                dtAsiento.Rows.Add(row);

            }

           // dtAux = dt;
            /* 
             foreach (DataRow row in dtAux.Rows)
             {
                 dtGeneral.Rows.Add(row);
             }
            */

            //int row = dtAux.Rows.Count;

            /*for (int i = 1; i < dtAux.Rows.Count; i++)
            {
                dtAux.Rows.Add(dtAux.Rows[i]);
            }*/
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            SLDocument s1 = new SLDocument(@"C:\Users\Franco\source\repos\WindowsFormsApp1\WindowsFormsApp1\Asientos.xlsx");


            s1.ImportDataTable(1, 1, dtAux, true);

            s1.SaveAs(@"C:\Users\Franco\source\repos\WindowsFormsApp1\WindowsFormsApp1\Asientos.xlsx");
        }

        private void button7_Click_4(object sender, EventArgs e)
        {
            panelPlanDeCuentas.Visible = true;
            btnLibroMayor.Visible = false;
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_5(object sender, EventArgs e)
        {
            Cuentas nuevaCuenta = new Cuentas();
            nuevaCuenta.codigo = codigoCuenta;
            nuevaCuenta.Nombre = txtCuentaAgregada.Text;

            cuentas.Add(nuevaCuenta);

            cmbItem1.Items.Add(txtCuentaAgregada.Text);
            cmbItem2.Items.Add(txtCuentaAgregada.Text);
            cmbAux.Items.Add(txtCuentaAgregada.Text);
            

            string stringListBox = (nuevaCuenta.codigo + ". " + txtCuentaAgregada.Text);
            
            cmbLibroMayor.Items.Add(stringListBox);

            listBoxCuentas.Items.Add(stringListBox);
            txtCuentaAgregada.Text = string.Empty;

            codigoCuenta++;
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            panelPlanDeCuentas.Visible = false;
            btnLibroMayor.Visible = true;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int indice = listBoxCuentas.SelectedIndex;

            if (indice != -1)
            {
                listBoxCuentas.Items.RemoveAt(indice);
                cuentas.RemoveAt(indice);
                cmbItem1.Items.RemoveAt(indice);
                cmbItem2.Items.RemoveAt(indice);
                cmbAux.Items.RemoveAt(indice);
                cmbLibroMayor.Items.RemoveAt(indice);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            int indice = 3;

            for (int i = 0; i < conteo; i++)
            {
                foreach (Control item in panelOperacion.Controls.OfType<ComboBox>())
                {
                    if (item.Name == ("cmbItem"+indice))
                        panelOperacion.Controls.Remove(item);
                }

                foreach (Control item in panelOperacion.Controls.OfType<TextBox>())
                {
                    if(item.Name == ("txtDebe" + indice))
                        panelOperacion.Controls.Remove(item);
                }

                foreach (Control item in panelOperacion.Controls.OfType<TextBox>())
                {
                    if (item.Name == ("txtHaber" + indice))
                        panelOperacion.Controls.Remove(item);
                }

                indice++;
            }

            conteo = 2;
            yItems = 193;


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelLibroPeriodo.Visible = true;
            btnLibroMayor.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelLibroMayor.Visible = true;
            btnLibroMayor.Visible = false;
        }

        private void panelLibroMayor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panelLibroMayor.Visible = false;
            btnLibroMayor.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int indice = cmbLibroMayor.SelectedIndex;
            double totalDebe = 0;
            double totalHaber = 0;

            DataTable dtLibroMayor = new DataTable();
            dgvLibroMayor.DataSource = dtLibroMayor;

            dtLibroMayor.Columns.Add(" ");
            dtLibroMayor.Columns.Add("Debe");
            dtLibroMayor.Columns.Add("Haber");

            for (int i = 0; i < cuentas[indice].HaberLista.Count(); i++)
            {
                DataRow row = dtLibroMayor.NewRow();

                row["Debe"] = cuentas[indice].DebeLista[i];
                totalDebe += cuentas[indice].DebeLista[i]; 
                
                row["Haber"] = cuentas[indice].HaberLista[i];
                totalHaber += cuentas[indice].HaberLista[i];


                dtLibroMayor.Rows.Add(row);
            }
            
            DataRow row1 = dtLibroMayor.NewRow();
            row1["Debe"] = "";
            row1["Haber"] = "";
            dtLibroMayor.Rows.Add(row1);

            DataRow rowSaldo = dtLibroMayor.NewRow();

            if (totalDebe>=totalHaber)
            {
                rowSaldo[" "] = "Saldo";
                rowSaldo["Debe"] = totalDebe;
                rowSaldo["Haber"] = "";
            }
            else
                if (totalDebe <= totalHaber)
            {
                rowSaldo[" "] = "Saldo";
                rowSaldo["Debe"] = "";
                rowSaldo["Haber"] = totalHaber;
            }

            dtLibroMayor.Rows.Add(rowSaldo);
        }

        private void cmbLibroMayor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
