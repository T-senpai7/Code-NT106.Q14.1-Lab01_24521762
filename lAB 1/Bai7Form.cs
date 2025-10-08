using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
// Có sử dụng AI adding icon để phân tier cho hsinh 
namespace WindowsFormsApp
{
    public class Bai7Form : Form
    {
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelInput;
        private Label lblInputLabel;
        private Label lblName;
        private TextBox txtName;
        private Label lblToan;
        private TextBox txtToan;
        private Label lblVan;
        private TextBox txtVan;
        private Label lblAnh;
        private TextBox txtAnh;
        private Button btnProcess;
        private Button btnClear;
        private Panel panelOutput;
        private Label lblOutputLabel;
        private RichTextBox txtOutput;

        public Bai7Form()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Xử lý điểm sinh viên";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(900, 700);
            BackColor = Color.FromArgb(240, 242, 245);
            Padding = new Padding(15);

            panelHeader = new Panel
            {
                Location = new Point(15, 15),
                Size = new Size(850, 80),
                BackColor = Color.FromArgb(0, 120, 215)
            };

            lblTitle = new Label
            {
                Text = "📊 XỬ LÝ ĐIỂM SINH VIÊN",
                Location = new Point(20, 15),
                Size = new Size(810, 35),
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter
            };

            lblSubtitle = new Label
            {
                Text = "Nhập điểm 3 môn: Toán - Văn - Anh",
                Location = new Point(20, 50),
                Size = new Size(810, 20),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(230, 240, 255),
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);

            panelInput = new Panel
            {
                Location = new Point(15, 105),
                Size = new Size(850, 240),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblInputLabel = new Label
            {
                Text = "Nhập thông tin:",
                Location = new Point(15, 15),
                Size = new Size(820, 25),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50)
            };

            lblName = new Label
            {
                Text = "👤 Họ và tên:",
                Location = new Point(30, 55),
                Size = new Size(120, 25),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(70, 70, 70),
                TextAlign = ContentAlignment.MiddleLeft
            };

            txtName = new TextBox
            {
                Location = new Point(160, 53),
                Size = new Size(660, 30),
                Font = new Font("Segoe UI", 11),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(250, 250, 250)
            };

            lblToan = new Label
            {
                Text = "📐 Điểm Toán:",
                Location = new Point(30, 100),
                Size = new Size(120, 25),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(70, 70, 70),
                TextAlign = ContentAlignment.MiddleLeft
            };

            txtToan = new TextBox
            {
                Location = new Point(160, 98),
                Size = new Size(200, 30),
                Font = new Font("Segoe UI", 11),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(250, 250, 250)
            };

            lblVan = new Label
            {
                Text = "📖 Điểm Văn:",
                Location = new Point(30, 145),
                Size = new Size(120, 25),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(70, 70, 70),
                TextAlign = ContentAlignment.MiddleLeft
            };

            txtVan = new TextBox
            {
                Location = new Point(160, 143),
                Size = new Size(200, 30),
                Font = new Font("Segoe UI", 11),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(250, 250, 250)
            };

            lblAnh = new Label
            {
                Text = "🌐 Điểm Anh:",
                Location = new Point(30, 190),
                Size = new Size(120, 25),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(70, 70, 70),
                TextAlign = ContentAlignment.MiddleLeft
            };

            txtAnh = new TextBox
            {
                Location = new Point(160, 188),
                Size = new Size(200, 30),
                Font = new Font("Segoe UI", 11),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(250, 250, 250)
            };

