
namespace SecondWindowsFormsApp_H
{
    partial class HomeForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.btnViewTicket = new System.Windows.Forms.Button();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(66, 51);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(200, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Airway Ticketing Application";
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Location = new System.Drawing.Point(111, 99);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(104, 23);
            this.btnBuyTicket.TabIndex = 1;
            this.btnBuyTicket.Text = "Buy Ticket";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.Location = new System.Drawing.Point(111, 188);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(104, 23);
            this.btnCancelTicket.TabIndex = 3;
            this.btnCancelTicket.Text = "Cancel Ticket";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // btnViewTicket
            // 
            this.btnViewTicket.Location = new System.Drawing.Point(111, 144);
            this.btnViewTicket.Name = "btnViewTicket";
            this.btnViewTicket.Size = new System.Drawing.Size(104, 23);
            this.btnViewTicket.TabIndex = 2;
            this.btnViewTicket.Text = "View Ticket";
            this.btnViewTicket.UseVisualStyleBackColor = true;
            this.btnViewTicket.Click += new System.EventHandler(this.btnViewTicket_Click);
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Location = new System.Drawing.Point(141, 241);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(43, 13);
            this.linkLogout.TabIndex = 4;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Log out";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 298);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.btnViewTicket);
            this.Controls.Add(this.btnCancelTicket);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.lblWelcome);
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Button btnViewTicket;
        private System.Windows.Forms.LinkLabel linkLogout;
    }
}