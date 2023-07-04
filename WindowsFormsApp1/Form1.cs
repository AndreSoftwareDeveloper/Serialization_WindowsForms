using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Person man;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstName = textBox2.Text;
            String lastName = textBox1.Text;
            DateTime birthDate = dateTimePicker1.Value;
            int phoneNumber = Int32.Parse(textBox3.Text);

            man = new Person(firstName, lastName, birthDate, phoneNumber);
            DisplayData(man);
            Serialize(man);
        }

        void Serialize(Person person)
        {
            string jsonData = JsonConvert.SerializeObject(person);

            String jsonFile = "person.json";
            FileStream fs = new FileStream(jsonFile, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            label12.Text = jsonData;

            sw.Write(jsonData);
            sw.Close();
        }

        void DisplayData(Person person)
        {
            label9.Text = person.firstName;
            label10.Text = person.lastName;
            label11.Text = person.birthDate.ToString("dd-MM-yyyy");
            label12.Text = Convert.ToString(person.phoneNumber);
        }

        Person Deserialize()
        {
            string jsonFile = "person.json";
            FileStream fs = new FileStream(jsonFile, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            String data, jsonData = "";

            while ((data = sr.ReadLine()) != null)
            {
                jsonData += data;
            }

            Person person = JsonConvert.DeserializeObject<Person>(jsonData);
            return person;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person person = Deserialize();
            DisplayData(person);
        }
    }
}
