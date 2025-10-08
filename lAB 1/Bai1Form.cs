using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp 
{
    public partial class Bai1Form : Form
    {
        private TextBox txtSo1;
        private TextBox txtSo2;
        private TextBox txtKetQua;
        private Button btnTinhTong;
        private Button btnXoaRong;
        private Button btnThoat;
        private Label lblSo1;
        private Label lblSo2;
        private Label lblKetQua;
        private Label lblTieuDe;
        private Panel pnlMain;
        private Panel pnlButtons;
        private ErrorProvider errorProvider;

        public Bai1Form()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Thiết lập form chính
            this.Size = new Size(450, 350);
            this.Text = "Tính Tổng Hai Số Nguyên";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 248, 255);
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Error
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Panel chính
            pnlMain = new Panel();
            pnlMain.Size = new Size(400, 200);
            pnlMain.Location = new Point(25, 20);
            pnlMain.BackColor = Color.White;
            pnlMain.BorderStyle = BorderStyle.FixedSingle;

            
            lblTieuDe = new Label();
            lblTieuDe.Text = "CHƯƠNG TRÌNH TÍNH TỔNG HAI SỐ NGUYÊN";
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(25, 118, 210);
            lblTieuDe.Size = new Size(380, 30);
            lblTieuDe.Location = new Point(10, 15);
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            
            lblSo1 = new Label();
            lblSo1.Text = "Số thứ nhất:";
            lblSo1.Size = new Size(100, 25);
            lblSo1.Location = new Point(30, 65);
            lblSo1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblSo1.ForeColor = Color.FromArgb(33, 37, 41);

            
            txtSo1 = new TextBox();
            txtSo1.Size = new Size(200, 25);
            txtSo1.Location = new Point(150, 65);
            txtSo1.Font = new Font("Segoe UI", 10F);
            txtSo1.BorderStyle = BorderStyle.FixedSingle;
            txtSo1.BackColor = Color.FromArgb(248, 249, 250);
            txtSo1.Leave += TxtSo1_Leave;
            txtSo1.TextChanged += Txt_TextChanged;
// Label Số 2
            lblSo2 = new Label();
            lblSo2.Text = "Số thứ hai:";
            lblSo2.Size = new Size(100, 25);
            lblSo2.Location = new Point(30, 105);
            lblSo2.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblSo2.ForeColor = Color.FromArgb(33, 37, 41);

            txtSo2 = new TextBox();
            txtSo2.Size = new Size(200, 25);
            txtSo2.Location = new Point(150, 105);
            txtSo2.Font = new Font("Segoe UI", 10F);
            txtSo2.BorderStyle = BorderStyle.FixedSingle;
            txtSo2.BackColor = Color.FromArgb(248, 249, 250);
            txtSo2.Leave += TxtSo2_Leave;
            txtSo2.TextChanged += Txt_TextChanged;

            // Kết quả
            lblKetQua = new Label();
            lblKetQua.Text = "Kết quả:";
            lblKetQua.Size = new Size(100, 25);
            lblKetQua.Location = new Point(30, 145);
            lblKetQua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKetQua.ForeColor = Color.FromArgb(220, 53, 69);

            
            txtKetQua = new TextBox();
            txtKetQua.Size = new Size(200, 25);
            txtKetQua.Location = new Point(150, 145);
            txtKetQua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtKetQua.BorderStyle = BorderStyle.FixedSingle;
            txtKetQua.BackColor = Color.FromArgb(255, 248, 225);
            txtKetQua.ReadOnly = true;
            txtKetQua.ForeColor = Color.FromArgb(220, 53, 69);

            // Panel chứa buttons
            pnlButtons = new Panel();
            pnlButtons.Size = new Size(400, 60);
            pnlButtons.Location = new Point(25, 240);
            pnlButtons.BackColor = Color.Transparent;

            // Tính tổng
            btnTinhTong = new Button();
            btnTinhTong.Text = "Tính Tổng";
            btnTinhTong.Size = new Size(100, 35);
            btnTinhTong.Location = new Point(50, 15);
            btnTinhTong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTinhTong.BackColor = Color.FromArgb(40, 167, 69);
            btnTinhTong.ForeColor = Color.White;
            btnTinhTong.FlatStyle = FlatStyle.Flat;
            btnTinhTong.FlatAppearance.BorderSize = 0;
            btnTinhTong.Cursor = Cursors.Hand;
            btnTinhTong.Click += BtnTinhTong_Click;

            // Button Xóa rỗng
            btnXoaRong = new Button();
            btnXoaRong.Text = "Xóa Rỗng";
            btnXoaRong.Size = new Size(100, 35);
            btnXoaRong.Location = new Point(165, 15);
            btnXoaRong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoaRong.BackColor = Color.FromArgb(255, 193, 7);
            btnXoaRong.ForeColor = Color.White;
            btnXoaRong.FlatStyle = FlatStyle.Flat;
            btnXoaRong.FlatAppearance.BorderSize = 0;
            btnXoaRong.Cursor = Cursors.Hand;
            btnXoaRong.Click += BtnXoaRong_Click;

           
            btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Size = new Size(100, 35);
            btnThoat.Location = new Point(280, 15);
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.BackColor = Color.FromArgb(220, 53, 69);
            btnThoat.ForeColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Click += BtnThoat_Click;

            
            AddButtonHoverEffects();

            // Add contrl in main panel
            pnlMain.Controls.Add(lblTieuDe);
            pnlMain.Controls.Add(lblSo1);
            pnlMain.Controls.Add(txtSo1);
            pnlMain.Controls.Add(lblSo2);
            pnlMain.Controls.Add(txtSo2);
            pnlMain.Controls.Add(lblKetQua);
            pnlMain.Controls.Add(txtKetQua);

            
            pnlButtons.Controls.Add(btnTinhTong);
            pnlButtons.Controls.Add(btnXoaRong);
            pnlButtons.Controls.Add(btnThoat);

           
            this.Controls.Add(pnlMain);
            this.Controls.Add(pnlButtons);

            
            txtSo1.TabIndex = 0;
            txtSo2.TabIndex = 1;
            btnTinhTong.TabIndex = 2;
            btnXoaRong.TabIndex = 3;
            btnThoat.TabIndex = 4;
        }

        private void AddButtonHoverEffects()
        {
            
            btnTinhTong.MouseEnter += (s, e) => btnTinhTong.BackColor = Color.FromArgb(34, 139, 58);
            btnTinhTong.MouseLeave += (s, e) => btnTinhTong.BackColor = Color.FromArgb(40, 167, 69);
            btnXoaRong.MouseEnter += (s, e) => btnXoaRong.BackColor = Color.FromArgb(227, 172, 6);
            btnXoaRong.MouseLeave += (s, e) => btnXoaRong.BackColor = Color.FromArgb(255, 193, 7);
            btnThoat.MouseEnter += (s, e) => btnThoat.BackColor = Color.FromArgb(200, 35, 51);
            btnThoat.MouseLeave += (s, e) => btnThoat.BackColor = Color.FromArgb(220, 53, 69);
        }

        private void TxtSo1_Leave(object sender, EventArgs e)
        {
            ValidateInteger(txtSo1, "Số thứ nhất");
        }

        private void TxtSo2_Leave(object sender, EventArgs e)
        {
            ValidateInteger(txtSo2, "Số thứ hai");
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            errorProvider.SetError(txt, ""); // Xóa error khi user bắt đầu nhập
            txtKetQua.Text = ""; 
        }

        private bool ValidateInteger(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, $"{fieldName} không được để trống!");
                return false;
            }

            if (!int.TryParse(textBox.Text.Trim(), out _))
            {
                errorProvider.SetError(textBox, $"{fieldName} phải là số nguyên hợp lệ!");
                return false;
            }

            errorProvider.SetError(textBox, "");
            return true;
        }

        private void BtnTinhTong_Click(object sender, EventArgs e)
        {
            // Validate cả hai số
            bool isValid1 = ValidateInteger(txtSo1, "Số thứ nhất");
            bool isValid2 = ValidateInteger(txtSo2, "Số thứ hai");

            if (!isValid1 || !isValid2)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số nguyên cho cả hai ô!", 
                              "Lỗi dữ liệu đầu vào", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int so1 = int.Parse(txtSo1.Text.Trim());
                int so2 = int.Parse(txtSo2.Text.Trim());
                long tong = (long)so1 + so2; // Sử dụng long tránh overflow

                txtKetQua.Text = tong.ToString();
                MessageBox.Show($"Tính toán thành công!\n{so1} + {so2} = {tong}", 
                              "Kết quả", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Information);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Kết quả quá lớn! Vui lòng nhập số nhỏ hơn.", 
                              "Lỗi tràn số", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", 
                              "Lỗi", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
            }
        }

        private void BtnXoaRong_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
            errorProvider.Clear();
            txtSo1.Focus();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", 
                              "Xác nhận thoát", 
                              MessageBoxButtons.YesNo, 
                              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                errorProvider?.Dispose();
            }
            base.Dispose(disposing);
        }
    }

}