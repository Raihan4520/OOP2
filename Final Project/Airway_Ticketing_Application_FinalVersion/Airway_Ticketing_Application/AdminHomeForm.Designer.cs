
namespace Airway_Ticketing_Application
{
    partial class AdminHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeForm));
            this.btnAddTickets = new System.Windows.Forms.Button();
            this.btnUpdateTickets = new System.Windows.Forms.Button();
            this.btnRemoveTickets = new System.Windows.Forms.Button();
            this.btnViewAllBookedTickets = new System.Windows.Forms.Button();
            this.btnViewAllTickets = new System.Windows.Forms.Button();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTickets
            // 
            this.btnAddTickets.Location = new System.Drawing.Point(474, 111);
            this.btnAddTickets.Name = "btnAddTickets";
            this.btnAddTickets.Size = new System.Drawing.Size(186, 23);
            this.btnAddTickets.TabIndex = 1;
            this.btnAddTickets.Text = "Add Tickets";
            this.btnAddTickets.UseVisualStyleBackColor = true;
            this.btnAddTickets.Click += new System.EventHandler(this.btnAddTickets_Click);
            // 
            // btnUpdateTickets
            // 
            this.btnUpdateTickets.Location = new System.Drawing.Point(121, 340);
            this.btnUpdateTickets.Name = "btnUpdateTickets";
            this.btnUpdateTickets.Size = new System.Drawing.Size(186, 23);
            this.btnUpdateTickets.TabIndex = 2;
            this.btnUpdateTickets.Text = "Update Tickets";
            this.btnUpdateTickets.UseVisualStyleBackColor = true;
            this.btnUpdateTickets.Click += new System.EventHandler(this.btnUpdateTickets_Click);
            // 
            // btnRemoveTickets
            // 
            this.btnRemoveTickets.Location = new System.Drawing.Point(474, 340);
            this.btnRemoveTickets.Name = "btnRemoveTickets";
            this.btnRemoveTickets.Size = new System.Drawing.Size(186, 23);
            this.btnRemoveTickets.TabIndex = 3;
            this.btnRemoveTickets.Text = "Remove Tickets";
            this.btnRemoveTickets.UseVisualStyleBackColor = true;
            this.btnRemoveTickets.Click += new System.EventHandler(this.btnRemoveTickets_Click);
            // 
            // btnViewAllBookedTickets
            // 
            this.btnViewAllBookedTickets.Location = new System.Drawing.Point(302, 229);
            this.btnViewAllBookedTickets.Name = "btnViewAllBookedTickets";
            this.btnViewAllBookedTickets.Size = new System.Drawing.Size(186, 23);
            this.btnViewAllBookedTickets.TabIndex = 4;
            this.btnViewAllBookedTickets.Text = "View All Booked Tickets";
            this.btnViewAllBookedTickets.UseVisualStyleBackColor = true;
            this.btnViewAllBookedTickets.Click += new System.EventHandler(this.btnViewAllBookedTickets_Click);
            // 
            // btnViewAllTickets
            // 
            this.btnViewAllTickets.Location = new System.Drawing.Point(121, 111);
            this.btnViewAllTickets.Name = "btnViewAllTickets";
            this.btnViewAllTickets.Size = new System.Drawing.Size(186, 23);
            this.btnViewAllTickets.TabIndex = 0;
            this.btnViewAllTickets.Text = "View All Tickets";
            this.btnViewAllTickets.UseVisualStyleBackColor = true;
            this.btnViewAllTickets.Click += new System.EventHandler(this.btnViewAllTickets_Click);
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.BackColor = System.Drawing.Color.Transparent;
            this.linkLogout.Location = new System.Drawing.Point(387, 439);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(43, 13);
            this.linkLogout.TabIndex = 5;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Log out";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(321, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(167, 25);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome Admin";
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnViewAllTickets);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.btnViewAllBookedTickets);
            this.Controls.Add(this.btnRemoveTickets);
            this.Controls.Add(this.btnUpdateTickets);
            this.Controls.Add(this.btnAddTickets);
            this.Name = "AdminHomeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTickets;
        private System.Windows.Forms.Button btnUpdateTickets;
        private System.Windows.Forms.Button btnRemoveTickets;
        private System.Windows.Forms.Button btnViewAllBookedTickets;
        private System.Windows.Forms.Button btnViewAllTickets;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.Label lblWelcome;
    }
}