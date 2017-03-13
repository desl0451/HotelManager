namespace HotelManager
{
    partial class RoomForm
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
            this.gbquery = new System.Windows.Forms.GroupBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.gbRoom = new System.Windows.Forms.GroupBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.txtBedNum = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvRoomInfo = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnModify = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancle = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.gbquery.SuspendLayout();
            this.gbRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbquery
            // 
            this.gbquery.Controls.Add(this.lblRoomID);
            this.gbquery.Controls.Add(this.txtRoomID);
            this.gbquery.Controls.Add(this.btnQuery);
            this.gbquery.Font = new System.Drawing.Font("宋体", 12F);
            this.gbquery.Location = new System.Drawing.Point(12, 38);
            this.gbquery.Name = "gbquery";
            this.gbquery.Size = new System.Drawing.Size(529, 59);
            this.gbquery.TabIndex = 18;
            this.gbquery.TabStop = false;
            this.gbquery.Text = "查询条件";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(55, 28);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(56, 16);
            this.lblRoomID.TabIndex = 12;
            this.lblRoomID.Text = "房间号";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(121, 24);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(190, 26);
            this.txtRoomID.TabIndex = 8;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(329, 21);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(74, 31);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // gbRoom
            // 
            this.gbRoom.Controls.Add(this.cmbRoomType);
            this.gbRoom.Controls.Add(this.txtBedNum);
            this.gbRoom.Controls.Add(this.txtDescription);
            this.gbRoom.Controls.Add(this.lblRoomType);
            this.gbRoom.Controls.Add(this.label2);
            this.gbRoom.Controls.Add(this.label1);
            this.gbRoom.Controls.Add(this.btnOK);
            this.gbRoom.Font = new System.Drawing.Font("宋体", 12F);
            this.gbRoom.Location = new System.Drawing.Point(12, 253);
            this.gbRoom.Name = "gbRoom";
            this.gbRoom.Size = new System.Drawing.Size(529, 129);
            this.gbRoom.TabIndex = 17;
            this.gbRoom.TabStop = false;
            this.gbRoom.Text = "房间信息维护";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(365, 27);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(121, 24);
            this.cmbRoomType.TabIndex = 17;
            // 
            // txtBedNum
            // 
            this.txtBedNum.Location = new System.Drawing.Point(97, 27);
            this.txtBedNum.Name = "txtBedNum";
            this.txtBedNum.Size = new System.Drawing.Size(121, 26);
            this.txtBedNum.TabIndex = 16;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 65);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(389, 26);
            this.txtDescription.TabIndex = 15;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(293, 31);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(72, 16);
            this.lblRoomType.TabIndex = 12;
            this.lblRoomType.Text = "房间类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "床位数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "房间描述";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(411, 100);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 31);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // dgvRoomInfo
            // 
            this.dgvRoomInfo.AllowUserToAddRows = false;
            this.dgvRoomInfo.AllowUserToDeleteRows = false;
            this.dgvRoomInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.bedNum,
            this.RoomState,
            this.roomType,
            this.description,
            this.guestNum,
            this.RoomTypeID,
            this.Column1});
            this.dgvRoomInfo.Location = new System.Drawing.Point(12, 103);
            this.dgvRoomInfo.Name = "dgvRoomInfo";
            this.dgvRoomInfo.ReadOnly = true;
            this.dgvRoomInfo.RowTemplate.Height = 23;
            this.dgvRoomInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomInfo.Size = new System.Drawing.Size(529, 139);
            this.dgvRoomInfo.TabIndex = 16;
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "房间号";
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            // 
            // bedNum
            // 
            this.bedNum.DataPropertyName = "BedNum";
            this.bedNum.HeaderText = "床位数";
            this.bedNum.Name = "bedNum";
            this.bedNum.ReadOnly = true;
            // 
            // RoomState
            // 
            this.RoomState.DataPropertyName = "RoomStateName";
            this.RoomState.HeaderText = "房间状态";
            this.RoomState.Name = "RoomState";
            this.RoomState.ReadOnly = true;
            // 
            // roomType
            // 
            this.roomType.DataPropertyName = "RoomTypeName";
            this.roomType.HeaderText = "房间类型";
            this.roomType.Name = "roomType";
            this.roomType.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "房间描述";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // guestNum
            // 
            this.guestNum.DataPropertyName = "GuestNum";
            this.guestNum.HeaderText = "房客数";
            this.guestNum.Name = "guestNum";
            this.guestNum.ReadOnly = true;
            // 
            // RoomTypeID
            // 
            this.RoomTypeID.DataPropertyName = "RoomTypeID";
            this.RoomTypeID.HeaderText = "房间类型ID";
            this.RoomTypeID.Name = "RoomTypeID";
            this.RoomTypeID.ReadOnly = true;
            this.RoomTypeID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RoomStateId";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnModify,
            this.tsbtnDelete,
            this.tsbtnCancle,
            this.tsbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(550, 28);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(46, 25);
            this.tsbtnAdd.Text = "新增";
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnModify
            // 
            this.tsbtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModify.Name = "tsbtnModify";
            this.tsbtnModify.Size = new System.Drawing.Size(46, 25);
            this.tsbtnModify.Text = "修改";
            this.tsbtnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(46, 25);
            this.tsbtnDelete.Text = "删除";
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnCancle
            // 
            this.tsbtnCancle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancle.Name = "tsbtnCancle";
            this.tsbtnCancle.Size = new System.Drawing.Size(46, 25);
            this.tsbtnCancle.Text = "取消";
            this.tsbtnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(46, 25);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 399);
            this.Controls.Add(this.gbquery);
            this.Controls.Add(this.gbRoom);
            this.Controls.Add(this.dgvRoomInfo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间信息管理";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.gbquery.ResumeLayout(false);
            this.gbquery.PerformLayout();
            this.gbRoom.ResumeLayout(false);
            this.gbRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbquery;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.GroupBox gbRoom;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.TextBox txtBedNum;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvRoomInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnModify;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnCancle;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomState;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}