namespace Server
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSend = new Button();
            txbMessage = new TextBox();
            lsvMessage = new ListView();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(562, 383);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(85, 46);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txbMessage
            // 
            txbMessage.Location = new Point(30, 383);
            txbMessage.Multiline = true;
            txbMessage.Name = "txbMessage";
            txbMessage.Size = new Size(526, 46);
            txbMessage.TabIndex = 4;
            // 
            // lsvMessage
            // 
            lsvMessage.Location = new Point(30, 21);
            lsvMessage.Name = "lsvMessage";
            lsvMessage.Size = new Size(617, 356);
            lsvMessage.TabIndex = 3;
            lsvMessage.UseCompatibleStateImageBehavior = false;
            lsvMessage.View = View.List;
            // 
            // Server
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(btnSend);
            Controls.Add(txbMessage);
            Controls.Add(lsvMessage);
            Name = "Server";
            Text = "Server";
            FormClosed += Server_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox txbMessage;
        private ListView lsvMessage;
    }
}
