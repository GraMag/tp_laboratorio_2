namespace MiCalculadora
{
    partial class LaCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaCalculadora));
            this.panelFondo = new System.Windows.Forms.Panel();
            this.groupBoxCalcular = new System.Windows.Forms.GroupBox();
            this.panelCalcular = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.comboBoxSigno = new System.Windows.Forms.ComboBox();
            this.txtBoxNumero2 = new System.Windows.Forms.TextBox();
            this.txtBoxNumero1 = new System.Windows.Forms.TextBox();
            this.groupBoxConvertirA = new System.Windows.Forms.GroupBox();
            this.panelConvertirA = new System.Windows.Forms.Panel();
            this.buttonConvertirADecimal = new System.Windows.Forms.Button();
            this.buttonConvertirABinario = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelFondo.SuspendLayout();
            this.groupBoxCalcular.SuspendLayout();
            this.panelCalcular.SuspendLayout();
            this.groupBoxConvertirA.SuspendLayout();
            this.panelConvertirA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelFondo.Controls.Add(this.groupBoxCalcular);
            this.panelFondo.Controls.Add(this.groupBoxConvertirA);
            this.panelFondo.Location = new System.Drawing.Point(-4, 1);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(709, 437);
            this.panelFondo.TabIndex = 0;
            // 
            // groupBoxCalcular
            // 
            this.groupBoxCalcular.BackColor = System.Drawing.Color.Purple;
            this.groupBoxCalcular.Controls.Add(this.panelCalcular);
            this.groupBoxCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCalcular.Location = new System.Drawing.Point(15, 11);
            this.groupBoxCalcular.Name = "groupBoxCalcular";
            this.groupBoxCalcular.Size = new System.Drawing.Size(680, 254);
            this.groupBoxCalcular.TabIndex = 7;
            this.groupBoxCalcular.TabStop = false;
            this.groupBoxCalcular.Text = "Calcular";
            // 
            // panelCalcular
            // 
            this.panelCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelCalcular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCalcular.Controls.Add(this.lblResultado);
            this.panelCalcular.Controls.Add(this.buttonCerrar);
            this.panelCalcular.Controls.Add(this.btnLimpiar);
            this.panelCalcular.Controls.Add(this.buttonOperar);
            this.panelCalcular.Controls.Add(this.comboBoxSigno);
            this.panelCalcular.Controls.Add(this.txtBoxNumero2);
            this.panelCalcular.Controls.Add(this.txtBoxNumero1);
            this.panelCalcular.Location = new System.Drawing.Point(23, 24);
            this.panelCalcular.Name = "panelCalcular";
            this.panelCalcular.Size = new System.Drawing.Size(634, 212);
            this.panelCalcular.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblResultado.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.DeepPink;
            this.lblResultado.Location = new System.Drawing.Point(288, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(313, 43);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Orange;
            this.buttonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCerrar.Location = new System.Drawing.Point(435, 135);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(155, 60);
            this.buttonCerrar.TabIndex = 5;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Orange;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(235, 135);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 60);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonOperar
            // 
            this.buttonOperar.BackColor = System.Drawing.Color.Orange;
            this.buttonOperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOperar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOperar.Location = new System.Drawing.Point(40, 135);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(155, 60);
            this.buttonOperar.TabIndex = 3;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = false;
            this.buttonOperar.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // comboBoxSigno
            // 
            this.comboBoxSigno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSigno.FormattingEnabled = true;
            this.comboBoxSigno.Items.AddRange(new object[] {
            " ",
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxSigno.Location = new System.Drawing.Point(292, 68);
            this.comboBoxSigno.Name = "comboBoxSigno";
            this.comboBoxSigno.Size = new System.Drawing.Size(57, 44);
            this.comboBoxSigno.TabIndex = 1;
            this.comboBoxSigno.SelectedIndex = 0;
            // 
            // txtBoxNumero2
            // 
            this.txtBoxNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumero2.Location = new System.Drawing.Point(435, 68);
            this.txtBoxNumero2.Name = "txtBoxNumero2";
            this.txtBoxNumero2.Size = new System.Drawing.Size(155, 41);
            this.txtBoxNumero2.TabIndex = 2;
            this.txtBoxNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxNumero1
            // 
            this.txtBoxNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumero1.Location = new System.Drawing.Point(40, 71);
            this.txtBoxNumero1.Name = "txtBoxNumero1";
            this.txtBoxNumero1.Size = new System.Drawing.Size(155, 41);
            this.txtBoxNumero1.TabIndex = 0;
            this.txtBoxNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxConvertirA
            // 
            this.groupBoxConvertirA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBoxConvertirA.Controls.Add(this.panelConvertirA);
            this.groupBoxConvertirA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxConvertirA.Location = new System.Drawing.Point(16, 279);
            this.groupBoxConvertirA.Name = "groupBoxConvertirA";
            this.groupBoxConvertirA.Size = new System.Drawing.Size(679, 146);
            this.groupBoxConvertirA.TabIndex = 9;
            this.groupBoxConvertirA.TabStop = false;
            this.groupBoxConvertirA.Text = "Convertir";
            // 
            // panelConvertirA
            // 
            this.panelConvertirA.BackColor = System.Drawing.Color.Navy;
            this.panelConvertirA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelConvertirA.Controls.Add(this.buttonConvertirADecimal);
            this.panelConvertirA.Controls.Add(this.buttonConvertirABinario);
            this.panelConvertirA.Location = new System.Drawing.Point(23, 21);
            this.panelConvertirA.Name = "panelConvertirA";
            this.panelConvertirA.Size = new System.Drawing.Size(634, 109);
            this.panelConvertirA.TabIndex = 8;
            // 
            // buttonConvertirADecimal
            // 
            this.buttonConvertirADecimal.BackColor = System.Drawing.Color.DeepPink;
            this.buttonConvertirADecimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConvertirADecimal.Enabled = false;
            this.buttonConvertirADecimal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvertirADecimal.Location = new System.Drawing.Point(327, 14);
            this.buttonConvertirADecimal.Name = "buttonConvertirADecimal";
            this.buttonConvertirADecimal.Size = new System.Drawing.Size(278, 79);
            this.buttonConvertirADecimal.TabIndex = 7;
            this.buttonConvertirADecimal.Text = "a DECIMAL";
            this.buttonConvertirADecimal.UseVisualStyleBackColor = false;
            this.buttonConvertirADecimal.Click += new System.EventHandler(this.buttonConvertirADecimal_Click);
            // 
            // buttonConvertirABinario
            // 
            this.buttonConvertirABinario.BackColor = System.Drawing.Color.DeepPink;
            this.buttonConvertirABinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConvertirABinario.Enabled = false;
            this.buttonConvertirABinario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvertirABinario.Location = new System.Drawing.Point(28, 14);
            this.buttonConvertirABinario.Name = "buttonConvertirABinario";
            this.buttonConvertirABinario.Size = new System.Drawing.Size(278, 79);
            this.buttonConvertirABinario.TabIndex = 6;
            this.buttonConvertirABinario.Text = "a BINARIO";
            this.buttonConvertirABinario.UseVisualStyleBackColor = false;
            this.buttonConvertirABinario.Click += new System.EventHandler(this.buttonConvertirABinario_Click);
            // 
            // LaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 438);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Magali Gracia del curso 2°C";
            this.panelFondo.ResumeLayout(false);
            this.groupBoxCalcular.ResumeLayout(false);
            this.panelCalcular.ResumeLayout(false);
            this.panelCalcular.PerformLayout();
            this.groupBoxConvertirA.ResumeLayout(false);
            this.panelConvertirA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.GroupBox groupBoxConvertirA;
        private System.Windows.Forms.Panel panelConvertirA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonConvertirADecimal;
        private System.Windows.Forms.Button buttonConvertirABinario;
        private System.Windows.Forms.GroupBox groupBoxCalcular;
        private System.Windows.Forms.Panel panelCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.ComboBox comboBoxSigno;
        private System.Windows.Forms.TextBox txtBoxNumero2;
        private System.Windows.Forms.TextBox txtBoxNumero1;
    }
}

