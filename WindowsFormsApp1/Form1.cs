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
        List<Operacion> operaciones = new List<Operacion>();
        int nroOperacion = 0;
        int indiceCmb1;
        int indiceCmb2;
        int nOperacionElegida = 0;

        //Variables para los elementos dinamicos
        private int yItems = 226;
        private int yDetalle = 291;
        private int conteo = 2;

        ComboBox cmbAux = new ComboBox();
        TextBox txtDebeAux = new TextBox();
        TextBox txtHaberAux = new TextBox();
        TextBox txtDescAux = new TextBox();

        //Data Table para el DataGridView
        private DataTable dtAux = new DataTable();

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
            cmbItem1.Items.Add(txtCuentaNueva.Text);
            cmbItem2.Items.Add(txtCuentaNueva.Text);
            cmbAux.Items.Add(txtCuentaNueva.Text);

            
            
            Cuentas newCuenta = new Cuentas(txtCuentaNueva.Text);
            cuentas.Add(newCuenta);


            //textBox7.Text = newCuenta.Nombre;
            //textBox7.Text = cuenta[0].Nombre;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
           
            nroOperacion++;
            //Creacion de objeto operacion
            Operacion operacion = new Operacion();

            //Agrego las cuentas de la operacion
            
            operacion.Cuentas.Add(new Cuentas(cmbItem1.Text));
            operacion.Cuentas.Add(new Cuentas(cmbItem2.Text));
            
            for (int i = 2; i < conteo; i++)
            {
                operacion.Cuentas.Add(new Cuentas(cmbAux.Text));
            }
            
            operacion.Numero = nroOperacion;
            
            
            //Se agrega otra operacion en el combo box para seleccionar el detalle de qué operacion queremos ver
            cmbNOperacion.Items.Add(nroOperacion);
            
            //operacion.Monto = 0;
            
            //Debe y Haber
            operacion.Cuentas[0].Debe = Convert.ToDouble(txtDebe1.Text);
            operacion.Cuentas[0].Haber = Convert.ToDouble(txtHaber1.Text);
            
            operacion.Cuentas[1].Debe = Convert.ToDouble(txtDebe2.Text);
            operacion.Cuentas[1].Haber = Convert.ToDouble(txtHaber2.Text);

            for (int i = 2; i < conteo; i++)
            {
                operacion.Cuentas[i].Debe = Convert.ToDouble(txtDebeAux.Text);
                operacion.Cuentas[i].Haber = Convert.ToDouble(txtHaberAux.Text);
               // operacion.Cuentas[i].Desc = Convert.ToDouble(txtDebeAux.Text);
            }


            operaciones.Add(operacion);
     
            
             
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
            DataTable dt = new DataTable();
            dt.Columns.Add("N°Asiento");
            dt.Columns.Add("Cuentas");
            dt.Columns.Add("Debe");
            dt.Columns.Add("Haber");
            
            dgvDetalleAsiento.DataSource = dt;
            
            
            int nroDeCuentas = operaciones[nOperacionElegida].Cuentas.Count();
 
            

            for (int i = 0; i < nroDeCuentas; i++)
            {
                DataRow row = dt.NewRow();
                row["N°Asiento"] = (nOperacionElegida+1).ToString();
                row["Cuentas"] = operaciones[nOperacionElegida].Cuentas[i].Nombre;
                row["Debe"] = operaciones[nOperacionElegida].Cuentas[i].Debe.ToString();
                row["Haber"] = operaciones[nOperacionElegida].Cuentas[i].Haber.ToString();
               
                dt.Rows.Add(row);

                

            }



            dtAux = dt;
            


            /*
            
           
            for (int i = 0; i < nroDeCuentas; i++)
            {

                TextBox detCuenta = new TextBox();
                TextBox detDebe = new TextBox();
                TextBox detHaber = new TextBox();

                detCuenta.Text = operaciones[nOperacionElegida].Cuentas[i].Nombre;
                detDebe.Text = operaciones[nOperacionElegida].Cuentas[i].Debe.ToString();
                detHaber.Text = operaciones[nOperacionElegida].Cuentas[i].Haber.ToString();

                //TextBoxs
              
                detCuenta.Height = 13;
                detCuenta.Width = 121;
                detCuenta.Name = "detCuenta" + conteo.ToString();

                detDebe.Height = 13;
                detDebe.Width = 121;
                detDebe.Name = "txtHaber" + conteo.ToString();

                detHaber.Height = 13;
                detHaber.Width = 121;
                detHaber.Name = "txtDesc" + conteo.ToString();

                //Ubicacion elementos
                detCuenta.Location = new Point(131, yDetalle);
                detDebe.Location = new Point(315, yDetalle);
                detHaber.Location = new Point(502, yDetalle);

                yDetalle += 50;

                
                panelOperacion.Controls.Add(detCuenta);
                panelOperacion.Controls.Add(detDebe);
                panelOperacion.Controls.Add(detHaber);

            }
            
            /*
            detCuenta2.Text = operaciones[nOperacionElegida].Cuentas[1].Nombre;

            
            detDebe2.Text = operaciones[nOperacionElegida].Cuentas[1].Debe.ToString();

            detDebe1.Text = operaciones[nOperacionElegida].Cuentas[0].Debe.ToString();
            detDebe2.Text = operaciones[nOperacionElegida].Cuentas[1].Debe.ToString();

           
            detHaber2.Text = operaciones[nOperacionElegida].Cuentas[1].Haber.ToString*/
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            nOperacionElegida = cmbNOperacion.SelectedIndex;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
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
            txtDebeItem.Height = 13;
            txtDebeItem.Width = 121;
            txtDebeItem.Name = "txtDebe" + conteo.ToString();

            TextBox txtHaberItem = new TextBox();
            txtHaberItem.Height = 13;
            txtHaberItem.Width = 121;
            txtHaberItem.Name = "txtHaber" + conteo.ToString();

            

            //Ubicacion elementos
            cmbTemp.Location = new Point(163, yItems);
            txtDebeItem.Location = new Point(322, yItems);
            txtHaberItem.Location = new Point(460, yItems);
        

            yItems += 20;

            //Agregacion de los elementos al forms
            
            panelOperacion.Controls.Add(cmbTemp);
            panelOperacion.Controls.Add(txtDebeItem);
            panelOperacion.Controls.Add(txtHaberItem);
          

            //Llenado de variables auxiliares para usar en otros metodos
            cmbAux = cmbTemp;
            txtDebeAux = txtDebeItem;
            txtHaberAux = txtHaberItem;
          

            conteo++;

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
            SLDocument s1 = new SLDocument();

            int iR = 0;

            s1.ImportDataTable(1, 1, dtAux, true);
            
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
    }
}
