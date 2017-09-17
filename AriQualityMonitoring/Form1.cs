using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;

namespace AriQualityMonitoring
{
    public partial class AriQualityMonitoringForm : Form
    {

        delegate void DelegateAppendText(string text);
        delegate void DelegateTextClear();

        private int PM1_0Val = 0;
        private int PM2_5Val = 0;
        private int PM10Val = 0;
        private int PM1_0ValInAir = 0;
        private int PM2_5ValInAir = 0;
        private int PM10ValInAir = 0;
        private double FormaldehydeVal = 0;
        private double TemperatureVal = 0;
        private double HumidityVal = 0;
        public AriQualityMonitoringForm()
        {
            InitializeComponent();
        }
        //public class AirQualityValueEventArgs : EventArgs
        //{

        //    public AirQualityValueEventArgs(string CHumidityValueArgs)
        //    {
        //        this.HumidityValueArgs = CHumidityValueArgs;
        //    }
        //    public string HumidityValueArgs { get; private set; }
        //}
        //public class AirQualityValueInfo
        //{
        //    public event EventHandler<AirQualityValueEventArgs> NewHumidityValueArgsInfo;

        //    public void AirQualityValueUpdata(string CHumidityValueArgs)
        //    {
        //        RaiseAirQualityValueInfo(CHumidityValueArgs);
        //    }

        //    protected virtual void RaiseAirQualityValueInfo(string CHumidityValueArgs)
        //    {
        //        EventHandler<AirQualityValueEventArgs> AirQualityValueInfo = NewHumidityValueArgsInfo;
        //        if (AirQualityValueInfo != null)
        //        {
        //            AirQualityValueInfo(this, new AirQualityValueEventArgs(CHumidityValueArgs));
        //        }
        //    }

        //}


        public double PM2_5Value()
        {
            return PM2_5Val;
        }

        public double FormaldehydeValue()
        {
            return FormaldehydeVal;
        }

        public double TemperatureValue()
        {
            return TemperatureVal;
        }
        public double HumidityValue()
        {
            return HumidityVal;
        }
        private void AriQualityMonitoringForm_Load(object sender, EventArgs e)
        {
            SerialPortComboBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.DiscardNull = false;
            serialPort1.DtrEnable = false;
            serialPort1.Handshake = Handshake.None;
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.ParityReplace = Convert.ToByte("63");
            serialPort1.RtsEnable = false;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            // serialPort1.ReadTimeout = -1;
            // serialPort1.PortName = SerialPortComboBox.Text.ToString();
            

        }
        private List<byte> SerialDataList = new List<byte>(2048);
        public void SerialDataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                DelegateAppendText DebugInfoAppendText = new DelegateAppendText(DebugInfoTextBox.AppendText);
                
                DelegateAppendText PM1_0ValAppendText = new DelegateAppendText(PM1_0ValTextBox.AppendText); //PM1.0 窗口显示的方法
                DelegateTextClear PM1_0ValClearText = new DelegateTextClear(PM1_0ValTextBox.Clear);

                DelegateAppendText PM2_5ValAppendText = new DelegateAppendText(PM2_5ValTextBox.AppendText); //PM2.5 窗口显示的方法
                DelegateTextClear PM2_5ValClearText = new DelegateTextClear(PM2_5ValTextBox.Clear);

                DelegateAppendText PM10ValAppendText = new DelegateAppendText(PM10ValTextBox.AppendText); //PM10 窗口显示的方法
                DelegateTextClear PM10ValClearText = new DelegateTextClear(PM10ValTextBox.Clear);

                DelegateAppendText PM1_0ValInAirAppendText = new DelegateAppendText(PM1_0ValInAirTextBox.AppendText); //PM1.0 InAir窗口显示的方法
                DelegateTextClear PM1_0ValInAirClearText = new DelegateTextClear(PM1_0ValInAirTextBox.Clear);

