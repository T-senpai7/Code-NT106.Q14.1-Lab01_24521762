using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace WindowsFormsApp
{
    public class Bai5Form : Form
    {
        private Panel panelHeader;
        private Panel panelInput;
        private Panel panelButtons;
        private Panel panelResult;
        private Label lblTitle;
        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnTinh;
        private Button btnXoa;
        private TextBox txtKetQua;

        public Bai5Form()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Bài 5 - Tính toán A và B";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(800, 650);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            BackColor = Color.FromArgb(240, 244, 248);

            panelHeader = new Panel();
            panelHeader.Location = new Point(0, 0);
            panelHeader.Size = new Size(800, 80);
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Dock = DockStyle.Top;

            lblTitle = new Label();
            lblTitle.Text = "TÍNH TOÁN A VÀ B";
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = false;
            lblTitle.Size = new Size(800, 80);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            panelHeader.Controls.Add(lblTitle);

            panelInput = new Panel();
            panelInput.Location = new Point(40, 100);
            panelInput.Size = new Size(720, 100);
            panelInput.BackColor = Color.White;
            panelInput.BorderStyle = BorderStyle.FixedSingle;

            lblA = new Label();
            lblA.Text = "● Số A:";
            lblA.Location = new Point(30, 25);
            lblA.Size = new Size(80, 30);
            lblA.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblA.ForeColor = Color.FromArgb(52, 73, 94);

            txtA = new TextBox();
            txtA.Location = new Point(120, 23);
            txtA.Size = new Size(200, 30);
            txtA.Font = new Font("Segoe UI", 12);
            txtA.BorderStyle = BorderStyle.FixedSingle;

            lblB = new Label();
            lblB.Text = "● Số B:";
            lblB.Location = new Point(380, 25);
            lblB.Size = new Size(80, 30);
            lblB.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblB.ForeColor = Color.FromArgb(52, 73, 94);

            txtB = new TextBox();
            txtB.Location = new Point(470, 23);
            txtB.Size = new Size(200, 30);
            txtB.Font = new Font("Segoe UI", 12);
            txtB.BorderStyle = BorderStyle.FixedSingle;

            panelInput.Controls.AddRange(new Control[] { lblA, txtA, lblB, txtB });

            panelButtons = new Panel();
            panelButtons.Location = new Point(40, 220);
            panelButtons.Size = new Size(720, 70);
            panelButtons.BackColor = Color.Transparent;

            btnTinh = new Button();
            btnTinh.Text = "🧮 TÍNH TOÁN";
            btnTinh.Location = new Point(180, 10);
            btnTinh.Size = new Size(160, 50);
            btnTinh.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnTinh.BackColor = Color.FromArgb(46, 204, 113);
            btnTinh.ForeColor = Color.White;
            btnTinh.FlatStyle = FlatStyle.Flat;
            btnTinh.FlatAppearance.BorderSize = 0;
            btnTinh.Cursor = Cursors.Hand;
            btnTinh.Click += BtnTinh_Click;
            btnTinh.MouseEnter += (s, e) => btnTinh.BackColor = Color.FromArgb(39, 174, 96);
            btnTinh.MouseLeave += (s, e) => btnTinh.BackColor = Color.FromArgb(46, 204, 113);

            btnXoa = new Button();
            btnXoa.Text = "🗑️ XÓA";
            btnXoa.Location = new Point(380, 10);
            btnXoa.Size = new Size(160, 50);
            btnXoa.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.ForeColor = Color.White;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Click += BtnXoa_Click;
            btnXoa.MouseEnter += (s, e) => btnXoa.BackColor = Color.FromArgb(192, 57, 43);
            btnXoa.MouseLeave += (s, e) => btnXoa.BackColor = Color.FromArgb(231, 76, 60);

            panelButtons.Controls.AddRange(new Control[] { btnTinh, btnXoa });

            panelResult = new Panel();
            panelResult.Location = new Point(40, 310);
            panelResult.Size = new Size(720, 280);
            panelResult.BackColor = Color.White;
            panelResult.BorderStyle = BorderStyle.FixedSingle;

            Label lblKetQuaTitle = new Label();
            lblKetQuaTitle.Text = "📊 KẾT QUẢ";
            lblKetQuaTitle.Location = new Point(10, 5);
            lblKetQuaTitle.Size = new Size(700, 30);
            lblKetQuaTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblKetQuaTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblKetQuaTitle.BackColor = Color.FromArgb(236, 240, 241);
            lblKetQuaTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblKetQuaTitle.Padding = new Padding(10, 0, 0, 0);

            txtKetQua = new TextBox();
            txtKetQua.Location = new Point(10, 40);
            txtKetQua.Size = new Size(700, 230);
            txtKetQua.Multiline = true;
            txtKetQua.ScrollBars = ScrollBars.Vertical;
            txtKetQua.Font = new Font("Consolas", 9.5F);
            txtKetQua.ReadOnly = true;
            txtKetQua.BackColor = Color.FromArgb(250, 250, 250);
            txtKetQua.BorderStyle = BorderStyle.None;

            panelResult.Controls.AddRange(new Control[] { lblKetQuaTitle, txtKetQua });

            Controls.AddRange(new Control[] { panelHeader, panelInput, panelButtons, panelResult });
        }

        private void BtnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ số A và B!", "⚠️ Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int A = int.Parse(txtA.Text);
                int B = int.Parse(txtB.Text);

                StringBuilder ketQua = new StringBuilder();
                ketQua.AppendLine("╔═══════════════════════════════════════════════════════════════╗");
                ketQua.AppendLine($"║       KẾT QUẢ TÍNH TOÁN VỚI A = {A,4}, B = {B,4}                ║");
                ketQua.AppendLine("╚═══════════════════════════════════════════════════════════════╝\n");

                ketQua.AppendLine("┌─────────────────────────────────────────────────────────────┐");
                ketQua.AppendLine("│ 1. BẢNG CỬU CHƯƠNG TỪ " + B + " ĐẾN " + A);
                ketQua.AppendLine("└─────────────────────────────────────────────────────────────┘");
                
                if (B <= A)
                {
                    for (int i = B; i <= A; i++)
                    {
                        ketQua.AppendLine($"\n   ➤ Bảng cửu chương {i}:");
                        for (int j = 1; j <= 10; j++)
                        {
                            ketQua.AppendLine($"      {i} × {j,2} = {i * j,4}");
                        }
                    }
                }
                else
                {
                    ketQua.AppendLine("   ✗ B > A: Không có bảng cửu chương");
                }

                ketQua.AppendLine("\n┌─────────────────────────────────────────────────────────────┐");
                ketQua.AppendLine("│ 2. TÍNH GIAI THỪA (A - B)!");
                ketQua.AppendLine("└─────────────────────────────────────────────────────────────┘");
                
                int hieu = A - B;
                ketQua.AppendLine($"   A - B = {A} - {B} = {hieu}");
                
                if (hieu < 0)
                {
                    ketQua.AppendLine($"   ✗ ({hieu})! không xác định (số âm)");
                }
                else if (hieu > 20)
                {
                    ketQua.AppendLine($"   ⚠ {hieu}! quá lớn để tính toán");
                }
                else
                {
                    long giaiThua = TinhGiaiThua(hieu);
                    ketQua.AppendLine($"   ✓ ({hieu})! = {giaiThua:N0}");
                }

                ketQua.AppendLine("\n┌─────────────────────────────────────────────────────────────┐");
                ketQua.AppendLine("│ 3. TÍNH TỔNG S = A¹ + A² + A³ + ... + A^B");
                ketQua.AppendLine("└─────────────────────────────────────────────────────────────┘");
                
                if (B <= 0)
                {
                    ketQua.AppendLine("   ✗ B ≤ 0: Tổng S = 0");
                }
                else if (B > 30 || (Math.Abs(A) > 10 && B > 20))
                {
                    ketQua.AppendLine("   ⚠ Số mũ quá lớn, không thể tính toán chính xác");
                }
                else
                {
                    double tong = TinhTongLuyThua(A, B, ketQua);
                    ketQua.AppendLine($"\n   ✓ Tổng S = {tong:N0}");
                }

                ketQua.AppendLine("\n╚═══════════════════════════════════════════════════════════════╝");
                txtKetQua.Text = ketQua.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "❌ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số quá lớn! Vui lòng nhập số nhỏ hơn.", "❌ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "❌ Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long TinhGiaiThua(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            
            long ketQua = 1;
            for (int i = 2; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }

        private double TinhTongLuyThua(int A, int B, StringBuilder ketQua)
        {
            double tong = 0;
            ketQua.Append("   S = ");
            
            int soHangHienThi = Math.Min(B, 10);
            
            for (int i = 1; i <= B; i++)
            {
                double giaTri = Math.Pow(A, i);
                tong += giaTri;
                
                if (i <= soHangHienThi)
                {
                    ketQua.Append($"{A}^{i}");
                    if (i < B)
                        ketQua.Append(" + ");
                    if (i == soHangHienThi && B > soHangHienThi)
                        ketQua.Append($"... + {A}^{B}");
                }
            }
            
            return tong;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }
    }
}