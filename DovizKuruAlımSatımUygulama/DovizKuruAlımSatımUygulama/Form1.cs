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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IMKBForexService f = new IMKBForexService();
            var response = f.GetList("http://www.tcmb.gov.tr/kurlar/today.xml");

            //Take methodu ile gelen cevaptan 1 eksik kadar veri aldık.
            response.Take(response.Count-1).ToList().ForEach(a =>
            {
                ListViewItem li = new ListViewItem();
                li.Text = a.CurrencyName;
                li.SubItems.Add(a.ForexBuying);
                li.SubItems.Add(a.ForexSelling);
                li.SubItems.Add(a.Unit);
                li.Tag = a; //boxing

                listView1.Items.Add(li);
            });


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //unboxing
            //tüm propertyleri bir arada tag den yakalarız.
            ForexModel model = (ForexModel)listView1.FocusedItem.Tag;

            lblName.Text = model.CurrencyCode;
            lblSelling.Text = model.EffectiveBankNoteSelling;
            lblBuying.Text = model.EffectiveBankNoteBuying;
        }
    }
}
