using DietProject.BLL.Manager.Concrete;

namespace DietProject.UI
{
    public partial class frm_AnaGirisEkran� : Form
    {
        public frm_AnaGirisEkran�()
        {
            InitializeComponent();


          
          


        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frm_Kullan�c�Kay�tFormu kay�tFormu = new frm_Kullan�c�Kay�tFormu();
            this.Hide();
            kay�tFormu.ShowDialog();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            frm_Kullan�c�GirisEkran� girisEkran� = new frm_Kullan�c�GirisEkran�();
            this.Hide( );
            girisEkran�.ShowDialog();
        }
    }
}
