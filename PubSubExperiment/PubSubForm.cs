using System;
using System.Windows.Forms;
using PubSub.Extension;

namespace PubSubExperiment
{
    public partial class frmPubSub : Form
    {
        public frmPubSub()
        {
            InitializeComponent();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            this.Subscribe<Policy>(policy =>
            {
                policy.CalcPremium(1, 2100);
                MessageBox.Show($"PolicyId: {policy.Id}, Premium: ${policy.Premium}");
            });
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            this.Unsubscribe<Policy>();
        }

        private void btnCreatePolicy_Click(object sender, EventArgs e)
        {
            this.Publish(new Policy(1011));
        }

        private void btnCreateAltPolicy_Click(object sender, EventArgs e)
        {
            this.Publish(new Policy(2222));
        }
    }
}
