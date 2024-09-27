
namespace Airway_Ticketing_Application
{
    partial class AdminViewAllTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewAllTicketsForm));
            this.dgvAllTickets = new System.Windows.Forms.DataGridView();
            this.lblAllTickets = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTickets
            // 
            this.dgvAllTickets.AllowUserToAddRows = false;
            this.dgvAllTickets.AllowUserToDeleteRows = false;
            this.dgvAllTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTickets.Location = new System.Drawing.Point(12, 72);
            this.dgvAllTickets.Name = "dgvAllTickets";
            this.dgvAllTickets.ReadOnly = true;
            this.dgvAllTickets.Size = new System.Drawing.Size(760, 320);
            this.dgvAllTickets.TabIndex = 0;
            // 
            // lblAllTickets
            // 
            this.lblAllTickets.AutoSize = true;
            this.lblAllTickets.BackColor = System.Drawing.Color.Transparent;
            this.lblAllTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTickets.Location = new System.Drawing.Point(354, 28);
            this.lblAllTickets.Name = "lblAllTickets";
            this.lblAllTickets.Size = new System.Drawing.Size(80, 20);
            this.lblAllTickets.TabIndex = 1;
            this.lblAllTickets.Text = "All Tickets";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Location = new System.Drawing.Point(48, 428);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(32, 13);
            this.lblBack.TabIndex = 27;
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
            // AdminViewAllTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAllTickets);
            this.Controls.Add(this.dgvAllTickets);
            this.Name = "AdminViewAllTicketsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllTicketsForm";
            this.Load += new System.EventHandler(this.ViewAllTicketsAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllTickets;
        private System.Windows.Forms.Label lblAllTickets;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnBack;
    }
}