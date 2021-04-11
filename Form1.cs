using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;

namespace OfflineChat
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var option = new ConfigurationOptions();
            option.EndPoints.Add("localhost", 6379);

            var redis = ConnectionMultiplexer.Connect(option);
            var db = redis.GetDatabase(1);

            const string Key = "Chat1";
            db.StringSet(Key, "Чат начался!");

            chatWindow.Text = db.StringGet(Key);

            /*db.StringSet(Key, "Znachenie");

            var result = db.StringGet(Key);*/

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
