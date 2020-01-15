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
            this.blinkTable = new System.Windows.Forms.TableLayoutPanel();
            this.butSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blinkTable
            // 
            this.blinkTable.ColumnCount = 1;
            this.blinkTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.blinkTable.Location = new System.Drawing.Point(12, 214);
            this.blinkTable.Name = "blinkTable";
            this.blinkTable.RowCount = 1;
            this.blinkTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.blinkTable.Size = new System.Drawing.Size(1058, 535);
            this.blinkTable.TabIndex = 0;
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 761);
            this.Controls.Add(this.butSettings);
            this.Controls.Add(this.blinkTable);
            this.Name = "mainForm";
            this.Text = "VisualMusic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel blinkTable;
        private System.Windows.Forms.Button butSettings;
    }
}

