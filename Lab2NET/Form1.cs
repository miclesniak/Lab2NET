using System.Text.Json;
namespace Lab2NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            var beers = context.Beers.ToList();
            listBox1.Items.Clear();
            foreach (var biwo in beers)
            {
                listBox1.Items.Add(biwo);
            }
        }
        Shop context = new Shop();

        private async void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox1.Text, out id))
            {
                textBox1.BackColor = Color.White;
                var json = await GetBeer(id);
                var beer = JsonSerializer.Deserialize<List<Beer>>(json);
                context.Beers.Add(new BeerDB { Name = beer[0].name, Description = beer[0].description, BrewersTips = beer[0].brewers_tips, ImageUrl = beer[0].image_url });
                context.SaveChanges();
                textBox2.Text = beer[0].description;
                label1.Text = beer[0].name;
                textBox3.Text = beer[0].brewers_tips;
                pictureBox1.ImageLocation = beer[0].image_url;
                var beers = context.Beers.ToList();
                listBox1.Items.Clear();
                foreach (var biwo in beers)
                {
                    listBox1.Items.Add(biwo);
                }
            }
            else
            {
                textBox1.BackColor = ColorTranslator.FromHtml("#ffb5b6");
            }
        }

        private async Task<string> GetBeer(int beer_id)
        {
            HttpClient client = new HttpClient();
            string call = $"https://api.punkapi.com/v2/beers/{beer_id}";
            string response = await client.GetStringAsync(call);
            return response;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var beers = context.Beers.ToList();
            if (listBox1.SelectedIndex != -1)
            {
                textBox2.Text = beers[listBox1.SelectedIndex].Description;
                label1.Text = beers[listBox1.SelectedIndex].Name;
                textBox3.Text = beers[listBox1.SelectedIndex].BrewersTips;
                pictureBox1.ImageLocation = beers[listBox1.SelectedIndex].ImageUrl;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var beers = context.Beers.ToList();
            if (beers.Count != 0 && listBox1.SelectedIndex != -1)
            {
                context.Remove(beers[listBox1.SelectedIndex]);
                context.SaveChanges();
                beers = context.Beers.ToList();
                listBox1.Items.Clear();
                foreach (var biwo in beers)
                {
                    listBox1.Items.Add(biwo);
                }
            }
        }
    }
}