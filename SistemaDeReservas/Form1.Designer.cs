namespace SistemaDeReservas
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
            splitContainer = new SplitContainer();
            panelMenu = new Panel();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            btnVerReservas = new Button();
            btnReservar = new Button();
            btnHamburguesa = new Button();
            tabControlCentral = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControlCentral.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(panelMenu);
            splitContainer.Panel1.Controls.Add(btnHamburguesa);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tabControlCentral);
            splitContainer.Size = new Size(966, 698);
            splitContainer.SplitterDistance = 322;
            splitContainer.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(groupBox1);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 57);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(322, 506);
            panelMenu.TabIndex = 1;
            panelMenu.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnVerReservas);
            groupBox1.Controls.Add(btnReservar);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 299);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menú de Reservas";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(32, 191);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(235, 52);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnVerReservas
            // 
            btnVerReservas.Location = new Point(32, 111);
            btnVerReservas.Name = "btnVerReservas";
            btnVerReservas.Size = new Size(235, 52);
            btnVerReservas.TabIndex = 1;
            btnVerReservas.Text = "Ver Reservas";
            btnVerReservas.UseVisualStyleBackColor = true;
            btnVerReservas.Click += VerReservas;
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(32, 41);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(235, 52);
            btnReservar.TabIndex = 0;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += Reservar;
            // 
            // btnHamburguesa
            // 
            btnHamburguesa.Dock = DockStyle.Top;
            btnHamburguesa.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHamburguesa.Location = new Point(0, 0);
            btnHamburguesa.Name = "btnHamburguesa";
            btnHamburguesa.Size = new Size(322, 57);
            btnHamburguesa.TabIndex = 0;
            btnHamburguesa.Text = "≡";
            btnHamburguesa.UseVisualStyleBackColor = true;
            btnHamburguesa.Click += AlternarVisibilidad;
            // 
            // tabControlCentral
            // 
            tabControlCentral.Controls.Add(tabPage1);
            tabControlCentral.Controls.Add(tabPage2);
            tabControlCentral.Dock = DockStyle.Fill;
            tabControlCentral.Location = new Point(0, 0);
            tabControlCentral.Name = "tabControlCentral";
            tabControlCentral.SelectedIndex = 0;
            tabControlCentral.Size = new Size(640, 698);
            tabControlCentral.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(632, 665);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reservar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(632, 665);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ver Reservas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 698);
            Controls.Add(splitContainer);
            Name = "Form1";
            Text = "Sistema de Reservas";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabControlCentral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TabControl tabControlCentral;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnHamburguesa;
        private Panel panelMenu;
        private GroupBox groupBox1;
        private Button btnSalir;
        private Button btnVerReservas;
        private Button btnReservar;
    }
}
