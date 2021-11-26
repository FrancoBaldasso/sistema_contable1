
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimeAsiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbItem1 = new System.Windows.Forms.ComboBox();
            this.cmbItem2 = new System.Windows.Forms.ComboBox();
            this.txtDebe1 = new System.Windows.Forms.TextBox();
            this.txtDebe2 = new System.Windows.Forms.TextBox();
            this.txtHaber1 = new System.Windows.Forms.TextBox();
            this.txtHaber2 = new System.Windows.Forms.TextBox();
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.lblDetalleOp = new System.Windows.Forms.Label();
            this.nroOp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.panelOperacion = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panelLibroPeriodo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelPlanDeCuentas = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panelLibroMayor = new System.Windows.Forms.Panel();
            this.dgvLibroMayor = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLibroMayor = new System.Windows.Forms.ComboBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCuentas = new System.Windows.Forms.ListBox();
            this.txtCuentaAgregada = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dateTimeFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvDetalleAsiento = new System.Windows.Forms.DataGridView();
            this.btnMostrarAsiento = new System.Windows.Forms.Button();
            this.dgvAsiento = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPlanDeCuentas = new System.Windows.Forms.Button();
            this.btnLibrioDiario = new System.Windows.Forms.Button();
            this.btnLibroMayor = new System.Windows.Forms.Button();
            this.panelOperacion.SuspendLayout();
            this.panelLibroPeriodo.SuspendLayout();
            this.panelPlanDeCuentas.SuspendLayout();
            this.panelLibroMayor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibroMayor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAsiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiento)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeAsiento
            // 
            this.dateTimeAsiento.Location = new System.Drawing.Point(261, 16);
            this.dateTimeAsiento.Name = "dateTimeAsiento";
            this.dateTimeAsiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAsiento.TabIndex = 0;
            this.dateTimeAsiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(165, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(165, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuenta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(346, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Debe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(499, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Haber";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(630, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripción";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbItem1
            // 
            this.cmbItem1.FormattingEnabled = true;
            this.cmbItem1.Location = new System.Drawing.Point(168, 137);
            this.cmbItem1.Name = "cmbItem1";
            this.cmbItem1.Size = new System.Drawing.Size(121, 21);
            this.cmbItem1.TabIndex = 7;
            this.cmbItem1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbItem2
            // 
            this.cmbItem2.FormattingEnabled = true;
            this.cmbItem2.Location = new System.Drawing.Point(168, 164);
            this.cmbItem2.Name = "cmbItem2";
            this.cmbItem2.Size = new System.Drawing.Size(121, 21);
            this.cmbItem2.TabIndex = 8;
            this.cmbItem2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtDebe1
            // 
            this.txtDebe1.Location = new System.Drawing.Point(327, 138);
            this.txtDebe1.Name = "txtDebe1";
            this.txtDebe1.Size = new System.Drawing.Size(100, 20);
            this.txtDebe1.TabIndex = 9;
            this.txtDebe1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDebe2
            // 
            this.txtDebe2.Location = new System.Drawing.Point(327, 165);
            this.txtDebe2.Name = "txtDebe2";
            this.txtDebe2.Size = new System.Drawing.Size(100, 20);
            this.txtDebe2.TabIndex = 10;
            this.txtDebe2.TextChanged += new System.EventHandler(this.txtDebe2_TextChanged);
            // 
            // txtHaber1
            // 
            this.txtHaber1.Location = new System.Drawing.Point(472, 138);
            this.txtHaber1.Name = "txtHaber1";
            this.txtHaber1.Size = new System.Drawing.Size(100, 20);
            this.txtHaber1.TabIndex = 11;
            this.txtHaber1.TextChanged += new System.EventHandler(this.txtHaber1_TextChanged);
            // 
            // txtHaber2
            // 
            this.txtHaber2.Location = new System.Drawing.Point(472, 165);
            this.txtHaber2.Name = "txtHaber2";
            this.txtHaber2.Size = new System.Drawing.Size(100, 20);
            this.txtHaber2.TabIndex = 12;
            this.txtHaber2.TextChanged += new System.EventHandler(this.txtHaber2_TextChanged);
            // 
            // txtDesc1
            // 
            this.txtDesc1.Location = new System.Drawing.Point(611, 137);
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.Size = new System.Drawing.Size(100, 20);
            this.txtDesc1.TabIndex = 13;
            this.txtDesc1.TextChanged += new System.EventHandler(this.txtDesc1_TextChanged);
            // 
            // btnOperacion
            // 
            this.btnOperacion.Location = new System.Drawing.Point(717, 314);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(106, 23);
            this.btnOperacion.TabIndex = 18;
            this.btnOperacion.Text = "Agregar asiento";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDetalleOp
            // 
            this.lblDetalleOp.AutoSize = true;
            this.lblDetalleOp.Location = new System.Drawing.Point(260, 18);
            this.lblDetalleOp.Name = "lblDetalleOp";
            this.lblDetalleOp.Size = new System.Drawing.Size(108, 13);
            this.lblDetalleOp.TabIndex = 19;
            this.lblDetalleOp.Text = "Asientos por periodos";
            this.lblDetalleOp.Click += new System.EventHandler(this.lblDetalleOp_Click);
            // 
            // nroOp
            // 
            this.nroOp.AutoSize = true;
            this.nroOp.Location = new System.Drawing.Point(122, 54);
            this.nroOp.Name = "nroOp";
            this.nroOp.Size = new System.Drawing.Size(66, 13);
            this.nroOp.TabIndex = 20;
            this.nroOp.Text = "Fecha inicial";
            this.nroOp.Click += new System.EventHandler(this.nroOp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 53);
            this.button1.TabIndex = 27;
            this.button1.Text = "Mostrar Detalle del asiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(32, 193);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(75, 23);
            this.btnItem.TabIndex = 29;
            this.btnItem.Text = "Agregar Item";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panelOperacion
            // 
            this.panelOperacion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelOperacion.BackColor = System.Drawing.SystemColors.Info;
            this.panelOperacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelOperacion.Controls.Add(this.button10);
            this.panelOperacion.Controls.Add(this.btnMostrarAsiento);
            this.panelOperacion.Controls.Add(this.dgvAsiento);
            this.panelOperacion.Controls.Add(this.button6);
            this.panelOperacion.Controls.Add(this.button3);
            this.panelOperacion.Controls.Add(this.button4);
            this.panelOperacion.Controls.Add(this.btnItem);
            this.panelOperacion.Controls.Add(this.label1);
            this.panelOperacion.Controls.Add(this.dateTimeAsiento);
            this.panelOperacion.Controls.Add(this.label2);
            this.panelOperacion.Controls.Add(this.label3);
            this.panelOperacion.Controls.Add(this.btnOperacion);
            this.panelOperacion.Controls.Add(this.label4);
            this.panelOperacion.Controls.Add(this.txtDesc1);
            this.panelOperacion.Controls.Add(this.label5);
            this.panelOperacion.Controls.Add(this.txtHaber2);
            this.panelOperacion.Controls.Add(this.cmbItem1);
            this.panelOperacion.Controls.Add(this.txtHaber1);
            this.panelOperacion.Controls.Add(this.cmbItem2);
            this.panelOperacion.Controls.Add(this.txtDebe2);
            this.panelOperacion.Controls.Add(this.txtDebe1);
            this.panelOperacion.Location = new System.Drawing.Point(30, 30);
            this.panelOperacion.Name = "panelOperacion";
            this.panelOperacion.Size = new System.Drawing.Size(881, 436);
            this.panelOperacion.TabIndex = 30;
            this.panelOperacion.Visible = false;
            this.panelOperacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(32, 251);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 39;
            this.button10.Text = "Eliminar Items Agregados";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panelLibroPeriodo
            // 
            this.panelLibroPeriodo.Controls.Add(this.label7);
            this.panelLibroPeriodo.Controls.Add(this.dateTimeFechaFinal);
            this.panelLibroPeriodo.Controls.Add(this.dateTimeFechaInicial);
            this.panelLibroPeriodo.Controls.Add(this.button5);
            this.panelLibroPeriodo.Controls.Add(this.lblDetalleOp);
            this.panelLibroPeriodo.Controls.Add(this.nroOp);
            this.panelLibroPeriodo.Controls.Add(this.dgvDetalleAsiento);
            this.panelLibroPeriodo.Controls.Add(this.button1);
            this.panelLibroPeriodo.Location = new System.Drawing.Point(52, 12);
            this.panelLibroPeriodo.Name = "panelLibroPeriodo";
            this.panelLibroPeriodo.Size = new System.Drawing.Size(830, 363);
            this.panelLibroPeriodo.TabIndex = 33;
            this.panelLibroPeriodo.Visible = false;
            this.panelLibroPeriodo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDetalleAsiento_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Fecha final";
            // 
            // panelPlanDeCuentas
            // 
            this.panelPlanDeCuentas.Controls.Add(this.button9);
            this.panelPlanDeCuentas.Controls.Add(this.button8);
            this.panelPlanDeCuentas.Controls.Add(this.label6);
            this.panelPlanDeCuentas.Controls.Add(this.listBoxCuentas);
            this.panelPlanDeCuentas.Controls.Add(this.txtCuentaAgregada);
            this.panelPlanDeCuentas.Controls.Add(this.button7);
            this.panelPlanDeCuentas.Location = new System.Drawing.Point(21, 3);
            this.panelPlanDeCuentas.Name = "panelPlanDeCuentas";
            this.panelPlanDeCuentas.Size = new System.Drawing.Size(814, 438);
            this.panelPlanDeCuentas.TabIndex = 33;
            this.panelPlanDeCuentas.Visible = false;
            this.panelPlanDeCuentas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(462, 161);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "Eliminar Cuenta";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // panelLibroMayor
            // 
            this.panelLibroMayor.Controls.Add(this.dgvLibroMayor);
            this.panelLibroMayor.Controls.Add(this.label9);
            this.panelLibroMayor.Controls.Add(this.button14);
            this.panelLibroMayor.Controls.Add(this.label8);
            this.panelLibroMayor.Controls.Add(this.cmbLibroMayor);
            this.panelLibroMayor.Controls.Add(this.button13);
            this.panelLibroMayor.Location = new System.Drawing.Point(52, 3);
            this.panelLibroMayor.Name = "panelLibroMayor";
            this.panelLibroMayor.Size = new System.Drawing.Size(726, 428);
            this.panelLibroMayor.TabIndex = 35;
            this.panelLibroMayor.Visible = false;
            this.panelLibroMayor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLibroMayor_Paint);
            // 
            // dgvLibroMayor
            // 
            this.dgvLibroMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibroMayor.Location = new System.Drawing.Point(179, 153);
            this.dgvLibroMayor.Name = "dgvLibroMayor";
            this.dgvLibroMayor.Size = new System.Drawing.Size(399, 184);
            this.dgvLibroMayor.TabIndex = 34;
            this.dgvLibroMayor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Libro Mayor";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(433, 86);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 3;
            this.button14.Text = "Ver";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cuenta";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbLibroMayor
            // 
            this.cmbLibroMayor.FormattingEnabled = true;
            this.cmbLibroMayor.Location = new System.Drawing.Point(278, 88);
            this.cmbLibroMayor.Name = "cmbLibroMayor";
            this.cmbLibroMayor.Size = new System.Drawing.Size(121, 21);
            this.cmbLibroMayor.TabIndex = 1;
            this.cmbLibroMayor.SelectedIndexChanged += new System.EventHandler(this.cmbLibroMayor_SelectedIndexChanged);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(597, 343);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = "Volver";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(455, 326);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Volver al menu";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cuentas en el plan:";
            // 
            // listBoxCuentas
            // 
            this.listBoxCuentas.FormattingEnabled = true;
            this.listBoxCuentas.Location = new System.Drawing.Point(314, 161);
            this.listBoxCuentas.Name = "listBoxCuentas";
            this.listBoxCuentas.Size = new System.Drawing.Size(120, 95);
            this.listBoxCuentas.TabIndex = 2;
            this.listBoxCuentas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtCuentaAgregada
            // 
            this.txtCuentaAgregada.Location = new System.Drawing.Point(220, 69);
            this.txtCuentaAgregada.Name = "txtCuentaAgregada";
            this.txtCuentaAgregada.Size = new System.Drawing.Size(128, 20);
            this.txtCuentaAgregada.TabIndex = 1;
            this.txtCuentaAgregada.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(390, 66);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Agregar Cuenta";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_5);
            // 
            // dateTimeFechaFinal
            // 
            this.dateTimeFechaFinal.Location = new System.Drawing.Point(208, 84);
            this.dateTimeFechaFinal.Name = "dateTimeFechaFinal";
            this.dateTimeFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaFinal.TabIndex = 35;
            this.dateTimeFechaFinal.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimeFechaInicial
            // 
            this.dateTimeFechaInicial.Location = new System.Drawing.Point(208, 48);
            this.dateTimeFechaInicial.Name = "dateTimeFechaInicial";
            this.dateTimeFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaInicial.TabIndex = 34;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(687, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Volver";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvDetalleAsiento
            // 
            this.dgvDetalleAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleAsiento.Location = new System.Drawing.Point(80, 130);
            this.dgvDetalleAsiento.Name = "dgvDetalleAsiento";
            this.dgvDetalleAsiento.Size = new System.Drawing.Size(601, 214);
            this.dgvDetalleAsiento.TabIndex = 32;
            this.dgvDetalleAsiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMostrarAsiento
            // 
            this.btnMostrarAsiento.Location = new System.Drawing.Point(717, 273);
            this.btnMostrarAsiento.Name = "btnMostrarAsiento";
            this.btnMostrarAsiento.Size = new System.Drawing.Size(106, 23);
            this.btnMostrarAsiento.TabIndex = 38;
            this.btnMostrarAsiento.Text = "Mostrar Asiento";
            this.btnMostrarAsiento.UseVisualStyleBackColor = true;
            this.btnMostrarAsiento.Click += new System.EventHandler(this.button9_Click);
            // 
            // dgvAsiento
            // 
            this.dgvAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiento.Location = new System.Drawing.Point(180, 304);
            this.dgvAsiento.Name = "dgvAsiento";
            this.dgvAsiento.Size = new System.Drawing.Size(466, 117);
            this.dgvAsiento.TabIndex = 37;
            this.dgvAsiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(717, 398);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 23);
            this.button6.TabIndex = 36;
            this.button6.Text = "Volver al menu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_3);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(799, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Guardar en Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(818, 535);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Volver al Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "Agregar asiento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnPlanDeCuentas
            // 
            this.btnPlanDeCuentas.Location = new System.Drawing.Point(114, 83);
            this.btnPlanDeCuentas.Name = "btnPlanDeCuentas";
            this.btnPlanDeCuentas.Size = new System.Drawing.Size(110, 31);
            this.btnPlanDeCuentas.TabIndex = 32;
            this.btnPlanDeCuentas.Text = "Plan de cuentas";
            this.btnPlanDeCuentas.UseVisualStyleBackColor = true;
            this.btnPlanDeCuentas.Click += new System.EventHandler(this.button7_Click_4);
            // 
            // btnLibrioDiario
            // 
            this.btnLibrioDiario.Location = new System.Drawing.Point(114, 269);
            this.btnLibrioDiario.Name = "btnLibrioDiario";
            this.btnLibrioDiario.Size = new System.Drawing.Size(139, 33);
            this.btnLibrioDiario.TabIndex = 33;
            this.btnLibrioDiario.Text = "Libros Diarios y Periodos";
            this.btnLibrioDiario.UseVisualStyleBackColor = true;
            this.btnLibrioDiario.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnLibroMayor
            // 
            this.btnLibroMayor.Location = new System.Drawing.Point(114, 331);
            this.btnLibroMayor.Name = "btnLibroMayor";
            this.btnLibroMayor.Size = new System.Drawing.Size(89, 34);
            this.btnLibroMayor.TabIndex = 34;
            this.btnLibroMayor.Text = "Libros Mayores";
            this.btnLibroMayor.UseVisualStyleBackColor = true;
            this.btnLibroMayor.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(937, 484);
            this.Controls.Add(this.btnLibroMayor);
            this.Controls.Add(this.panelPlanDeCuentas);
            this.Controls.Add(this.panelLibroMayor);
            this.Controls.Add(this.panelLibroPeriodo);
            this.Controls.Add(this.btnLibrioDiario);
            this.Controls.Add(this.btnPlanDeCuentas);
            this.Controls.Add(this.panelOperacion);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOperacion.ResumeLayout(false);
            this.panelOperacion.PerformLayout();
            this.panelLibroPeriodo.ResumeLayout(false);
            this.panelLibroPeriodo.PerformLayout();
            this.panelPlanDeCuentas.ResumeLayout(false);
            this.panelPlanDeCuentas.PerformLayout();
            this.panelLibroMayor.ResumeLayout(false);
            this.panelLibroMayor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibroMayor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAsiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeAsiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbItem1;
        private System.Windows.Forms.ComboBox cmbItem2;
        private System.Windows.Forms.TextBox txtDebe1;
        private System.Windows.Forms.TextBox txtDebe2;
        private System.Windows.Forms.TextBox txtHaber1;
        private System.Windows.Forms.TextBox txtHaber2;
        private System.Windows.Forms.TextBox txtDesc1;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.Label lblDetalleOp;
        private System.Windows.Forms.Label nroOp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Panel panelOperacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvDetalleAsiento;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelLibroPeriodo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgvAsiento;
        private System.Windows.Forms.Button btnMostrarAsiento;
        private System.Windows.Forms.Button btnPlanDeCuentas;
        private System.Windows.Forms.Panel panelPlanDeCuentas;
        private System.Windows.Forms.TextBox txtCuentaAgregada;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBoxCuentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLibrioDiario;
        private System.Windows.Forms.Button btnLibroMayor;
        private System.Windows.Forms.Panel panelLibroMayor;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLibroMayor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvLibroMayor;
    }
}

