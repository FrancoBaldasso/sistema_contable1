
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.txtCuentaNueva = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.lblDetalleOp = new System.Windows.Forms.Label();
            this.nroOp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbNOperacion = new System.Windows.Forms.ComboBox();
            this.btnItem = new System.Windows.Forms.Button();
            this.panelOperacion = new System.Windows.Forms.Panel();
            this.dgvDetalleAsiento = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelOperacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAsiento)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(157, 29);
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
            this.label2.Location = new System.Drawing.Point(157, 93);
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
            this.label3.Location = new System.Drawing.Point(338, 93);
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
            this.label4.Location = new System.Drawing.Point(491, 93);
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
            this.label5.Location = new System.Drawing.Point(622, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripción";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbItem1
            // 
            this.cmbItem1.FormattingEnabled = true;
            this.cmbItem1.Location = new System.Drawing.Point(160, 126);
            this.cmbItem1.Name = "cmbItem1";
            this.cmbItem1.Size = new System.Drawing.Size(121, 21);
            this.cmbItem1.TabIndex = 7;
            this.cmbItem1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbItem2
            // 
            this.cmbItem2.FormattingEnabled = true;
            this.cmbItem2.Location = new System.Drawing.Point(160, 165);
            this.cmbItem2.Name = "cmbItem2";
            this.cmbItem2.Size = new System.Drawing.Size(121, 21);
            this.cmbItem2.TabIndex = 8;
            this.cmbItem2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtDebe1
            // 
            this.txtDebe1.Location = new System.Drawing.Point(319, 127);
            this.txtDebe1.Name = "txtDebe1";
            this.txtDebe1.Size = new System.Drawing.Size(100, 20);
            this.txtDebe1.TabIndex = 9;
            this.txtDebe1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDebe2
            // 
            this.txtDebe2.Location = new System.Drawing.Point(319, 166);
            this.txtDebe2.Name = "txtDebe2";
            this.txtDebe2.Size = new System.Drawing.Size(100, 20);
            this.txtDebe2.TabIndex = 10;
            this.txtDebe2.TextChanged += new System.EventHandler(this.txtDebe2_TextChanged);
            // 
            // txtHaber1
            // 
            this.txtHaber1.Location = new System.Drawing.Point(464, 127);
            this.txtHaber1.Name = "txtHaber1";
            this.txtHaber1.Size = new System.Drawing.Size(100, 20);
            this.txtHaber1.TabIndex = 11;
            this.txtHaber1.TextChanged += new System.EventHandler(this.txtHaber1_TextChanged);
            // 
            // txtHaber2
            // 
            this.txtHaber2.Location = new System.Drawing.Point(464, 165);
            this.txtHaber2.Name = "txtHaber2";
            this.txtHaber2.Size = new System.Drawing.Size(100, 20);
            this.txtHaber2.TabIndex = 12;
            this.txtHaber2.TextChanged += new System.EventHandler(this.txtHaber2_TextChanged);
            // 
            // txtDesc1
            // 
            this.txtDesc1.Location = new System.Drawing.Point(603, 126);
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.Size = new System.Drawing.Size(100, 20);
            this.txtDesc1.TabIndex = 13;
            this.txtDesc1.TextChanged += new System.EventHandler(this.txtDesc1_TextChanged);
            // 
            // txtCuentaNueva
            // 
            this.txtCuentaNueva.Location = new System.Drawing.Point(188, 55);
            this.txtCuentaNueva.Name = "txtCuentaNueva";
            this.txtCuentaNueva.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaNueva.TabIndex = 15;
            this.txtCuentaNueva.Text = "Nueva Cuenta";
            this.txtCuentaNueva.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(310, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar Cuenta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOperacion
            // 
            this.btnOperacion.Location = new System.Drawing.Point(688, 300);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(130, 23);
            this.btnOperacion.TabIndex = 18;
            this.btnOperacion.Text = "Agregar asiento";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDetalleOp
            // 
            this.lblDetalleOp.AutoSize = true;
            this.lblDetalleOp.Location = new System.Drawing.Point(108, 335);
            this.lblDetalleOp.Name = "lblDetalleOp";
            this.lblDetalleOp.Size = new System.Drawing.Size(118, 13);
            this.lblDetalleOp.TabIndex = 19;
            this.lblDetalleOp.Text = "Detalle de la Operacion";
            this.lblDetalleOp.Click += new System.EventHandler(this.lblDetalleOp_Click);
            // 
            // nroOp
            // 
            this.nroOp.AutoSize = true;
            this.nroOp.Location = new System.Drawing.Point(262, 340);
            this.nroOp.Name = "nroOp";
            this.nroOp.Size = new System.Drawing.Size(19, 13);
            this.nroOp.TabIndex = 20;
            this.nroOp.Text = "N°";
            this.nroOp.Click += new System.EventHandler(this.nroOp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 53);
            this.button1.TabIndex = 27;
            this.button1.Text = "Mostrar Detalle del asiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmbNOperacion
            // 
            this.cmbNOperacion.FormattingEnabled = true;
            this.cmbNOperacion.Location = new System.Drawing.Point(300, 332);
            this.cmbNOperacion.Name = "cmbNOperacion";
            this.cmbNOperacion.Size = new System.Drawing.Size(34, 21);
            this.cmbNOperacion.TabIndex = 28;
            this.cmbNOperacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(12, 217);
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
            this.panelOperacion.Controls.Add(this.button3);
            this.panelOperacion.Controls.Add(this.dgvDetalleAsiento);
            this.panelOperacion.Controls.Add(this.button4);
            this.panelOperacion.Controls.Add(this.button1);
            this.panelOperacion.Controls.Add(this.nroOp);
            this.panelOperacion.Controls.Add(this.cmbNOperacion);
            this.panelOperacion.Controls.Add(this.btnItem);
            this.panelOperacion.Controls.Add(this.label1);
            this.panelOperacion.Controls.Add(this.lblDetalleOp);
            this.panelOperacion.Controls.Add(this.dateTimePicker1);
            this.panelOperacion.Controls.Add(this.txtCuentaNueva);
            this.panelOperacion.Controls.Add(this.btnAgregar);
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
            this.panelOperacion.Location = new System.Drawing.Point(0, 3);
            this.panelOperacion.Name = "panelOperacion";
            this.panelOperacion.Size = new System.Drawing.Size(987, 624);
            this.panelOperacion.TabIndex = 30;
            this.panelOperacion.Visible = false;
            this.panelOperacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvDetalleAsiento
            // 
            this.dgvDetalleAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleAsiento.Location = new System.Drawing.Point(123, 374);
            this.dgvDetalleAsiento.Name = "dgvDetalleAsiento";
            this.dgvDetalleAsiento.Size = new System.Drawing.Size(551, 214);
            this.dgvDetalleAsiento.TabIndex = 32;
            this.dgvDetalleAsiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(815, 565);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Volver al Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(815, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Agregar asiento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(987, 627);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelOperacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOperacion.ResumeLayout(false);
            this.panelOperacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleAsiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
        private System.Windows.Forms.TextBox txtCuentaNueva;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.Label lblDetalleOp;
        private System.Windows.Forms.Label nroOp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbNOperacion;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Panel panelOperacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvDetalleAsiento;
        private System.Windows.Forms.Button button3;
    }
}

