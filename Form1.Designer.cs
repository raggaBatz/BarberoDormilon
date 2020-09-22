namespace BarberoDormilon
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientsNo = new System.Windows.Forms.Label();
            this.pbBarber = new System.Windows.Forms.PictureBox();
            this.pb0 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnOpenDoor = new System.Windows.Forms.Button();
            this.btnCloseDoor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIEMPO DE ATENCION";
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(143, 10);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(44, 20);
            this.tbxTime.TabIndex = 1;
            this.tbxTime.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLIENTES NO ATENDIDOS";
            // 
            // lblClientsNo
            // 
            this.lblClientsNo.AutoSize = true;
            this.lblClientsNo.Location = new System.Drawing.Point(362, 13);
            this.lblClientsNo.Name = "lblClientsNo";
            this.lblClientsNo.Size = new System.Drawing.Size(0, 13);
            this.lblClientsNo.TabIndex = 3;
            // 
            // pbBarber
            // 
            this.pbBarber.Image = ((System.Drawing.Image)(resources.GetObject("pbBarber.Image")));
            this.pbBarber.Location = new System.Drawing.Point(214, 70);
            this.pbBarber.Name = "pbBarber";
            this.pbBarber.Size = new System.Drawing.Size(90, 81);
            this.pbBarber.TabIndex = 4;
            this.pbBarber.TabStop = false;
            // 
            // pb0
            // 
            this.pb0.Location = new System.Drawing.Point(16, 174);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(90, 86);
            this.pb0.TabIndex = 5;
            this.pb0.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(112, 174);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(90, 86);
            this.pb1.TabIndex = 6;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(208, 174);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(90, 86);
            this.pb2.TabIndex = 7;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(304, 174);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(90, 86);
            this.pb3.TabIndex = 8;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(400, 174);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(90, 86);
            this.pb4.TabIndex = 9;
            this.pb4.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(427, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "INICIAR";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(427, 38);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "PARAR";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnOpenDoor
            // 
            this.btnOpenDoor.Enabled = false;
            this.btnOpenDoor.Location = new System.Drawing.Point(427, 70);
            this.btnOpenDoor.Name = "btnOpenDoor";
            this.btnOpenDoor.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDoor.TabIndex = 12;
            this.btnOpenDoor.Text = "ABRIR";
            this.btnOpenDoor.UseVisualStyleBackColor = true;
            this.btnOpenDoor.Click += new System.EventHandler(this.BtnOpenDoor_Click);
            this.btnOpenDoor.Visible = false;
            // 
            // btnCloseDoor
            // 
            this.btnCloseDoor.Location = new System.Drawing.Point(427, 100);
            this.btnCloseDoor.Name = "btnCloseDoor";
            this.btnCloseDoor.Size = new System.Drawing.Size(75, 23);
            this.btnCloseDoor.TabIndex = 13;
            this.btnCloseDoor.Text = "CERRAR";
            this.btnCloseDoor.UseVisualStyleBackColor = true;
            this.btnCloseDoor.Click += new System.EventHandler(this.BtnCloseDoor_Click);
            this.btnCloseDoor.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 276);
            this.Controls.Add(this.btnCloseDoor);
            this.Controls.Add(this.btnOpenDoor);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb0);
            this.Controls.Add(this.pbBarber);
            this.Controls.Add(this.lblClientsNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbBarber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientsNo;
        private System.Windows.Forms.PictureBox pbBarber;
        private System.Windows.Forms.PictureBox pb0;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOpenDoor;
        private System.Windows.Forms.Button btnCloseDoor;
    }
}

