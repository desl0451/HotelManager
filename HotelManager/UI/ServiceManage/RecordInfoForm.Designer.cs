namespace HotelManager
{
    partial class RecordInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.cmbResideState = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lbfromTime = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginTime = new System.Windows.Forms.DateTimePicker();
            this.dgvRecordInfo = new System.Windows.Forms.DataGridView();
            this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resideDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resideState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResideId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "退房信息";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(261, 34);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 36);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确定退房";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAmount.ForeColor = System.Drawing.Color.Red;
            this.txtAmount.Location = new System.Drawing.Point(112, 41);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(136, 21);
            this.txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "房款";
            // 
            // gbQuery
            // 
            this.gbQuery.Controls.Add(this.cmbResideState);
            this.gbQuery.Controls.Add(this.lblTo);
            this.gbQuery.Controls.Add(this.lbfromTime);
            this.gbQuery.Controls.Add(this.btnQuery);
            this.gbQuery.Controls.Add(this.dtpEndTime);
            this.gbQuery.Controls.Add(this.dtpBeginTime);
            this.gbQuery.Font = new System.Drawing.Font("宋体", 12F);
            this.gbQuery.Location = new System.Drawing.Point(12, 12);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Size = new System.Drawing.Size(611, 67);
            this.gbQuery.TabIndex = 7;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "查询条件";
            // 
            // cmbResideState
            // 
            this.cmbResideState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResideState.FormattingEnabled = true;
            this.cmbResideState.Items.AddRange(new object[] {
            "未结账",
            "已结账"});
            this.cmbResideState.Location = new System.Drawing.Point(437, 25);
            this.cmbResideState.Name = "cmbResideState";
            this.cmbResideState.Size = new System.Drawing.Size(78, 24);
            this.cmbResideState.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(234, 29);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 16);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "至";
            // 
            // lbfromTime
            // 
            this.lbfromTime.AutoSize = true;
            this.lbfromTime.Location = new System.Drawing.Point(36, 29);
            this.lbfromTime.Name = "lbfromTime";
            this.lbfromTime.Size = new System.Drawing.Size(24, 16);
            this.lbfromTime.TabIndex = 8;
            this.lbfromTime.Text = "从";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(530, 23);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 29);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(257, 24);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(163, 26);
            this.dtpEndTime.TabIndex = 4;
            // 
            // dtpBeginTime
            // 
            this.dtpBeginTime.CustomFormat = "yyyy-MM-dd";
            this.dtpBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeginTime.Location = new System.Drawing.Point(65, 24);
            this.dtpBeginTime.Name = "dtpBeginTime";
            this.dtpBeginTime.Size = new System.Drawing.Size(163, 26);
            this.dtpBeginTime.TabIndex = 5;
            // 
            // dgvRecordInfo
            // 
            this.dgvRecordInfo.AllowUserToAddRows = false;
            this.dgvRecordInfo.AllowUserToDeleteRows = false;
            this.dgvRecordInfo.AllowUserToResizeColumns = false;
            this.dgvRecordInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRecordInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecordInfo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecordInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecordInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestName,
            this.identityID,
            this.resideDate,
            this.deposit,
            this.resideState,
            this.leaveDate,
            this.totalMoney,
            this.roomID,
            this.roomTypeName,
            this.roomStateName,
            this.GuestId,
            this.ResideId});
            this.dgvRecordInfo.Location = new System.Drawing.Point(12, 85);
            this.dgvRecordInfo.Name = "dgvRecordInfo";
            this.dgvRecordInfo.RowHeadersVisible = false;
            this.dgvRecordInfo.RowTemplate.Height = 23;
            this.dgvRecordInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecordInfo.Size = new System.Drawing.Size(611, 225);
            this.dgvRecordInfo.TabIndex = 6;
            // 
            // GuestName
            // 
            this.GuestName.DataPropertyName = "GuestName";
            this.GuestName.HeaderText = "客户姓名";
            this.GuestName.Name = "GuestName";
            this.GuestName.ReadOnly = true;
            this.GuestName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // identityID
            // 
            this.identityID.DataPropertyName = "IdentityID";
            this.identityID.HeaderText = "身份证号";
            this.identityID.Name = "identityID";
            this.identityID.ReadOnly = true;
            // 
            // resideDate
            // 
            this.resideDate.DataPropertyName = "ResideDate";
            this.resideDate.HeaderText = "入住日期";
            this.resideDate.Name = "resideDate";
            this.resideDate.ReadOnly = true;
            // 
            // deposit
            // 
            this.deposit.DataPropertyName = "Deposit";
            this.deposit.HeaderText = "订金";
            this.deposit.Name = "deposit";
            this.deposit.ReadOnly = true;
            // 
            // resideState
            // 
            this.resideState.DataPropertyName = "ResideName";
            this.resideState.HeaderText = "状态";
            this.resideState.Name = "resideState";
            this.resideState.ReadOnly = true;
            // 
            // leaveDate
            // 
            this.leaveDate.DataPropertyName = "LeaveDate";
            this.leaveDate.HeaderText = "退房日期";
            this.leaveDate.Name = "leaveDate";
            this.leaveDate.ReadOnly = true;
            // 
            // totalMoney
            // 
            this.totalMoney.DataPropertyName = "TotalMoney";
            this.totalMoney.HeaderText = "消费金额";
            this.totalMoney.Name = "totalMoney";
            this.totalMoney.ReadOnly = true;
            // 
            // roomID
            // 
            this.roomID.DataPropertyName = "RoomID";
            this.roomID.HeaderText = "房间号";
            this.roomID.Name = "roomID";
            this.roomID.ReadOnly = true;
            // 
            // roomTypeName
            // 
            this.roomTypeName.DataPropertyName = "TypeName";
            this.roomTypeName.HeaderText = "房间类型";
            this.roomTypeName.Name = "roomTypeName";
            this.roomTypeName.ReadOnly = true;
            // 
            // roomStateName
            // 
            this.roomStateName.DataPropertyName = "RoomStateName";
            this.roomStateName.HeaderText = "房间状态";
            this.roomStateName.Name = "roomStateName";
            this.roomStateName.ReadOnly = true;
            // 
            // GuestId
            // 
            this.GuestId.DataPropertyName = "GuestId";
            this.GuestId.HeaderText = "GuestId";
            this.GuestId.Name = "GuestId";
            this.GuestId.Visible = false;
            // 
            // ResideId
            // 
            this.ResideId.DataPropertyName = "ResideId";
            this.ResideId.HeaderText = "ResideId";
            this.ResideId.Name = "ResideId";
            this.ResideId.Visible = false;
            // 
            // RecordInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbQuery);
            this.Controls.Add(this.dgvRecordInfo);
            this.Name = "RecordInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顾客信息查询";
            this.Load += new System.EventHandler(this.RecordInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbQuery.ResumeLayout(false);
            this.gbQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.ComboBox cmbResideState;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lbfromTime;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpBeginTime;
        private System.Windows.Forms.DataGridView dgvRecordInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn identityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn resideDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn resideState;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResideId;
    }
}