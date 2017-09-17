namespace AriQualityMonitoring
{
    partial class AriQualityMonitoringForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PM1_0ValLabel = new System.Windows.Forms.Label();
            this.PM1_0ValTextBox = new System.Windows.Forms.TextBox();
            this.PM1_0UnitLabel = new System.Windows.Forms.Label();
            this.PM2_5UnitLabel = new System.Windows.Forms.Label();
            this.PM2_5ValTextBox = new System.Windows.Forms.TextBox();
            this.PM2_5ValLabel = new System.Windows.Forms.Label();
            this.PM10UnitLabel = new System.Windows.Forms.Label();
            this.PM10ValTextBox = new System.Windows.Forms.TextBox();
            this.PM10ValLabel = new System.Windows.Forms.Label();
            this.PM10UnitInAirLabel = new System.Windows.Forms.Label();
            this.PM10ValInAirTextBox = new System.Windows.Forms.TextBox();
            this.PM10ValInAirLabel = new System.Windows.Forms.Label();
            this.PM2_5UnitInAirLabel = new System.Windows.Forms.Label();
            this.PM2_5ValInAirTextBox = new System.Windows.Forms.TextBox();
            this.PM2_5ValInAirLabel = new System.Windows.Forms.Label();
            this.PM1_0UnitInAirLabel = new System.Windows.Forms.Label();
            this.PM1_0ValInAirTextBox = new System.Windows.Forms.TextBox();
            this.PM1_0ValInAirLabel = new System.Windows.Forms.Label();
            this.FormaldehydeUnitLabel1 = new System.Windows.Forms.Label();
            this.FormaldehydeValTextBox = new System.Windows.Forms.TextBox();
            this.FormaldehydeValLabel2 = new System.Windows.Forms.Label();
            this.TemperatureUnitlabel = new System.Windows.Forms.Label();
            this.TemperatureValTextBox = new System.Windows.Forms.TextBox();
            this.TemperatureValLabel = new System.Windows.Forms.Label();
            this.HumidityUnitLabel = new System.Windows.Forms.Label();
            this.HumidityValTextBox = new System.Windows.Forms.TextBox();
            this.HumidityValLabel = new System.Windows.Forms.Label();
            this.StartDetectionButton = new System.Windows.Forms.Button();
            this.DebugInfoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialPortComboBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.StopDetectionButton = new System.Windows.Forms.Button();
            this.ShowChartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PM1_0ValLabel
            // 
            this.PM1_0ValLabel.AutoSize = true;
            this.PM1_0ValLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM1_0ValLabel.Location = new System.Drawing.Point(33, 37);
            this.PM1_0ValLabel.Name = "PM1_0ValLabel";
            this.PM1_0ValLabel.Size = new System.Drawing.Size(60, 22);
            this.PM1_0ValLabel.TabIndex = 0;
            this.PM1_0ValLabel.Text = "PM1.0";
            // 
            // PM1_0ValTextBox
            // 
            this.PM1_0ValTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM1_0ValTextBox.Location = new System.Drawing.Point(129, 33);
            this.PM1_0ValTextBox.Name = "PM1_0ValTextBox";
            this.PM1_0ValTextBox.ReadOnly = true;
            this.PM1_0ValTextBox.Size = new System.Drawing.Size(135, 26);
            this.PM1_0ValTextBox.TabIndex = 1;
            // 
            // PM1_0UnitLabel
            // 
            this.PM1_0UnitLabel.AutoSize = true;
            this.PM1_0UnitLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM1_0UnitLabel.Location = new System.Drawing.Point(293, 37);
            this.PM1_0UnitLabel.Name = "PM1_0UnitLabel";
            this.PM1_0UnitLabel.Size = new System.Drawing.Size(230, 22);
            this.PM1_0UnitLabel.TabIndex = 2;
            this.PM1_0UnitLabel.Text = "μg/m3 CF=1，标准颗粒物";
            // 
            // PM2_5UnitLabel
            // 
            this.PM2_5UnitLabel.AutoSize = true;
            this.PM2_5UnitLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM2_5UnitLabel.Location = new System.Drawing.Point(293, 69);
            this.PM2_5UnitLabel.Name = "PM2_5UnitLabel";
            this.PM2_5UnitLabel.Size = new System.Drawing.Size(230, 22);
            this.PM2_5UnitLabel.TabIndex = 5;
            this.PM2_5UnitLabel.Text = "μg/m3 CF=1，标准颗粒物";
            // 
            // PM2_5ValTextBox
            // 
            this.PM2_5ValTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM2_5ValTextBox.Location = new System.Drawing.Point(129, 65);
            this.PM2_5ValTextBox.Name = "PM2_5ValTextBox";
            this.PM2_5ValTextBox.ReadOnly = true;
            this.PM2_5ValTextBox.Size = new System.Drawing.Size(135, 26);
            this.PM2_5ValTextBox.TabIndex = 4;
            // 
            // PM2_5ValLabel
            // 
            this.PM2_5ValLabel.AutoSize = true;
            this.PM2_5ValLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM2_5ValLabel.Location = new System.Drawing.Point(33, 69);
            this.PM2_5ValLabel.Name = "PM2_5ValLabel";
            this.PM2_5ValLabel.Size = new System.Drawing.Size(60, 22);
            this.PM2_5ValLabel.TabIndex = 3;
            this.PM2_5ValLabel.Text = "PM2.5";
            // 
            // PM10UnitLabel
            // 
            this.PM10UnitLabel.AutoSize = true;
            this.PM10UnitLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM10UnitLabel.Location = new System.Drawing.Point(293, 101);
            this.PM10UnitLabel.Name = "PM10UnitLabel";
            this.PM10UnitLabel.Size = new System.Drawing.Size(230, 22);
            this.PM10UnitLabel.TabIndex = 8;
            this.PM10UnitLabel.Text = "μg/m3 CF=1，标准颗粒物";
            // 
            // PM10ValTextBox
            // 
            this.PM10ValTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM10ValTextBox.Location = new System.Drawing.Point(129, 97);
            this.PM10ValTextBox.Name = "PM10ValTextBox";
            this.PM10ValTextBox.ReadOnly = true;
            this.PM10ValTextBox.Size = new System.Drawing.Size(135, 26);
            this.PM10ValTextBox.TabIndex = 7;
            // 
            // PM10ValLabel
            // 
            this.PM10ValLabel.AutoSize = true;
            this.PM10ValLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM10ValLabel.Location = new System.Drawing.Point(33, 101);
            this.PM10ValLabel.Name = "PM10ValLabel";
            this.PM10ValLabel.Size = new System.Drawing.Size(50, 22);
            this.PM10ValLabel.TabIndex = 6;
            this.PM10ValLabel.Text = "PM10";
            // 
            // PM10UnitInAirLabel
            // 
            this.PM10UnitInAirLabel.AutoSize = true;
            this.PM10UnitInAirLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM10UnitInAirLabel.Location = new System.Drawing.Point(293, 197);
            this.PM10UnitInAirLabel.Name = "PM10UnitInAirLabel";
            this.PM10UnitInAirLabel.Size = new System.Drawing.Size(170, 22);
            this.PM10UnitInAirLabel.TabIndex = 17;
            this.PM10UnitInAirLabel.Text = "μg/m3 大气环境下";
            // 
            // PM10ValInAirTextBox
            // 
            this.PM10ValInAirTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM10ValInAirTextBox.Location = new System.Drawing.Point(129, 193);
            this.PM10ValInAirTextBox.Name = "PM10ValInAirTextBox";
            this.PM10ValInAirTextBox.ReadOnly = true;
            this.PM10ValInAirTextBox.Size = new System.Drawing.Size(135, 26);
            this.PM10ValInAirTextBox.TabIndex = 16;
            // 
            // PM10ValInAirLabel
            // 
            this.PM10ValInAirLabel.AutoSize = true;
            this.PM10ValInAirLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM10ValInAirLabel.Location = new System.Drawing.Point(33, 197);
            this.PM10ValInAirLabel.Name = "PM10ValInAirLabel";
            this.PM10ValInAirLabel.Size = new System.Drawing.Size(50, 22);
            this.PM10ValInAirLabel.TabIndex = 15;
            this.PM10ValInAirLabel.Text = "PM10";
            // 
            // PM2_5UnitInAirLabel
            // 
            this.PM2_5UnitInAirLabel.AutoSize = true;
            this.PM2_5UnitInAirLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM2_5UnitInAirLabel.Location = new System.Drawing.Point(293, 165);
            this.PM2_5UnitInAirLabel.Name = "PM2_5UnitInAirLabel";
            this.PM2_5UnitInAirLabel.Size = new System.Drawing.Size(170, 22);
            this.PM2_5UnitInAirLabel.TabIndex = 14;
            this.PM2_5UnitInAirLabel.Text = "μg/m3 大气环境下";
            // 
            // PM2_5ValInAirTextBox
            // 
            this.PM2_5ValInAirTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM2_5ValInAirTextBox.Location = new System.Drawing.Point(129, 161);
            this.PM2_5ValInAirTextBox.Name = "PM2_5ValInAirTextBox";
            this.PM2_5ValInAirTextBox.ReadOnly = true;
            this.PM2_5ValInAirTextBox.Size = new System.Drawing.Size(135, 26);
            this.PM2_5ValInAirTextBox.TabIndex = 13;
            // 
            // PM2_5ValInAirLabel
            // 
            this.PM2_5ValInAirLabel.AutoSize = true;
            this.PM2_5ValInAirLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM2_5ValInAirLabel.Location = new System.Drawing.Point(33, 165);
            this.PM2_5ValInAirLabel.Name = "PM2_5ValInAirLabel";
            this.PM2_5ValInAirLabel.Size = new System.Drawing.Size(60, 22);
            this.PM2_5ValInAirLabel.TabIndex = 12;
            this.PM2_5ValInAirLabel.Text = "PM2.5";
            // 
            // PM1_0UnitInAirLabel
            // 
            this.PM1_0UnitInAirLabel.AutoSize = true;
            this.PM1_0UnitInAirLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM1_0UnitInAirLabel.Location = new System.Drawing.Point(293, 133);
            this.PM1_0UnitInAirLabel.Name = "PM1_0UnitInAirLabel";
            this.PM1_0UnitInAirLabel.Size = new System.Drawing.Size(170, 22);
            this.PM1_0UnitInAirLabel.TabIndex = 11;
            this.PM1_0UnitInAirLabel.Text = "μg/m3 大气环境下";
            // 
            // PM1_0ValInAirTextBox
            // 
            this.PM1_0ValInAirTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM1_0ValInAirTextBox.Location = new System.Drawing.Point(129, 129);
            this.PM1_0ValInAirTextBox.Name = "PM1_0ValInAirTextBox";
            this.PM1_0ValInAirTextBox.ReadOnly = true;
            this.PM1_0ValInAirTextBox.Size = new System.Drawing.Size(135, 26);
            this.PM1_0ValInAirTextBox.TabIndex = 10;
            // 
            // PM1_0ValInAirLabel
            // 
            this.PM1_0ValInAirLabel.AutoSize = true;
            this.PM1_0ValInAirLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PM1_0ValInAirLabel.Location = new System.Drawing.Point(33, 133);
            this.PM1_0ValInAirLabel.Name = "PM1_0ValInAirLabel";
            this.PM1_0ValInAirLabel.Size = new System.Drawing.Size(60, 22);
            this.PM1_0ValInAirLabel.TabIndex = 9;
            this.PM1_0ValInAirLabel.Text = "PM1.0";
            // 
            // FormaldehydeUnitLabel1
            // 
            this.FormaldehydeUnitLabel1.AutoSize = true;
            this.FormaldehydeUnitLabel1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaldehydeUnitLabel1.Location = new System.Drawing.Point(293, 229);
            this.FormaldehydeUnitLabel1.Name = "FormaldehydeUnitLabel1";
            this.FormaldehydeUnitLabel1.Size = new System.Drawing.Size(60, 22);
            this.FormaldehydeUnitLabel1.TabIndex = 20;
            this.FormaldehydeUnitLabel1.Text = "mg/m³";
            // 
            // FormaldehydeValTextBox
            // 
            this.FormaldehydeValTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaldehydeValTextBox.Location = new System.Drawing.Point(129, 225);
            this.FormaldehydeValTextBox.Name = "FormaldehydeValTextBox";
            this.FormaldehydeValTextBox.ReadOnly = true;
            this.FormaldehydeValTextBox.Size = new System.Drawing.Size(135, 26);
            this.FormaldehydeValTextBox.TabIndex = 19;
            // 
            // FormaldehydeValLabel2
            // 
            this.FormaldehydeValLabel2.AutoSize = true;
            this.FormaldehydeValLabel2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaldehydeValLabel2.Location = new System.Drawing.Point(33, 229);
            this.FormaldehydeValLabel2.Name = "FormaldehydeValLabel2";
            this.FormaldehydeValLabel2.Size = new System.Drawing.Size(50, 22);
            this.FormaldehydeValLabel2.TabIndex = 18;
            this.FormaldehydeValLabel2.Text = "甲醛";
            // 
            // TemperatureUnitlabel
            // 
            this.TemperatureUnitlabel.AutoSize = true;
            this.TemperatureUnitlabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureUnitlabel.Location = new System.Drawing.Point(293, 261);
            this.TemperatureUnitlabel.Name = "TemperatureUnitlabel";
            this.TemperatureUnitlabel.Size = new System.Drawing.Size(25, 22);
            this.TemperatureUnitlabel.TabIndex = 23;
            this.TemperatureUnitlabel.Text = "℃";
            // 
            // TemperatureValTextBox
            // 
            this.TemperatureValTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureValTextBox.Location = new System.Drawing.Point(129, 257);
            this.TemperatureValTextBox.Name = "TemperatureValTextBox";
            this.TemperatureValTextBox.ReadOnly = true;
            this.TemperatureValTextBox.Size = new System.Drawing.Size(135, 26);
            this.TemperatureValTextBox.TabIndex = 22;
            // 
            // TemperatureValLabel
            // 
            this.TemperatureValLabel.AutoSize = true;
            this.TemperatureValLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureValLabel.Location = new System.Drawing.Point(33, 261);
            this.TemperatureValLabel.Name = "TemperatureValLabel";
            this.TemperatureValLabel.Size = new System.Drawing.Size(50, 22);
            this.TemperatureValLabel.TabIndex = 21;
            this.TemperatureValLabel.Text = "温度";
            // 
            // HumidityUnitLabel
            // 
            this.HumidityUnitLabel.AutoSize = true;
            this.HumidityUnitLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityUnitLabel.Location = new System.Drawing.Point(293, 293);
            this.HumidityUnitLabel.Name = "HumidityUnitLabel";
            this.HumidityUnitLabel.Size = new System.Drawing.Size(60, 22);
            this.HumidityUnitLabel.TabIndex = 26;
            this.HumidityUnitLabel.Text = "mg/m³";
            // 
            // HumidityValTextBox
            // 
            this.HumidityValTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityValTextBox.Location = new System.Drawing.Point(129, 289);
            this.HumidityValTextBox.Name = "HumidityValTextBox";
            this.HumidityValTextBox.ReadOnly = true;
            this.HumidityValTextBox.Size = new System.Drawing.Size(135, 26);
            this.HumidityValTextBox.TabIndex = 25;
            // 
            // HumidityValLabel
            // 
            this.HumidityValLabel.AutoSize = true;
            this.HumidityValLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityValLabel.Location = new System.Drawing.Point(33, 293);
            this.HumidityValLabel.Name = "HumidityValLabel";
            this.HumidityValLabel.Size = new System.Drawing.Size(50, 22);
            this.HumidityValLabel.TabIndex = 24;
            this.HumidityValLabel.Text = "湿度";
            // 
            // StartDetectionButton
            // 
            this.StartDetectionButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDetectionButton.Location = new System.Drawing.Point(325, 341);
            this.StartDetectionButton.Name = "StartDetectionButton";
            this.StartDetectionButton.Size = new System.Drawing.Size(92, 38);
            this.StartDetectionButton.TabIndex = 27;
            this.StartDetectionButton.Text = "开始检测";
            this.StartDetectionButton.UseVisualStyleBackColor = true;
            this.StartDetectionButton.Click += new System.EventHandler(this.StartDetectionButton_Click);
            // 
            // DebugInfoTextBox
            // 
            this.DebugInfoTextBox.Location = new System.Drawing.Point(37, 407);
            this.DebugInfoTextBox.Multiline = true;
            this.DebugInfoTextBox.Name = "DebugInfoTextBox";
            this.DebugInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugInfoTextBox.Size = new System.Drawing.Size(465, 205);
            this.DebugInfoTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "端口";
            // 
            // SerialPortComboBox
            // 
            this.SerialPortComboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialPortComboBox.FormattingEnabled = true;
            this.SerialPortComboBox.Location = new System.Drawing.Point(129, 348);
            this.SerialPortComboBox.Name = "SerialPortComboBox";
            this.SerialPortComboBox.Size = new System.Drawing.Size(135, 27);
            this.SerialPortComboBox.TabIndex = 30;
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 2048;
            // 
            // StopDetectionButton
            // 
            this.StopDetectionButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopDetectionButton.Location = new System.Drawing.Point(431, 341);
            this.StopDetectionButton.Name = "StopDetectionButton";
            this.StopDetectionButton.Size = new System.Drawing.Size(92, 38);
            this.StopDetectionButton.TabIndex = 31;
            this.StopDetectionButton.Text = "停止检测";
            this.StopDetectionButton.UseVisualStyleBackColor = true;
            this.StopDetectionButton.Click += new System.EventHandler(this.StopDetectionButton_Click);
            // 
            // ShowChartButton
            // 
            this.ShowChartButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowChartButton.Location = new System.Drawing.Point(431, 276);
            this.ShowChartButton.Name = "ShowChartButton";
            this.ShowChartButton.Size = new System.Drawing.Size(92, 39);
            this.ShowChartButton.TabIndex = 32;
            this.ShowChartButton.Text = "显示图表";
            this.ShowChartButton.UseVisualStyleBackColor = true;
            this.ShowChartButton.Click += new System.EventHandler(this.ShowChartButton_Click);
            // 
            // AriQualityMonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 624);
            this.Controls.Add(this.ShowChartButton);
            this.Controls.Add(this.StopDetectionButton);
            this.Controls.Add(this.SerialPortComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DebugInfoTextBox);
            this.Controls.Add(this.StartDetectionButton);
            this.Controls.Add(this.HumidityUnitLabel);
            this.Controls.Add(this.HumidityValTextBox);
            this.Controls.Add(this.HumidityValLabel);
            this.Controls.Add(this.TemperatureUnitlabel);
            this.Controls.Add(this.TemperatureValTextBox);
            this.Controls.Add(this.TemperatureValLabel);
            this.Controls.Add(this.FormaldehydeUnitLabel1);
            this.Controls.Add(this.FormaldehydeValTextBox);
            this.Controls.Add(this.FormaldehydeValLabel2);
            this.Controls.Add(this.PM10UnitInAirLabel);
            this.Controls.Add(this.PM10ValInAirTextBox);
            this.Controls.Add(this.PM10ValInAirLabel);
            this.Controls.Add(this.PM2_5UnitInAirLabel);
            this.Controls.Add(this.PM2_5ValInAirTextBox);
            this.Controls.Add(this.PM2_5ValInAirLabel);
            this.Controls.Add(this.PM1_0UnitInAirLabel);
            this.Controls.Add(this.PM1_0ValInAirTextBox);
            this.Controls.Add(this.PM1_0ValInAirLabel);
            this.Controls.Add(this.PM10UnitLabel);
            this.Controls.Add(this.PM10ValTextBox);
            this.Controls.Add(this.PM10ValLabel);
            this.Controls.Add(this.PM2_5UnitLabel);
            this.Controls.Add(this.PM2_5ValTextBox);
            this.Controls.Add(this.PM2_5ValLabel);
            this.Controls.Add(this.PM1_0UnitLabel);
            this.Controls.Add(this.PM1_0ValTextBox);
            this.Controls.Add(this.PM1_0ValLabel);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AriQualityMonitoringForm";
            this.Text = "AriQualityMonitoring";
            this.Load += new System.EventHandler(this.AriQualityMonitoringForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PM1_0ValLabel;
        private System.Windows.Forms.TextBox PM1_0ValTextBox;
        private System.Windows.Forms.Label PM1_0UnitLabel;
        private System.Windows.Forms.Label PM2_5UnitLabel;
        private System.Windows.Forms.TextBox PM2_5ValTextBox;
        private System.Windows.Forms.Label PM2_5ValLabel;
        private System.Windows.Forms.Label PM10UnitLabel;
        private System.Windows.Forms.TextBox PM10ValTextBox;
        private System.Windows.Forms.Label PM10ValLabel;
        private System.Windows.Forms.Label PM10UnitInAirLabel;
        private System.Windows.Forms.TextBox PM10ValInAirTextBox;
        private System.Windows.Forms.Label PM10ValInAirLabel;
        private System.Windows.Forms.Label PM2_5UnitInAirLabel;
        private System.Windows.Forms.TextBox PM2_5ValInAirTextBox;
        private System.Windows.Forms.Label PM2_5ValInAirLabel;
        private System.Windows.Forms.Label PM1_0UnitInAirLabel;
        private System.Windows.Forms.TextBox PM1_0ValInAirTextBox;
        private System.Windows.Forms.Label PM1_0ValInAirLabel;
        private System.Windows.Forms.Label FormaldehydeUnitLabel1;
        private System.Windows.Forms.TextBox FormaldehydeValTextBox;
        private System.Windows.Forms.Label FormaldehydeValLabel2;
        private System.Windows.Forms.Label TemperatureUnitlabel;
        private System.Windows.Forms.TextBox TemperatureValTextBox;
        private System.Windows.Forms.Label TemperatureValLabel;
        private System.Windows.Forms.Label HumidityUnitLabel;
        private System.Windows.Forms.TextBox HumidityValTextBox;
        private System.Windows.Forms.Label HumidityValLabel;
        private System.Windows.Forms.Button StartDetectionButton;
        private System.Windows.Forms.TextBox DebugInfoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SerialPortComboBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button StopDetectionButton;
        private System.Windows.Forms.Button ShowChartButton;
    }
}

