using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class Bai6Form : Form
    {
        private Label lblTitle;
        private Label lblInstruction;
        private DateTimePicker dtpBirthDate;
        private Button btnGetInfo;
        private TextBox txtResult;

        public Bai6Form()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Bài 6 - Cung Hoàng Đạo";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(600, 450);
            BackColor = Color.White;

            // Nhãn title 
            lblTitle = new Label
            {
                Text = "THÔNG TIN CUNG HOÀNG ĐẠO",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                AutoSize = true,
                Location = new Point(150, 20)
            };

            
            lblInstruction = new Label
            {
                Text = "Chọn ngày tháng năm sinh của bạn:",
                Font = new Font("Arial", 10, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(50, 70)
            };

            // Date
            dtpBirthDate = new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy",
                Location = new Point(50, 100),
                Width = 200,
                Font = new Font("Arial", 10)
            };

            // Button xem thông tin
            btnGetInfo = new Button
            {
                Text = "Xem thông tin",
                Location = new Point(270, 98),
                Width = 120,
                Height = 26,
                Font = new Font("Arial", 10),
                BackColor = Color.LightBlue,
                Cursor = Cursors.Hand
            };
            btnGetInfo.Click += BtnGetInfo_Click;

            
            txtResult = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Location = new Point(50, 150),
                Size = new Size(500, 220),
                Font = new Font("Arial", 11),
                BackColor = Color.Linen,
                ScrollBars = ScrollBars.Vertical
            };

            // Add controls to panel form 
            Controls.Add(lblTitle);
            Controls.Add(lblInstruction);
            Controls.Add(dtpBirthDate);
            Controls.Add(btnGetInfo);
            Controls.Add(txtResult);
        }

        private void BtnGetInfo_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dtpBirthDate.Value;
            int day = birthDate.Day;
            int month = birthDate.Month;

            string zodiacSign = GetZodiacSign(day, month);
            
            txtResult.Text = $"Ngày sinh: {birthDate.ToString("dd/MM/yyyy")}\r\n\r\n";
            txtResult.Text += $"Cung hoàng đạo của bạn là: {zodiacSign}\r\n\r\n";
            txtResult.Text += GetZodiacDescription(zodiacSign);
        }

        private string GetZodiacSign(int day, int month)
        {
            switch (month)
            {
                case 1:
                    return day <= 20 ? "Cung Ma Kết" : "Cung Bảo Bình";
                case 2:
                    return day <= 19 ? "Cung Bảo Bình" : "Cung Song Ngư";
                case 3:
                    return day <= 20 ? "Cung Song Ngư" : "Cung Bạch Dương";
                case 4:
                    return day <= 20 ? "Cung Bạch Dương" : "Cung Kim Ngưu";
                case 5:
                    return day <= 21 ? "Cung Kim Ngưu" : "Cung Song Tử";
                case 6:
                    return day <= 21 ? "Cung Song Tử" : "Cung Cự Giải";
                case 7:
                    return day <= 22 ? "Cung Cự Giải" : "Cung Sư Tử";
                case 8:
                    return day <= 22 ? "Cung Sư Tử" : "Cung Xử Nữ";
                case 9:
                    return day <= 23 ? "Cung Xử Nữ" : "Cung Thiên Bình";
                case 10:
                    return day <= 23 ? "Cung Thiên Bình" : "Cung Thần Nông";
                case 11:
                    return day <= 22 ? "Cung Thần Nông" : "Cung Nhân Mã";
                case 12:
                    return day <= 21 ? "Cung Nhân Mã" : "Cung Ma Kết";
                default:
                    return "Không xác định";
            }
        }

        private string GetZodiacDescription(string zodiacSign)
        {
            switch (zodiacSign)
            {
                case "Cung Bạch Dương":
                    return "Bạch Dương (21/03 - 20/04): Là cung hoàng đạo đầu tiên, tượng trưng cho sự khởi đầu, năng động và dũng cảm.";
                case "Cung Kim Ngưu":
                    return "Kim Ngưu (21/04 - 21/05): Tượng trưng cho sự kiên định, thực tế và yêu thích sự ổn định.";
                case "Cung Song Tử":
                    return "Song Tử (22/05 - 21/06): Linh hoạt, thông minh và có khả năng giao tiếp tốt.";
                case "Cung Cự Giải":
                    return "Cự Giải (22/06 - 22/07): Nhạy cảm, giàu cảm xúc và có tính gia đình cao.";
                case "Cung Sư Tử":
                    return "Sư Tử (23/07 - 22/08): Tự tin, hào phóng và có khả năng lãnh đạo tự nhiên.";
                case "Cung Xử Nữ":
                    return "Xử Nữ (23/08 - 23/09): Tỉ mỉ, hoàn hảo và có tính phân tích cao.";
                case "Cung Thiên Bình":
                    return "Thiên Bình (24/09 - 23/10): Cân bằng, hài hòa và yêu thích cái đẹp.";
                case "Cung Thần Nông":
                    return "Thần Nông (24/10 - 22/11): Bí ẩn, quyết đoán và có ý chí mạnh mẽ.";
                case "Cung Nhân Mã":
                    return "Nhân Mã (23/11 - 21/12): Tự do, phiêu lưu và yêu thích khám phá.";
                case "Cung Ma Kết":
                    return "Ma Kết (22/12 - 20/01): Thực tế, có trách nhiệm và có mục tiêu rõ ràng.";
                case "Cung Bảo Bình":
                    return "Bảo Bình (21/01 - 19/02): Độc lập, sáng tạo và có tư duy tiến bộ.";
                case "Cung Song Ngư":
                    return "Song Ngư (20/02 - 20/03): Nhạy cảm, giàu trí tưởng tượng và đồng cảm cao.";
                default:
                    return "Thông tin không có sẵn.";
            }
        }
    }
}