
namespace DepreciacionApp.Forms
{
    partial class FrmViewDepreciacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDepreciacion = new System.Windows.Forms.DataGridView();
            this.cmbDepreciacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepreciacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodo de depreciación:";
            // 
            // dgvDepreciacion
            // 
            this.dgvDepreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepreciacion.Location = new System.Drawing.Point(21, 48);
            this.dgvDepreciacion.Name = "dgvDepreciacion";
            this.dgvDepreciacion.Size = new System.Drawing.Size(676, 264);
            this.dgvDepreciacion.TabIndex = 2;
            // 
            // cmbDepreciacion
            // 
            this.cmbDepreciacion.FormattingEnabled = true;
            this.cmbDepreciacion.Location = new System.Drawing.Point(185, 16);
            this.cmbDepreciacion.Name = "cmbDepreciacion";
            this.cmbDepreciacion.Size = new System.Drawing.Size(512, 27);
            this.cmbDepreciacion.TabIndex = 3;
            // 
            // FrmViewDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 324);
            this.Controls.Add(this.cmbDepreciacion);
            this.Controls.Add(this.dgvDepreciacion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmViewDepreciacion";
            this.Text = "FrmViewDepreciacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepreciacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDepreciacion;
        private System.Windows.Forms.ComboBox cmbDepreciacion;
    }
}