                DelegateAppendText PM2_5ValInAirAppendText = new DelegateAppendText(PM2_5ValInAirTextBox.AppendText); //PM2.5 InAir 窗口显示的方法
                DelegateTextClear PM2_5ValInAirClearText = new DelegateTextClear(PM2_5ValInAirTextBox.Clear);

                DelegateAppendText PM10ValInAirAppendText = new DelegateAppendText(PM10ValInAirTextBox.AppendText); //PM10 InAir 窗口显示的方法
                DelegateTextClear PM10ValInAirClearText = new DelegateTextClear(PM10ValInAirTextBox.Clear);

                DelegateAppendText FormaldehydeValAppendText = new DelegateAppendText(FormaldehydeValTextBox.AppendText); //甲醛 窗口显示的方法
                DelegateTextClear FormaldehydeValClearText = new DelegateTextClear(FormaldehydeValTextBox.Clear);

                DelegateAppendText TemperatureValAppendText = new DelegateAppendText(TemperatureValTextBox.AppendText); //温度 窗口显示的方法
                DelegateTextClear TemperatureValClearText = new DelegateTextClear(TemperatureValTextBox.Clear);

                DelegateAppendText HumidityValAppendText = new DelegateAppendText(HumidityValTextBox.AppendText); //湿度 窗口显示的方法
                DelegateTextClear HumidityValClearText = new DelegateTextClear(HumidityValTextBox.Clear);
                //Comm.BytesToRead中为要读入的字节长度

                int len = serialPort1.BytesToRead;
                byte[] readBuffer = new byte[len];
                int checksum = 0;
                int ReciveCheckData = 0;

                


                serialPort1.Read(readBuffer, 0, len);   //将数据读入缓存

                SerialDataList.AddRange(readBuffer);    //将读到的数据放到数据链表中
                
