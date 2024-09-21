using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using main_form.work;
using QRCoder;

namespace main_form.FormApp.Pay
{
    public partial class FormPayQR : UserControl
    {
        int countDownTime = 90;
        private static FormPayQR _instance;
        public static FormPayQR Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormPayQR();
                }
                return _instance;
            }
        }
        public FormPayQR()
        {
            InitializeComponent();
        }

        private void setUpBorderR()
        {
            setUpBR.setUpBorderRadius(this, "btn_pay", 90, 90);
        }

        private void FormPayQR_Load(object sender, EventArgs e)
        {
            setUpBorderR();
            createQRcode();
            timer1.Start();
        }

        private void createQRcode()
        {
            // Lấy văn bản từ TextBox để mã hóa thành QR
            string inputText = "QR cua ban";

            // Tạo mã QR
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            // Chuyển đổi mã QR thành hình ảnh
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Hiển thị mã QR trong PictureBox
            picb_QRCode.Image = qrCodeImage;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDownTime--;

            if (countDownTime <= 0)
            {
                countDownTime = 90;
            }

            lab_timeDownCount.Text = countDownTime.ToString() + "s";
        }
    }
}
