
namespace Airway_Ticketing_Application
{
    partial class UserBookTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBookTicketsForm));
            this.lblFlightFrom = new System.Windows.Forms.Label();
            this.btnSearchTicket = new System.Windows.Forms.Button();
            this.lblFlightTo = new System.Windows.Forms.Label();
            this.dgvAvailableTickets = new System.Windows.Forms.DataGridView();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.txtFlightNo = new System.Windows.Forms.TextBox();
            this.lblEnterFlightNo = new System.Windows.Forms.Label();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFlightFrom
            // 
            this.lblFlightFrom.AutoSize = true;
            this.lblFlightFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFlightFrom.Location = new System.Drawing.Point(89, 22);
            this.lblFlightFrom.Name = "lblFlightFrom";
            this.lblFlightFrom.Size = new System.Drawing.Size(64, 13);
            this.lblFlightFrom.TabIndex = 5;
            this.lblFlightFrom.Text = "Flight From: ";
            // 
            // btnSearchTicket
            // 
            this.btnSearchTicket.Location = new System.Drawing.Point(331, 61);
            this.btnSearchTicket.Name = "btnSearchTicket";
            this.btnSearchTicket.Size = new System.Drawing.Size(145, 23);
            this.btnSearchTicket.TabIndex = 2;
            this.btnSearchTicket.Text = "Search Available Ticket";
            this.btnSearchTicket.UseVisualStyleBackColor = true;
            this.btnSearchTicket.Click += new System.EventHandler(this.btnSearchTicket_Click);
            // 
            // lblFlightTo
            // 
            this.lblFlightTo.AutoSize = true;
            this.lblFlightTo.BackColor = System.Drawing.Color.Transparent;
            this.lblFlightTo.Location = new System.Drawing.Point(499, 22);
            this.lblFlightTo.Name = "lblFlightTo";
            this.lblFlightTo.Size = new System.Drawing.Size(54, 13);
            this.lblFlightTo.TabIndex = 10;
            this.lblFlightTo.Text = "Flight To: ";
            // 
            // dgvAvailableTickets
            // 
            this.dgvAvailableTickets.AllowUserToAddRows = false;
            this.dgvAvailableTickets.AllowUserToDeleteRows = false;
            this.dgvAvailableTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableTickets.Location = new System.Drawing.Point(12, 90);
            this.dgvAvailableTickets.Name = "dgvAvailableTickets";
            this.dgvAvailableTickets.ReadOnly = true;
            this.dgvAvailableTickets.Size = new System.Drawing.Size(760, 250);
            this.dgvAvailableTickets.TabIndex = 3;
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Location = new System.Drawing.Point(362, 405);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(92, 23);
            this.btnBookTicket.TabIndex = 5;
            this.btnBookTicket.Text = "Book Ticket";
            this.btnBookTicket.UseVisualStyleBackColor = true;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // txtFlightNo
            // 
            this.txtFlightNo.Location = new System.Drawing.Point(454, 364);
            this.txtFlightNo.Name = "txtFlightNo";
            this.txtFlightNo.Size = new System.Drawing.Size(137, 20);
            this.txtFlightNo.TabIndex = 4;
            // 
            // lblEnterFlightNo
            // 
            this.lblEnterFlightNo.AutoSize = true;
            this.lblEnterFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterFlightNo.Location = new System.Drawing.Point(219, 367);
            this.lblEnterFlightNo.Name = "lblEnterFlightNo";
            this.lblEnterFlightNo.Size = new System.Drawing.Size(235, 13);
            this.lblEnterFlightNo.TabIndex = 19;
            this.lblEnterFlightNo.Text = "Enter below the flight number you want to book: ";
            // 
            // cbFrom
            // 
            this.cbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.Items.AddRange(new object[] {
            "Barisal",
            "Chittagong",
            "Cox Bazar",
            "Dhaka",
            "Jessore",
            "Rajshahi",
            "Saidpur",
            "Sylhet"});
            this.cbFrom.Location = new System.Drawing.Point(159, 19);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(140, 21);
            this.cbFrom.Sorted = true;
            this.cbFrom.TabIndex = 0;
            // 
            // cbTo
            // 
            this.cbTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "Barisal",
            "Chittagong",
            "Cox Bazar",
            "Dhaka",
            "Jessore",
            "Rajshahi",
            "Saidpur",
            "Sylhet"});
            this.cbTo.Location = new System.Drawing.Point(559, 19);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(140, 21);
            this.cbTo.Sorted = true;
            this.cbTo.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<---";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Location = new System.Drawing.Point(48, 428);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(32, 13);
            this.lblBack.TabIndex = 25;
            this.lblBack.Text = "Back";
            // 
            // UserBookTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.txtFlightNo);
            this.Controls.Add(this.lblEnterFlightNo);
            this.Controls.Add(this.dgvAvailableTickets);
            this.Controls.Add(this.btnSearchTicket);
            this.Controls.Add(this.lblFlightTo);
            this.Controls.Add(this.lblFlightFrom);
            this.Name = "UserBookTicketsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookTicketsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlightFrom;
        private System.Windows.Forms.Button btnSearchTicket;
        private System.Windows.Forms.Label lblFlightTo;
        private System.Windows.Forms.DataGridView dgvAvailableTickets;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.TextBox txtFlightNo;
        private System.Windows.Forms.Label lblEnterFlightNo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBack;
    }
}