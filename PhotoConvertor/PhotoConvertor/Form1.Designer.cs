namespace PhotoConvertor
{
    partial class Form1
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
            this.pb_Original = new System.Windows.Forms.PictureBox();
            this.pb_solution = new System.Windows.Forms.PictureBox();
            this.txb_multiplier = new System.Windows.Forms.TextBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.txb_sizeOfOriginal = new System.Windows.Forms.TextBox();
            this.txb_sizeOfSolution = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_choosePicture = new System.Windows.Forms.Button();
            this.btn_savePicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_solution)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Original
            // 
            this.pb_Original.Location = new System.Drawing.Point(36, 69);
            this.pb_Original.Name = "pb_Original";
            this.pb_Original.Size = new System.Drawing.Size(184, 173);
            this.pb_Original.TabIndex = 0;
            this.pb_Original.TabStop = false;
            // 
            // pb_solution
            // 
            this.pb_solution.Location = new System.Drawing.Point(572, 69);
            this.pb_solution.Name = "pb_solution";
            this.pb_solution.Size = new System.Drawing.Size(184, 171);
            this.pb_solution.TabIndex = 1;
            this.pb_solution.TabStop = false;
            // 
            // txb_multiplier
            // 
            this.txb_multiplier.Location = new System.Drawing.Point(344, 94);
            this.txb_multiplier.Name = "txb_multiplier";
            this.txb_multiplier.Size = new System.Drawing.Size(100, 20);
            this.txb_multiplier.TabIndex = 2;
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(354, 135);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(75, 23);
            this.btn_execute.TabIndex = 3;
            this.btn_execute.Text = "Convert";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // txb_sizeOfOriginal
            // 
            this.txb_sizeOfOriginal.Location = new System.Drawing.Point(76, 273);
            this.txb_sizeOfOriginal.Name = "txb_sizeOfOriginal";
            this.txb_sizeOfOriginal.ReadOnly = true;
            this.txb_sizeOfOriginal.Size = new System.Drawing.Size(100, 20);
            this.txb_sizeOfOriginal.TabIndex = 4;
            // 
            // txb_sizeOfSolution
            // 
            this.txb_sizeOfSolution.Location = new System.Drawing.Point(613, 273);
            this.txb_sizeOfSolution.Name = "txb_sizeOfSolution";
            this.txb_sizeOfSolution.ReadOnly = true;
            this.txb_sizeOfSolution.Size = new System.Drawing.Size(100, 20);
            this.txb_sizeOfSolution.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // btn_choosePicture
            // 
            this.btn_choosePicture.Location = new System.Drawing.Point(76, 40);
            this.btn_choosePicture.Name = "btn_choosePicture";
            this.btn_choosePicture.Size = new System.Drawing.Size(88, 23);
            this.btn_choosePicture.TabIndex = 7;
            this.btn_choosePicture.Text = "Choose picture";
            this.btn_choosePicture.UseVisualStyleBackColor = true;
            this.btn_choosePicture.Click += new System.EventHandler(this.btn_choosePicture_Click);
            // 
            // btn_savePicture
            // 
            this.btn_savePicture.Location = new System.Drawing.Point(629, 40);
            this.btn_savePicture.Name = "btn_savePicture";
            this.btn_savePicture.Size = new System.Drawing.Size(75, 23);
            this.btn_savePicture.TabIndex = 8;
            this.btn_savePicture.Text = "Save picture";
            this.btn_savePicture.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_savePicture);
            this.Controls.Add(this.btn_choosePicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_sizeOfSolution);
            this.Controls.Add(this.txb_sizeOfOriginal);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.txb_multiplier);
            this.Controls.Add(this.pb_solution);
            this.Controls.Add(this.pb_Original);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_solution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Original;
        private System.Windows.Forms.PictureBox pb_solution;
        private System.Windows.Forms.TextBox txb_multiplier;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.TextBox txb_sizeOfOriginal;
        private System.Windows.Forms.TextBox txb_sizeOfSolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_choosePicture;
        private System.Windows.Forms.Button btn_savePicture;
    }
}

