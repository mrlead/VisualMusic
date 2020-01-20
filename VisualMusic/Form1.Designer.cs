namespace VisualMusic
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butSettings = new System.Windows.Forms.Button();
            this.blinkGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.blinkGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // butSettings
            // 
            this.butSettings.Image = global::VisualMusic.Properties.Resources.icoSettings;
            this.butSettings.Location = new System.Drawing.Point(1015, 12);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(55, 57);
            this.butSettings.TabIndex = 1;
            this.butSettings.UseVisualStyleBackColor = true;
            this.butSettings.Click += new System.EventHandler(this.butSettings_Click);
            // 
            // blinkGrid
            // 
            this.blinkGrid.AllowUserToAddRows = false;
            this.blinkGrid.AllowUserToDeleteRows = false;
            this.blinkGrid.AllowUserToResizeColumns = false;
            this.blinkGrid.AllowUserToResizeRows = false;
            this.blinkGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.blinkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blinkGrid.ColumnHeadersVisible = false;
            this.blinkGrid.Location = new System.Drawing.Point(12, 285);
            this.blinkGrid.Name = "blinkGrid";
            this.blinkGrid.ReadOnly = true;
            this.blinkGrid.RowHeadersVisible = false;
            this.blinkGrid.ShowCellErrors = false;
            this.blinkGrid.ShowCellToolTips = false;
            this.blinkGrid.ShowEditingIcon = false;
            this.blinkGrid.ShowRowErrors = false;
            this.blinkGrid.Size = new System.Drawing.Size(1058, 464);
            this.blinkGrid.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 761);
            this.Controls.Add(this.blinkGrid);
            this.Controls.Add(this.butSettings);
            this.Name = "mainForm";
            this.Text = "VisualMusic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blinkGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butSettings;
        private System.Windows.Forms.DataGridView blinkGrid;
    }
}