                while (SerialDataList.Count >= 4)       //判断大于不定长协议头的最小长度
                {
                    if ((SerialDataList[0] == 0x42) && (SerialDataList[1] == 0x4d))     //判断协议头
                    {
                        int SerialDatalen = (SerialDataList[2] << 8) + SerialDataList[3];     //取出协议长度
                        //DebugInfoTextBox.Invoke(DebugInfoAppendText, "SerialDatalen" + SerialDatalen.ToString() + "\n");
                        if (SerialDataList.Count < SerialDatalen + 4)                           //说明协议未收集全，退出循环重新收集
                        {
                            //说明数据没有收集完整
                            break;
                        }
                        for (int i = 0; i < SerialDatalen + 4 - 2; i++)      //校验和
                        {
                            checksum += SerialDataList[i];
                            
                        }
                        //checksum &= 0x0000ffff;
                        ReciveCheckData = (SerialDataList[SerialDatalen + 2] << 8) + SerialDataList[SerialDatalen + 3];
                        //ReciveCheckData &= 0x0000ffff;
                        if (checksum != ReciveCheckData)
                        {
                            SerialDataList.RemoveRange(0, SerialDatalen + 4);
                            DebugInfoTextBox.Invoke(DebugInfoAppendText, "数据包校验不正确 !!\n");
                            //break;
                            continue;       //这里需要验证应该要用break;
                        }
                        else
                        {
                            //for (int i = 0; i < SerialDatalen + 4; i++)
                            //{
                            //    DebugInfoTextBox.Invoke(DebugInfoAppendText, SerialDataList[i].ToString() + ";");
                            //}
                            //DebugInfoTextBox.Invoke(DebugInfoAppendText, "\n");


                            PM1_0Val = (SerialDataList[4] << 8) + SerialDataList[5];
                            PM1_0ValTextBox.Invoke(PM1_0ValClearText);
                            PM1_0ValTextBox.Invoke(PM1_0ValAppendText, PM1_0Val.ToString());

                            PM2_5Val = (SerialDataList[6] << 8) + SerialDataList[7];
                            PM2_5ValTextBox.Invoke(PM2_5ValClearText);
                            PM2_5ValTextBox.Invoke(PM2_5ValAppendText, PM2_5Val.ToString());

                            PM10Val = (SerialDataList[8] << 8) + SerialDataList[9];
                            PM10ValTextBox.Invoke(PM10ValClearText);
                            PM10ValTextBox.Invoke(PM10ValAppendText, PM10Val.ToString());

                            PM1_0ValInAir = (SerialDataList[10] << 8) + SerialDataList[11];
                            PM1_0ValInAirTextBox.Invoke(PM1_0ValInAirClearText);
                            PM1_0ValInAirTextBox.Invoke(PM1_0ValInAirAppendText, PM1_0ValInAir.ToString());

                            PM2_5ValInAir = (SerialDataList[12] << 8) + SerialDataList[13];
                            PM2_5ValInAirTextBox.Invoke(PM2_5ValInAirClearText);
                            PM2_5ValInAirTextBox.Invoke(PM2_5ValInAirAppendText, PM2_5ValInAir.ToString());

                            PM10ValInAir = (SerialDataList[14] << 8) + SerialDataList[15];
                            PM10ValInAirTextBox.Invoke(PM10ValInAirClearText);
                            PM10ValInAirTextBox.Invoke(PM10ValInAirAppendText, PM10ValInAir.ToString());

                            FormaldehydeVal = ((double)((SerialDataList[28] << 8) + SerialDataList[29]))/1000;
                            FormaldehydeValTextBox.Invoke(FormaldehydeValClearText);
                            FormaldehydeValTextBox.Invoke(FormaldehydeValAppendText, FormaldehydeVal.ToString());

                            TemperatureVal = ((double)((SerialDataList[30] << 8) + SerialDataList[31]))/10;
                            TemperatureValTextBox.Invoke(TemperatureValClearText);
                            TemperatureValTextBox.Invoke(TemperatureValAppendText, TemperatureVal.ToString());

                            HumidityVal = ((double)((SerialDataList[32] << 8) + SerialDataList[33]))/10;
                            HumidityValTextBox.Invoke(HumidityValClearText);
                            HumidityValTextBox.Invoke(HumidityValAppendText, HumidityVal.ToString());

                            //执行解析代码
                            SerialDataList.RemoveRange(0, SerialDatalen + 4);
                        }



                    }
                    else   //清除错误帧头
                    {
                        SerialDataList.RemoveAt(0);
                    }
                }


                
                //DebugInfoTextBox.Invoke(DebugInfoAppendText, len.ToString() + ":");

                //for (int i = 0; i < len; i++)
                //{
                //    DebugInfoTextBox.Invoke(DebugInfoAppendText, readBuffer[i].ToString() + ";");
                //}
                //DebugInfoTextBox.Invoke(DebugInfoAppendText, "\n");

            }
            catch (Exception ex)
            {
                MessageBox.Show("提示信息,接收返回消息异常！具体原因：" + ex.Message);
            }
        }        
        private void StartDetectionButton_Click(object sender, EventArgs e)
        {

            
            if (SerialPortComboBox.Text.ToString() == "")
            {
                MessageBox.Show("端口号不能为空");
                return;
            }
            serialPort1.PortName = SerialPortComboBox.Text.ToString();
            //serialPort1.Open();
            try
            {
                serialPort1.ReceivedBytesThreshold = 1; //串口读到有一个字节时触发事件
                serialPort1.Open(); //打开串口
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived); //设置数据接收事件（监听）
                    StartDetectionButton.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("提示信息 ,串行端口打开失败！具体原因：" + ex.Message);
                System.Environment.Exit(0); //彻底退出应用程序   
            }

        }

        private void StopDetectionButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                serialPort1.DataReceived -= new SerialDataReceivedEventHandler(SerialDataReceived);
                StartDetectionButton.Enabled = true;
            }
        }

        private void ShowChartButton_Click(object sender, EventArgs e)
        {
            ChartForm ChartWinForm = new ChartForm();
            ChartWinForm.Show();
        }
    }
}
