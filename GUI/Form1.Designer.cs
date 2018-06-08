namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcTabss = new System.Windows.Forms.TabControl();
            this.tpRechargeUidAmount = new System.Windows.Forms.TabPage();
            this.cbUserIDs = new System.Windows.Forms.ComboBox();
            this.btRechargeByUserID = new System.Windows.Forms.Button();
            this.cbAmountByUserID = new System.Windows.Forms.ComboBox();
            this.lbAmountByUserID = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.tpRechargeUsernameAmount = new System.Windows.Forms.TabPage();
            this.cbUsernames = new System.Windows.Forms.ComboBox();
            this.btRechargeByUsername = new System.Windows.Forms.Button();
            this.cbAmoutByUsername = new System.Windows.Forms.ComboBox();
            this.lbAmountByUsername = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tpRechargeCardIdAmount = new System.Windows.Forms.TabPage();
            this.cbCardIDs = new System.Windows.Forms.ComboBox();
            this.btRechargeByCardID = new System.Windows.Forms.Button();
            this.cbAmountByCardID = new System.Windows.Forms.ComboBox();
            this.lbAmountByCardID = new System.Windows.Forms.Label();
            this.lbCardID = new System.Windows.Forms.Label();
            this.tpServiceData = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lInfo = new System.Windows.Forms.Label();
            this.lCardData = new System.Windows.Forms.Label();
            this.lUserData = new System.Windows.Forms.Label();
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.tcTabss.SuspendLayout();
            this.tpRechargeUidAmount.SuspendLayout();
            this.tpRechargeUsernameAmount.SuspendLayout();
            this.tpRechargeCardIdAmount.SuspendLayout();
            this.tpServiceData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTabss
            // 
            resources.ApplyResources(this.tcTabss, "tcTabss");
            this.tcTabss.Controls.Add(this.tpRechargeUidAmount);
            this.tcTabss.Controls.Add(this.tpRechargeUsernameAmount);
            this.tcTabss.Controls.Add(this.tpRechargeCardIdAmount);
            this.tcTabss.Controls.Add(this.tpServiceData);
            this.tcTabss.Name = "tcTabss";
            this.tcTabss.SelectedIndex = 0;
            // 
            // tpRechargeUidAmount
            // 
            resources.ApplyResources(this.tpRechargeUidAmount, "tpRechargeUidAmount");
            this.tpRechargeUidAmount.BackgroundImage = global::GUI.Properties.Resources.FollowYou_print_new2_jpg;
            this.tpRechargeUidAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpRechargeUidAmount.Controls.Add(this.cbUserIDs);
            this.tpRechargeUidAmount.Controls.Add(this.btRechargeByUserID);
            this.tpRechargeUidAmount.Controls.Add(this.cbAmountByUserID);
            this.tpRechargeUidAmount.Controls.Add(this.lbAmountByUserID);
            this.tpRechargeUidAmount.Controls.Add(this.lbUserID);
            this.tpRechargeUidAmount.Name = "tpRechargeUidAmount";
            this.tpRechargeUidAmount.UseVisualStyleBackColor = true;
            // 
            // cbUserIDs
            // 
            resources.ApplyResources(this.cbUserIDs, "cbUserIDs");
            this.cbUserIDs.FormattingEnabled = true;
            this.cbUserIDs.Name = "cbUserIDs";
            // 
            // btRechargeByUserID
            // 
            resources.ApplyResources(this.btRechargeByUserID, "btRechargeByUserID");
            this.btRechargeByUserID.Name = "btRechargeByUserID";
            this.btRechargeByUserID.UseVisualStyleBackColor = true;
            this.btRechargeByUserID.Click += new System.EventHandler(this.btRechargeByUserID_Click);
            // 
            // cbAmountByUserID
            // 
            resources.ApplyResources(this.cbAmountByUserID, "cbAmountByUserID");
            this.cbAmountByUserID.FormattingEnabled = true;
            this.cbAmountByUserID.Items.AddRange(new object[] {
            resources.GetString("cbAmountByUserID.Items"),
            resources.GetString("cbAmountByUserID.Items1"),
            resources.GetString("cbAmountByUserID.Items2"),
            resources.GetString("cbAmountByUserID.Items3"),
            resources.GetString("cbAmountByUserID.Items4")});
            this.cbAmountByUserID.Name = "cbAmountByUserID";
            // 
            // lbAmountByUserID
            // 
            resources.ApplyResources(this.lbAmountByUserID, "lbAmountByUserID");
            this.lbAmountByUserID.Name = "lbAmountByUserID";
            // 
            // lbUserID
            // 
            resources.ApplyResources(this.lbUserID, "lbUserID");
            this.lbUserID.Name = "lbUserID";
            // 
            // tpRechargeUsernameAmount
            // 
            resources.ApplyResources(this.tpRechargeUsernameAmount, "tpRechargeUsernameAmount");
            this.tpRechargeUsernameAmount.BackgroundImage = global::GUI.Properties.Resources.FollowYou_print_new2_jpg;
            this.tpRechargeUsernameAmount.Controls.Add(this.cbUsernames);
            this.tpRechargeUsernameAmount.Controls.Add(this.btRechargeByUsername);
            this.tpRechargeUsernameAmount.Controls.Add(this.cbAmoutByUsername);
            this.tpRechargeUsernameAmount.Controls.Add(this.lbAmountByUsername);
            this.tpRechargeUsernameAmount.Controls.Add(this.lbUsername);
            this.tpRechargeUsernameAmount.Name = "tpRechargeUsernameAmount";
            this.tpRechargeUsernameAmount.UseVisualStyleBackColor = true;
            // 
            // cbUsernames
            // 
            resources.ApplyResources(this.cbUsernames, "cbUsernames");
            this.cbUsernames.FormattingEnabled = true;
            this.cbUsernames.Name = "cbUsernames";
            // 
            // btRechargeByUsername
            // 
            resources.ApplyResources(this.btRechargeByUsername, "btRechargeByUsername");
            this.btRechargeByUsername.Name = "btRechargeByUsername";
            this.btRechargeByUsername.UseVisualStyleBackColor = true;
            this.btRechargeByUsername.Click += new System.EventHandler(this.btRechargeByUsername_Click);
            // 
            // cbAmoutByUsername
            // 
            resources.ApplyResources(this.cbAmoutByUsername, "cbAmoutByUsername");
            this.cbAmoutByUsername.FormattingEnabled = true;
            this.cbAmoutByUsername.Items.AddRange(new object[] {
            resources.GetString("cbAmoutByUsername.Items"),
            resources.GetString("cbAmoutByUsername.Items1"),
            resources.GetString("cbAmoutByUsername.Items2"),
            resources.GetString("cbAmoutByUsername.Items3"),
            resources.GetString("cbAmoutByUsername.Items4")});
            this.cbAmoutByUsername.Name = "cbAmoutByUsername";
            // 
            // lbAmountByUsername
            // 
            resources.ApplyResources(this.lbAmountByUsername, "lbAmountByUsername");
            this.lbAmountByUsername.Name = "lbAmountByUsername";
            // 
            // lbUsername
            // 
            resources.ApplyResources(this.lbUsername, "lbUsername");
            this.lbUsername.Name = "lbUsername";
            // 
            // tpRechargeCardIdAmount
            // 
            resources.ApplyResources(this.tpRechargeCardIdAmount, "tpRechargeCardIdAmount");
            this.tpRechargeCardIdAmount.BackgroundImage = global::GUI.Properties.Resources.FollowYou_print_new2_jpg;
            this.tpRechargeCardIdAmount.Controls.Add(this.cbCardIDs);
            this.tpRechargeCardIdAmount.Controls.Add(this.btRechargeByCardID);
            this.tpRechargeCardIdAmount.Controls.Add(this.cbAmountByCardID);
            this.tpRechargeCardIdAmount.Controls.Add(this.lbAmountByCardID);
            this.tpRechargeCardIdAmount.Controls.Add(this.lbCardID);
            this.tpRechargeCardIdAmount.Name = "tpRechargeCardIdAmount";
            this.tpRechargeCardIdAmount.UseVisualStyleBackColor = true;
            // 
            // cbCardIDs
            // 
            resources.ApplyResources(this.cbCardIDs, "cbCardIDs");
            this.cbCardIDs.FormattingEnabled = true;
            this.cbCardIDs.Name = "cbCardIDs";
            // 
            // btRechargeByCardID
            // 
            resources.ApplyResources(this.btRechargeByCardID, "btRechargeByCardID");
            this.btRechargeByCardID.Name = "btRechargeByCardID";
            this.btRechargeByCardID.UseVisualStyleBackColor = true;
            this.btRechargeByCardID.Click += new System.EventHandler(this.btRechargeByCardID_Click);
            // 
            // cbAmountByCardID
            // 
            resources.ApplyResources(this.cbAmountByCardID, "cbAmountByCardID");
            this.cbAmountByCardID.FormattingEnabled = true;
            this.cbAmountByCardID.Items.AddRange(new object[] {
            resources.GetString("cbAmountByCardID.Items"),
            resources.GetString("cbAmountByCardID.Items1"),
            resources.GetString("cbAmountByCardID.Items2"),
            resources.GetString("cbAmountByCardID.Items3"),
            resources.GetString("cbAmountByCardID.Items4")});
            this.cbAmountByCardID.Name = "cbAmountByCardID";
            // 
            // lbAmountByCardID
            // 
            resources.ApplyResources(this.lbAmountByCardID, "lbAmountByCardID");
            this.lbAmountByCardID.Name = "lbAmountByCardID";
            // 
            // lbCardID
            // 
            resources.ApplyResources(this.lbCardID, "lbCardID");
            this.lbCardID.Name = "lbCardID";
            // 
            // tpServiceData
            // 
            resources.ApplyResources(this.tpServiceData, "tpServiceData");
            this.tpServiceData.BackgroundImage = global::GUI.Properties.Resources.FollowYou_print_new2_jpg;
            this.tpServiceData.Controls.Add(this.dgvCards);
            this.tpServiceData.Controls.Add(this.dgvUsers);
            this.tpServiceData.Controls.Add(this.lInfo);
            this.tpServiceData.Controls.Add(this.lCardData);
            this.tpServiceData.Controls.Add(this.lUserData);
            this.tpServiceData.Name = "tpServiceData";
            this.tpServiceData.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            resources.ApplyResources(this.dgvUsers, "dgvUsers");
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            // 
            // lInfo
            // 
            resources.ApplyResources(this.lInfo, "lInfo");
            this.lInfo.Name = "lInfo";
            // 
            // lCardData
            // 
            resources.ApplyResources(this.lCardData, "lCardData");
            this.lCardData.Name = "lCardData";
            // 
            // lUserData
            // 
            resources.ApplyResources(this.lUserData, "lUserData");
            this.lUserData.Name = "lUserData";
            // 
            // dgvCards
            // 
            resources.ApplyResources(this.dgvCards, "dgvCards");
            this.dgvCards.AllowUserToAddRows = false;
            this.dgvCards.AllowUserToDeleteRows = false;
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcTabss);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            this.tcTabss.ResumeLayout(false);
            this.tpRechargeUidAmount.ResumeLayout(false);
            this.tpRechargeUidAmount.PerformLayout();
            this.tpRechargeUsernameAmount.ResumeLayout(false);
            this.tpRechargeUsernameAmount.PerformLayout();
            this.tpRechargeCardIdAmount.ResumeLayout(false);
            this.tpRechargeCardIdAmount.PerformLayout();
            this.tpServiceData.ResumeLayout(false);
            this.tpServiceData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabss;
        private System.Windows.Forms.TabPage tpRechargeUidAmount;
        private System.Windows.Forms.TabPage tpRechargeUsernameAmount;
        private System.Windows.Forms.TabPage tpRechargeCardIdAmount;
        private System.Windows.Forms.TabPage tpServiceData;
        private System.Windows.Forms.Button btRechargeByUserID;
        private System.Windows.Forms.ComboBox cbAmountByUserID;
        private System.Windows.Forms.Label lbAmountByUserID;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Button btRechargeByUsername;
        private System.Windows.Forms.ComboBox cbAmoutByUsername;
        private System.Windows.Forms.Label lbAmountByUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btRechargeByCardID;
        private System.Windows.Forms.ComboBox cbAmountByCardID;
        private System.Windows.Forms.Label lbAmountByCardID;
        private System.Windows.Forms.Label lbCardID;
        private System.Windows.Forms.ComboBox cbUserIDs;
        private System.Windows.Forms.ComboBox cbUsernames;
        private System.Windows.Forms.ComboBox cbCardIDs;
        private System.Windows.Forms.Label lCardData;
        private System.Windows.Forms.Label lUserData;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvCards;
    }
}

