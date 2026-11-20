namespace Examen_Cafeteria_RotcivOzuna
{
    partial class frmPedidos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtCliente = new TextBox();
            txtProducto = new TextBox();
            dtpFecha = new DateTimePicker();
            txtPrecio = new TextBox();
            nudCantidad = new NumericUpDown();
            chkFrecuente = new CheckBox();
            groupBox1 = new GroupBox();
            rbtGrande = new RadioButton();
            rbtNormal = new RadioButton();
            groupBox2 = new GroupBox();
            rbtLlevar = new RadioButton();
            rbtLocal = new RadioButton();
            chkPorcionExtra = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            lstPedido = new ListBox();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblEmpaque = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            label14 = new Label();
            lblEncabezado = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 14);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 71);
            label2.Name = "label2";
            label2.Size = new Size(33, 14);
            label2.TabIndex = 1;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 105);
            label3.Name = "label3";
            label3.Size = new Size(52, 14);
            label3.TabIndex = 2;
            label3.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 144);
            label4.Name = "label4";
            label4.Size = new Size(36, 14);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 179);
            label5.Name = "label5";
            label5.Size = new Size(47, 14);
            label5.TabIndex = 4;
            label5.Text = "Cantidad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(400, 240);
            label10.Name = "label10";
            label10.Size = new Size(49, 14);
            label10.TabIndex = 9;
            label10.Text = "Subtotal";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(400, 270);
            label11.Name = "label11";
            label11.Size = new Size(56, 14);
            label11.TabIndex = 10;
            label11.Text = "Descuento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(400, 299);
            label12.Name = "label12";
            label12.Size = new Size(47, 14);
            label12.TabIndex = 11;
            label12.Text = "Empaque";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(400, 330);
            label13.Name = "label13";
            label13.Size = new Size(61, 14);
            label13.TabIndex = 12;
            label13.Text = "ITBIS (18%)";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.FromArgb(192, 255, 192);
            txtCliente.Location = new Point(77, 6);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(275, 23);
            txtCliente.TabIndex = 14;
            txtCliente.TextChanged += textBox1_TextChanged;
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.FromArgb(192, 255, 192);
            txtProducto.Location = new Point(77, 96);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(275, 23);
            txtProducto.TabIndex = 15;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(77, 62);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(275, 23);
            dtpFecha.TabIndex = 16;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(192, 255, 192);
            txtPrecio.Location = new Point(77, 135);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(275, 23);
            txtPrecio.TabIndex = 17;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(77, 170);
            nudCantidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 18;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkFrecuente
            // 
            chkFrecuente.AutoSize = true;
            chkFrecuente.Location = new Point(33, 38);
            chkFrecuente.Name = "chkFrecuente";
            chkFrecuente.Size = new Size(102, 18);
            chkFrecuente.TabIndex = 19;
            chkFrecuente.Text = "Cliente Frecuente";
            chkFrecuente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(rbtGrande);
            groupBox1.Controls.Add(rbtNormal);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(24, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(151, 100);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tamaño";
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(17, 53);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(101, 18);
            rbtGrande.TabIndex = 1;
            rbtGrande.Text = "Grande (+RD$25)";
            rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Checked = true;
            rbtNormal.Location = new Point(17, 28);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(60, 18);
            rbtNormal.TabIndex = 0;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 192);
            groupBox2.Controls.Add(rbtLlevar);
            groupBox2.Controls.Add(rbtLocal);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(198, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(154, 100);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicio";
            // 
            // rbtLlevar
            // 
            rbtLlevar.AutoSize = true;
            rbtLlevar.Location = new Point(27, 52);
            rbtLlevar.Name = "rbtLlevar";
            rbtLlevar.Size = new Size(116, 18);
            rbtLlevar.TabIndex = 3;
            rbtLlevar.Text = "Para llevar (+RD$20)";
            rbtLlevar.UseVisualStyleBackColor = true;
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Location = new Point(27, 28);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(105, 18);
            rbtLocal.TabIndex = 2;
            rbtLocal.Text = "Consumir en local";
            rbtLocal.UseVisualStyleBackColor = true;
            // 
            // chkPorcionExtra
            // 
            chkPorcionExtra.AutoSize = true;
            chkPorcionExtra.Location = new Point(33, 334);
            chkPorcionExtra.Name = "chkPorcionExtra";
            chkPorcionExtra.Size = new Size(134, 18);
            chkPorcionExtra.TabIndex = 22;
            chkPorcionExtra.Text = "Porcion Extra (+RD$30)";
            chkPorcionExtra.UseVisualStyleBackColor = true;
            chkPorcionExtra.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(255, 255, 128);
            btnCalcular.Location = new Point(34, 381);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(97, 34);
            btnCalcular.TabIndex = 23;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 255, 128);
            btnLimpiar.Location = new Point(151, 381);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(92, 34);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Nuevo Pedido";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 255, 128);
            btnSalir.Location = new Point(260, 381);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 34);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 255, 128);
            btnAgregar.Location = new Point(398, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(420, 39);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar al pedido";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lstPedido
            // 
            lstPedido.BackColor = Color.FromArgb(255, 192, 192);
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(398, 71);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(420, 144);
            lstPedido.TabIndex = 27;
            // 
            // lblSubtotal
            // 
            lblSubtotal.BackColor = Color.FromArgb(255, 255, 192);
            lblSubtotal.BorderStyle = BorderStyle.FixedSingle;
            lblSubtotal.Location = new Point(669, 231);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(84, 23);
            lblSubtotal.TabIndex = 28;
            lblSubtotal.Text = "RD$ 0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            lblDescuento.BackColor = Color.FromArgb(255, 255, 192);
            lblDescuento.BorderStyle = BorderStyle.FixedSingle;
            lblDescuento.Location = new Point(669, 261);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(84, 23);
            lblDescuento.TabIndex = 29;
            lblDescuento.Text = "RD$ 0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmpaque
            // 
            lblEmpaque.BackColor = Color.FromArgb(255, 255, 192);
            lblEmpaque.BorderStyle = BorderStyle.FixedSingle;
            lblEmpaque.Location = new Point(669, 290);
            lblEmpaque.Name = "lblEmpaque";
            lblEmpaque.Size = new Size(84, 23);
            lblEmpaque.TabIndex = 30;
            lblEmpaque.Text = "RD$ 0.00";
            lblEmpaque.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItbis
            // 
            lblItbis.BackColor = Color.FromArgb(255, 255, 192);
            lblItbis.BorderStyle = BorderStyle.FixedSingle;
            lblItbis.Location = new Point(669, 321);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(84, 23);
            lblItbis.TabIndex = 31;
            lblItbis.Text = "RD$ 0.00";
            lblItbis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(255, 255, 192);
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Location = new Point(669, 372);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(84, 23);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "RD$ 0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(398, 381);
            label14.Name = "label14";
            label14.Size = new Size(83, 14);
            label14.TabIndex = 33;
            label14.Text = "TOTAL A PAGAR";
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(400, 54);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(33, 14);
            lblEncabezado.TabIndex = 35;
            lblEncabezado.Text = "label7";
            // 
            // frmPedidos
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(879, 450);
            Controls.Add(lblEncabezado);
            Controls.Add(label14);
            Controls.Add(lblTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblEmpaque);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(lstPedido);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chkPorcionExtra);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(chkFrecuente);
            Controls.Add(nudCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(dtpFecha);
            Controls.Add(txtProducto);
            Controls.Add(txtCliente);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPedidos";
            Text = "Cafetería El Buen Sabor - Pedidos";
            Load += frmPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private DateTimePicker dtpFecha;
        private TextBox txtPrecio;
        private NumericUpDown nudCantidad;
        private CheckBox chkFrecuente;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkPorcionExtra;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAgregar;
        private ListBox lstPedido;
        private RadioButton rbtGrande;
        private RadioButton rbtNormal;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblEmpaque;
        private Label lblItbis;
        private Label lblTotal;
        private Label label14;
        private Label lblEncabezado;
        private RadioButton rbtLlevar;
        private RadioButton rbtLocal;
    }
}
