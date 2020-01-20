namespace VisualMusic
{
    partial class settingsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorFull = new System.Windows.Forms.ColorDialog();
            this.colorEmpty = new System.Windows.Forms.ColorDialog();
            this.valRow = new System.Windows.Forms.TextBox();
            this.valCol = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butFull = new System.Windows.Forms.Button();
            this.butEmpty = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота матрицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина матрицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цвет заполняемых плиток";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цвет плиток по умолчанию";
            // 
            // colorFull
            // 
            this.colorFull.FullOpen = true;
            // 
            // colorEmpty
            // 
            this.colorEmpty.FullOpen = true;
            // 
            // valRow
            // 
            this.valRow.Location = new System.Drawing.Point(113, 13);
            this.valRow.Name = "valRow";
            this.valRow.Size = new System.Drawing.Size(115, 20);
            this.valRow.TabIndex = 4;
            this.valRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valRow_KeyPress);
            // 
            // valCol
            // 
            this.valCol.Location = new System.Drawing.Point(113, 43);
            this.valCol.Name = "valCol";
            this.valCol.Size = new System.Drawing.Size(115, 20);
            this.valCol.TabIndex = 5;
            this.valCol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valCol_KeyPress);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(16, 156);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(94, 23);
            this.butSave.TabIndex = 6;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butFull
            // 
            this.butFull.Location = new System.Drawing.Point(160, 69);
            this.butFull.Name = "butFull";
            this.butFull.Size = new System.Drawing.Size(63, 23);
            this.butFull.TabIndex = 7;
            this.butFull.UseVisualStyleBackColor = true;
            this.butFull.Click += new System.EventHandler(this.butFull_Click);
            // 
            // butEmpty
            // 
            this.butEmpty.Location = new System.Drawing.Point(160, 104);
            this.butEmpty.Name = "butEmpty";
            this.butEmpty.Size = new System.Drawing.Size(63, 23);
            this.butEmpty.TabIndex = 8;
            this.butEmpty.UseVisualStyleBackColor = true;
            this.butEmpty.Click += new System.EventHandler(this.butEmpty_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(134, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 191);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.butEmpty);
            this.Controls.Add(this.butFull);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.valCol);
            this.Controls.Add(this.valRow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "settingsForm";
            this.ShowIcon = false;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorFull;
        private System.Windows.Forms.ColorDialog colorEmpty;
        private System.Windows.Forms.TextBox valRow;
        private System.Windows.Forms.TextBox valCol;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butFull;
        private System.Windows.Forms.Button butEmpty;
        private System.Windows.Forms.Button btnCancel;
    }
}