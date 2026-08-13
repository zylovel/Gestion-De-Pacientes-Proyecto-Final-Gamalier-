using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProyectoFinalGamalier.NewFolder;

// alias para acceder a la clase anidada Pacientes y al tipo Paciente
using PacientesClass = ProyectoFinalGamalier.NewFolder.Pacientes.Pacientes;

namespace FinalGamalier
{
    public partial class Form1 : Form
    {
        private GestorPacientes gestor = new GestorPacientes();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Rellenar los ComboBox con los valores de los enums
            cmbSexo.Items.Clear();
            cmbSexo.Items.AddRange(Enum.GetNames(typeof(PacientesClass.Sexo)));

            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(Enum.GetNames(typeof(PacientesClass.EstadoPaciente)));

            // Inicializar opcionalmente FechaIngreso con la fecha de hoy
            cmbFechaIngreso.Items.Clear();
            cmbFechaIngreso.Items.Add(DateTime.Now.ToShortDateString());
            cmbFechaIngreso.SelectedIndex = 0;

            RefrescarGrilla(gestor.ObtenerTodos());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Ningún comportamiento requerido por el diseño; conservado para compatibilidad del diseñador
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBID_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            RefrescarGrilla(gestor.ObtenerTodos());
        }

        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            string nombre = txtBNombre.Text ?? string.Empty;
            var resultados = gestor.BuscarPorNombre(nombre);
            RefrescarGrilla(resultados);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.CurrentRow == null) return;

            var item = dataGridView1.CurrentRow.DataBoundItem;
            if (item == null) return;

            try
            {
                var paciente = item as PacientesClass.Paciente;
                if (paciente == null) return;

                txtBID.Text = paciente.Id;
                txtBNombre.Text = paciente.Nombre;
                textBox1.Text = paciente.Edad.ToString();
                textBox2.Text = paciente.Diagnostico;
                cmbSexo.SelectedItem = paciente.Sexo.ToString();
                cmbEstado.SelectedItem = paciente.Estado.ToString();
                cmbFechaIngreso.SelectedItem = paciente.FechaIngreso.ToShortDateString();
            }
            catch
            {
                // Ignorar errores de conversión para evitar que eventos del diseñador provoquen fallos
            }
        }

        private void txtBNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblSexo_Click(object sender, EventArgs e)
        {
        }

        private void lblID_Click(object sender, EventArgs e)
        {
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
        }

        private void lblEdad_Click(object sender, EventArgs e)
        {
        }

        private void lblDiagnostico_Click(object sender, EventArgs e)
        {
        }

        // Método auxiliar para refrescar la fuente del DataGridView de forma segura
        private void RefrescarGrilla(List<PacientesClass.Paciente> lista)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo paciente a partir de los campos del formulario y añadirlo al gestor
            var nuevo = new PacientesClass.Paciente();
            nuevo.Id = txtBID.Text?.Trim() ?? string.Empty;
            nuevo.Nombre = txtBNombre.Text?.Trim() ?? string.Empty;

            if (!int.TryParse(textBox1.Text?.Trim(), out int edad))
            {
                MessageBox.Show("Edad inválida. Ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nuevo.Edad = edad;
            nuevo.Diagnostico = textBox2.Text?.Trim() ?? string.Empty;

            if (cmbSexo.SelectedItem != null && Enum.TryParse<PacientesClass.Sexo>(cmbSexo.SelectedItem.ToString(), out var sx))
            {
                nuevo.Sexo = sx;
            }

            if (cmbEstado.SelectedItem != null && Enum.TryParse<PacientesClass.EstadoPaciente>(cmbEstado.SelectedItem.ToString(), out var est))
            {
                nuevo.Estado = est;
            }

            // FechaIngreso: intentar convertir el elemento seleccionado; si falla usar la fecha actual
            if (cmbFechaIngreso.SelectedItem != null && DateTime.TryParse(cmbFechaIngreso.SelectedItem.ToString(), out var fi))
            {
                nuevo.FechaIngreso = fi;
            }

            gestor.AgregarPaciente(nuevo);
            RefrescarGrilla(gestor.ObtenerTodos());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar paciente existente usando los campos del formulario
            var actualizado = new PacientesClass.Paciente();
            actualizado.Id = txtBID.Text?.Trim() ?? string.Empty;
            actualizado.Nombre = txtBNombre.Text?.Trim() ?? string.Empty;

            if (!int.TryParse(textBox1.Text?.Trim(), out int edad))
            {
                MessageBox.Show("Edad inválida. Ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            actualizado.Edad = edad;
            actualizado.Diagnostico = textBox2.Text?.Trim() ?? string.Empty;

            if (cmbSexo.SelectedItem != null && Enum.TryParse<PacientesClass.Sexo>(cmbSexo.SelectedItem.ToString(), out var sx))
            {
                actualizado.Sexo = sx;
            }

            if (cmbEstado.SelectedItem != null && Enum.TryParse<PacientesClass.EstadoPaciente>(cmbEstado.SelectedItem.ToString(), out var est))
            {
                actualizado.Estado = est;
            }

            if (cmbFechaIngreso.SelectedItem != null && DateTime.TryParse(cmbFechaIngreso.SelectedItem.ToString(), out var fi))
            {
                actualizado.FechaIngreso = fi;
            }

            gestor.ActualizarPaciente(actualizado);
            RefrescarGrilla(gestor.ObtenerTodos());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los controles de entrada
            txtBID.Text = string.Empty;
            txtBNombre.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            cmbSexo.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbFechaIngreso.SelectedIndex = -1;
            textBox3.Text = string.Empty;
            // También refrescar la grilla con la lista actual
            RefrescarGrilla(gestor.ObtenerTodos());
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text?.Trim();
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Ingrese un ID para buscar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var p = gestor.BuscarPorId(id);
            if (p == null)
            {
                MessageBox.Show("No se encontró el paciente con ese ID.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Rellenar el formulario con el paciente encontrado y resaltar en la grilla
            txtBID.Text = p.Id;
            txtBNombre.Text = p.Nombre;
            textBox1.Text = p.Edad.ToString();
            textBox2.Text = p.Diagnostico;
            cmbSexo.SelectedItem = p.Sexo.ToString();
            cmbEstado.SelectedItem = p.Estado.ToString();
            cmbFechaIngreso.SelectedItem = p.FechaIngreso.ToShortDateString();

            // Seleccionar la fila en el DataGrid si está presente
            var all = gestor.ObtenerTodos();
            RefrescarGrilla(all);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var item = dataGridView1.Rows[i].DataBoundItem as PacientesClass.Paciente;
                if (item != null && string.Equals(item.Id, p.Id, StringComparison.OrdinalIgnoreCase))
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    break;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBusquedaYListado_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            string id = txtBID.Text?.Trim();
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Ingrese el ID del paciente a eliminar (campo ID).", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"¿Eliminar paciente con ID '{id}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            gestor.EliminarPaciente(id);
            RefrescarGrilla(gestor.ObtenerTodos());
            btnLimpiar_Click(sender, e);
        }

        private void lblFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void cmbFechaIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
