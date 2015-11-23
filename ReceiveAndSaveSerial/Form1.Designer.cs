namespace ReceiveAndSaveSerial
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.com_cbx = new System.Windows.Forms.ComboBox();
            this.baudRate_cbx = new System.Windows.Forms.ComboBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.state_txb = new System.Windows.Forms.TextBox();
            this.receive_txb = new System.Windows.Forms.TextBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.path_txb = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.filename_txb = new System.Windows.Forms.TextBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pathSelect = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // com_cbx
            // 
            this.com_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_cbx.FormattingEnabled = true;
            this.com_cbx.Location = new System.Drawing.Point(12, 49);
            this.com_cbx.Name = "com_cbx";
            this.com_cbx.Size = new System.Drawing.Size(63, 20);
            this.com_cbx.TabIndex = 0;
            // 
            // baudRate_cbx
            // 
            this.baudRate_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRate_cbx.FormattingEnabled = true;
            this.baudRate_cbx.Location = new System.Drawing.Point(81, 49);
            this.baudRate_cbx.Name = "baudRate_cbx";
            this.baudRate_cbx.Size = new System.Drawing.Size(69, 20);
            this.baudRate_cbx.TabIndex = 1;
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(156, 47);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 2;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // state_txb
            // 
            this.state_txb.Location = new System.Drawing.Point(12, 76);
            this.state_txb.Name = "state_txb";
            this.state_txb.ReadOnly = true;
            this.state_txb.Size = new System.Drawing.Size(138, 19);
            this.state_txb.TabIndex = 3;
            this.state_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // receive_txb
            // 
            this.receive_txb.Location = new System.Drawing.Point(12, 101);
            this.receive_txb.Multiline = true;
            this.receive_txb.Name = "receive_txb";
            this.receive_txb.ReadOnly = true;
            this.receive_txb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receive_txb.Size = new System.Drawing.Size(219, 249);
            this.receive_txb.TabIndex = 4;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(156, 74);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 5;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // path_txb
            // 
            this.path_txb.Location = new System.Drawing.Point(37, 356);
            this.path_txb.Name = "path_txb";
            this.path_txb.Size = new System.Drawing.Size(194, 19);
            this.path_txb.TabIndex = 6;
            this.path_txb.Text = "path";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(138, 381);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(93, 23);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Logging Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // filename_txb
            // 
            this.filename_txb.Location = new System.Drawing.Point(13, 383);
            this.filename_txb.Name = "filename_txb";
            this.filename_txb.Size = new System.Drawing.Size(83, 19);
            this.filename_txb.TabIndex = 8;
            this.filename_txb.Text = "filename";
            this.filename_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(138, 432);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(93, 23);
            this.close_btn.TabIndex = 9;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = ".txt";
            // 
            // pathSelect
            // 
            this.pathSelect.Location = new System.Drawing.Point(12, 354);
            this.pathSelect.Name = "pathSelect";
            this.pathSelect.Size = new System.Drawing.Size(19, 23);
            this.pathSelect.TabIndex = 12;
            this.pathSelect.Text = "...";
            this.pathSelect.UseVisualStyleBackColor = true;
            this.pathSelect.Click += new System.EventHandler(this.pathSelect_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 408);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Auto Name";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 467);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pathSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.filename_txb);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.path_txb);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.receive_txb);
            this.Controls.Add(this.state_txb);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.baudRate_cbx);
            this.Controls.Add(this.com_cbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Serial saver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox com_cbx;
        private System.Windows.Forms.ComboBox baudRate_cbx;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox state_txb;
        private System.Windows.Forms.TextBox receive_txb;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.TextBox path_txb;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox filename_txb;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button pathSelect;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

