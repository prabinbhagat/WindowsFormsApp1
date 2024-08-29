using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //const string connectionUri = "mongodb+srv://prabinbhagat:Prabin96818@cluster0.ch9fclu.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            //var settings = MongoClientSettings.FromConnectionString(connectionUri);
            //// Set the ServerApi field of the settings object to set the version of the Stable API on the client
            //settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            //// Create a new client and connect to the server
            //var client = new MongoClient(settings);
            //// Send a ping to confirm a successful connection
            //try
            //{
            //    var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
            //    Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}

            var connString = "mongodb+srv://prabinbhagat:<passwordwithout@andnobracketshere>@cluster0.ch9fclu.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            var client = new MongoClient(connString);
            var database = client.GetDatabase("allpujacollection2023");

            var collection = database.GetCollection<BsonDocument>("allpujacollection2023");
            var filter = Builders<BsonDocument>.Filter.Eq("Amount", "251.00");

            var data = collection.Find(filter).FirstOrDefault();

            if (data != null) { MessageBox.Show(data.ToString()); }


        }
    }
}
