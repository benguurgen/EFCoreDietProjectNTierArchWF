namespace DietProject.UI
{
    public partial class AnaGirisEkran� : Form
    {
        public AnaGirisEkran�()
        {
            InitializeComponent();
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Kullan�c�Kay�tFormu kay�tFormu = new Kullan�c�Kay�tFormu();
            this.Hide();
            kay�tFormu.ShowDialog();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullan�c�GirisEkran� girisEkran� = new Kullan�c�GirisEkran�();
            this.Hide( );
            girisEkran�.ShowDialog();
        }
    }
}
