using PSP_pirma_st.Enums;
using PSP_pirma_st.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSP_pirma_st
{
    public partial class Client : Form
    {
        //DestinationStrategy flightDestSt;
        //FlightClassStrategy flightClassSt;
        FlightTicket flightTicket;
        Document doc;
        FlightTicketData ftd;

        PackageDelivery packageDelivery;
        int weight;
        double deliveryPrice;

        public Client()
        {
            InitializeComponent();

            flightTicket = new FlightTicket(new BostonStrategy(), new BusinessClassStrategy());
            packageDelivery = new PackageDelivery(new RomeStrategy());

            comboBox1.DataSource = Enum.GetValues(typeof(Document));

            // Should I remove these?
            flightDestField.Text = flightTicket.getDestination().ToString();
            flightClassField.Text = flightTicket.getFlightClass().ToString();
            deliveryDestField.Text = packageDelivery.getDestination().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc = (Document)comboBox1.SelectedValue;

            ftd = flightTicket.getTicket(doc);

            flightPriceField.Text = ftd.Price.ToString();
            luggageField.Text = ftd.Luggage.ToString();
            if (ftd.GoodDoc)
            {
                goodDocumentField.Text = "yes";
            }
            else if (!ftd.GoodDoc)
            {
                goodDocumentField.Text = "no";
            }
            else
            {
                throw new NotImplementedException("document value undefined");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            weight = Convert.ToInt32(weightInput.Value);
            if (weight > 0)
            {
                weightWarningField.Visible = false;
            }
            else
            {
                weightWarningField.Visible = true;
                return;
            }

            deliveryPrice = packageDelivery.calculatePrice(weight);
            
            weightField.Text = weight.ToString();
            deliveryPriceField.Text = deliveryPrice.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
