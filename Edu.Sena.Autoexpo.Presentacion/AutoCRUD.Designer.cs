namespace Edu.Sena.Autoexpo.Presentacion {
    partial class AutoCRUD {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoCRUD));
            this.lblAutoCRUD = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnCRUD = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.cbPuertas = new System.Windows.Forms.ComboBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablasDataSet = new Edu.Sena.Autoexpo.Presentacion.TablasDataSet();
            this.marcaTableAdapter = new Edu.Sena.Autoexpo.Presentacion.TablasDataSetTableAdapters.MarcaTableAdapter();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutoCRUD
            // 
            this.lblAutoCRUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoCRUD.Location = new System.Drawing.Point(13, 13);
            this.lblAutoCRUD.Name = "lblAutoCRUD";
            this.lblAutoCRUD.Size = new System.Drawing.Size(204, 23);
            this.lblAutoCRUD.TabIndex = 0;
            this.lblAutoCRUD.Text = "Auto CRUD";
            this.lblAutoCRUD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(36, 52);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 2;
            this.tbId.Visible = false;
            // 
            // btnCRUD
            // 
            this.btnCRUD.Location = new System.Drawing.Point(86, 254);
            this.btnCRUD.Name = "btnCRUD";
            this.btnCRUD.Size = new System.Drawing.Size(75, 23);
            this.btnCRUD.TabIndex = 3;
            this.btnCRUD.Text = "CRUD";
            this.btnCRUD.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(142, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(86, 94);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(131, 20);
            this.tbPlaca.TabIndex = 5;
            // 
            // cbPuertas
            // 
            this.cbPuertas.FormattingEnabled = true;
            this.cbPuertas.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8"});
            this.cbPuertas.Location = new System.Drawing.Point(86, 147);
            this.cbPuertas.Name = "cbPuertas";
            this.cbPuertas.Size = new System.Drawing.Size(131, 21);
            this.cbPuertas.TabIndex = 7;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(86, 174);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(131, 20);
            this.tbColor.TabIndex = 8;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(86, 200);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(131, 20);
            this.tbPrecio.TabIndex = 9;
            // 
            // cbMarca
            // 
            this.cbMarca.DataSource = this.marcaBindingSource;
            this.cbMarca.DisplayMember = "Marca";
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(86, 227);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(131, 21);
            this.cbMarca.TabIndex = 10;
            this.cbMarca.ValueMember = "MarcaId";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.tablasDataSet;
            // 
            // tablasDataSet
            // 
            this.tablasDataSet.DataSetName = "TablasDataSet";
            this.tablasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(13, 97);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 11;
            this.lblPlaca.Text = "Placa";
            this.lblPlaca.Visible = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 123);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 12;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Visible = false;
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Location = new System.Drawing.Point(13, 150);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(67, 13);
            this.lblPuertas.TabIndex = 13;
            this.lblPuertas.Text = "# de puertas";
            this.lblPuertas.Visible = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(13, 230);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Visible = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 203);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.Visible = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(13, 177);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 14;
            this.lblColor.Text = "Color";
            this.lblColor.Visible = false;
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(86, 123);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(131, 21);
            this.cbModelo.TabIndex = 17;
            // 
            // AutoCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 284);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPuertas);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.cbPuertas);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCRUD);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblAutoCRUD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCRUD";
            this.Load += new System.EventHandler(this.AutoCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutoCRUD;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnCRUD;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.ComboBox cbPuertas;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.ComboBox cbMarca;
        private TablasDataSet tablasDataSet;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private TablasDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbModelo;
    }
}