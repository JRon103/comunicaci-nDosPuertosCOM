namespace PuertoSerie
{
    partial class frmSerie
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
            cmbPuertos = new ComboBox();
            btnConectar = new Button();
            label2 = new Label();
            txtEnviar = new TextBox();
            btnEnviar = new Button();
            btnActualizar = new Button();
            button1 = new Button();
            recibirBluetooth = new RichTextBox();
            comboBoxBluetooth = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 156, 255);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 0;
            label1.Text = "Puerto Serie";
            // 
            // cmbPuertos
            // 
            cmbPuertos.BackColor = Color.FromArgb(235, 235, 240);
            cmbPuertos.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPuertos.FormattingEnabled = true;
            cmbPuertos.Location = new Point(12, 32);
            cmbPuertos.Name = "cmbPuertos";
            cmbPuertos.Size = new Size(120, 25);
            cmbPuertos.TabIndex = 1;
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.FromArgb(235, 235, 240);
            btnConectar.Location = new Point(276, 31);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(82, 24);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // txtEnviar
            // 
            txtEnviar.BackColor = Color.FromArgb(235, 235, 240);
            txtEnviar.Font = new Font("Cascadia Code", 9.75F);
            txtEnviar.Location = new Point(12, 74);
            txtEnviar.Name = "txtEnviar";
            txtEnviar.Size = new Size(240, 23);
            txtEnviar.TabIndex = 5;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(235, 235, 240);
            btnEnviar.Location = new Point(276, 74);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(235, 235, 240);
            btnActualizar.Location = new Point(364, 31);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 235, 240);
            button1.Location = new Point(452, 32);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 8;
            button1.Text = "Cerrar conexión ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // recibirBluetooth
            // 
            recibirBluetooth.BackColor = Color.FromArgb(235, 235, 240);
            recibirBluetooth.BorderStyle = BorderStyle.None;
            recibirBluetooth.Font = new Font("Cascadia Code", 9.75F);
            recibirBluetooth.Location = new Point(12, 113);
            recibirBluetooth.Name = "recibirBluetooth";
            recibirBluetooth.Size = new Size(529, 172);
            recibirBluetooth.TabIndex = 9;
            recibirBluetooth.Text = "";
            // 
            // comboBoxBluetooth
            // 
            comboBoxBluetooth.BackColor = Color.FromArgb(235, 235, 240);
            comboBoxBluetooth.Font = new Font("Cascadia Code", 9.75F);
            comboBoxBluetooth.FormattingEnabled = true;
            comboBoxBluetooth.Location = new Point(138, 32);
            comboBoxBluetooth.Name = "comboBoxBluetooth";
            comboBoxBluetooth.Size = new Size(114, 25);
            comboBoxBluetooth.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 156, 255);
            label3.Location = new Point(138, 9);
            label3.Name = "label3";
            label3.Size = new Size(114, 17);
            label3.TabIndex = 11;
            label3.Text = "Puerto bluetooth";
            label3.Click += label3_Click;
            // 
            // frmSerie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 62, 64);
            ClientSize = new Size(553, 305);
            Controls.Add(label3);
            Controls.Add(comboBoxBluetooth);
            Controls.Add(recibirBluetooth);
            Controls.Add(button1);
            Controls.Add(btnActualizar);
            Controls.Add(btnEnviar);
            Controls.Add(txtEnviar);
            Controls.Add(label2);
            Controls.Add(btnConectar);
            Controls.Add(cmbPuertos);
            Controls.Add(label1);
            Name = "frmSerie";
            Text = "Puerto Serie";
            Load += frmSerie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPuertos;
        private Button btnConectar;
        private Label label2;
        private TextBox txtEnviar;
        private Button btnEnviar;
        private Button btnActualizar;
        private Button button1;
        private RichTextBox recibirBluetooth;
        private ComboBox comboBoxBluetooth;
        private Label label3;
    }
}
