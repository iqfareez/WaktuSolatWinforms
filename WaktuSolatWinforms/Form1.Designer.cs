namespace WaktuSolatWinforms
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
            this.button1 = new System.Windows.Forms.Button();
            this.prayerGridView = new System.Windows.Forms.DataGridView();
            this.Prayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.zoneLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.negeriComboBox = new System.Windows.Forms.ComboBox();
            this.daerahComboBox = new System.Windows.Forms.ComboBox();
            this.h12RadioButton = new System.Windows.Forms.RadioButton();
            this.h24RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.prayerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Call";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prayerGridView
            // 
            this.prayerGridView.AllowUserToDeleteRows = false;
            this.prayerGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.prayerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prayerGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.prayerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prayerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Prayer, this.Time });
            this.prayerGridView.Location = new System.Drawing.Point(229, 71);
            this.prayerGridView.Name = "prayerGridView";
            this.prayerGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prayerGridView.RowTemplate.Height = 35;
            this.prayerGridView.Size = new System.Drawing.Size(376, 355);
            this.prayerGridView.TabIndex = 1;
            // 
            // Prayer
            // 
            this.Prayer.HeaderText = "Prayer";
            this.Prayer.Name = "Prayer";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zone:";
            // 
            // zoneLabel
            // 
            this.zoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.zoneLabel.Location = new System.Drawing.Point(86, 313);
            this.zoneLabel.Name = "zoneLabel";
            this.zoneLabel.Size = new System.Drawing.Size(100, 23);
            this.zoneLabel.TabIndex = 3;
            this.zoneLabel.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(12, 116);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(163, 23);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "label2";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(12, 16);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(199, 84);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "label2";
            // 
            // negeriComboBox
            // 
            this.negeriComboBox.FormattingEnabled = true;
            this.negeriComboBox.Location = new System.Drawing.Point(229, 16);
            this.negeriComboBox.Name = "negeriComboBox";
            this.negeriComboBox.Size = new System.Drawing.Size(147, 24);
            this.negeriComboBox.TabIndex = 6;
            this.negeriComboBox.Text = "-- Select Negeri -";
            this.negeriComboBox.SelectedIndexChanged += new System.EventHandler(this.negeriComboBox_SelectedIndexChanged);
            // 
            // daerahComboBox
            // 
            this.daerahComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.daerahComboBox.FormattingEnabled = true;
            this.daerahComboBox.Location = new System.Drawing.Point(382, 16);
            this.daerahComboBox.Name = "daerahComboBox";
            this.daerahComboBox.Size = new System.Drawing.Size(223, 24);
            this.daerahComboBox.TabIndex = 7;
            this.daerahComboBox.Text = "-- Select Daerah --";
            // 
            // h12RadioButton
            // 
            this.h12RadioButton.Checked = true;
            this.h12RadioButton.Location = new System.Drawing.Point(13, 19);
            this.h12RadioButton.Name = "h12RadioButton";
            this.h12RadioButton.Size = new System.Drawing.Size(65, 24);
            this.h12RadioButton.TabIndex = 8;
            this.h12RadioButton.TabStop = true;
            this.h12RadioButton.Text = "12 H";
            this.h12RadioButton.UseVisualStyleBackColor = true;
            // 
            // h24RadioButton
            // 
            this.h24RadioButton.Location = new System.Drawing.Point(85, 19);
            this.h24RadioButton.Name = "h24RadioButton";
            this.h24RadioButton.Size = new System.Drawing.Size(65, 24);
            this.h24RadioButton.TabIndex = 9;
            this.h24RadioButton.Text = "24 H";
            this.h24RadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.h24RadioButton);
            this.groupBox1.Controls.Add(this.h12RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Format";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.daerahComboBox);
            this.Controls.Add(this.negeriComboBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.zoneLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prayerGridView);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "Waktu Solat";
            ((System.ComponentModel.ISupportInitialize)(this.prayerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.RadioButton h12RadioButton;
        private System.Windows.Forms.RadioButton h24RadioButton;

        private System.Windows.Forms.ComboBox daerahComboBox;

        private System.Windows.Forms.ComboBox negeriComboBox;

        private System.Windows.Forms.Label dateLabel;

        private System.Windows.Forms.Label timeLabel;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zoneLabel;

        private System.Windows.Forms.DataGridViewTextBoxColumn Prayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;

        private System.Windows.Forms.DataGridView prayerGridView;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}