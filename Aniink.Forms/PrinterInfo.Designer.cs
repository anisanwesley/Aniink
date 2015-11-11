namespace Aniink.Forms
{
    partial class PrinterInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtPagesPerMin = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtJobs = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtUntilTime = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtDefaultPriority = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecurityDescr = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDataType = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrintProcessor = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDevMode = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPortName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSharedName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkWorkOffline = new System.Windows.Forms.CheckBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.chkCompleteFirst = new System.Windows.Forms.CheckBox();
            this.chkEnableDevq = new System.Windows.Forms.CheckBox();
            this.chkRawOnly = new System.Windows.Forms.CheckBox();
            this.chkShared = new System.Windows.Forms.CheckBox();
            this.chkNetwork = new System.Windows.Forms.CheckBox();
            this.chkQueued = new System.Windows.Forms.CheckBox();
            this.chkPublished = new System.Windows.Forms.CheckBox();
            this.chkKeepPrinterJobs = new System.Windows.Forms.CheckBox();
            this.chkLocal = new System.Windows.Forms.CheckBox();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.chkDirect = new System.Windows.Forms.CheckBox();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.AutoSize = true;
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.Location = new System.Drawing.Point(99, 42);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(85, 13);
            this.txtServerName.TabIndex = 2;
            this.txtServerName.Text = "{{Server Name}}";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtPagesPerMin);
            this.groupBox.Controls.Add(this.label32);
            this.groupBox.Controls.Add(this.txtJobs);
            this.groupBox.Controls.Add(this.label30);
            this.groupBox.Controls.Add(this.txtStatus);
            this.groupBox.Controls.Add(this.label28);
            this.groupBox.Controls.Add(this.txtUntilTime);
            this.groupBox.Controls.Add(this.label26);
            this.groupBox.Controls.Add(this.txtStartTime);
            this.groupBox.Controls.Add(this.label24);
            this.groupBox.Controls.Add(this.txtDefaultPriority);
            this.groupBox.Controls.Add(this.label22);
            this.groupBox.Controls.Add(this.txtPriority);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.txtSecurityDescr);
            this.groupBox.Controls.Add(this.label18);
            this.groupBox.Controls.Add(this.txtDataType);
            this.groupBox.Controls.Add(this.label16);
            this.groupBox.Controls.Add(this.txtPrintProcessor);
            this.groupBox.Controls.Add(this.label14);
            this.groupBox.Controls.Add(this.txtDevMode);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.txtDriverName);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.txtPortName);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.txtSharedName);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.txtServerName);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(45, 35);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(298, 450);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "{{Printer Name}}";
            // 
            // txtPagesPerMin
            // 
            this.txtPagesPerMin.AutoSize = true;
            this.txtPagesPerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagesPerMin.Location = new System.Drawing.Point(103, 371);
            this.txtPagesPerMin.Name = "txtPagesPerMin";
            this.txtPagesPerMin.Size = new System.Drawing.Size(74, 13);
            this.txtPagesPerMin.TabIndex = 34;
            this.txtPagesPerMin.Text = "{{Pages/min}}";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(12, 371);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(61, 13);
            this.label32.TabIndex = 33;
            this.label32.Text = "Pages/min:";
            // 
            // txtJobs
            // 
            this.txtJobs.AutoSize = true;
            this.txtJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobs.Location = new System.Drawing.Point(103, 346);
            this.txtJobs.Name = "txtJobs";
            this.txtJobs.Size = new System.Drawing.Size(45, 13);
            this.txtJobs.TabIndex = 32;
            this.txtJobs.Text = "{{Jobs}}";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(12, 346);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(78, 13);
            this.label30.TabIndex = 31;
            this.label30.Text = "Jobs in Queue:";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(103, 324);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(53, 13);
            this.txtStatus.TabIndex = 30;
            this.txtStatus.Text = "{{Status}}";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(12, 324);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 13);
            this.label28.TabIndex = 29;
            this.label28.Text = "Status:";
            // 
            // txtUntilTime
            // 
            this.txtUntilTime.AutoSize = true;
            this.txtUntilTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUntilTime.Location = new System.Drawing.Point(102, 300);
            this.txtUntilTime.Name = "txtUntilTime";
            this.txtUntilTime.Size = new System.Drawing.Size(70, 13);
            this.txtUntilTime.TabIndex = 28;
            this.txtUntilTime.Text = "{{Until Time}}";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(11, 300);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 13);
            this.label26.TabIndex = 27;
            this.label26.Text = "Until Time:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.AutoSize = true;
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.Location = new System.Drawing.Point(102, 278);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(71, 13);
            this.txtStartTime.TabIndex = 26;
            this.txtStartTime.Text = "{{Start Time}}";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(11, 278);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Start Time:";
            // 
            // txtDefaultPriority
            // 
            this.txtDefaultPriority.AutoSize = true;
            this.txtDefaultPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultPriority.Location = new System.Drawing.Point(101, 254);
            this.txtDefaultPriority.Name = "txtDefaultPriority";
            this.txtDefaultPriority.Size = new System.Drawing.Size(91, 13);
            this.txtDefaultPriority.TabIndex = 24;
            this.txtDefaultPriority.Text = "{{Default Priority}}";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 254);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "Default Priority:";
            // 
            // txtPriority
            // 
            this.txtPriority.AutoSize = true;
            this.txtPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriority.Location = new System.Drawing.Point(101, 232);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(54, 13);
            this.txtPriority.TabIndex = 22;
            this.txtPriority.Text = "{{Priority}}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Priority:";
            // 
            // txtSecurityDescr
            // 
            this.txtSecurityDescr.AutoSize = true;
            this.txtSecurityDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityDescr.Location = new System.Drawing.Point(99, 208);
            this.txtSecurityDescr.Name = "txtSecurityDescr";
            this.txtSecurityDescr.Size = new System.Drawing.Size(92, 13);
            this.txtSecurityDescr.TabIndex = 18;
            this.txtSecurityDescr.Text = "{{Security Descr}}";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Security Descr:";
            // 
            // txtDataType
            // 
            this.txtDataType.AutoSize = true;
            this.txtDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataType.Location = new System.Drawing.Point(99, 185);
            this.txtDataType.Name = "txtDataType";
            this.txtDataType.Size = new System.Drawing.Size(73, 13);
            this.txtDataType.TabIndex = 16;
            this.txtDataType.Text = "{{Data Type}}";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Data Type:";
            // 
            // txtPrintProcessor
            // 
            this.txtPrintProcessor.AutoSize = true;
            this.txtPrintProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrintProcessor.Location = new System.Drawing.Point(99, 162);
            this.txtPrintProcessor.Name = "txtPrintProcessor";
            this.txtPrintProcessor.Size = new System.Drawing.Size(94, 13);
            this.txtPrintProcessor.TabIndex = 14;
            this.txtPrintProcessor.Text = "{{Print Processor}}";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Print Processor:";
            // 
            // txtDevMode
            // 
            this.txtDevMode.AutoSize = true;
            this.txtDevMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevMode.Location = new System.Drawing.Point(99, 138);
            this.txtDevMode.Name = "txtDevMode";
            this.txtDevMode.Size = new System.Drawing.Size(70, 13);
            this.txtDevMode.TabIndex = 12;
            this.txtDevMode.Text = "{{DevMode}}";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "DevMode:";
            // 
            // txtDriverName
            // 
            this.txtDriverName.AutoSize = true;
            this.txtDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName.Location = new System.Drawing.Point(99, 113);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(82, 13);
            this.txtDriverName.TabIndex = 10;
            this.txtDriverName.Text = "{{Driver Name}}";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Driver Name:";
            // 
            // txtPortName
            // 
            this.txtPortName.AutoSize = true;
            this.txtPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortName.Location = new System.Drawing.Point(99, 90);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(73, 13);
            this.txtPortName.TabIndex = 8;
            this.txtPortName.Text = "{{Port Name}}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Port Name:";
            // 
            // txtSharedName
            // 
            this.txtSharedName.AutoSize = true;
            this.txtSharedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSharedName.Location = new System.Drawing.Point(98, 64);
            this.txtSharedName.Name = "txtSharedName";
            this.txtSharedName.Size = new System.Drawing.Size(82, 13);
            this.txtSharedName.TabIndex = 6;
            this.txtSharedName.Text = "{{Share Name}}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Share Name:";
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(286, 470);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(75, 23);
            this.btnMore.TabIndex = 4;
            this.btnMore.Text = "More >>";
            this.btnMore.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkWorkOffline);
            this.groupBox1.Controls.Add(this.chkDefault);
            this.groupBox1.Controls.Add(this.chkCompleteFirst);
            this.groupBox1.Controls.Add(this.chkEnableDevq);
            this.groupBox1.Controls.Add(this.chkRawOnly);
            this.groupBox1.Controls.Add(this.chkShared);
            this.groupBox1.Controls.Add(this.chkNetwork);
            this.groupBox1.Controls.Add(this.chkQueued);
            this.groupBox1.Controls.Add(this.chkPublished);
            this.groupBox1.Controls.Add(this.chkKeepPrinterJobs);
            this.groupBox1.Controls.Add(this.chkLocal);
            this.groupBox1.Controls.Add(this.chkHidden);
            this.groupBox1.Controls.Add(this.chkDirect);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(383, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 334);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // chkWorkOffline
            // 
            this.chkWorkOffline.AutoSize = true;
            this.chkWorkOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWorkOffline.Location = new System.Drawing.Point(6, 255);
            this.chkWorkOffline.Name = "chkWorkOffline";
            this.chkWorkOffline.Size = new System.Drawing.Size(85, 17);
            this.chkWorkOffline.TabIndex = 18;
            this.chkWorkOffline.Text = "Work Offline";
            this.chkWorkOffline.UseVisualStyleBackColor = true;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefault.Location = new System.Drawing.Point(6, 71);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(60, 17);
            this.chkDefault.TabIndex = 17;
            this.chkDefault.Text = "Default";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // chkCompleteFirst
            // 
            this.chkCompleteFirst.AutoSize = true;
            this.chkCompleteFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompleteFirst.Location = new System.Drawing.Point(6, 232);
            this.chkCompleteFirst.Name = "chkCompleteFirst";
            this.chkCompleteFirst.Size = new System.Drawing.Size(92, 17);
            this.chkCompleteFirst.TabIndex = 16;
            this.chkCompleteFirst.Text = "Complete First";
            this.chkCompleteFirst.UseVisualStyleBackColor = true;
            // 
            // chkEnableDevq
            // 
            this.chkEnableDevq.AutoSize = true;
            this.chkEnableDevq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableDevq.Location = new System.Drawing.Point(6, 186);
            this.chkEnableDevq.Name = "chkEnableDevq";
            this.chkEnableDevq.Size = new System.Drawing.Size(131, 17);
            this.chkEnableDevq.TabIndex = 15;
            this.chkEnableDevq.Text = "Enable DevQueryPrint";
            this.chkEnableDevq.UseVisualStyleBackColor = true;
            // 
            // chkRawOnly
            // 
            this.chkRawOnly.AutoSize = true;
            this.chkRawOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRawOnly.Location = new System.Drawing.Point(6, 278);
            this.chkRawOnly.Name = "chkRawOnly";
            this.chkRawOnly.Size = new System.Drawing.Size(72, 17);
            this.chkRawOnly.TabIndex = 14;
            this.chkRawOnly.Text = "Raw Only";
            this.chkRawOnly.UseVisualStyleBackColor = true;
            // 
            // chkShared
            // 
            this.chkShared.AutoSize = true;
            this.chkShared.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShared.Location = new System.Drawing.Point(6, 94);
            this.chkShared.Name = "chkShared";
            this.chkShared.Size = new System.Drawing.Size(60, 17);
            this.chkShared.TabIndex = 13;
            this.chkShared.Text = "Shared";
            this.chkShared.UseVisualStyleBackColor = true;
            // 
            // chkNetwork
            // 
            this.chkNetwork.AutoSize = true;
            this.chkNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNetwork.Location = new System.Drawing.Point(6, 117);
            this.chkNetwork.Name = "chkNetwork";
            this.chkNetwork.Size = new System.Drawing.Size(66, 17);
            this.chkNetwork.TabIndex = 12;
            this.chkNetwork.Text = "Network";
            this.chkNetwork.UseVisualStyleBackColor = true;
            // 
            // chkQueued
            // 
            this.chkQueued.AutoSize = true;
            this.chkQueued.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQueued.Location = new System.Drawing.Point(6, 25);
            this.chkQueued.Name = "chkQueued";
            this.chkQueued.Size = new System.Drawing.Size(64, 17);
            this.chkQueued.TabIndex = 11;
            this.chkQueued.Text = "Queued";
            this.chkQueued.UseVisualStyleBackColor = true;
            // 
            // chkPublished
            // 
            this.chkPublished.AutoSize = true;
            this.chkPublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPublished.Location = new System.Drawing.Point(6, 301);
            this.chkPublished.Name = "chkPublished";
            this.chkPublished.Size = new System.Drawing.Size(72, 17);
            this.chkPublished.TabIndex = 10;
            this.chkPublished.Text = "Published";
            this.chkPublished.UseVisualStyleBackColor = true;
            // 
            // chkKeepPrinterJobs
            // 
            this.chkKeepPrinterJobs.AutoSize = true;
            this.chkKeepPrinterJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKeepPrinterJobs.Location = new System.Drawing.Point(6, 209);
            this.chkKeepPrinterJobs.Name = "chkKeepPrinterJobs";
            this.chkKeepPrinterJobs.Size = new System.Drawing.Size(109, 17);
            this.chkKeepPrinterJobs.TabIndex = 9;
            this.chkKeepPrinterJobs.Text = "Keep Printer Jobs";
            this.chkKeepPrinterJobs.UseVisualStyleBackColor = true;
            // 
            // chkLocal
            // 
            this.chkLocal.AutoSize = true;
            this.chkLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLocal.Location = new System.Drawing.Point(6, 163);
            this.chkLocal.Name = "chkLocal";
            this.chkLocal.Size = new System.Drawing.Size(52, 17);
            this.chkLocal.TabIndex = 8;
            this.chkLocal.Text = "Local";
            this.chkLocal.UseVisualStyleBackColor = true;
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHidden.Location = new System.Drawing.Point(6, 140);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(60, 17);
            this.chkHidden.TabIndex = 7;
            this.chkHidden.Text = "Hidden";
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // chkDirect
            // 
            this.chkDirect.AutoSize = true;
            this.chkDirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDirect.Location = new System.Drawing.Point(6, 48);
            this.chkDirect.Name = "chkDirect";
            this.chkDirect.Size = new System.Drawing.Size(54, 17);
            this.chkDirect.TabIndex = 6;
            this.chkDirect.Text = "Direct";
            this.chkDirect.UseVisualStyleBackColor = true;
            // 
            // PrinterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.groupBox);
            this.Name = "PrinterInfo";
            this.Text = "PrinterInfo";
            this.Load += new System.EventHandler(this.PrinterInfo_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtServerName;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label txtDriverName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtPortName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtSharedName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtSecurityDescr;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txtDataType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txtPrintProcessor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtDevMode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtPagesPerMin;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label txtJobs;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label txtUntilTime;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label txtStartTime;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label txtDefaultPriority;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCompleteFirst;
        private System.Windows.Forms.CheckBox chkEnableDevq;
        private System.Windows.Forms.CheckBox chkRawOnly;
        private System.Windows.Forms.CheckBox chkShared;
        private System.Windows.Forms.CheckBox chkNetwork;
        private System.Windows.Forms.CheckBox chkQueued;
        private System.Windows.Forms.CheckBox chkPublished;
        private System.Windows.Forms.CheckBox chkKeepPrinterJobs;
        private System.Windows.Forms.CheckBox chkLocal;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.CheckBox chkDirect;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.CheckBox chkWorkOffline;
    }
}