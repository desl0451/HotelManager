namespace HotelManager
{
    partial class GuestInfoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.cmbRoomList = new System.Windows.Forms.ComboBox();
            this.lblidentityID = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.dtpReside = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtIdentityID = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.cmbRoomList);
            this.groupBox1.Controls.Add(this.lblidentityID);
            this.groupBox1.Controls.Add(this.lblRoomID);
            this.groupBox1.Controls.Add(this.lblGuestName);
            this.groupBox1.Controls.Add(this.lblDeposit);
            this.groupBox1.Controls.Add(this.dtpReside);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDeposit);
            this.groupBox1.Controls.Add(this.txtIdentityID);
            this.groupBox1.Controls.Add(this.txtGuestName);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 275);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登记顾客信息";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(188, 235);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // cmbRoomList
            // 
            this.cmbRoomList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomList.FormattingEnabled = true;
            this.cmbRoomList.Location = new System.Drawing.Point(95, 154);
            this.cmbRoomList.Name = "cmbRoomList";
            this.cmbRoomList.Size = new System.Drawing.Size(171, 24);
            this.cmbRoomList.TabIndex = 6;
            // 
            // lblidentityID
            // 
            this.lblidentityID.AutoSize = true;
            this.lblidentityID.Location = new System.Drawing.Point(18, 51);
            this.lblidentityID.Name = "lblidentityID";
            this.lblidentityID.Size = new System.Drawing.Size(72, 16);
            this.lblidentityID.TabIndex = 0;
            this.lblidentityID.Text = "身份证号";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(28, 161);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(40, 16);
            this.lblRoomID.TabIndex = 5;
            this.lblRoomID.Text = "房间";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(18, 89);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(72, 16);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "客户姓名";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(28, 127);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(40, 16);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "押金";
            // 
            // dtpReside
            // 
            this.dtpReside.CustomFormat = "yyyy-MM-dd HH:mm:00";
            this.dtpReside.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReside.Location = new System.Drawing.Point(95, 191);
            this.dtpReside.Name = "dtpReside";
            this.dtpReside.Size = new System.Drawing.Size(171, 26);
            this.dtpReside.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "入住时间";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(95, 119);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(171, 26);
            this.txtDeposit.TabIndex = 1;
            // 
            // txtIdentityID
            // 
            this.txtIdentityID.Location = new System.Drawing.Point(95, 47);
            this.txtIdentityID.Name = "txtIdentityID";
            this.txtIdentityID.Size = new System.Drawing.Size(171, 26);
            this.txtIdentityID.TabIndex = 1;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(95, 83);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(171, 26);
            this.txtGuestName.TabIndex = 1;
            // 
            // GuestInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 311);
            this.Controls.Add(this.groupBox1);
            this.Name = "GuestInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顾客入住信息登记";
            this.Load += new System.EventHandler(this.GuestInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbRoomList;
        private System.Windows.Forms.Label lblidentityID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.DateTimePicker dtpReside;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtIdentityID;
        private System.Windows.Forms.TextBox txtGuestName;
    }
}