            btnProcess = new Button
            {
                Text = "Xử lý dữ liệu",
                Location = new Point(400, 98),
                Size = new Size(150, 45),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnProcess.FlatAppearance.BorderSize = 0;
            btnProcess.Click += BtnProcess_Click;

            btnClear = new Button
            {
                Text = "Xóa",
                Location = new Point(400, 158),
                Size = new Size(150, 45),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(220, 220, 220),
                ForeColor = Color.FromArgb(60, 60, 60),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Click += BtnClear_Click;

            panelInput.Controls.Add(lblInputLabel);
            panelInput.Controls.Add(lblName);
            panelInput.Controls.Add(txtName);
            panelInput.Controls.Add(lblToan);
            panelInput.Controls.Add(txtToan);
            panelInput.Controls.Add(lblVan);
            panelInput.Controls.Add(txtVan);
            panelInput.Controls.Add(lblAnh);
            panelInput.Controls.Add(txtAnh);
            panelInput.Controls.Add(btnProcess);
            panelInput.Controls.Add(btnClear);

            panelOutput = new Panel
            {
                Location = new Point(15, 355),
                Size = new Size(850, 310),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblOutputLabel = new Label
            {
                Text = "📋 Kết quả phân tích:",
                Location = new Point(15, 10),
                Size = new Size(820, 25),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50)
            };

            txtOutput = new RichTextBox
            {
                Location = new Point(15, 40),
                Size = new Size(820, 255),
                Font = new Font("Consolas", 10),
                ReadOnly = true,
                BackColor = Color.FromArgb(250, 250, 250),
                BorderStyle = BorderStyle.None,
                ScrollBars = RichTextBoxScrollBars.Vertical
            };

            panelOutput.Controls.Add(lblOutputLabel);
            panelOutput.Controls.Add(txtOutput);

            Controls.Add(panelHeader);
            Controls.Add(panelInput);
            Controls.Add(panelOutput);

            txtOutput.Text = "Chào mừng! Vui lòng nhập thông tin sinh viên và điểm 3 môn.";
            txtOutput.SelectionFont = new Font("Segoe UI", 10, FontStyle.Italic);
            txtOutput.SelectionColor = Color.Gray;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            txtOutput.Clear();
            txtOutput.Text = "Chào mừng! Vui lòng nhập thông tin sinh viên và điểm 3 môn.";
            txtOutput.SelectionFont = new Font("Segoe UI", 10, FontStyle.Italic);
            txtOutput.SelectionColor = Color.Gray;
            txtName.Focus();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            string studentName = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(studentName))
            {
                ShowError("⚠️ Vui lòng nhập họ và tên sinh viên!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtToan.Text))
            {
                ShowError("⚠️ Vui lòng nhập điểm Toán!");
                return;
            }
            if (!double.TryParse(txtToan.Text.Trim(), out double diemToan))
            {
                ShowError($"❌ Điểm Toán '{txtToan.Text}' không hợp lệ!");
                return;
            }
            if (diemToan < 0 || diemToan > 10)
            {
                ShowError($"❌ Điểm Toán phải từ 0-10 (nhập: {diemToan})");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVan.Text))
            {
                ShowError("⚠️ Vui lòng nhập điểm Văn!");
                return;
            }
            if (!double.TryParse(txtVan.Text.Trim(), out double diemVan))
            {
                ShowError($"❌ Điểm Văn '{txtVan.Text}' không hợp lệ!");
                return;
            }
            if (diemVan < 0 || diemVan > 10)
            {
                ShowError($"❌ Điểm Văn phải từ 0-10 (nhập: {diemVan})");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAnh.Text))
            {
                ShowError("⚠️ Vui lòng nhập điểm Anh!");
                return;
            }
            if (!double.TryParse(txtAnh.Text.Trim(), out double diemAnh))
            {
                ShowError($"❌ Điểm Anh '{txtAnh.Text}' không hợp lệ!");
                return;
            }
            if (diemAnh < 0 || diemAnh > 10)
            {
                ShowError($"❌ Điểm Anh phải từ 0-10 (nhập: {diemAnh})");
                return;
            }

            ShowSuccess("✅ Đã nhập đúng thông tin!\n\n");
            double[] grades = { diemToan, diemVan, diemAnh };
            string[] subjects = { "Toán", "Văn", "Anh" };
            ProcessAndDisplayResults(studentName, grades, subjects);
        }
// layout thông tin sinh viên output - AI cấu hình lại design 
        private void ProcessAndDisplayResults(string studentName, double[] grades, string[] subjects)
        {
            AppendText("═══════════════════════════════════════════════════════════════\n");
            
            AppendColoredText("👤 Họ và tên: ", Color.FromArgb(80, 80, 80), true);
            AppendColoredText($"{studentName}\n", Color.FromArgb(0, 120, 215), true);
            AppendText("═══════════════════════════════════════════════════════════════\n\n");

            AppendColoredText("📚 BẢNG ĐIỂM:\n", Color.FromArgb(0, 150, 136), true);
            AppendText("───────────────────────────────────────────────────────────────\n");
            
            for (int i = 0; i < grades.Length; i++)
            {
                Color gradeColor = GetGradeColor(grades[i]);
                AppendColoredText($"   {subjects[i],-8}: ", Color.FromArgb(100, 100, 100), false);
                AppendColoredText($"{grades[i],5:F1}", gradeColor, true);
                
                if (grades[i] >= 8)
                    AppendColoredText(" ⭐ Giỏi", Color.Gold, false);
                else if (grades[i] >= 6.5)
                    AppendColoredText(" ✓ Khá", Color.Green, false);
                else if (grades[i] >= 5)
                    AppendColoredText(" ✓ Trung bình", Color.Orange, false);
                else
                    AppendColoredText(" ✗ Yếu", Color.Red, false);
                
                AppendText("\n");
            }
            AppendText("───────────────────────────────────────────────────────────────\n\n");

            double average = grades.Average();
            AppendColoredText("📊 THỐNG KÊ:\n", Color.FromArgb(156, 39, 176), true);
            AppendText("───────────────────────────────────────────────────────────────\n");
            AppendColoredText("   Điểm trung bình: ", Color.FromArgb(100, 100, 100), false);
            AppendColoredText($"{average:F2}\n", Color.FromArgb(33, 150, 243), true);

            double maxGrade = grades.Max();
            double minGrade = grades.Min();
            
            int maxIndex = Array.IndexOf(grades, maxGrade);
            int minIndex = Array.IndexOf(grades, minGrade);

            AppendColoredText("   Môn điểm cao nhất: ", Color.FromArgb(100, 100, 100), false);
            AppendColoredText($"{subjects[maxIndex]} - ", Color.Black, false);
            AppendColoredText($"{maxGrade:F1} ⬆\n", Color.FromArgb(76, 175, 80), true);
            
            AppendColoredText("   Môn điểm thấp nhất: ", Color.FromArgb(100, 100, 100), false);
            AppendColoredText($"{subjects[minIndex]} - ", Color.Black, false);
            AppendColoredText($"{minGrade:F1} ⬇\n", Color.FromArgb(244, 67, 54), true);

            int passCount = grades.Count(g => g >= 5);
            int failCount = grades.Count(g => g < 5);

            AppendColoredText("   Số môn đậu: ", Color.FromArgb(100, 100, 100), false);
            AppendColoredText($"{passCount}/3", Color.FromArgb(76, 175, 80), true);
            AppendText($" ({(double)passCount / 3 * 100:F0}%)\n");
            
            AppendColoredText("   Số môn không đậu: ", Color.FromArgb(100, 100, 100), false);
            AppendColoredText($"{failCount}/3", Color.FromArgb(244, 67, 54), true);
            AppendText($" ({(double)failCount / 3 * 100:F0}%)\n");
            
            AppendText("───────────────────────────────────────────────────────────────\n\n");

            string classification = ClassifyStudent(average, grades);
            string icon = GetClassificationIcon(classification);
            Color classColor = GetClassificationColor(classification);
            
            AppendColoredText("🏆 XẾP LOẠI: ", Color.FromArgb(255, 152, 0), true);
            AppendColoredText($"{icon} {classification}\n", classColor, true);
            AppendText("═══════════════════════════════════════════════════════════════\n");
        }

