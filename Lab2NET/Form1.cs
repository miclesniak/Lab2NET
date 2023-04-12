using System.Text.Json;
namespace Lab2NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox1.Text, out id))
            {
                textBox1.BackColor = Color.White;
                var json = await GetBeer(id);
                var beer = JsonSerializer.Deserialize<List<Beer>>(json);
                textBox2.Text = beer[0].description;
                label1.Text = beer[0].name;
                textBox3.Text = beer[0].brewers_tips;
                pictureBox1.ImageLocation = beer[0].image_url;
            } else
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
    }
}