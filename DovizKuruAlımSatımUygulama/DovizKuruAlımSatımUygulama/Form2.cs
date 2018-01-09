using DovizKuruAlımSatımUygulama.models;
using DovizKuruAlımSatımUygulama.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizKuruAlımSatımUygulama
{
    public partial class Form2 : Form
    {
        private List<ForexModel> data = new List<ForexModel>();
        public Form2()
        {
            InitializeComponent();
            data = f.GetList("http://www.tcmb.gov.tr/kurlar/today.xml");
        }

        IMKBForexService f = new IMKBForexService();
        private void Form2_Load(object sender, EventArgs e)
        {
            cmbCurrency1.Items.AddRange(data.ToArray());
            cmbCurrency1.DisplayMember = "CurrencyCode";

            cmbCurrency2.Items.AddRange(data.ToArray());
            cmbCurrency2.DisplayMember = "CurrencyCode";
            //combobox içerisinde görüntülenecek olan alanları displayMember ile yazıyoruz.

            cmbCurrencyType.DataSource = Enum.GetValues(typeof(ForexType));


            //Kullanım Şekli
            ForexModel selection1 = f.GetByCurrencyCode("EUR");
            ForexModel selection2 = f.GetByCurrencyCode("USD");
            ForexType type = ForexType.ForexSelling;

            //ForexManager ex = new ForexManager();
            //decimal result = ex.Exchange(type, selection1, selection2, 100);

            //lblForexValue.Text = result +" "+ selection2.CurrencyCode;


            ForexManagerTwo t = new ForexManagerTwo(new ForexExchangeUnitOne());
            t.Exchange(selection1, selection2, 100, type);

        }

        private void btnExchange_Click(object sender, EventArgs e)
        {   //unboxing işlemleri
            ForexType _type = (ForexType)cmbCurrencyType.SelectedItem;
            ForexModel _selection1 = (ForexModel)cmbCurrency1.SelectedItem;
            ForexModel _selection2 = (ForexModel)cmbCurrency2.SelectedItem;
            decimal amount = decimal.Parse(txtCurrencyAmount.Text);

            ForexManager manager = new ForexManager();
            lblForexValue.Text =  manager.Exchange(_type, _selection1, _selection2, amount).ToString() + " " + _selection2.CurrencyCode;

        }

        private void cmbCurrency1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCurrency2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