        private Color GetGradeColor(double grade)
        {
            if (grade >= 8.5) return Color.FromArgb(0, 200, 83);
            if (grade >= 7) return Color.FromArgb(76, 175, 80);
            if (grade >= 5.5) return Color.FromArgb(255, 152, 0);
            if (grade >= 4) return Color.FromArgb(255, 87, 34);
            return Color.FromArgb(244, 67, 54);
        }

        private string ClassifyStudent(double average, double[] grades)
        {
            double minGrade = grades.Min();

            if (average >= 8 && minGrade >= 6.5)
                return "GIỎI";
            else if (average >= 6.5 && minGrade >= 5)
                return "KHÁ";
            else if (average >= 5 && minGrade >= 3.5)
                return "TRUNG BÌNH";
            else if (average >= 3.5 && minGrade >= 2)
                return "YẾU";
            else
                return "KÉM";
        }

        private string GetClassificationIcon(string classification)
        {
            switch (classification)
            {
                case "GIỎI": return "🥇";
                case "KHÁ": return "🥈";
                case "TRUNG BÌNH": return "🥉";
                case "YẾU": return "⚠️";
                case "KÉM": return "❌";
                default: return "";
            }
        }

        private Color GetClassificationColor(string classification)
        {
            switch (classification)
            {
                case "GIỎI": return Color.FromArgb(0, 200, 83);
                case "KHÁ": return Color.FromArgb(33, 150, 243);
                case "TRUNG BÌNH": return Color.FromArgb(255, 152, 0);
                case "YẾU": return Color.FromArgb(255, 87, 34);
                case "KÉM": return Color.FromArgb(244, 67, 54);
                default: return Color.Black;
            }
        }

        private void ShowError(string message)
        {
            txtOutput.Clear();
            AppendColoredText(message + "\n\n", Color.FromArgb(244, 67, 54), true);
            AppendColoredText("💡 Lưu ý:\n", Color.FromArgb(255, 152, 0), true);
            AppendText("• Nhập đầy đủ họ tên và điểm 3 môn\n");
            AppendText("• Điểm phải là số từ 0 đến 10\n");
            AppendText("• Có thể nhập số thập phân (VD: 8.5)\n");
        }

        private void ShowSuccess(string message)
        {
            AppendColoredText(message, Color.FromArgb(76, 175, 80), true);
        }

        private void AppendText(string text)
        {
            txtOutput.SelectionFont = new Font("Consolas", 10);
            txtOutput.SelectionColor = Color.FromArgb(60, 60, 60);
            txtOutput.AppendText(text);
        }

        private void AppendColoredText(string text, Color color, bool bold = false)
        {
            txtOutput.SelectionStart = txtOutput.TextLength;
            txtOutput.SelectionLength = 0;
            txtOutput.SelectionColor = color;
            txtOutput.SelectionFont = new Font("Consolas", 10, bold ? FontStyle.Bold : FontStyle.Regular);
            txtOutput.AppendText(text);
        }
    }
}