
namespace DataLoadingTest
{
    partial class FPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bLoad = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lbLoaded = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(91, 44);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 1;
            this.bLoad.Text = "Load...";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Image = global::DataLoadingTest.Properties.Resources.horizontal_loading;
            this.pbLoading.Location = new System.Drawing.Point(183, 47);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(54, 17);
            this.pbLoading.TabIndex = 0;
            this.pbLoading.TabStop = false;
            // 
            // lbLoaded
            // 
            this.lbLoaded.AutoSize = true;
            this.lbLoaded.BackColor = System.Drawing.SystemColors.Control;
            this.lbLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaded.ForeColor = System.Drawing.Color.Red;
            this.lbLoaded.Location = new System.Drawing.Point(187, 88);
            this.lbLoaded.Name = "lbLoaded";
            this.lbLoaded.Size = new System.Drawing.Size(0, 13);
            this.lbLoaded.TabIndex = 2;
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 113);
            this.Controls.Add(this.lbLoaded);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.pbLoading);
            this.MaximumSize = new System.Drawing.Size(381, 152);
            this.MinimumSize = new System.Drawing.Size(381, 152);
            this.Name = "FPrincipal";
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Label lbLoaded;
    }
}

