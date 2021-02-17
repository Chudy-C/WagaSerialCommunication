
namespace SerialCommunication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.portList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.lConnection = new System.Windows.Forms.Label();
            this.lWaga = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.wagaPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // portList
            // 
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(44, 21);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(121, 21);
            this.portList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(44, 66);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(121, 28);
            this.ConnectionButton.TabIndex = 2;
            this.ConnectionButton.Text = "Connect";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // lConnection
            // 
            this.lConnection.AutoSize = true;
            this.lConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lConnection.Location = new System.Drawing.Point(193, 74);
            this.lConnection.Name = "lConnection";
            this.lConnection.Size = new System.Drawing.Size(139, 20);
            this.lConnection.TabIndex = 3;
            this.lConnection.Text = "IS_CONNECTED";
            // 
            // lWaga
            // 
            this.lWaga.AutoSize = true;
            this.lWaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lWaga.Location = new System.Drawing.Point(239, 22);
            this.lWaga.Name = "lWaga";
            this.lWaga.Size = new System.Drawing.Size(51, 20);
            this.lWaga.TabIndex = 4;
            this.lWaga.Text = "Waga";
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.Location = new System.Drawing.Point(44, 115);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(288, 41);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // wagaPort
            // 
            this.wagaPort.BaudRate = 4800;
            this.wagaPort.PortName = "COM4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 168);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.lWaga);
            this.Controls.Add(this.lConnection);
            this.Controls.Add(this.ConnectionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.Label lConnection;
        private System.Windows.Forms.Label lWaga;
        private System.Windows.Forms.Button stopButton;
        private System.IO.Ports.SerialPort wagaPort;
    }
}

