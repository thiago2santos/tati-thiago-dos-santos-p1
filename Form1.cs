using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace tati_thiago_dos_santos_p1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void btnGET_Click(object sender, EventArgs e) {
            string url = "https://reqres.in/api/users?page=2";
            using (HttpClient client = new HttpClient()) {
                try {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(responseBody);
                    MessageBox.Show($"Total de usuários: {userResponse.Total}", "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (HttpRequestException ex) {
                    MessageBox.Show($"Erro na requisição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
