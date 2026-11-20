using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examen_Cafeteria_RotcivOzuna
{
    public partial class frmPedidos : Form
    {
        // ---------- Constantes (reglas de negocio) ----------
        private const decimal RECARGO_GRANDE = 25m;
        private const decimal RECARGO_PORCION_EXTRA = 30m;
        private const decimal PORCENTAJE_DESCUENTO = 0.10m;
        private const decimal EMPAQUE_PARA_LLEVAR = 20m;
        private const decimal PORCENTAJE_ITBIS = 0.18m;

        // Anchos de columnas
        private const int ANCHO_CANT = 6;
        private const int ANCHO_PRODUCTO = 24;
        private const int ANCHO_PRECIO = 10;
        private const int ANCHO_TOTAL = 12;

        // Subtotal acumulado del pedido
        private decimal subtotal = 0m;

        public frmPedidos()
        {
            InitializeComponent();

            // Conectar eventos por codigo (no hagas doble clic en los botones del diseñador)
            this.Load += frmPedidos_Load;
            btnAgregar.Click += btnAgregar_Click;
            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        // ---------- Load ----------
        private void frmPedidos_Load(object sender, EventArgs e)
        {
            // Fuente monoespaciada para que las columnas se alineen
            lstPedido.Font = new Font("Consolas", 10);
            lblEncabezado.Font = new Font("Consolas", 10, FontStyle.Bold);

            lblEncabezado.Text = FormatearLinea("Cant", "Producto", "Precio", "Total");
            ReiniciarFormulario();
        }

        // ---------- Agregar al pedido ----------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Digite el nombre del producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Digite un precio válido (mayor que cero).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                txtPrecio.SelectAll();
                return;
            }

            int cantidad = (int)nudCantidad.Value;

            // Precio unitario = precio + 25 si es grande + 30 si lleva porcion extra
            decimal precioUnitario = precio;
            if (rbtGrande.Checked) precioUnitario += RECARGO_GRANDE;
            if (chkPorcionExtra.Checked) precioUnitario += RECARGO_PORCION_EXTRA;

            // Total de linea
            decimal totalLinea = precioUnitario * cantidad;

            // Producto con su tamaño/extra entre parentesis
            string descripcion = txtProducto.Text.Trim() + ObtenerDetalle();

            // Mostrar la linea en columnas
            lstPedido.Items.Add(FormatearLinea(
                cantidad.ToString(),
                descripcion,
                precioUnitario.ToString("0.00"),
                totalLinea.ToString("0.00")));

            // Acumular subtotal
            subtotal += totalLinea;
            lblSubtotal.Text = FormatoMoneda(subtotal);

            // Reiniciar controles del producto
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            rbtNormal.Checked = true;
            chkPorcionExtra.Checked = false;
            txtProducto.Focus();
        }

        // ---------- Calcular total ----------
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstPedido.Items.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto al pedido.", "Sin productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal descuento = chkFrecuente.Checked ? subtotal * PORCENTAJE_DESCUENTO : 0m;
            decimal empaque = rbtLlevar.Checked ? EMPAQUE_PARA_LLEVAR : 0m;
            decimal baseImponible = subtotal - descuento + empaque;
            decimal itbis = baseImponible * PORCENTAJE_ITBIS;
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = FormatoMoneda(subtotal);
            lblDescuento.Text = FormatoMoneda(descuento);
            lblEmpaque.Text = FormatoMoneda(empaque);
            lblItbis.Text = FormatoMoneda(itbis);
            lblTotal.Text = FormatoMoneda(total);
        }

        // ---------- Nuevo pedido ----------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
            txtCliente.Focus();
        }

        // ---------- Salir ----------
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                this.Close();
        }

        // ---------- Metodos auxiliares ----------
        private void ReiniciarFormulario()
        {
            txtCliente.Clear();
            chkFrecuente.Checked = false;
            dtpFecha.Value = DateTime.Now;
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 20;
            nudCantidad.Value = 1;
            rbtNormal.Checked = true;
            chkPorcionExtra.Checked = false;
            rbtLocal.Checked = true;
            lstPedido.Items.Clear();

            subtotal = 0m;
            lblSubtotal.Text = FormatoMoneda(0m);
            lblDescuento.Text = FormatoMoneda(0m);
            lblEmpaque.Text = FormatoMoneda(0m);
            lblItbis.Text = FormatoMoneda(0m);
            lblTotal.Text = FormatoMoneda(0m);
        }

        private string FormatearLinea(string cant, string producto, string precio, string total)
        {
            return cant.PadRight(ANCHO_CANT)
                 + producto.PadRight(ANCHO_PRODUCTO)
                 + precio.PadLeft(ANCHO_PRECIO)
                 + total.PadLeft(ANCHO_TOTAL);
        }

        private string ObtenerDetalle()
        {
            string detalle = "";
            if (rbtGrande.Checked) detalle = "Grande";
            if (chkPorcionExtra.Checked)
                detalle += (detalle == "" ? "" : ", ") + "Extra";

            return detalle == "" ? "" : " (" + detalle + ")";
        }

        private string FormatoMoneda(decimal valor)
        {
            return "RD$ " + valor.ToString("0.00");
        }

        // Métodos vacíos creados por el diseñador (evitan errores de compilación)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }
    }
}
