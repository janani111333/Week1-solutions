using System;
using System.Windows.Forms;
using Confluent.Kafka;

namespace KafkaChatGUI
{
    public partial class Form1 : Form
    {
        private TextBox txtMessage;
        private Button btnSend;
        private TextBox txtChat;

        private readonly string bootstrapServers = "localhost:9092";
        private readonly string topic = "test-topic";

        public Form1()
        {
            InitializeComponent();

            // UI Setup
            this.Text = "Kafka Chat App";
            this.Width = 500;
            this.Height = 400;

            txtChat = new TextBox()
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Width = 460,
                Height = 250,
                Top = 10,
                Left = 10
            };

            txtMessage = new TextBox()
            {
                Width = 360,
                Top = 270,
                Left = 10
            };

            btnSend = new Button()
            {
                Text = "Send",
                Width = 80,
                Top = 270,
                Left = 380
            };

            btnSend.Click += btnSend_Click;

            this.Controls.Add(txtChat);
            this.Controls.Add(txtMessage);
            this.Controls.Add(btnSend);
        }

        private async void btnSend_Click(object? sender, EventArgs e)
        {
            var config = new ProducerConfig { BootstrapServers = bootstrapServers };

            using (var p = new ProducerBuilder<Null, string>(config).Build())
            {
                try
                {
                    var msg = txtMessage.Text;
                    var result = await p.ProduceAsync(topic, new Message<Null, string> { Value = msg });
                    txtChat.AppendText($"Sent: {msg}\r\n");
                    txtMessage.Clear();
                }
                catch (ProduceException<Null, string> ex)
                {
                    txtChat.AppendText($"Error: {ex.Message}\r\n");
                }
            }
        }
    }
}
