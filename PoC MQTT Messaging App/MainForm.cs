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
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            var mqttClientOptions = new MqttClientOptionsBuilder()
                .WithClientId("PoC_MQTT_Messaging_App")
                .WithTcpServer(txtServerAddress.Text)
                .Build();

            await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);
        }
    }
}
