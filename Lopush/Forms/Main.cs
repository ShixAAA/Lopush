using Lopush.DataModel;
using Lopush.Forms;
using Lopush.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lopush
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            products = Model1.Product.ToList();
        }
        private Model1 Model1 = new Model1();
        private List<Product> products = new List<Product>();
        private void Form1_Load(object sender, EventArgs e)
        {
            List<ProductType> producttypes = Model1.ProductType.ToList();
            producttypes.Add(new ProductType(6, "Все типы"));
            productTypeBindingSource.DataSource = producttypes;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 5;
            FillPanel();
        }
        private void FillPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Product prod in products)
            {
                UserControl1 userControl1 = new UserControl1(prod, Model1);
                flowLayoutPanel1.Controls.Add(userControl1);
            }
        }
            
            private void FiltrAndSorting()
            {
                Filtr();
                Sort();
            }
            private void Sort()
            {
                if (comboBox1.SelectedItem.ToString() == "ID")
                {
                    products = products.OrderBy(x => x.ID).ToList();
                }
                if (comboBox1.SelectedItem.ToString() == "Title")
                {
                    products = products.OrderBy(x => x.Title).ToList();

                }
                if (comboBox1.SelectedItem.ToString() == "MinCostForAgent")
                {
                    products = products.OrderBy(x => x.MinCostForAgent).ToList();

                }
                FillPanel();
            }
        private void Filtr()
        {
            if (comboBox2.SelectedItem == null)
                return;


            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                products = Model1.Product.ToList();
            }
            else
            {
                products = Model1.Product.Where(x => x.Title.ToLower().Replace(" ", "").Contains(textBox1.Text.ToLower().Replace(" ", ""))).ToList();
            }

            if ((comboBox2.SelectedItem as ProductType).Title != "Все типы")
            {
                products = products.Where(x => x.ProductType.ID == (comboBox2.SelectedItem as ProductType).ID).ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrAndSorting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Add().ShowDialog();
            Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrAndSorting();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrAndSorting();
        }
    }
}
