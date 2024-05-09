using System.Drawing;

namespace genetik_algoritma_proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 20D);
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonClr2 = new System.Windows.Forms.Button();
            this.buttonClr1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown5.Location = new System.Drawing.Point(194, 216);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(64, 25);
            this.numericUpDown5.TabIndex = 4;
            this.numericUpDown5.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mutasyon Oranı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "İterasyon Sayısı:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown4.Location = new System.Drawing.Point(194, 179);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(64, 25);
            this.numericUpDown4.TabIndex = 4;
            this.numericUpDown4.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown6.Location = new System.Drawing.Point(194, 254);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(64, 25);
            this.numericUpDown6.TabIndex = 4;
            this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Elitizim:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown2.Location = new System.Drawing.Point(194, 104);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(64, 25);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çaprazlama Oranı:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown3.Location = new System.Drawing.Point(194, 141);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(64, 25);
            this.numericUpDown3.TabIndex = 4;
            this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Döngü Hızı(Ms):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(194, 67);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 25);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popülasyon:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown6);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(284, 396);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarlar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(262, 148);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(262, 113);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "%";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(290, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(836, 400);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elitizm Genler : ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 31);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(827, 353);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(659, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Toplam : 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::genetik_algoritma_proje.Properties.Resources.matyas;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(489, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1591, 840);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 417);
            this.panel2.TabIndex = 10;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Gainsboro;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            this.chart1.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-54, 22);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 2;
            series1.Name = "Series1";
            dataPoint1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            dataPoint1.BorderWidth = 2;
            dataPoint1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataPoint2.CustomProperties = "DrawingStyle=Cylinder";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1326, 391);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1141, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 420);
            this.panel1.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.buttonClr2);
            this.groupBox4.Controls.Add(this.buttonClr1);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.numericUpDown7);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 222);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(437, 166);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Matyas Tablo";
            // 
            // buttonClr2
            // 
            this.buttonClr2.BackColor = System.Drawing.Color.Red;
            this.buttonClr2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClr2.Location = new System.Drawing.Point(252, 102);
            this.buttonClr2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClr2.Name = "buttonClr2";
            this.buttonClr2.Size = new System.Drawing.Size(15, 19);
            this.buttonClr2.TabIndex = 5;
            this.buttonClr2.UseVisualStyleBackColor = false;
            this.buttonClr2.Click += new System.EventHandler(this.buttonClr2_Click);
            // 
            // buttonClr1
            // 
            this.buttonClr1.BackColor = System.Drawing.Color.Black;
            this.buttonClr1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClr1.ForeColor = System.Drawing.Color.Black;
            this.buttonClr1.Location = new System.Drawing.Point(252, 74);
            this.buttonClr1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClr1.Name = "buttonClr1";
            this.buttonClr1.Size = new System.Drawing.Size(15, 19);
            this.buttonClr1.TabIndex = 5;
            this.buttonClr1.UseVisualStyleBackColor = false;
            this.buttonClr1.Click += new System.EventHandler(this.buttonClr1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 100);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 22);
            this.label16.TabIndex = 3;
            this.label16.Text = "Elitizm Renk:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 72);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 22);
            this.label15.TabIndex = 3;
            this.label15.Text = "Birey Renk:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Bright", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 41);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 22);
            this.label14.TabIndex = 3;
            this.label14.Text = "Opaklık(0-255):";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown7.Location = new System.Drawing.Point(222, 43);
            this.numericUpDown7.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(45, 23);
            this.numericUpDown7.TabIndex = 4;
            this.numericUpDown7.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(437, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "X1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "X2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(43, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "11";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(43, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "22";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(6, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(437, 91);
            this.button1.TabIndex = 6;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1141, 420);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 417);
            this.panel3.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 847F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(489, 244);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1135, 404);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 7);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1602, 850);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.Red;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1629, 866);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(816, 470);
            this.Name = "Form1";
            this.Text = "Genetik Algoritma BEYZA UZUNGEL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonClr2;
        private System.Windows.Forms.Button buttonClr1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Panel panel1;
    }
}

