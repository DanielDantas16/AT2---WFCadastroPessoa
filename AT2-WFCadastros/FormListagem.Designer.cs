namespace AT2_WFCadastros
{
    partial class FormListagem
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
            dvgListadeProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgListadeProdutos).BeginInit();
            SuspendLayout();
            // 
            // dvgListadeProdutos
            // 
            dvgListadeProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgListadeProdutos.Location = new Point(26, 45);
            dvgListadeProdutos.Name = "dvgListadeProdutos";
            dvgListadeProdutos.Size = new Size(762, 393);
            dvgListadeProdutos.TabIndex = 0;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dvgListadeProdutos);
            Name = "FormListagem";
            Text = "Listagem";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dvgListadeProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgListadeProdutos;
    }
}