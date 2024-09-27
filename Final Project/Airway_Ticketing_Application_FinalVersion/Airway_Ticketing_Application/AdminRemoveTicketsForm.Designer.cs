
namespace Airway_Ticketing_Application
{
    partial class AdminRemoveTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRemoveTicketsForm));
            this.lblEnterFlightNo = new System.Windows.Forms.Label();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.btnRemoveTicket = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterFlightNo
            // 
            this.lblEnterFlightNo.AutoSize = true;
            this.lblEnterFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterFlightNo.Location = new System.Drawing.Point(209, 35);
            this.lblEnterFlightNo.Name = "lblEnterFlightNo";
            this.lblEnterFlightNo.Size = new System.Drawing.Size(215, 13);
            this.lblEnterFlightNo.TabIndex = 4;
            this.lblEnterFlightNo.Text = "Enter the flight number you want to remove: ";
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Location = new System.Drawing.Point(430, 32);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(137, 20);
            this.txtFlightNo.TabIndex = 0;
            // 
            // btnRemoveTicket
            // 
            this.btnRemoveTicket.Location = new System.Drawing.Point(457, 84);
            this.btnRemoveTicket.Name = "btnRemoveTicket";
            this.btnRemoveTicket.Size = new System.Drawing.Size(92, 23);
            this.btnRemoveTicket.TabIndex = 1;
            this.btnRemoveTicket.Text = "Remove Ticket";
            this.btnRemoveTicket.UseVisualStyleBackColor = true;
            this.btnRemoveTicket.Click += new System.EventHandler(this.btnRemoveTicket_Click);
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
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<---";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminRemoveTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveTicket);
            this.Controls.Add(this.txtFlightNo);
            this.Controls.Add(this.lblEnterFlightNo);
            this.Name = "AdminRemoveTicketsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveTicketsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterFlightNo;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Button btnRemoveTicket;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnBack;
    }
}