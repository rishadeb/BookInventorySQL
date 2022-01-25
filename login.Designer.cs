
namespace DemoApplication
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxInsert = new System.Windows.Forms.TextBox();
            this.tbxUpdate = new System.Windows.Forms.TextBox();
            this.cbxDelete = new System.Windows.Forms.ComboBox();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEdition = new System.Windows.Forms.TextBox();
            this.lblEdition = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblPriceUpdate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxEditionUpdate = new System.Windows.Forms.TextBox();
            this.tbxAuthorUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCopies = new System.Windows.Forms.TextBox();
            this.cbxAvail = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tbxServer = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.lbliPAddress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(227, 48);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(47, 86);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(612, 140);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(234, 48);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(51, 86);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(204, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxInsert
            // 
            this.tbxInsert.Location = new System.Drawing.Point(109, 30);
            this.tbxInsert.Name = "tbxInsert";
            this.tbxInsert.Size = new System.Drawing.Size(100, 20);
            this.tbxInsert.TabIndex = 4;
            // 
            // tbxUpdate
            // 
            this.tbxUpdate.Location = new System.Drawing.Point(122, 30);
            this.tbxUpdate.Name = "tbxUpdate";
            this.tbxUpdate.Size = new System.Drawing.Size(106, 20);
            this.tbxUpdate.TabIndex = 6;
            // 
            // cbxDelete
            // 
            this.cbxDelete.FormattingEnabled = true;
            this.cbxDelete.Location = new System.Drawing.Point(10, 21);
            this.cbxDelete.Name = "cbxDelete";
            this.cbxDelete.Size = new System.Drawing.Size(160, 21);
            this.cbxDelete.TabIndex = 8;
            // 
            // cbxID
            // 
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(33, 30);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(41, 21);
            this.cbxID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "User:";
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(109, 56);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbxAuthor.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Author:";
            // 
            // tbxEdition
            // 
            this.tbxEdition.Location = new System.Drawing.Point(109, 82);
            this.tbxEdition.Name = "tbxEdition";
            this.tbxEdition.Size = new System.Drawing.Size(100, 20);
            this.tbxEdition.TabIndex = 16;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(13, 85);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(42, 13);
            this.lblEdition.TabIndex = 17;
            this.lblEdition.Text = "Edition:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxEdition);
            this.groupBox1.Controls.Add(this.lblEdition);
            this.groupBox1.Controls.Add(this.tbxAuthor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxInsert);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(32, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 172);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Book Entry";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(109, 135);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxPrice.TabIndex = 23;
            this.tbxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPrice_Validating);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(14, 138);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Price:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date Published:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxPriceUpdate);
            this.groupBox2.Controls.Add(this.lblPriceUpdate);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxEditionUpdate);
            this.groupBox2.Controls.Add(this.tbxAuthorUpdate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxUpdate);
            this.groupBox2.Controls.Add(this.cbxID);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(334, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 172);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Entry";
            // 
            // tbxPriceUpdate
            // 
            this.tbxPriceUpdate.Location = new System.Drawing.Point(122, 138);
            this.tbxPriceUpdate.Name = "tbxPriceUpdate";
            this.tbxPriceUpdate.Size = new System.Drawing.Size(106, 20);
            this.tbxPriceUpdate.TabIndex = 25;
            this.tbxPriceUpdate.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPriceUpdate_Validating);
            // 
            // lblPriceUpdate
            // 
            this.lblPriceUpdate.AutoSize = true;
            this.lblPriceUpdate.Location = new System.Drawing.Point(6, 142);
            this.lblPriceUpdate.Name = "lblPriceUpdate";
            this.lblPriceUpdate.Size = new System.Drawing.Size(34, 13);
            this.lblPriceUpdate.TabIndex = 24;
            this.lblPriceUpdate.Text = "Price:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(122, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Date Published:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Edition:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Author:";
            // 
            // tbxEditionUpdate
            // 
            this.tbxEditionUpdate.Location = new System.Drawing.Point(122, 82);
            this.tbxEditionUpdate.Name = "tbxEditionUpdate";
            this.tbxEditionUpdate.Size = new System.Drawing.Size(106, 20);
            this.tbxEditionUpdate.TabIndex = 21;
            // 
            // tbxAuthorUpdate
            // 
            this.tbxAuthorUpdate.Location = new System.Drawing.Point(122, 56);
            this.tbxAuthorUpdate.Name = "tbxAuthorUpdate";
            this.tbxAuthorUpdate.Size = new System.Drawing.Size(106, 20);
            this.tbxAuthorUpdate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxDelete);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(32, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 84);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Entry:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbxCopies);
            this.groupBox4.Controls.Add(this.cbxAvail);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(334, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 86);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Availability";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "# of Books:";
            // 
            // tbxCopies
            // 
            this.tbxCopies.Location = new System.Drawing.Point(209, 50);
            this.tbxCopies.Name = "tbxCopies";
            this.tbxCopies.Size = new System.Drawing.Size(76, 20);
            this.tbxCopies.TabIndex = 1;
            // 
            // cbxAvail
            // 
            this.cbxAvail.FormattingEnabled = true;
            this.cbxAvail.Location = new System.Drawing.Point(12, 19);
            this.cbxAvail.Name = "cbxAvail";
            this.cbxAvail.Size = new System.Drawing.Size(166, 21);
            this.cbxAvail.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(659, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "Disconnected!";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(367, 6);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Visible = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // tbxServer
            // 
            this.tbxServer.Location = new System.Drawing.Point(93, 7);
            this.tbxServer.Name = "tbxServer";
            this.tbxServer.Size = new System.Drawing.Size(100, 20);
            this.tbxServer.TabIndex = 24;
            this.tbxServer.Text = "localhost";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(234, 8);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 20);
            this.tbxPort.TabIndex = 25;
            this.tbxPort.Text = "3306";
            // 
            // lbliPAddress
            // 
            this.lbliPAddress.AutoSize = true;
            this.lbliPAddress.Location = new System.Drawing.Point(39, 11);
            this.lbliPAddress.Name = "lbliPAddress";
            this.lbliPAddress.Size = new System.Drawing.Size(48, 13);
            this.lbliPAddress.TabIndex = 26;
            this.lbliPAddress.Text = "Address:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(199, 11);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 27;
            this.lblPort.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(367, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 28;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(659, 486);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lbliPAddress);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.tbxServer);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MariaDb Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxInsert;
        private System.Windows.Forms.TextBox tbxUpdate;
        private System.Windows.Forms.ComboBox cbxDelete;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxEdition;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxEditionUpdate;
        private System.Windows.Forms.TextBox tbxAuthorUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCopies;
        private System.Windows.Forms.ComboBox cbxAvail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox tbxServer;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label lbliPAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxPriceUpdate;
        private System.Windows.Forms.Label lblPriceUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

