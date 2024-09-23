namespace BibliotecaHerecia
{
    partial class ToastFormActualizar
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelTypeTittle = new Label();
            ToastCheckMessage = new Label();
            ToastActualizarTimer = new System.Windows.Forms.Timer(components);
            ToastTimerHideActualizar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(-10, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(18, 62);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Check_Icon;
            pictureBox1.Image = Properties.Resources.Check_Icon;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTypeTittle
            // 
            labelTypeTittle.AutoSize = true;
            labelTypeTittle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTypeTittle.Location = new Point(50, 9);
            labelTypeTittle.Name = "labelTypeTittle";
            labelTypeTittle.Size = new Size(91, 20);
            labelTypeTittle.TabIndex = 2;
            labelTypeTittle.Text = "Actualizado";
            labelTypeTittle.Click += labelTypeTittle_Click;
            // 
            // ToastCheckMessage
            // 
            ToastCheckMessage.AutoSize = true;
            ToastCheckMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ToastCheckMessage.Location = new Point(54, 31);
            ToastCheckMessage.Name = "ToastCheckMessage";
            ToastCheckMessage.Size = new Size(204, 17);
            ToastCheckMessage.TabIndex = 3;
            ToastCheckMessage.Text = "La informacion ha sido actualizada";
            // 
            // ToastActualizarTimer
            // 
            ToastActualizarTimer.Enabled = true;
            ToastActualizarTimer.Interval = 10;
            ToastActualizarTimer.Tick += ToastActualizarTimer_Tick;
            // 
            // ToastTimerHideActualizar
            // 
            ToastTimerHideActualizar.Enabled = true;
            ToastTimerHideActualizar.Interval = 10;
            ToastTimerHideActualizar.Tick += ToastTimerHideActualizar_Tick;
            // 
            // ToastFormActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 59);
            Controls.Add(ToastCheckMessage);
            Controls.Add(labelTypeTittle);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToastFormActualizar";
            Text = "ToastForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelTypeTittle;
        private Label ToastCheckMessage;
        private System.Windows.Forms.Timer ToastActualizarTimer;
        private System.Windows.Forms.Timer ToastTimerHideActualizar;
    }
}