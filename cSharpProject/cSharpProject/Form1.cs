using ScraperLibrary;
using System.Diagnostics;


namespace cSharpProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cpuBox.Text = "No CPUs";
            mbBox.Text = "No Motherboards";
        }
        //getting the selected CPU object
        private void cpuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrlShort us = new UrlShort();

            if (cpuBox.SelectedItem == null) return;
            var b = (Processor)cpuBox.SelectedItem;
            if (b != null)
            {
                cpuPriceLabel.Text = "Price: " + b.price.ToString() + "€";
                cpuSocketLabel.Text = "Socket: " + b.socket;
                cpuLinkLabel.Text = us.shortenUrl(b.url);
            }
            compChecker();
        }
        //getting the selected Motherboard object
        private void mbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrlShort us = new UrlShort();

            if (mbBox.SelectedItem == null) return;
            var b = (Motherboard)mbBox.SelectedItem;
            if (b != null)
            {
                mbPriceLabel.Text = "Price: " + b.price.ToString() + "€";
                mbChipsetLabel.Text = "Chipset: " + b.chipset;
                mbSocketLabel.Text = "Socket: " + b.socket;
                mbFactorLabel.Text = "Form Factor: " + b.ffactor;
                mbLinkLabel.Text = us.shortenUrl(b.url);
            }
            compChecker();
        }
        //scrape button press
        private void scrapeButton_Click(object sender, EventArgs e)
        {
            Processor processor = new Processor();
            Motherboard motherboard = new Motherboard();
            Cursor = Cursors.WaitCursor;
            scrapeButton.Text = "Getting results...";
            List<Processor> unsortedProcessors = Task.Run(() => processor.GetHtmlAsync()).Result;
            List<Motherboard> unsortedMotherboards = motherboard.GetHtmlAsync();

            List<Processor> processors = unsortedProcessors.OrderBy(o => o.name).ToList();
            List<Motherboard> motherboards = unsortedMotherboards.OrderBy(o => o.name).ToList();

            cpuBox.Text = "Choose your CPU";
            foreach (Processor p in processors)
            {
                cpuBox.Items.Add(p);
            }
            mbBox.Text = "Choose your Motherboard";
            foreach (Motherboard m in motherboards)
            {
                mbBox.Items.Add(m);
            }
            Cursor = Cursors.Arrow;
            scrapeButton.Text = "Get Available parts";
            cpuBox.Text = "Choose a CPU";
            mbBox.Text = "Choose a Motherboard";
        }
        //checking if selected parts are compatible
        private void compChecker()
        {
            if (mbBox.SelectedItem != null && cpuBox.SelectedItem != null)
            {
                var m = (Motherboard)mbBox.SelectedItem;
                var c = (Processor)cpuBox.SelectedItem;

                if (string.Compare(m.socket, c.socket) == 0) //if equal
                {
                    compTitle.Text = "The chosen parts are: COMPATIBLE!";
                    compTitle.ForeColor = Color.Green;
                }
                else
                {
                    compTitle.Text = "The chosen parts are: INCOMPATIBLE :(";
                    compTitle.ForeColor = Color.Red;
                }
            }
        }

        //copy link to clipboard when it has been clicked
        private void cpuLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cpuLinkLabel.Text == "Link") return;
            else{
                Clipboard.SetText(cpuLinkLabel.Text);
                MessageBox.Show("The link has been copied to clipboard");
            }
        }
        private void mbLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mbLinkLabel.Text == "Link") return;
            else{
                Clipboard.SetText(mbLinkLabel.Text);
                MessageBox.Show("The link has been copied to clipboard");
            }
        }
    }
}