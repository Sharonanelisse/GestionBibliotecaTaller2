
namespace BibliotecaHerecia
{
    partial class ToastFormEliminar
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
            labelTittleEliminado = new Label();
            ToastEliminateMessage = new Label();
            ToastEliminarTimer = new System.Windows.Forms.Timer(components);
            ToastTimerHideEliminar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(-10, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(18, 62);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Check_Icon;
            pictureBox1.Image = Properties.Resources.eliminar;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTittleEliminado
            // 
            labelTittleEliminado.AutoSize = true;
            labelTittleEliminado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTittleEliminado.Location = new Point(50, 9);
            labelTittleEliminado.Name = "labelTittleEliminado";
            labelTittleEliminado.Size = new Size(78, 20);
            labelTittleEliminado.TabIndex = 2;
            labelTittleEliminado.Text = "Eliminado";
            labelTittleEliminado.Click += labelTypeTittle_Click;
            // 
            // ToastEliminateMessage
            // 
            ToastEliminateMessage.AutoSize = true;
            ToastEliminateMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ToastEliminateMessage.Location = new Point(54, 31);
            ToastEliminateMessage.Name = "ToastEliminateMessage";
            ToastEliminateMessage.Size = new Size(194, 17);
            ToastEliminateMessage.TabIndex = 3;
            ToastEliminateMessage.Text = "La informacion ha sido eliminada";
            // 
            // ToastEliminarTimer
            // 
            ToastEliminarTimer.Enabled = true;
            ToastEliminarTimer.Interval = 10;
            ToastEliminarTimer.Tick += timer1_Tick;
            // 
            // ToastTimerHideEliminar
            // 
            ToastTimerHideEliminar.Enabled = true;
            ToastTimerHideEliminar.Interval = 10;
            ToastTimerHideEliminar.Tick += ToastTimerHideEliminar_Tick;
            // 
            // ToastFormEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 59);
            Controls.Add(ToastEliminateMessage);
            Controls.Add(labelTittleEliminado);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToastFormEliminar";
            Text = "ToastForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelTittleEliminado;
        private Label ToastEliminateMessage;
        private System.Windows.Forms.Timer ToastEliminarTimer;
        private System.Windows.Forms.Timer ToastTimerHideEliminar;
    }
}