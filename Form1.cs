using MQTTnet;
using MQTTnet.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTTMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var server = ConfigurationManager.AppSettings["Server"];
            if (server != null)
            {
                tbServer.Text = server.ToString();
            }

            var topic = ConfigurationManager.AppSettings["Topic"];
            if (topic != null)
            {
                tbTopic.Text = topic.ToString();
            }

            var closedVal = ConfigurationManager.AppSettings["ClosedVal"];
            if (closedVal != null)
            {
                tbClosedVal.Text = closedVal.ToString();
            }

            var thrownVal = ConfigurationManager.AppSettings["ThrownVal"];
            if (thrownVal != null)
            {
                tbThrownVal.Text = thrownVal.ToString();
            }

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (!cbDegrees.Checked)
                await SendMQTTMessage(tbServer.Text, tbTopic.Text, tbClosedVal.Text+"C",false);
            else
                await SendMQTTMessage(tbServer.Text, tbTopic.Text, tbClosedVal.Text + "CD", false);
        }

        private async Task SendMQTTMessage(string server, string topic, string message, bool retain)
        {
            var mqttFactory = new MqttFactory();

            using (var mqttClient = mqttFactory.CreateMqttClient())
            {
                var mqttClientOptions = new MqttClientOptionsBuilder()
                    .WithTcpServer(server)
                    .Build();

                await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

                var applicationMessage = new MqttApplicationMessageBuilder()
                    .WithTopic(topic)
                    .WithPayload(message).WithRetainFlag(retain)
                    .Build();

                await mqttClient.PublishAsync(applicationMessage, CancellationToken.None);

                await mqttClient.DisconnectAsync();

                lbOutput.Items.Add("MQTT application message is published.");
            }
        }

        private async void btnSendThrown_Click(object sender, EventArgs e)
        {
            if (!cbDegrees.Checked)
                await SendMQTTMessage(tbServer.Text, tbTopic.Text, tbThrownVal.Text + "T",false);
            else
                await SendMQTTMessage(tbServer.Text, tbTopic.Text, tbThrownVal.Text + "TD", false);
        }
    }
}
