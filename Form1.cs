using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SBC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            if (textBox1.Text != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Corporatie.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {

                    string nume = node.Attributes[0].Value;
                    if (nume == textBox1.Text)
                    {

                        foreach (XmlNode child in node.ChildNodes)
                        {

                            listView1.Items.Add(child.InnerText);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Input Invalid");
                textBox1.Text = string.Empty;
                textBox1.Focus();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            if (textBox2.Text != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Corporatie.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {

                    string nume = node.Attributes[0].Value;
                    if (nume == textBox2.Text)
                    {
                        foreach (XmlNode child in node.SelectNodes("ora_pranz"))
                        {
                            switch (textBox2.Text)
                            {
                                case "ion":
                                    listView2.Clear();
                                    if (textBox3.Text == child.InnerText && textBox3.Text != "")
                                        listView2.Items.Add("Nu");
                                    else
                                    {
                                        listView2.Clear();
                                        if (textBox3.Text != child.InnerText && textBox3.Text != "")
                                            listView2.Items.Add("Da");
                                    }
                                    break;
                                case "maria":
                                    listView2.Clear();
                                    if (textBox3.Text == child.InnerText && textBox3.Text != "")
                                        listView2.Items.Add("Nu");
                                    else
                                    {
                                        listView2.Clear();
                                        if (textBox3.Text != child.InnerText && textBox3.Text != "")
                                            listView2.Items.Add("Da");
                                    }
                                    break;
                                case "vasile":
                                    listView2.Clear();
                                    if (textBox3.Text == child.InnerText && textBox3.Text != "")
                                        listView2.Items.Add("Nu");
                                    else
                                    {
                                        listView2.Clear();
                                        if (textBox3.Text != child.InnerText && textBox3.Text != "")
                                            listView2.Items.Add("Da");
                                    }
                                    break;
                                case "anca":
                                    listView2.Clear();
                                    if (textBox3.Text == child.InnerText && textBox3.Text != "")
                                        listView2.Items.Add("Nu");
                                    else
                                    {
                                        listView2.Clear();
                                        if (textBox3.Text != child.InnerText && textBox3.Text != "")
                                            listView2.Items.Add("Da");
                                    }
                                    break;
                                case "alex":
                                    listView2.Clear();
                                    if (textBox3.Text == child.InnerText && textBox3.Text != "")
                                        listView2.Items.Add("Nu");
                                    else
                                    {
                                        listView2.Clear();
                                        if (textBox3.Text != child.InnerText && textBox3.Text != "")
                                            listView2.Items.Add("Da");
                                    }
                                    break;
                                case "dan":
                                    listView2.Clear();
                                    if (textBox3.Text == child.InnerText && textBox3.Text != "")
                                        listView2.Items.Add("Nu");
                                    else
                                    {
                                        listView2.Clear();
                                        if (textBox3.Text != child.InnerText && textBox3.Text != "")
                                            listView2.Items.Add("Da");
                                    }
                                    break;

                            }
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Input Invalid");
                textBox2.Text = string.Empty;
                textBox2.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listView3.Clear();
                listView3.Items.Add("11");
            }

            if (checkBox2.Checked == true)
            {
                listView3.Clear();
                listView3.Items.Add("10");
            }

            if (checkBox3.Checked == true)
            {
                listView3.Clear();
                listView3.Items.Add("9");
            }

            if (checkBox3.Checked == true)
            {
                listView3.Clear();
                listView3.Items.Add("9");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var departament = "";
            var departamentColeg = "";

            listView4.Clear();
            if (textBox4.Text != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Corporatie.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {

                    string nume = node.Attributes[0].Value;
                    if (nume == textBox4.Text)
                    {
                        foreach (XmlNode child in node.SelectNodes("departament"))
                        {
                            departament = child.InnerText;
                        }
                    }
                }

                foreach (XmlNode node in doc.DocumentElement)
                {

                    string nume = node.Attributes[0].Value;
                    if (nume == textBox5.Text)
                    {
                        foreach (XmlNode child in node.SelectNodes("departament"))
                        {
                            departamentColeg = child.InnerText;
                        }
                    }
                }

                if (departament == departamentColeg)
                {
                    listView4.Clear();
                    listView4.Items.Add(departament);
                }
                else {
                    listView4.Clear();
                    listView4.Items.Add("NU");
                    listView4.Items.Add("Sunt");
                    listView4.Items.Add("Colegi");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var proiect1 = "";
            var proiect2 = "";

            listView5.Clear();
            if (textBox6.Text != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Corporatie.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {

                    string nume_departament = node.Attributes[0].Value;
                    if (nume_departament == textBox6.Text)
                    {
                        foreach (XmlNode child in node.SelectNodes("proiect"))
                        {
                            proiect1 = child.InnerText;
                        }
                    }
                }

                foreach (XmlNode node in doc.DocumentElement)
                {

                    string nume_departament = node.Attributes[0].Value;
                    if (nume_departament == textBox7.Text)
                    {
                        foreach (XmlNode child in node.SelectNodes("proiect"))
                        {
                            proiect2 = child.InnerText;
                        }
                    }
                }

                if (proiect1 == proiect2)
                {
                    listView5.Clear();
                    listView5.Items.Add(proiect1);
                }
                else
                {
                    listView5.Clear();
                    listView5.Items.Add("NU");
                    listView5.Items.Add("Au");
                    listView5.Items.Add("Proiecte");
                    listView5.Items.Add("Comune");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string studii = "";
            int OT = 0;
            listView6.Clear();
            listView7.Clear();
            listView8.Clear();
            if (textBox8.Text != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Corporatie.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {

                    string nume = node.Attributes[0].Value;
                    if (nume == textBox8.Text)
                    {

                        foreach (XmlNode child in node.SelectNodes("studii"))
                        {
                            studii = child.InnerText;
                            listView6.Items.Add(studii);
                        }
                        foreach (XmlNode child in node.SelectNodes("ore_saptamana"))
                        {
                            OT = Convert.ToInt32(child.InnerText) - 40;
                            
                            listView7.Items.Add(OT.ToString());
                        }
                    }
                }

                if (studii == "doctorat" && OT > 0)
                    listView8.Items.Add("Candidat");
                else
                {
                    listView8.Clear();
                    listView8.Items.Add("Negativ");
                }
            }
            else
            {
                MessageBox.Show("Input Invalid");
                textBox1.Text = string.Empty;
                textBox1.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}