namespace birdAviarymanagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addBtn = new System.Windows.Forms.Button();
            this.randomDataBtn = new System.Windows.Forms.Button();
            this.idTxtBx = new System.Windows.Forms.TextBox();
            this.colorMutTxtBx = new System.Windows.Forms.TextBox();
            this.yearTxtBx = new System.Windows.Forms.TextBox();
            this.typeCbox = new System.Windows.Forms.ComboBox();
            this.statusCbox = new System.Windows.Forms.ComboBox();
            this.availCbox = new System.Windows.Forms.ComboBox();
            this.birdsGrid = new System.Windows.Forms.DataGridView();
            this.X_id = new System.Windows.Forms.Label();
            this.X_type = new System.Windows.Forms.Label();
            this.X_year = new System.Windows.Forms.Label();
            this.x_color = new System.Windows.Forms.Label();
            this.x_status = new System.Windows.Forms.Label();
            this.x_avail = new System.Windows.Forms.Label();
            this.createSortedReportBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblBirdsInSystem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birdsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(306, 542);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(163, 36);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "button1";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // randomDataBtn
            // 
            this.randomDataBtn.Location = new System.Drawing.Point(814, 530);
            this.randomDataBtn.Name = "randomDataBtn";
            this.randomDataBtn.Size = new System.Drawing.Size(206, 48);
            this.randomDataBtn.TabIndex = 1;
            this.randomDataBtn.Text = "button2";
            this.randomDataBtn.UseVisualStyleBackColor = true;
            this.randomDataBtn.Click += new System.EventHandler(this.randomDataBtn_Click);
            // 
            // idTxtBx
            // 
            this.idTxtBx.Location = new System.Drawing.Point(185, 136);
            this.idTxtBx.Name = "idTxtBx";
            this.idTxtBx.Size = new System.Drawing.Size(172, 22);
            this.idTxtBx.TabIndex = 2;
            // 
            // colorMutTxtBx
            // 
            this.colorMutTxtBx.Location = new System.Drawing.Point(306, 257);
            this.colorMutTxtBx.Name = "colorMutTxtBx";
            this.colorMutTxtBx.Size = new System.Drawing.Size(172, 22);
            this.colorMutTxtBx.TabIndex = 3;
          
            // 
            // yearTxtBx
            // 
            this.yearTxtBx.Location = new System.Drawing.Point(288, 320);
            this.yearTxtBx.Name = "yearTxtBx";
            this.yearTxtBx.Size = new System.Drawing.Size(172, 22);
            this.yearTxtBx.TabIndex = 4;
            // 
            // typeCbox
            // 
            this.typeCbox.FormattingEnabled = true;
            this.typeCbox.Location = new System.Drawing.Point(223, 195);
            this.typeCbox.Name = "typeCbox";
            this.typeCbox.Size = new System.Drawing.Size(176, 24);
            this.typeCbox.TabIndex = 5;
            // 
            // statusCbox
            // 
            this.statusCbox.FormattingEnabled = true;
            this.statusCbox.Location = new System.Drawing.Point(198, 381);
            this.statusCbox.Name = "statusCbox";
            this.statusCbox.Size = new System.Drawing.Size(176, 24);
            this.statusCbox.TabIndex = 6;
            this.statusCbox.SelectedIndexChanged += new System.EventHandler(this.statusCbox_SelectedIndexChanged);
            // 
            // availCbox
            // 
            this.availCbox.FormattingEnabled = true;
            this.availCbox.Location = new System.Drawing.Point(360, 445);
            this.availCbox.Name = "availCbox";
            this.availCbox.Size = new System.Drawing.Size(176, 24);
            this.availCbox.TabIndex = 7;
            // 
            // birdsGrid
            // 
            this.birdsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            this.birdsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.birdsGrid.Location = new System.Drawing.Point(769, 40);
            this.birdsGrid.Name = "birdsGrid";
            this.birdsGrid.RowHeadersWidth = 51;
            this.birdsGrid.RowTemplate.Height = 24;
            this.birdsGrid.Size = new System.Drawing.Size(525, 449);
            this.birdsGrid.TabIndex = 8;
            this.birdsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.birdsGrid_CellDoubleClick);
            // 
            // X_id
            // 
            this.X_id.AutoSize = true;
            this.X_id.BackColor = System.Drawing.Color.Transparent;
            this.X_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.X_id.ForeColor = System.Drawing.Color.Red;
            this.X_id.Location = new System.Drawing.Point(389, 129);
            this.X_id.Name = "X_id";
            this.X_id.Size = new System.Drawing.Size(31, 29);
            this.X_id.TabIndex = 9;
            this.X_id.Text = "X";
            this.X_id.Visible = false;
           
            // 
            // X_type
            // 
            this.X_type.AutoSize = true;
            this.X_type.BackColor = System.Drawing.Color.Transparent;
            this.X_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.X_type.ForeColor = System.Drawing.Color.Red;
            this.X_type.Location = new System.Drawing.Point(438, 195);
            this.X_type.Name = "X_type";
            this.X_type.Size = new System.Drawing.Size(31, 29);
            this.X_type.TabIndex = 10;
            this.X_type.Text = "X";
            this.X_type.Visible = false;
           
            // 
            // X_year
            // 
            this.X_year.AutoSize = true;
            this.X_year.BackColor = System.Drawing.Color.Transparent;
            this.X_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.X_year.ForeColor = System.Drawing.Color.Red;
            this.X_year.Location = new System.Drawing.Point(484, 320);
            this.X_year.Name = "X_year";
            this.X_year.Size = new System.Drawing.Size(31, 29);
            this.X_year.TabIndex = 11;
            this.X_year.Text = "X";
            this.X_year.Visible = false;
            // 
            // x_color
            // 
            this.x_color.AutoSize = true;
            this.x_color.BackColor = System.Drawing.Color.Transparent;
            this.x_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.x_color.ForeColor = System.Drawing.Color.Red;
            this.x_color.Location = new System.Drawing.Point(505, 257);
            this.x_color.Name = "x_color";
            this.x_color.Size = new System.Drawing.Size(31, 29);
            this.x_color.TabIndex = 12;
            this.x_color.Text = "X";
            this.x_color.Visible = false;
           
            // 
            // x_status
            // 
            this.x_status.AutoSize = true;
            this.x_status.BackColor = System.Drawing.Color.Transparent;
            this.x_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.x_status.ForeColor = System.Drawing.Color.Red;
            this.x_status.Location = new System.Drawing.Point(389, 381);
            this.x_status.Name = "x_status";
            this.x_status.Size = new System.Drawing.Size(31, 29);
            this.x_status.TabIndex = 13;
            this.x_status.Text = "X";
            this.x_status.Visible = false;
            // 
            // x_avail
            // 
            this.x_avail.AutoSize = true;
            this.x_avail.BackColor = System.Drawing.Color.Transparent;
            this.x_avail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.x_avail.ForeColor = System.Drawing.Color.Red;
            this.x_avail.Location = new System.Drawing.Point(564, 445);
            this.x_avail.Name = "x_avail";
            this.x_avail.Size = new System.Drawing.Size(31, 29);
            this.x_avail.TabIndex = 14;
            this.x_avail.Text = "X";
            this.x_avail.Visible = false;
            // 
            // createSortedReportBtn
            // 
            this.createSortedReportBtn.Location = new System.Drawing.Point(1071, 530);
            this.createSortedReportBtn.Name = "createSortedReportBtn";
            this.createSortedReportBtn.Size = new System.Drawing.Size(203, 48);
            this.createSortedReportBtn.TabIndex = 15;
            this.createSortedReportBtn.Text = "button2";
            this.createSortedReportBtn.UseVisualStyleBackColor = true;
            this.createSortedReportBtn.Click += new System.EventHandler(this.createSortedReportBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(841, 231);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(415, 23);
            this.progressBar1.TabIndex = 17;
           
            // 
            // lblBirdsInSystem
            // 
            this.lblBirdsInSystem.AutoSize = true;
            this.lblBirdsInSystem.BackColor = System.Drawing.Color.Transparent;
            this.lblBirdsInSystem.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirdsInSystem.Location = new System.Drawing.Point(40, 604);
            this.lblBirdsInSystem.Name = "lblBirdsInSystem";
            this.lblBirdsInSystem.Size = new System.Drawing.Size(0, 25);
            this.lblBirdsInSystem.TabIndex = 18;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::birdAviarymanagement.Properties.Resources.bird_aviary__remastered__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 647);
            this.Controls.Add(this.lblBirdsInSystem);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.createSortedReportBtn);
            this.Controls.Add(this.x_avail);
            this.Controls.Add(this.x_status);
            this.Controls.Add(this.x_color);
            this.Controls.Add(this.X_year);
            this.Controls.Add(this.X_type);
            this.Controls.Add(this.X_id);
            this.Controls.Add(this.birdsGrid);
            this.Controls.Add(this.availCbox);
            this.Controls.Add(this.statusCbox);
            this.Controls.Add(this.typeCbox);
            this.Controls.Add(this.yearTxtBx);
            this.Controls.Add(this.colorMutTxtBx);
            this.Controls.Add(this.idTxtBx);
            this.Controls.Add(this.randomDataBtn);
            this.Controls.Add(this.addBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bird Aviary Management";
            ((System.ComponentModel.ISupportInitialize)(this.birdsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button randomDataBtn;
        private System.Windows.Forms.TextBox idTxtBx;
        private System.Windows.Forms.TextBox colorMutTxtBx;
        private System.Windows.Forms.TextBox yearTxtBx;
        private System.Windows.Forms.ComboBox typeCbox;
        private System.Windows.Forms.ComboBox statusCbox;
        private System.Windows.Forms.ComboBox availCbox;
        private System.Windows.Forms.DataGridView birdsGrid;
        private System.Windows.Forms.Label X_id;
        private System.Windows.Forms.Label X_type;
        private System.Windows.Forms.Label X_year;
        private System.Windows.Forms.Label x_color;
        private System.Windows.Forms.Label x_status;
        private System.Windows.Forms.Label x_avail;
        private System.Windows.Forms.Button createSortedReportBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblBirdsInSystem;
    }
}

