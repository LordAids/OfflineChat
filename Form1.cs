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

            const string Key = "Chat:list";
            db.StringSet(Key, "====ЧАТ НАЧАЛСЯ=====");
            chatWindow.Text +=  db.StringGet(Key);
            
            timer1.Interval = 10;
            timer1.Start();
            /*db.StringSet(Key, "Znachenie");

            var result = db.StringGet(Key);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var option = new ConfigurationOptions();
            option.EndPoints.Add("localhost", 6379);

            var redis = ConnectionMultiplexer.Connect(option);
            var db = redis.GetDatabase(1);
            string Key = "Chat:list";
            string message = DateTime.Now.ToString() + " : " + userNickname.Text + " : " + messageBox.Text;
            db.StringSet(Key, message);
            chatWindow.Text += "\n" + db.StringGet(Key);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var option = new ConfigurationOptions();
            option.EndPoints.Add("localhost", 6379);

            var redis = ConnectionMultiplexer.Connect(option);
            var db = redis.GetDatabase(1);
            string Key = "Chat:list";
            if (!chatWindow.Text.Contains(db.StringGet(Key)))
                {
                    chatWindow.Text += "\n" + db.StringGet(Key);
                }
            
        }
    }
}
