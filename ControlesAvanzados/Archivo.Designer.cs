namespace ControlesAvanzados
{
    partial class Archivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listadoVentas = new FlowLayoutPanel();
            selectorDepartamento = new ListBox();
            ComboBoxAnios = new ComboBox();
            ComboBoxMeses = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 31);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Nuevo Archivo";
            // 
            // listadoVentas
            // 
            listadoVentas.AutoScroll = true;
            listadoVentas.BackColor = SystemColors.WindowFrame;
            listadoVentas.Location = new Point(369, -1);
            listadoVentas.Name = "listadoVentas";
            listadoVentas.Size = new Size(578, 498);
            listadoVentas.TabIndex = 1;
            // 
            // selectorDepartamento
            // 
            selectorDepartamento.BackColor = SystemColors.InactiveCaption;
            selectorDepartamento.FormattingEnabled = true;
            selectorDepartamento.Location = new Point(12, 281);
            selectorDepartamento.Name = "selectorDepartamento";
            selectorDepartamento.SelectionMode = SelectionMode.MultiSimple;
            selectorDepartamento.Size = new Size(334, 144);
            selectorDepartamento.TabIndex = 2;
            selectorDepartamento.SelectedValueChanged += selectorDepartamento_SelectedValueChanged_1;
            // 
            // ComboBoxAnios
            // 
            ComboBoxAnios.BackColor = SystemColors.MenuHighlight;
            ComboBoxAnios.FormattingEnabled = true;
            ComboBoxAnios.Location = new Point(12, 112);
            ComboBoxAnios.Name = "ComboBoxAnios";
            ComboBoxAnios.Size = new Size(334, 28);
            ComboBoxAnios.TabIndex = 3;
            // 
            // ComboBoxMeses
            // 
            ComboBoxMeses.BackColor = SystemColors.MenuHighlight;
            ComboBoxMeses.FormattingEnabled = true;
            ComboBoxMeses.Location = new Point(12, 193);
            ComboBoxMeses.Name = "ComboBoxMeses";
            ComboBoxMeses.Size = new Size(334, 28);
            ComboBoxMeses.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(12, 247);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 5;
            label2.Text = "Seleccionar Departamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 6;
            label3.Text = "Seleccionar Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 7;
            label4.Text = "Seleccionar Mes";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-1, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 488);
            panel1.TabIndex = 8;
            // 
            // Archivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 498);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ComboBoxMeses);
            Controls.Add(ComboBoxAnios);
            Controls.Add(selectorDepartamento);
            Controls.Add(listadoVentas);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Archivo";
            Text = " ";
            Load += Archivo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel listadoVentas;
        private ListBox selectorDepartamento;
        private ComboBox ComboBoxAnios;
        private ComboBox ComboBoxMeses;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
    }
}