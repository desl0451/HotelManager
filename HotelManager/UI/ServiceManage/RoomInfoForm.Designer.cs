namespace HotelManager
{
    partial class RoomInfoForm
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
            this.gbRoomType = new System.Windows.Forms.GroupBox();
            this.tvRoom = new System.Windows.Forms.TreeView();
            this.lvRooms = new System.Windows.Forms.ListView();
            this.gbRoomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRoomType
            // 
            this.gbRoomType.Controls.Add(this.tvRoom);
            this.gbRoomType.Font = new System.Drawing.Font("宋体", 12F);
            this.gbRoomType.Location = new System.Drawing.Point(12, 12);
            this.gbRoomType.Name = "gbRoomType";
            this.gbRoomType.Size = new System.Drawing.Size(152, 345);
            this.gbRoomType.TabIndex = 4;
            this.gbRoomType.TabStop = false;
            this.gbRoomType.Text = "房间类型列表";
            // 
            // tvRoom
            // 
            this.tvRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvRoom.Location = new System.Drawing.Point(16, 20);
            this.tvRoom.Name = "tvRoom";
            this.tvRoom.Size = new System.Drawing.Size(121, 309);
            this.tvRoom.TabIndex = 0;
            // 
            // lvRooms
            // 
            this.lvRooms.Font = new System.Drawing.Font("宋体", 12F);
            this.lvRooms.Location = new System.Drawing.Point(170, 32);
            this.lvRooms.Name = "lvRooms";
            this.lvRooms.Size = new System.Drawing.Size(337, 309);
            this.lvRooms.TabIndex = 3;
            this.lvRooms.UseCompatibleStateImageBehavior = false;
            // 
            // RoomInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 365);
            this.Controls.Add(this.gbRoomType);
            this.Controls.Add(this.lvRooms);
            this.Name = "RoomInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间信息查看";
            this.gbRoomType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRoomType;
        private System.Windows.Forms.TreeView tvRoom;
        private System.Windows.Forms.ListView lvRooms;
    }
}