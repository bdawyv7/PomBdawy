namespace PomodoroProject
{
    partial class frmEditTask
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOkEditTask = new System.Windows.Forms.Button();
            this.btnCanelEditTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(90, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 32);
            this.textBox1.TabIndex = 0;
            // 
            // btnOkEditTask
            // 
            this.btnOkEditTask.BackColor = System.Drawing.Color.Transparent;
            this.btnOkEditTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOkEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkEditTask.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOkEditTask.Location = new System.Drawing.Point(164, 84);
            this.btnOkEditTask.Name = "btnOkEditTask";
            this.btnOkEditTask.Size = new System.Drawing.Size(113, 39);
            this.btnOkEditTask.TabIndex = 1;
            this.btnOkEditTask.Text = "OK";
            this.btnOkEditTask.UseVisualStyleBackColor = false;
            this.btnOkEditTask.Click += new System.EventHandler(this.btnOkEditTask_Click);
            // 
            // btnCanelEditTask
            // 
            this.btnCanelEditTask.BackColor = System.Drawing.Color.Transparent;
            this.btnCanelEditTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCanelEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanelEditTask.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCanelEditTask.Location = new System.Drawing.Point(338, 84);
            this.btnCanelEditTask.Name = "btnCanelEditTask";
            this.btnCanelEditTask.Size = new System.Drawing.Size(113, 39);
            this.btnCanelEditTask.TabIndex = 2;
            this.btnCanelEditTask.Text = "Cancel";
            this.btnCanelEditTask.UseVisualStyleBackColor = false;
            this.btnCanelEditTask.Click += new System.EventHandler(this.btnCanelEditTask_Click);
            // 
            // frmEditTask
            // 
            this.AcceptButton = this.btnOkEditTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(628, 128);
            this.ControlBox = false;
            this.Controls.Add(this.btnCanelEditTask);
            this.Controls.Add(this.btnOkEditTask);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(650, 150);
            this.MinimumSize = new System.Drawing.Size(650, 150);
            this.Name = "frmEditTask";
            this.Load += new System.EventHandler(this.FocusScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOkEditTask;
        private System.Windows.Forms.Button btnCanelEditTask;
    }
}