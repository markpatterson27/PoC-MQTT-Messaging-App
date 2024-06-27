using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;

namespace PoC_MQTT_Messaging_App
{
    public partial class MainForm : Form
    {
        private IMqttClient mqttClient;
        public MainForm()
        {
            InitializeComponent();
            InitializeMqttClient();
        }

        // Initialise MQTT client
        private void InitializeMqttClient()
        {
            var factory = new MqttFactory();
            mqttClient = factory.CreateMqttClient();

            // Setup MQTT event handlers
            mqttClient.ConnectedAsync += e =>
            {
                Invoke(new Action(() =>
                {
                    lblStatus.Text = "Connected";
                    lblStatus.ForeColor = Color.Green;
                }));
                return Task.CompletedTask;
            };
            mqttClient.DisconnectedAsync += e =>
            {
                Invoke(new Action(() =>
                {
                    lblStatus.Text = "Disconnected";
                    lblStatus.ForeColor = Color.Red;
                }));
                return Task.CompletedTask;
            };
            mqttClient.ApplicationMessageReceivedAsync += e =>
            {
                Invoke(new Action(() =>
                {
                    // Add message to the subscribe listbox messages
                    lstSubscribeMessages.Items.Add(Encoding.UTF8.GetString(e.ApplicationMessage.Payload));

                    // update status
                    lblStatus.Text = "Message received";
                    lblStatus.ForeColor = Color.Blue;

                }));

                return Task.CompletedTask;
            };
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            var mqttClientOptions = new MqttClientOptionsBuilder()
                .WithClientId("PoC_MQTT_Messaging_App")
                .WithTcpServer(txtServerAddress.Text)
                .Build();

            await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);
        }

        private async void btnPublish_Click(object sender, EventArgs e)
        {
            // build message
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(txtPublishTopic.Text)
                .WithPayload(txtPublishMessage.Text)
                .Build();

            await mqttClient.PublishAsync(message, CancellationToken.None);

            // update status
            lblStatus.Text = "message published";
            lblStatus.ForeColor = Color.Green;

            // clear message box
            txtPublishMessage.Text = "";

        }

        private async void btnSubscribe_Click(object sender, EventArgs e)
        {
            // build subscribe options
            var mqttSubscribeOptions = new MqttClientSubscribeOptionsBuilder()
                .WithTopicFilter(txtSubscribeTopic.Text)
                .Build();

            await mqttClient.SubscribeAsync(mqttSubscribeOptions, CancellationToken.None);

            // update status
            lblStatus.Text = "subscribed to topic";
            lblStatus.ForeColor = Color.Blue;
        }
    }
}
