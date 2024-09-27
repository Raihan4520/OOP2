
namespace Airway_Ticketing_Application
{
    partial class AdminViewBookedTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewBookedTicketsForm));
            this.lblAllBookedTickets = new System.Windows.Forms.Label();
            this.dgvBookedTickets = new System.Windows.Forms.DataGridView();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookedTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAllBookedTickets
            // 
            this.lblAllBookedTickets.AutoSize = true;
            this.lblAllBookedTickets.BackColor = System.Drawing.Color.Transparent;
            this.lblAllBookedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllBookedTickets.Location = new System.Drawing.Point(331, 32);
            this.lblAllBookedTickets.Name = "lblAllBookedTickets";
            this.lblAllBookedTickets.Size = new System.Drawing.Size(139, 20);
            this.lblAllBookedTickets.TabIndex = 22;
            this.lblAllBookedTickets.Text = "All Booked Tickets";
            // 
            // dgvBookedTickets
            // 
            this.dgvBookedTickets.AllowUserToAddRows = false;
            this.dgvBookedTickets.AllowUserToDeleteRows = false;
            this.dgvBookedTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookedTickets.Location = new System.Drawing.Point(12, 78);
            this.dgvBookedTickets.Name = "dgvBookedTickets";
            this.dgvBookedTickets.ReadOnly = true;
            this.dgvBookedTickets.Size = new System.Drawing.Size(760, 320);
            this.dgvBookedTickets.TabIndex = 0;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Location = new System.Drawing.Point(48, 428);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(32, 13);
            this.lblBack.TabIndex = 32;
            this.lblBack.Text = "Back";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<---";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminViewBookedTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAllBookedTickets);
            this.Controls.Add(this.dgvBookedTickets);
            this.Name = "AdminViewBookedTicketsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBookedTicketsAdminForm";
            this.Load += new System.EventHandler(this.ViewBookedTicketsAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookedTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllBookedTickets;
        private System.Windows.Forms.DataGridView dgvBookedTickets;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnBack;
    }
}