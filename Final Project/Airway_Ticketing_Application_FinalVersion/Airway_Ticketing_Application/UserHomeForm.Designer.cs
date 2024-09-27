
namespace Airway_Ticketing_Application
{
    partial class UserHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHomeForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBookTickets = new System.Windows.Forms.Button();
            this.btnCancelTickets = new System.Windows.Forms.Button();
            this.btnViewBookedTickets = new System.Windows.Forms.Button();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.btnViewAvailableTickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(220, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(351, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Airway Ticketing Application";
            // 
            // btnBookTickets
            // 
            this.btnBookTickets.Location = new System.Drawing.Point(489, 128);
            this.btnBookTickets.Name = "btnBookTickets";
            this.btnBookTickets.Size = new System.Drawing.Size(171, 23);
            this.btnBookTickets.TabIndex = 1;
            this.btnBookTickets.Text = "Book Tickets";
            this.btnBookTickets.UseVisualStyleBackColor = true;
            this.btnBookTickets.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // btnCancelTickets
            // 
            this.btnCancelTickets.Location = new System.Drawing.Point(489, 333);
            this.btnCancelTickets.Name = "btnCancelTickets";
            this.btnCancelTickets.Size = new System.Drawing.Size(171, 23);
            this.btnCancelTickets.TabIndex = 3;
            this.btnCancelTickets.Text = "Cancel Tickets";
            this.btnCancelTickets.UseVisualStyleBackColor = true;
            this.btnCancelTickets.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // btnViewBookedTickets
            // 
            this.btnViewBookedTickets.Location = new System.Drawing.Point(111, 333);
            this.btnViewBookedTickets.Name = "btnViewBookedTickets";
            this.btnViewBookedTickets.Size = new System.Drawing.Size(171, 23);
            this.btnViewBookedTickets.TabIndex = 2;
            this.btnViewBookedTickets.Text = "View Booked Tickets";
            this.btnViewBookedTickets.UseVisualStyleBackColor = true;
            this.btnViewBookedTickets.Click += new System.EventHandler(this.btnViewTicket_Click);
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.BackColor = System.Drawing.Color.Transparent;
            this.linkLogout.Location = new System.Drawing.Point(386, 429);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(43, 13);
            this.linkLogout.TabIndex = 4;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Log out";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // btnViewAvailableTickets
            // 
            this.btnViewAvailableTickets.Location = new System.Drawing.Point(111, 128);
            this.btnViewAvailableTickets.Name = "btnViewAvailableTickets";
            this.btnViewAvailableTickets.Size = new System.Drawing.Size(171, 23);
            this.btnViewAvailableTickets.TabIndex = 0;
            this.btnViewAvailableTickets.Text = "View Available Tickets";
            this.btnViewAvailableTickets.UseVisualStyleBackColor = true;
            this.btnViewAvailableTickets.Click += new System.EventHandler(this.btnViewAvailableTickets_Click);
            // 
            // UserHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnViewAvailableTickets);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.btnViewBookedTickets);
            this.Controls.Add(this.btnCancelTickets);
            this.Controls.Add(this.btnBookTickets);
            this.Controls.Add(this.lblWelcome);
            this.Name = "UserHomeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBookTickets;
        private System.Windows.Forms.Button btnCancelTickets;
        private System.Windows.Forms.Button btnViewBookedTickets;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.Button btnViewAvailableTickets;
    }
}