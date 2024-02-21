using System.Data;

namespace SiroomB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Koneksi.Connection();
            QRCodePicture();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private  void QRCodePicture()
        {
            string qrCode = "Hello World!";
            //gimana caranya qrcodenya terus berubah tiap beberapa detik dan tiap ada yang selesai scan
            QRCoder.QRCodeGenerator qrGen = new QRCoder.QRCodeGenerator();
            var qrdata = qrGen.CreateQrCode(qrCode, QRCoder.QRCodeGenerator.ECCLevel.H);
            var qrcode = new QRCoder.QRCode(qrdata);
            pictureBoxQRCode.Image = qrcode.GetGraphic(50);
        }
        DataTable rekapMahasiswa = new DataTable();

        
    }
}
