using Lopush.DataModel;
using Lopush.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopush.UserControls
{
    public partial class UserControl1 : UserControl
    {
        private Product _product;
        private Model1 _model;
        private Model1 model;

        public UserControl1(Product product, Model1 model)
        {
            InitializeComponent();
            Fill(product);
            _model = model;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private void Fill(Product product)
        {
            _product = product;
            iDLabel2.Text = product.ID.ToString();
            titleLabel2.Text = product.Title.ToString();
            minCostForAgentLabel2.Text = product.MinCostForAgent.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(product.Image);

            }
            catch
            {
                pictureBox1.Image = Properties.Resources.Лопушок;
            }

        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            Edit form2 = new Edit(_product, _model);
            form2.ShowDialog();
        }
    }
}
