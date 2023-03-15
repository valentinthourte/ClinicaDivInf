namespace ClinicaDivInf
{
    partial class frmClinica
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
            edtNombre = new TextBox();
            lblPersona = new Label();
            edtEspecialidad = new TextBox();
            lblMedico = new Label();
            lblPaciente = new Label();
            btnCrearMedico = new Button();
            btnCrearPaciente = new Button();
            panel1 = new Panel();
            rbPractica = new RadioButton();
            rbConsultorio = new RadioButton();
            dtFecha = new DateTimePicker();
            lblFecha = new Label();
            cbProfesional = new ComboBox();
            lblProfesional = new Label();
            lblCostoConsulta = new Label();
            lblDescripcion = new Label();
            edtDescripcion = new TextBox();
            lblCostoMateriales = new Label();
            lblConsulta = new Label();
            btnConsulta = new Button();
            lblParaPaciente = new Label();
            cbParaPaciente = new ComboBox();
            edtNroMatricula = new NumericUpDown();
            edtNumeroHistoriaClinica = new NumericUpDown();
            edtCostoConsulta = new NumericUpDown();
            edtCostoMateriales = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edtNroMatricula).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edtNumeroHistoriaClinica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edtCostoConsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edtCostoMateriales).BeginInit();
            SuspendLayout();
            // 
            // edtNombre
            // 
            edtNombre.Location = new Point(306, 42);
            edtNombre.Name = "edtNombre";
            edtNombre.PlaceholderText = "Nombre";
            edtNombre.Size = new Size(171, 23);
            edtNombre.TabIndex = 0;
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPersona.Location = new Point(350, 9);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(89, 30);
            lblPersona.TabIndex = 1;
            lblPersona.Text = "Persona";
            // 
            // edtEspecialidad
            // 
            edtEspecialidad.Location = new Point(306, 101);
            edtEspecialidad.Name = "edtEspecialidad";
            edtEspecialidad.PlaceholderText = "Especialidad";
            edtEspecialidad.Size = new Size(171, 23);
            edtEspecialidad.TabIndex = 3;
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedico.Location = new Point(350, 68);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(86, 30);
            lblMedico.TabIndex = 5;
            lblMedico.Text = "Medico";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaciente.Location = new Point(350, 186);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(93, 30);
            lblPaciente.TabIndex = 6;
            lblPaciente.Text = "Paciente";
            // 
            // btnCrearMedico
            // 
            btnCrearMedico.Location = new Point(321, 168);
            btnCrearMedico.Name = "btnCrearMedico";
            btnCrearMedico.Size = new Size(149, 23);
            btnCrearMedico.TabIndex = 8;
            btnCrearMedico.Text = "Crear Medico";
            btnCrearMedico.UseVisualStyleBackColor = true;
            btnCrearMedico.Click += btnCrearMedico_Click;
            // 
            // btnCrearPaciente
            // 
            btnCrearPaciente.Location = new Point(321, 260);
            btnCrearPaciente.Name = "btnCrearPaciente";
            btnCrearPaciente.Size = new Size(149, 23);
            btnCrearPaciente.TabIndex = 9;
            btnCrearPaciente.Text = "Crear Paciente";
            btnCrearPaciente.UseVisualStyleBackColor = true;
            btnCrearPaciente.Click += btnCrearPaciente_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbPractica);
            panel1.Controls.Add(rbConsultorio);
            panel1.Location = new Point(244, 320);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 100);
            panel1.TabIndex = 10;
            // 
            // rbPractica
            // 
            rbPractica.AutoSize = true;
            rbPractica.Location = new Point(5, 60);
            rbPractica.Name = "rbPractica";
            rbPractica.Size = new Size(241, 19);
            rbPractica.TabIndex = 1;
            rbPractica.Text = "Fue la realización de una práctica médica";
            rbPractica.UseVisualStyleBackColor = true;
            rbPractica.CheckedChanged += onConsultaChanged;
            // 
            // rbConsultorio
            // 
            rbConsultorio.AutoSize = true;
            rbConsultorio.Checked = true;
            rbConsultorio.Location = new Point(5, 17);
            rbConsultorio.Name = "rbConsultorio";
            rbConsultorio.Size = new Size(189, 19);
            rbConsultorio.TabIndex = 0;
            rbConsultorio.TabStop = true;
            rbConsultorio.Text = "Fue realizada en un consultorio";
            rbConsultorio.UseVisualStyleBackColor = true;
            rbConsultorio.CheckedChanged += onConsultaChanged;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(364, 426);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(182, 23);
            dtFecha.TabIndex = 11;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(244, 432);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(119, 15);
            lblFecha.TabIndex = 12;
            lblFecha.Text = "Fecha de realización: ";
            // 
            // cbProfesional
            // 
            cbProfesional.FormattingEnabled = true;
            cbProfesional.Location = new Point(401, 455);
            cbProfesional.Name = "cbProfesional";
            cbProfesional.Size = new Size(145, 23);
            cbProfesional.TabIndex = 13;
            // 
            // lblProfesional
            // 
            lblProfesional.AutoSize = true;
            lblProfesional.Location = new Point(244, 458);
            lblProfesional.Name = "lblProfesional";
            lblProfesional.Size = new Size(84, 15);
            lblProfesional.TabIndex = 14;
            lblProfesional.Text = "Realizado por: ";
            // 
            // lblCostoConsulta
            // 
            lblCostoConsulta.AutoSize = true;
            lblCostoConsulta.Location = new Point(243, 513);
            lblCostoConsulta.Name = "lblCostoConsulta";
            lblCostoConsulta.Size = new Size(120, 15);
            lblCostoConsulta.TabIndex = 18;
            lblCostoConsulta.Text = "Costo de la consulta: ";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(243, 542);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(151, 15);
            lblDescripcion.TabIndex = 20;
            lblDescripcion.Text = "Descripcion de la consulta: ";
            // 
            // edtDescripcion
            // 
            edtDescripcion.Location = new Point(400, 539);
            edtDescripcion.Name = "edtDescripcion";
            edtDescripcion.Size = new Size(145, 23);
            edtDescripcion.TabIndex = 19;
            // 
            // lblCostoMateriales
            // 
            lblCostoMateriales.AutoSize = true;
            lblCostoMateriales.Location = new Point(243, 571);
            lblCostoMateriales.Name = "lblCostoMateriales";
            lblCostoMateriales.Size = new Size(135, 15);
            lblCostoMateriales.TabIndex = 22;
            lblCostoMateriales.Text = "Costo de los materiales: ";
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblConsulta.Location = new Point(343, 287);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(96, 30);
            lblConsulta.TabIndex = 23;
            lblConsulta.Text = "Consulta";
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(321, 597);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(149, 23);
            btnConsulta.TabIndex = 24;
            btnConsulta.Text = "Crear Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // lblParaPaciente
            // 
            lblParaPaciente.AutoSize = true;
            lblParaPaciente.Location = new Point(243, 487);
            lblParaPaciente.Name = "lblParaPaciente";
            lblParaPaciente.Size = new Size(137, 15);
            lblParaPaciente.TabIndex = 26;
            lblParaPaciente.Text = "Realizado para paciente: ";
            // 
            // cbParaPaciente
            // 
            cbParaPaciente.FormattingEnabled = true;
            cbParaPaciente.Location = new Point(400, 484);
            cbParaPaciente.Name = "cbParaPaciente";
            cbParaPaciente.Size = new Size(145, 23);
            cbParaPaciente.TabIndex = 25;
            // 
            // edtNroMatricula
            // 
            edtNroMatricula.Location = new Point(306, 139);
            edtNroMatricula.Name = "edtNroMatricula";
            edtNroMatricula.Size = new Size(171, 23);
            edtNroMatricula.TabIndex = 27;
            // 
            // edtNumeroHistoriaClinica
            // 
            edtNumeroHistoriaClinica.Location = new Point(306, 231);
            edtNumeroHistoriaClinica.Name = "edtNumeroHistoriaClinica";
            edtNumeroHistoriaClinica.Size = new Size(171, 23);
            edtNumeroHistoriaClinica.TabIndex = 28;
            // 
            // edtCostoConsulta
            // 
            edtCostoConsulta.Location = new Point(400, 513);
            edtCostoConsulta.Name = "edtCostoConsulta";
            edtCostoConsulta.Size = new Size(145, 23);
            edtCostoConsulta.TabIndex = 29;
            // 
            // edtCostoMateriales
            // 
            edtCostoMateriales.Location = new Point(400, 568);
            edtCostoMateriales.Name = "edtCostoMateriales";
            edtCostoMateriales.Size = new Size(146, 23);
            edtCostoMateriales.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(341, 124);
            label1.Name = "label1";
            label1.Size = new Size(98, 12);
            label1.TabIndex = 31;
            label1.Text = "Numero de matrícula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(326, 216);
            label2.Name = "label2";
            label2.Size = new Size(117, 12);
            label2.TabIndex = 32;
            label2.Text = "Numero de histora clínica";
            // 
            // frmClinica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 682);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(edtCostoMateriales);
            Controls.Add(edtCostoConsulta);
            Controls.Add(edtNumeroHistoriaClinica);
            Controls.Add(edtNroMatricula);
            Controls.Add(lblParaPaciente);
            Controls.Add(cbParaPaciente);
            Controls.Add(btnConsulta);
            Controls.Add(lblConsulta);
            Controls.Add(lblCostoMateriales);
            Controls.Add(lblDescripcion);
            Controls.Add(edtDescripcion);
            Controls.Add(lblCostoConsulta);
            Controls.Add(lblProfesional);
            Controls.Add(cbProfesional);
            Controls.Add(lblFecha);
            Controls.Add(dtFecha);
            Controls.Add(panel1);
            Controls.Add(btnCrearPaciente);
            Controls.Add(btnCrearMedico);
            Controls.Add(lblPaciente);
            Controls.Add(lblMedico);
            Controls.Add(edtEspecialidad);
            Controls.Add(lblPersona);
            Controls.Add(edtNombre);
            Name = "frmClinica";
            Text = "Clinica";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edtNroMatricula).EndInit();
            ((System.ComponentModel.ISupportInitialize)edtNumeroHistoriaClinica).EndInit();
            ((System.ComponentModel.ISupportInitialize)edtCostoConsulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)edtCostoMateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox edtNombre;
        private Label lblPersona;
        private TextBox edtEspecialidad;
        private Label lblMedico;
        private Label lblPaciente;
        private Button btnCrearMedico;
        private Button btnCrearPaciente;
        private Panel panel1;
        private RadioButton rbPractica;
        private RadioButton rbConsultorio;
        private DateTimePicker dtFecha;
        private Label lblFecha;
        private ComboBox cbProfesional;
        private Label lblProfesional;
        private Label lblCostoConsulta;
        private Label lblDescripcion;
        private TextBox edtDescripcion;
        private Label lblCostoMateriales;
        private Label lblConsulta;
        private Button btnConsulta;
        private Label lblParaPaciente;
        private ComboBox cbParaPaciente;
        private NumericUpDown edtNroMatricula;
        private NumericUpDown edtNumeroHistoriaClinica;
        private NumericUpDown edtCostoConsulta;
        private NumericUpDown edtCostoMateriales;
        private Label label1;
        private Label label2;
    }
}