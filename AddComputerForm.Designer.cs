namespace Device_Information_Store
{
    partial class AddComputerForm
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
            this.textDeviceType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textIPAddress = new System.Windows.Forms.TextBox();
            this.textDeviceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddWinKey = new System.Windows.Forms.Button();
            this.listWindowsKeys = new System.Windows.Forms.ListBox();
            this.comboWindowsVersion = new System.Windows.Forms.ComboBox();
            this.comboWindowsArch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboOfficeVersions = new System.Windows.Forms.ComboBox();
            this.textOfficeKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddDevice = new System.Windows.Forms.Button();
            this.listAttachedDevices = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonAddPersistRoute = new System.Windows.Forms.Button();
            this.listPersistantRoutes = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDeviceType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textIPAddress);
            this.groupBox1.Controls.Add(this.textDeviceName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textDeviceType
            // 
            this.textDeviceType.Location = new System.Drawing.Point(9, 110);
            this.textDeviceType.Name = "textDeviceType";
            this.textDeviceType.ReadOnly = true;
            this.textDeviceType.Size = new System.Drawing.Size(175, 20);
            this.textDeviceType.TabIndex = 2;
            this.textDeviceType.Text = "Computer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Device Type";
            // 
            // textIPAddress
            // 
            this.textIPAddress.Location = new System.Drawing.Point(6, 71);
            this.textIPAddress.Name = "textIPAddress";
            this.textIPAddress.Size = new System.Drawing.Size(178, 20);
            this.textIPAddress.TabIndex = 3;
            this.textIPAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textDeviceName
            // 
            this.textDeviceName.Location = new System.Drawing.Point(6, 32);
            this.textDeviceName.Name = "textDeviceName";
            this.textDeviceName.Size = new System.Drawing.Size(178, 20);
            this.textDeviceName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Name";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(383, 358);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(108, 23);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit Computer";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddWinKey);
            this.groupBox2.Controls.Add(this.listWindowsKeys);
            this.groupBox2.Controls.Add(this.comboWindowsVersion);
            this.groupBox2.Controls.Add(this.comboWindowsArch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Windows Information";
            // 
            // buttonAddWinKey
            // 
            this.buttonAddWinKey.Location = new System.Drawing.Point(6, 161);
            this.buttonAddWinKey.Name = "buttonAddWinKey";
            this.buttonAddWinKey.Size = new System.Drawing.Size(178, 23);
            this.buttonAddWinKey.TabIndex = 8;
            this.buttonAddWinKey.Text = "Add Windows Key";
            this.buttonAddWinKey.UseVisualStyleBackColor = true;
            this.buttonAddWinKey.Click += new System.EventHandler(this.buttonAddWinKey_Click);
            // 
            // listWindowsKeys
            // 
            this.listWindowsKeys.FormattingEnabled = true;
            this.listWindowsKeys.Location = new System.Drawing.Point(7, 112);
            this.listWindowsKeys.Name = "listWindowsKeys";
            this.listWindowsKeys.Size = new System.Drawing.Size(177, 43);
            this.listWindowsKeys.TabIndex = 5;
            // 
            // comboWindowsVersion
            // 
            this.comboWindowsVersion.FormattingEnabled = true;
            this.comboWindowsVersion.Items.AddRange(new object[] {
            "Windows 7 Professional",
            "Windows 7 Home Premium",
            "Windows 7 Ulitmate",
            "Windows 8/8.1",
            "Windows 8/8.1 Professional"});
            this.comboWindowsVersion.Location = new System.Drawing.Point(6, 32);
            this.comboWindowsVersion.Name = "comboWindowsVersion";
            this.comboWindowsVersion.Size = new System.Drawing.Size(178, 21);
            this.comboWindowsVersion.TabIndex = 7;
            // 
            // comboWindowsArch
            // 
            this.comboWindowsArch.FormattingEnabled = true;
            this.comboWindowsArch.Items.AddRange(new object[] {
            "x86_64 (64-bit)",
            "x86 (32-bit)"});
            this.comboWindowsArch.Location = new System.Drawing.Point(6, 72);
            this.comboWindowsArch.Name = "comboWindowsArch";
            this.comboWindowsArch.Size = new System.Drawing.Size(178, 21);
            this.comboWindowsArch.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Windows Keys";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Windows Architecture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Windows Version";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboOfficeVersions);
            this.groupBox3.Controls.Add(this.textOfficeKey);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(208, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 107);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Office Information";
            // 
            // comboOfficeVersions
            // 
            this.comboOfficeVersions.FormattingEnabled = true;
            this.comboOfficeVersions.Location = new System.Drawing.Point(6, 32);
            this.comboOfficeVersions.Name = "comboOfficeVersions";
            this.comboOfficeVersions.Size = new System.Drawing.Size(128, 21);
            this.comboOfficeVersions.TabIndex = 4;
            // 
            // textOfficeKey
            // 
            this.textOfficeKey.Location = new System.Drawing.Point(6, 72);
            this.textOfficeKey.Name = "textOfficeKey";
            this.textOfficeKey.Size = new System.Drawing.Size(128, 20);
            this.textOfficeKey.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Office Licence Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Office Version";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonAddUser);
            this.groupBox4.Controls.Add(this.buttonAddDevice);
            this.groupBox4.Controls.Add(this.listAttachedDevices);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.listUsers);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(354, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 338);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Users and Devices";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(6, 137);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(125, 23);
            this.buttonAddUser.TabIndex = 8;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddDevice
            // 
            this.buttonAddDevice.Location = new System.Drawing.Point(6, 309);
            this.buttonAddDevice.Name = "buttonAddDevice";
            this.buttonAddDevice.Size = new System.Drawing.Size(125, 23);
            this.buttonAddDevice.TabIndex = 7;
            this.buttonAddDevice.Text = "Add a Device";
            this.buttonAddDevice.UseVisualStyleBackColor = true;
            // 
            // listAttachedDevices
            // 
            this.listAttachedDevices.FormattingEnabled = true;
            this.listAttachedDevices.Location = new System.Drawing.Point(6, 179);
            this.listAttachedDevices.Name = "listAttachedDevices";
            this.listAttachedDevices.Size = new System.Drawing.Size(125, 121);
            this.listAttachedDevices.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Attached Devices";
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(6, 32);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(125, 95);
            this.listUsers.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Users";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonAddPersistRoute);
            this.groupBox5.Controls.Add(this.listPersistantRoutes);
            this.groupBox5.Location = new System.Drawing.Point(208, 125);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(140, 227);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Persistant Routes";
            // 
            // buttonAddPersistRoute
            // 
            this.buttonAddPersistRoute.Location = new System.Drawing.Point(9, 198);
            this.buttonAddPersistRoute.Name = "buttonAddPersistRoute";
            this.buttonAddPersistRoute.Size = new System.Drawing.Size(125, 23);
            this.buttonAddPersistRoute.TabIndex = 1;
            this.buttonAddPersistRoute.Text = "Add Persistant Route";
            this.buttonAddPersistRoute.UseVisualStyleBackColor = true;
            this.buttonAddPersistRoute.Click += new System.EventHandler(this.buttonAddPersistRoute_Click);
            // 
            // listPersistantRoutes
            // 
            this.listPersistantRoutes.FormattingEnabled = true;
            this.listPersistantRoutes.Location = new System.Drawing.Point(6, 19);
            this.listPersistantRoutes.Name = "listPersistantRoutes";
            this.listPersistantRoutes.Size = new System.Drawing.Size(128, 173);
            this.listPersistantRoutes.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(302, 356);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 391);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddComputerForm";
            this.Text = "AddComputerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textIPAddress;
        private System.Windows.Forms.TextBox textDeviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textDeviceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboWindowsVersion;
        private System.Windows.Forms.ComboBox comboWindowsArch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listWindowsKeys;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboOfficeVersions;
        private System.Windows.Forms.TextBox textOfficeKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.ListBox listAttachedDevices;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAddWinKey;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddDevice;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonAddPersistRoute;
        private System.Windows.Forms.ListBox listPersistantRoutes;
        private System.Windows.Forms.Button buttonCancel;
    }
}