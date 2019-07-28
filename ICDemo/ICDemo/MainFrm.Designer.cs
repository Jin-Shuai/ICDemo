namespace ICDemo
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hWindow1 = new HalconDotNet.HWindowControl();
            this.hWindow3 = new HalconDotNet.HWindowControl();
            this.hWindow2 = new HalconDotNet.HWindowControl();
            this.hWindow4 = new HalconDotNet.HWindowControl();
            this.hWindow5 = new HalconDotNet.HWindowControl();
            this.hWindow6 = new HalconDotNet.HWindowControl();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnMultiChannel = new System.Windows.Forms.Button();
            this.btnResistors = new System.Windows.Forms.Button();
            this.btnCapacitors = new System.Windows.Forms.Button();
            this.btnPins = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.hWindow1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hWindow3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.hWindow2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.hWindow4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.hWindow5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.hWindow6, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.btnPins);
            this.groupBox1.Controls.Add(this.btnCapacitors);
            this.groupBox1.Controls.Add(this.btnResistors);
            this.groupBox1.Controls.Add(this.btnMultiChannel);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(1004, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数调试";
            // 
            // hWindow1
            // 
            this.hWindow1.BackColor = System.Drawing.Color.Black;
            this.hWindow1.BorderColor = System.Drawing.Color.Black;
            this.hWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindow1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow1.Location = new System.Drawing.Point(3, 3);
            this.hWindow1.Name = "hWindow1";
            this.hWindow1.Size = new System.Drawing.Size(322, 207);
            this.hWindow1.TabIndex = 0;
            this.hWindow1.WindowSize = new System.Drawing.Size(322, 207);
            // 
            // hWindow3
            // 
            this.hWindow3.BackColor = System.Drawing.Color.Black;
            this.hWindow3.BorderColor = System.Drawing.Color.Black;
            this.hWindow3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindow3.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow3.Location = new System.Drawing.Point(659, 3);
            this.hWindow3.Name = "hWindow3";
            this.hWindow3.Size = new System.Drawing.Size(324, 207);
            this.hWindow3.TabIndex = 1;
            this.hWindow3.WindowSize = new System.Drawing.Size(324, 207);
            // 
            // hWindow2
            // 
            this.hWindow2.BackColor = System.Drawing.Color.Black;
            this.hWindow2.BorderColor = System.Drawing.Color.Black;
            this.hWindow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindow2.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow2.Location = new System.Drawing.Point(331, 3);
            this.hWindow2.Name = "hWindow2";
            this.hWindow2.Size = new System.Drawing.Size(322, 207);
            this.hWindow2.TabIndex = 2;
            this.hWindow2.WindowSize = new System.Drawing.Size(322, 207);
            // 
            // hWindow4
            // 
            this.hWindow4.BackColor = System.Drawing.Color.Black;
            this.hWindow4.BorderColor = System.Drawing.Color.Black;
            this.hWindow4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindow4.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow4.Location = new System.Drawing.Point(3, 216);
            this.hWindow4.Name = "hWindow4";
            this.hWindow4.Size = new System.Drawing.Size(322, 207);
            this.hWindow4.TabIndex = 3;
            this.hWindow4.WindowSize = new System.Drawing.Size(322, 207);
            // 
            // hWindow5
            // 
            this.hWindow5.BackColor = System.Drawing.Color.Black;
            this.hWindow5.BorderColor = System.Drawing.Color.Black;
            this.hWindow5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindow5.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow5.Location = new System.Drawing.Point(331, 216);
            this.hWindow5.Name = "hWindow5";
            this.hWindow5.Size = new System.Drawing.Size(322, 207);
            this.hWindow5.TabIndex = 4;
            this.hWindow5.WindowSize = new System.Drawing.Size(322, 207);
            // 
            // hWindow6
            // 
            this.hWindow6.BackColor = System.Drawing.Color.Black;
            this.hWindow6.BorderColor = System.Drawing.Color.Black;
            this.hWindow6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindow6.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow6.Location = new System.Drawing.Point(659, 216);
            this.hWindow6.Name = "hWindow6";
            this.hWindow6.Size = new System.Drawing.Size(324, 207);
            this.hWindow6.TabIndex = 5;
            this.hWindow6.WindowSize = new System.Drawing.Size(324, 207);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(6, 33);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(158, 40);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开图像";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnMultiChannel
            // 
            this.btnMultiChannel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMultiChannel.Location = new System.Drawing.Point(6, 97);
            this.btnMultiChannel.Name = "btnMultiChannel";
            this.btnMultiChannel.Size = new System.Drawing.Size(158, 40);
            this.btnMultiChannel.TabIndex = 1;
            this.btnMultiChannel.Text = "显示多通道";
            this.btnMultiChannel.UseVisualStyleBackColor = true;
            this.btnMultiChannel.Click += new System.EventHandler(this.btnMultiChannel_Click);
            // 
            // btnResistors
            // 
            this.btnResistors.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResistors.Location = new System.Drawing.Point(6, 161);
            this.btnResistors.Name = "btnResistors";
            this.btnResistors.Size = new System.Drawing.Size(158, 40);
            this.btnResistors.TabIndex = 2;
            this.btnResistors.Text = "测试电阻器";
            this.btnResistors.UseVisualStyleBackColor = true;
            this.btnResistors.Click += new System.EventHandler(this.btnResistors_Click);
            // 
            // btnCapacitors
            // 
            this.btnCapacitors.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCapacitors.Location = new System.Drawing.Point(6, 225);
            this.btnCapacitors.Name = "btnCapacitors";
            this.btnCapacitors.Size = new System.Drawing.Size(158, 40);
            this.btnCapacitors.TabIndex = 3;
            this.btnCapacitors.Text = "测试电容器";
            this.btnCapacitors.UseVisualStyleBackColor = true;
            this.btnCapacitors.Click += new System.EventHandler(this.btnCapacitors_Click);
            // 
            // btnPins
            // 
            this.btnPins.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPins.Location = new System.Drawing.Point(6, 289);
            this.btnPins.Name = "btnPins";
            this.btnPins.Size = new System.Drawing.Size(158, 40);
            this.btnPins.TabIndex = 4;
            this.btnPins.Text = "测试Pin";
            this.btnPins.UseVisualStyleBackColor = true;
            this.btnPins.Click += new System.EventHandler(this.btnPins_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShow.Location = new System.Drawing.Point(6, 351);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(158, 40);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "综合显示";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "测试";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private HalconDotNet.HWindowControl hWindow1;
        private HalconDotNet.HWindowControl hWindow3;
        private HalconDotNet.HWindowControl hWindow2;
        private HalconDotNet.HWindowControl hWindow4;
        private HalconDotNet.HWindowControl hWindow5;
        private HalconDotNet.HWindowControl hWindow6;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnMultiChannel;
        private System.Windows.Forms.Button btnPins;
        private System.Windows.Forms.Button btnCapacitors;
        private System.Windows.Forms.Button btnResistors;
        private System.Windows.Forms.Button btnShow;
    }
}

