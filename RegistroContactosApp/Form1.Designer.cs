namespace RegistroContactosApp
{
    partial class Form1
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
            EtiquetaNombre = new Label();
            EtiquetaTelefono = new Label();
            EtiquetaEmail = new Label();
            TextBoxNombre = new TextBox();
            TextBoxTelefono = new TextBox();
            TextBoxEmail = new TextBox();
            ButtonAgregar = new Button();
            ButtonLimpiar = new Button();
            ListBoxContactos = new ListBox();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Location = new Point(51, 69);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(64, 20);
            EtiquetaNombre.TabIndex = 0;
            EtiquetaNombre.Text = "Nombre";
            // 
            // EtiquetaTelefono
            // 
            EtiquetaTelefono.AutoSize = true;
            EtiquetaTelefono.Location = new Point(51, 167);
            EtiquetaTelefono.Name = "EtiquetaTelefono";
            EtiquetaTelefono.Size = new Size(67, 20);
            EtiquetaTelefono.TabIndex = 1;
            EtiquetaTelefono.Text = "Telefono";
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.Location = new Point(51, 272);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(132, 20);
            EtiquetaEmail.TabIndex = 2;
            EtiquetaEmail.Text = "Correo electronico";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(51, 105);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(125, 27);
            TextBoxNombre.TabIndex = 3;
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(51, 216);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.Size = new Size(125, 27);
            TextBoxTelefono.TabIndex = 4;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(51, 322);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(125, 27);
            TextBoxEmail.TabIndex = 5;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.Location = new Point(51, 397);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(139, 29);
            ButtonAgregar.TabIndex = 6;
            ButtonAgregar.Text = "Agregar Contacto";
            ButtonAgregar.UseVisualStyleBackColor = true;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // ButtonLimpiar
            // 
            ButtonLimpiar.Location = new Point(232, 397);
            ButtonLimpiar.Name = "ButtonLimpiar";
            ButtonLimpiar.Size = new Size(125, 29);
            ButtonLimpiar.TabIndex = 7;
            ButtonLimpiar.Text = "Limpiar Campos";
            ButtonLimpiar.UseVisualStyleBackColor = true;
            ButtonLimpiar.Click += ButtonLimpiar_Click;
            // 
            // ListBoxContactos
            // 
            ListBoxContactos.FormattingEnabled = true;
            ListBoxContactos.Location = new Point(232, 57);
            ListBoxContactos.Name = "ListBoxContactos";
            ListBoxContactos.Size = new Size(545, 324);
            ListBoxContactos.TabIndex = 8;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(482, 397);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(0, 20);
            LabelEstado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelEstado);
            Controls.Add(ListBoxContactos);
            Controls.Add(ButtonLimpiar);
            Controls.Add(ButtonAgregar);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxTelefono);
            Controls.Add(TextBoxNombre);
            Controls.Add(EtiquetaEmail);
            Controls.Add(EtiquetaTelefono);
            Controls.Add(EtiquetaNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaNombre;
        private Label EtiquetaTelefono;
        private Label EtiquetaEmail;
        private TextBox TextBoxNombre;
        private TextBox TextBoxTelefono;
        private TextBox TextBoxEmail;
        private Button ButtonAgregar;
        private Button ButtonLimpiar;
        private ListBox ListBoxContactos;
        private Label LabelEstado;
    }
}
