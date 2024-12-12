namespace Gestion_Tareas_Pendientes
{
    partial class Panel_General
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
            this.Botndeagregar = new System.Windows.Forms.Button();
            this.botndeeliminación = new System.Windows.Forms.Button();
            this.list_tareas = new System.Windows.Forms.ListBox();
            this.escribir_tareas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Botndeagregar
            // 
            this.Botndeagregar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Botndeagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botndeagregar.Location = new System.Drawing.Point(167, 123);
            this.Botndeagregar.Name = "Botndeagregar";
            this.Botndeagregar.Size = new System.Drawing.Size(280, 44);
            this.Botndeagregar.TabIndex = 0;
            this.Botndeagregar.Text = "Agregar Tarea";
            this.Botndeagregar.UseVisualStyleBackColor = false;
            this.Botndeagregar.Click += new System.EventHandler(this.Botndeagregar_Click);
            // 
            // botndeeliminación
            // 
            this.botndeeliminación.BackColor = System.Drawing.Color.Crimson;
            this.botndeeliminación.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botndeeliminación.Location = new System.Drawing.Point(224, 465);
            this.botndeeliminación.Name = "botndeeliminación";
            this.botndeeliminación.Size = new System.Drawing.Size(197, 65);
            this.botndeeliminación.TabIndex = 1;
            this.botndeeliminación.Text = "Eliminar tarea  seleccionada ";
            this.botndeeliminación.UseVisualStyleBackColor = false;
            this.botndeeliminación.Click += new System.EventHandler(this.botndeeliminación_Click);
            // 
            // list_tareas
            // 
            this.list_tareas.BackColor = System.Drawing.Color.PowderBlue;
            this.list_tareas.FormattingEnabled = true;
            this.list_tareas.ItemHeight = 16;
            this.list_tareas.Location = new System.Drawing.Point(109, 183);
            this.list_tareas.Name = "list_tareas";
            this.list_tareas.Size = new System.Drawing.Size(428, 260);
            this.list_tareas.TabIndex = 2;
            // 
            // escribir_tareas
            // 
            this.escribir_tareas.BackColor = System.Drawing.Color.White;
            this.escribir_tareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escribir_tareas.Location = new System.Drawing.Point(109, 50);
            this.escribir_tareas.Name = "escribir_tareas";
            this.escribir_tareas.Size = new System.Drawing.Size(410, 26);
            this.escribir_tareas.TabIndex = 3;
            this.escribir_tareas.TabStop = false;
            this.escribir_tareas.TextChanged += new System.EventHandler(this.escribir_tareas_TextChanged);
            // 
            // Panel_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(650, 597);
            this.Controls.Add(this.escribir_tareas);
            this.Controls.Add(this.list_tareas);
            this.Controls.Add(this.Botndeagregar);
            this.Controls.Add(this.botndeeliminación);
            this.Name = "Panel_General";
            this.Text = "Gestion de Tareas Pendientes";
            this.Load += new System.EventHandler(this.Panel_General_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botndeagregar;
        private System.Windows.Forms.Button botndeeliminación;
        private System.Windows.Forms.ListBox list_tareas;
        private System.Windows.Forms.TextBox escribir_tareas;
    }
}

