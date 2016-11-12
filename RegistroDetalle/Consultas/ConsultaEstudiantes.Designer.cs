namespace RegistroDetalle.Consultas
{
    partial class ConsultaEstudiantes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEstudiantes));
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConsultaEstudiantedataGridView = new System.Windows.Forms.DataGridView();
            this.Idbutton = new System.Windows.Forms.Button();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.IderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaEstudiantedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(65, 65);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(150, 24);
            this.FiltrarcomboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombretextBox);
            this.groupBox1.Controls.Add(this.ConsultaEstudiantedataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ConsultaEstudiantedataGridView
            // 
            this.ConsultaEstudiantedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaEstudiantedataGridView.Location = new System.Drawing.Point(6, 50);
            this.ConsultaEstudiantedataGridView.Name = "ConsultaEstudiantedataGridView";
            this.ConsultaEstudiantedataGridView.RowTemplate.Height = 24;
            this.ConsultaEstudiantedataGridView.Size = new System.Drawing.Size(562, 150);
            this.ConsultaEstudiantedataGridView.TabIndex = 0;
            // 
            // Idbutton
            // 
            this.Idbutton.Image = ((System.Drawing.Image)(resources.GetObject("Idbutton.Image")));
            this.Idbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Idbutton.Location = new System.Drawing.Point(459, 37);
            this.Idbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Idbutton.Name = "Idbutton";
            this.Idbutton.Size = new System.Drawing.Size(83, 52);
            this.Idbutton.TabIndex = 78;
            this.Idbutton.Text = "Id";
            this.Idbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Idbutton.UseVisualStyleBackColor = true;
            this.Idbutton.Click += new System.EventHandler(this.Idbutton_Click);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(436, 22);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(132, 22);
            this.NombretextBox.TabIndex = 1;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(221, 67);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(217, 22);
            this.FiltrotextBox.TabIndex = 2;
            // 
            // IderrorProvider
            // 
            this.IderrorProvider.ContainerControl = this;
            // 
            // ConsultaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 401);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.Idbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Name = "ConsultaEstudiantes";
            this.Text = "ConsultaEstudiantes";
            this.Load += new System.EventHandler(this.ConsultaEstudiantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaEstudiantedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IderrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ConsultaEstudiantedataGridView;
        private System.Windows.Forms.Button Idbutton;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.ErrorProvider IderrorProvider;
    }
}