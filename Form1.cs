using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Tareas_Pendientes
{
    public partial class Panel_General : Form
    {
        public Panel_General()
        {
            InitializeComponent();
        }

        private void escribir_tareas_TextChanged(object sender, EventArgs e)
        {

            if (escribir_tareas.Text == "Escrbir las tareas....")
            { 
                escribir_tareas.Text = "";
                escribir_tareas.ForeColor = Color.Gray;
            
            }
        }

        private void Panel_General_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(escribir_tareas.Text))
            {
                escribir_tareas.Text = "Escrbir las tareas....";
                escribir_tareas.ForeColor = Color.Black;

            }
        }

        private void Botndeagregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(escribir_tareas.Text) && escribir_tareas.Text != "Escrbir las tareas....")
            {
                list_tareas.Items.Add(escribir_tareas.Text);
                escribir_tareas.Clear();
                escribir_tareas.Text = "Escrbir las tareas....";
                escribir_tareas.ForeColor = Color.Gray;
                escribir_tareas.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese una tarea andes de precionar agregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void botndeeliminación_Click(object sender, EventArgs e)
        {
            if(list_tareas.SelectedItem != null)
            {
                list_tareas.Items.Remove(list_tareas.SelectedItem);
            }
            else
            {
                MessageBox.Show("--SELECIONE UNA TAREA PARA PODER EILIMAR--","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
