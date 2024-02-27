using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EasyModbus;
using NPOI.HSSF.Record.Chart;

using MQTTnet;
using MQTTnet.Client;


namespace FireMon_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region makeHeader
            {
                MakeHeader_machine();
                MakeHeader_tem();
                MakeHeader_gas();
            }
            #endregion
            timer1.Tick += timer1_Tick;
            timer1.Interval = 100;

            
            chart1.Series.Clear();
            Series text1 = chart1.Series.Add(" ");
            text1.ChartType = SeriesChartType.Spline;
            text1.BorderWidth = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd-HH:mm:ss";
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.Legends.Clear();

            chart2.Series.Clear();
            Series text2 = chart2.Series.Add(" ");
            text2.ChartType = SeriesChartType.Spline;
            text2.BorderWidth = 1;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 100;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd-HH:mm:ss";
            chart2.Series[0].XValueType = ChartValueType.DateTime;
            chart2.Legends.Clear();
            
            max_gas = 0;
            max_tem = 0;
            btn_Connect.PerformClick();
            this.WindowState = FormWindowState.Minimized;
        }
        private void MakeHeader_machine()
        {
            #region Setting_ListView
            {
                MachineData_listView.Items.Clear();
                MachineData_listView.Columns.Add("Addr");
                MachineData_listView.Columns.Add("설명");
                MachineData_listView.Columns.Add("Value");
                ListViewItem li;
                li = new ListViewItem("0");
                li.SubItems.Add("화재대표");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("1");
                li.SubItems.Add("가스대표");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("2");
                li.SubItems.Add("감시대표");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("3");
                li.SubItems.Add("이상대표");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("4");
                li.SubItems.Add("예비전원이상");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("5");
                li.SubItems.Add("발신기");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("6");
                li.SubItems.Add("전화");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("7");
                li.SubItems.Add("교류전원사용");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("8");
                li.SubItems.Add("예비전원사용");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("9");
                li.SubItems.Add("예비전원시험");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("10");
                li.SubItems.Add("주음향정지");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("11");
                li.SubItems.Add("기타음향정지");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("12");
                li.SubItems.Add("축적설정");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("13");
                li.SubItems.Add("자동복구설정");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("14");
                li.SubItems.Add("수신기복구중");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S1");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S2");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S3");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S4");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S5");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S6");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S7");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S8");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S9");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S10");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S11");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S12");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S13");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                li = new ListViewItem("15");
                li.SubItems.Add("연동정지 S14");
                li.SubItems.Add("");
                MachineData_listView.Items.Add(li);
                MachineData_listView.GridLines = true;
            }
            #endregion
        }
        private void MakeHeader_gas()
        {
            #region Setting_ListView
            {
                GasData_listView.Items.Clear();
                GasData_listView.Columns.Add("Addr");
                GasData_listView.Columns.Add("중계기");
                GasData_listView.Columns.Add("Value");
                GasData_listView.Columns.Add("타입");
                GasData_listView.Columns.Add("값");
                GasData_listView.Columns[3].Width = 100;
                for (int i = 0; i < 10; i++)
                {
                    ListViewItem li = new ListViewItem("");
                    li.SubItems.Add("");
                    li.SubItems.Add("");
                    li.SubItems.Add("");
                    li.SubItems.Add("");
                    GasData_listView.Items.Add(li);
                }
                GasData_listView.GridLines = true;
            }
            #endregion
        }
        private void MakeHeader_tem()
        {
            #region Setting_ListView
            {
                TemData_listView.Items.Clear();
                TemData_listView.Columns.Add("Addr");
                TemData_listView.Columns.Add("중계기");
                TemData_listView.Columns.Add("Value");
                TemData_listView.Columns.Add("타입");
                TemData_listView.Columns.Add("값");
                TemData_listView.Columns[3].Width = 100;
                for (int i = 0; i < 10; i++)
                {
                    ListViewItem li = new ListViewItem("");
                    li.SubItems.Add("");
                    li.SubItems.Add("");
                    li.SubItems.Add("");
                    li.SubItems.Add("");
                    TemData_listView.Items.Add(li);
                }

                TemData_listView.GridLines = true;
            }
            #endregion
        }
        ModbusClient modbus = null;

        double max_gas = 0;
        double max_tem = 0;
        int countnum = 0;
        string sendmsg = "";
        
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            String IP = txt_ip.Text.Trim();
            int PORT = Int32.Parse(txt_port.Text.Trim());

            try
            {
                #region Connect
                {
                    if (modbus != null)
                        modbus.Disconnect();

                    modbus = new ModbusClient(IP, PORT);
                    modbus.Connect();
                    btn_Connect.BackColor = Color.Lime;
                }
                #endregion

                if (timer1.Enabled)
                    timer1.Stop();

                timer1.Start();

                Thread_Status_APC();
            }
            catch
            {
                btn_Connect.BackColor = Color.Red;
            }
        }

        Thread Thread_Status = null;
        bool Thread_Status_Flag = false;
        public void Thread_Status_APC()
        {
            Thread_Status_Close();
            Thread_Status_Flag = true;
            Thread_Status = new Thread(delegate () { Thread_Status_Proc(); });
            //Thread_Status.Priority = ThreadPriority.Highest;
            Thread_Status.Start();
        }
        public void Thread_Status_Close()
        {
            if (Thread_Status_Flag == true)
            {
                Thread_Status_Flag = false;
                if (!(Thread_Status == null))
                {
                    //Thread_Status.Join(1500);
                    Thread_Status.Abort();
                    Thread_Status = null;
                }
            }
        }
        public void Thread_Status_Proc()
        {
            bool[] b_coils = new bool[29];
           
            /*
            var mqttClient2 = new MqttFactory().CreateMqttClient();
            var options = new MqttClientOptionsBuilder().WithTcpServer("smarthousing.tnmiot.co.kr", 1883).WithCredentials("smart", "smart1234").Build();
            mqttClient2.ConnectAsync(options, CancellationToken.None);
            */

            while (Thread_Status_Flag)
            {
                //Thread.Sleep(3000);   continue;
                try
                {
                    #region Machine
                    bool[] coils = modbus.ReadCoils(0x0000, 29);
                    for (int i = 0; i < coils.Length; i++)
                    {
                        if (b_coils[i] != coils[i])
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                if (coils[i] == true)
                                    MachineData_listView.Items[i].SubItems[2].Text = "True";
                                else
                                    MachineData_listView.Items[i].SubItems[2].Text = "";
                            }));
                        }
                        b_coils[i] = coils[i];
                    }
                    #endregion

                    #region Data
                    {
                        int loop = 1;
                        int addr = 1;

                        if (loop == 0 || addr == 0)
                            throw new System.Exception();


                        int idx = 1000 + ((loop - 1) * 2000);
                        idx += ((addr - 1) * 4);

                        //int[] InputRegister2 = modbus.ReadInputRegisters(999 , 60);

                        int[] InputRegister = modbus.ReadInputRegisters(idx, 80);
                        double max_gas_one = 0;
                        double max_tem_one = 0;

                        for (int i = 0; i < InputRegister.Length; i++)
                        {
                            int _idx = idx - ((loop - 1) * 2000) - 1000 + i;
                            int _addr = _idx / 4 + 1;
                            int _ch = _idx % 4 + 1;
                            string REPEATER = loop.ToString("00") + "-" + _addr.ToString("000") + "-" + _ch.ToString();

                            int type = InputRegister[i] >> 12;
                            int analog_value = InputRegister[i] & 0x0FFF;

                            string str_type = "";
                            if (type == 1) str_type = "I/O 중계기";
                            else if (type == 2) str_type = i.ToString() + "연기 감지기" ;
                            else if (type == 3) str_type = i.ToString() + "온도 감지기";
                            else if (type == 4) str_type = "전원반";

                            string str_analog_value = "";
                            if (analog_value > 0)
                            {
                                double temp = ((double)analog_value / 10.0);
                                if (type == 2)
                                {
                                    if (max_gas_one < temp)
                                        max_gas_one = temp;
                                }
                                else if (type == 3)
                                {
                                    if (max_tem_one < temp)
                                        max_tem_one = temp;
                                }
                                str_analog_value = ((double)analog_value / 10.0).ToString("0.0");
                            }
                            if(str_analog_value == "")
                            {
                                str_analog_value = "0.0";
                            }
                            if (countnum >= 300) {
                                Application.ExitThread();
                                Environment.Exit(0);
                            }
                            if (i == 52) { countnum++; }
                            if (i == 20)
                            {
                                sendmsg = "{\"complex_tag\": \"3611025022SR\",\"building_in_complex\": \"B01\",\"floor_in_complex\": \"F02\",\"home_in_complex\": \"H01\",\"space_class\": \"0\",\"device_info\": [{\"device_id\": \"sensor_smoke\",\"device_type\": \"C01\",\"data_type\": \"0\",\"install_location\": \"living\",\"msg_data\": [{\"field_name\": \"timestamp\",\"field_value\": \"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\",\"field_type\": \"string\"},{\"field_name\": \"smoke\",\"field_value\": \""+str_analog_value+"\",\"field_type\": \"string\"}]}]}";
                                Sendmqtt(sendmsg);
                                
                                //var message = new MqttApplicationMessageBuilder().WithTopic("/REGISTER/T36110325809166/THR/TF01/normal").WithPayload(sendmsg).Build();
                                //mqttClient2.PublishAsync(message);
                            }

                            if (i == 24)
                            {
                                sendmsg = "{\"complex_tag\": \"3611025022SR\",\"building_in_complex\": \"B01\",\"floor_in_complex\": \"F02\",\"home_in_complex\": \"H01\",\"space_class\": \"0\",\"device_info\": [{\"device_id\": \"sensor_smoke\",\"device_type\": \"C01\",\"data_type\": \"0\",\"install_location\": \"kitchen\",\"msg_data\": [{\"field_name\": \"timestamp\",\"field_value\": \"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\",\"field_type\": \"string\"},{\"field_name\": \"smoke\",\"field_value\": \"" + str_analog_value + "\",\"field_type\": \"string\"}]}]}";
                                Sendmqtt(sendmsg);

                                //var message1 = new MqttApplicationMessageBuilder().WithTopic("/REGISTER/T36110325809166/THR/TF01/normal").WithPayload(sendmsg).Build();
                                //mqttClient2.PublishAsync(message1);
                            }

                            if (i == 28)
                            {
                                sendmsg = "{\"complex_tag\": \"3611025022SR\",\"building_in_complex\": \"B01\",\"floor_in_complex\": \"F02\",\"home_in_complex\": \"H01\",\"space_class\": \"0\",\"device_info\": [{\"device_id\": \"sensor_smoke\",\"device_type\": \"C01\",\"data_type\": \"0\",\"install_location\": \"bedroom1\",\"msg_data\": [{\"field_name\": \"timestamp\",\"field_value\": \"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\",\"field_type\": \"string\"},{\"field_name\": \"smoke\",\"field_value\": \"" + str_analog_value + "\",\"field_type\": \"string\"}]}]}";
                                Sendmqtt(sendmsg);

                                //var message2 = new MqttApplicationMessageBuilder().WithTopic("/REGISTER/T36110325809166/THR/TF01/normal").WithPayload(sendmsg).Build();
                                //mqttClient2.PublishAsync(message2);
                            }

                             if (i == 44)
                            {
                                sendmsg = "{\"complex_tag\": \"3611025022SR\",\"building_in_complex\": \"B01\",\"floor_in_complex\": \"F02\",\"home_in_complex\": \"H01\",\"space_class\": \"0\",\"device_info\": [{\"device_id\": \"sensor_heat\",\"device_type\": \"C07\",\"data_type\": \"0\",\"install_location\": \"bedroom2\",\"msg_data\": [{\"field_name\": \"timestamp\",\"field_value\": \"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\",\"field_type\": \"string\"},{\"field_name\": \"heat\",\"field_value\": \"" + str_analog_value + "\",\"field_type\": \"string\"}]}]}";
                                Sendmqtt(sendmsg);

                                //var message3 = new MqttApplicationMessageBuilder().WithTopic("/REGISTER/T36110325809166/THR/TF01/normal").WithPayload(sendmsg).Build();
                                //mqttClient2.PublishAsync(message3);
                            }

                            if (i == 48)
                            {
                                sendmsg = "{\"complex_tag\": \"3611025022SR\",\"building_in_complex\": \"B01\",\"floor_in_complex\": \"F02\",\"home_in_complex\": \"H01\",\"space_class\": \"0\",\"device_info\": [{\"device_id\": \"sensor_heat\",\"device_type\": \"C07\",\"data_type\": \"0\",\"install_location\": \"bedroom3\",\"msg_data\": [{\"field_name\": \"timestamp\",\"field_value\": \"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\",\"field_type\": \"string\"},{\"field_name\": \"heat\",\"field_value\": \"" + str_analog_value + "\",\"field_type\": \"string\"}]}]}";
                                Sendmqtt(sendmsg);

                                //var message4 = new MqttApplicationMessageBuilder().WithTopic("/REGISTER/T36110325809166/THR/TF01/normal").WithPayload(sendmsg).Build();
                                //mqttClient2.PublishAsync(message4);
                            }

                            
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                if ((i % 4) == 0)
                                    NewMethod(idx, InputRegister, i, REPEATER, type, analog_value, str_type, str_analog_value);
                            }));
                        }
                        max_gas = max_gas_one;
                        max_tem = max_tem_one;
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                        }));
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    Console.WriteLine("err");
                    Application.ExitThread();
                }
                Thread.Sleep(1000);
            }
        }

        private void NewMethod(int idx, int[] InputRegister, int i, string REPEATER, int type, int analog_value, string str_type, string str_analog_value)
        {
            if (type == 2)
            {
                int row = i / 4;
                GasData_listView.Items[row].SubItems[0].Text = (idx + i).ToString();
                GasData_listView.Items[row].SubItems[1].Text = REPEATER;
                GasData_listView.Items[row].SubItems[2].Text = string.Format("0x{0:X4}", InputRegister[i]);
                GasData_listView.Items[row].SubItems[3].Text = str_type;
                GasData_listView.Items[row].SubItems[4].Text = str_analog_value;
                if (((double)analog_value / 10.0) >= 15.0)
                    GasData_listView.Items[row].BackColor = Color.Red;
                else if (((double)analog_value / 10.0) >= 5.0)
                    GasData_listView.Items[row].BackColor = Color.Yellow;
                else
                    GasData_listView.Items[row].BackColor = Color.White;
            }
            else if (type == 3)
            {
                int row = i / 4 - 10;
                TemData_listView.Items[row].SubItems[0].Text = (idx + i).ToString();
                TemData_listView.Items[row].SubItems[1].Text = REPEATER;
                TemData_listView.Items[row].SubItems[2].Text = string.Format("0x{0:X4}", InputRegister[i]);
                TemData_listView.Items[row].SubItems[3].Text = str_type;
                TemData_listView.Items[row].SubItems[4].Text = str_analog_value;
                double threshold_temp = 50.0;
                double threshold_danger = 70.0;

                if (((double)analog_value / 10.0) >= threshold_danger)
                    TemData_listView.Items[row].BackColor = Color.Red;
                else if (((double)analog_value / 10.0) >= threshold_temp)
                    TemData_listView.Items[row].BackColor = Color.Yellow;
                else
                    TemData_listView.Items[row].BackColor = Color.White;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thread_Status_Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            chart1.Series[0].Points.AddXY(now, max_gas);
            chart2.Series[0].Points.AddXY(now, max_tem);
            chart1.ChartAreas[0].AxisX.Minimum = now.AddSeconds(-10).ToOADate();
            chart2.ChartAreas[0].AxisX.Minimum = now.AddSeconds(-10).ToOADate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        
        async void Sendmqtt(string mqttmsg)
        {
            try
            {
                var mqttClient = new MqttFactory().CreateMqttClient();

                var options = new MqttClientOptionsBuilder().WithTcpServer("smarthousing.tnmiot.co.kr", 1883).WithCredentials("smart", "smart1234").Build();

                var message = new MqttApplicationMessageBuilder().WithTopic("/REGISTER/T36110325809166/THR/TF01/normal").WithPayload(mqttmsg).WithRetainFlag(false).WithQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.AtMostOnce).Build();


                //Console.WriteLine("run");

                _ = await mqttClient.ConnectAsync(options, CancellationToken.None);

                await mqttClient.PublishAsync(message);

                await mqttClient.DisconnectAsync();
            }

            catch (Exception ex)
            {
                Application.ExitThread();
            }

        }
        
    }
}
