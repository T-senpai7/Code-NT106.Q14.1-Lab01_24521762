using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Bai2Form : Form
    {
        private TextBox txtSoThuNhat;
        private TextBox txtSoThuHai;
        private TextBox txtSoThuBa;
        private TextBox txtSoLonNhat;
        private TextBox txtSoNhoNhat;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblSoThuNhat;
        private Label lblSoThuHai;
        private Label lblSoThuBa;
        private Label lblSoLonNhat;
        private Label lblSoNhoNhat;
        private Label lblTieuDe;
        private Panel pnlMain;
        private Panel pnlInput;
        private Panel pnlOutput;
        private Panel pnlButtons;
        private Panel pnlHeader;
        private ErrorProvider errorProvider;

        public Bai2Form()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Thiết lập form chính
            this.Size = new Size(550, 500);
            this.Text = "Lab 1 - Bài 2: Tìm Min Max";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.FromArgb(32, 32, 32);
            pnlHeader.Height = 80;

            // TieuDe
            lblTieuDe = new Label();
            lblTieuDe.Text = "BÀI 2: TÌM SỐ LỚN NHẤT VÀ NHỎ NHẤT";
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.AutoSize = false;
            lblTieuDe.Size = new Size(500, 40);
            lblTieuDe.Location = new Point(25, 20);
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // Panel chính
            pnlMain = new Panel();
            pnlMain.Size = new Size(500, 380);
            pnlMain.Location = new Point(25, 100);
            pnlMain.BackColor = Color.White;

            pnlInput = new Panel();
            pnlInput.Size = new Size(480, 140);
            pnlInput.Location = new Point(10, 20);
            pnlInput.BackColor = Color.FromArgb(248, 249, 250);
            pnlInput.BorderStyle = BorderStyle.FixedSingle;
            Label lblInputTitle = new Label();
            lblInputTitle.Text = "NHẬP DỮ LIỆU";
            lblInputTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInputTitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblInputTitle.Size = new Size(120, 25);
            lblInputTitle.Location = new Point(15, 10);
            pnlInput.Controls.Add(lblInputTitle);

            // Số thứ nhất
            lblSoThuNhat = new Label();
            lblSoThuNhat.Text = "Số thứ nhất:";
            lblSoThuNhat.Size = new Size(120, 25);
            lblSoThuNhat.Location = new Point(30, 45);
            lblSoThuNhat.Font = new Font("Segoe UI", 10F);
            lblSoThuNhat.ForeColor = Color.FromArgb(33, 37, 41);

            txtSoThuNhat = new TextBox();
            txtSoThuNhat.Size = new Size(280, 25);
            txtSoThuNhat.Location = new Point(160, 45);
            txtSoThuNhat.Font = new Font("Segoe UI", 10F);
            txtSoThuNhat.BorderStyle = BorderStyle.FixedSingle;
            txtSoThuNhat.BackColor = Color.White;
            txtSoThuNhat.Leave += TxtSoThuNhat_Leave;
            txtSoThuNhat.TextChanged += Txt_TextChanged;
            txtSoThuNhat.KeyPress += Txt_KeyPress;

            // Số thứ hai
            lblSoThuHai = new Label();
            lblSoThuHai.Text = "Số thứ hai:";
            lblSoThuHai.Size = new Size(120, 25);
            lblSoThuHai.Location = new Point(30, 75);
            lblSoThuHai.Font = new Font("Segoe UI", 10F);
            lblSoThuHai.ForeColor = Color.FromArgb(33, 37, 41);

            txtSoThuHai = new TextBox();
            txtSoThuHai.Size = new Size(280, 25);
            txtSoThuHai.Location = new Point(160, 75);
            txtSoThuHai.Font = new Font("Segoe UI", 10F);
            txtSoThuHai.BorderStyle = BorderStyle.FixedSingle;
            txtSoThuHai.BackColor = Color.White;
            txtSoThuHai.Leave += TxtSoThuHai_Leave;
            txtSoThuHai.TextChanged += Txt_TextChanged;
            txtSoThuHai.KeyPress += Txt_KeyPress;

            // Số thứ ba
            lblSoThuBa = new Label();
            lblSoThuBa.Text = "Số thứ ba:";
            lblSoThuBa.Size = new Size(120, 25);
            lblSoThuBa.Location = new Point(30, 105);
            lblSoThuBa.Font = new Font("Segoe UI", 10F);
            lblSoThuBa.ForeColor = Color.FromArgb(33, 37, 41);

            txtSoThuBa = new TextBox();
            txtSoThuBa.Size = new Size(280, 25);
            txtSoThuBa.Location = new Point(160, 105);
            txtSoThuBa.Font = new Font("Segoe UI", 10F);
            txtSoThuBa.BorderStyle = BorderStyle.FixedSingle;
            txtSoThuBa.BackColor = Color.White;
            txtSoThuBa.Leave += TxtSoThuBa_Leave;
            txtSoThuBa.TextChanged += Txt_TextChanged;
            txtSoThuBa.KeyPress += Txt_KeyPress;

            // Add control in panel
            pnlInput.Controls.Add(lblSoThuNhat);
            pnlInput.Controls.Add(txtSoThuNhat);
            pnlInput.Controls.Add(lblSoThuHai);
            pnlInput.Controls.Add(txtSoThuHai);
            pnlInput.Controls.Add(lblSoThuBa);
            pnlInput.Controls.Add(txtSoThuBa);

            // Output
            pnlOutput = new Panel();
            pnlOutput.Size = new Size(480, 100);
            pnlOutput.Location = new Point(10, 170);
            pnlOutput.BackColor = Color.FromArgb(240, 248, 255);
            pnlOutput.BorderStyle = BorderStyle.FixedSingle;

            // Label Output Title
            Label lblOutputTitle = new Label();
            lblOutputTitle.Text = "KẾT QUẢ";
            lblOutputTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblOutputTitle.ForeColor = Color.FromArgb(108, 117, 125);
            lblOutputTitle.Size = new Size(100, 25);
            lblOutputTitle.Location = new Point(15, 10);
            pnlOutput.Controls.Add(lblOutputTitle);

            // Max And Min 
            lblSoLonNhat = new Label();
            lblSoLonNhat.Text = "Số lớn nhất:";
            lblSoLonNhat.Size = new Size(120, 25);
            lblSoLonNhat.Location = new Point(30, 40);
            lblSoLonNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSoLonNhat.ForeColor = Color.FromArgb(220, 53, 69);

            txtSoLonNhat = new TextBox();
            txtSoLonNhat.Size = new Size(280, 25);
            txtSoLonNhat.Location = new Point(160, 40);
            txtSoLonNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtSoLonNhat.BorderStyle = BorderStyle.FixedSingle;
            txtSoLonNhat.BackColor = Color.FromArgb(255, 248, 225);
            txtSoLonNhat.ReadOnly = true;
            txtSoLonNhat.ForeColor = Color.FromArgb(220, 53, 69);

            
            lblSoNhoNhat = new Label();
            lblSoNhoNhat.Text = "Số nhỏ nhất:";
            lblSoNhoNhat.Size = new Size(120, 25);
            lblSoNhoNhat.Location = new Point(30, 70);
            lblSoNhoNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSoNhoNhat.ForeColor = Color.FromArgb(25, 135, 84);

            txtSoNhoNhat = new TextBox();
            txtSoNhoNhat.Size = new Size(280, 25);
            txtSoNhoNhat.Location = new Point(160, 70);
            txtSoNhoNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtSoNhoNhat.BorderStyle = BorderStyle.FixedSingle;
            txtSoNhoNhat.BackColor = Color.FromArgb(240, 255, 240);
            txtSoNhoNhat.ReadOnly = true;
            txtSoNhoNhat.ForeColor = Color.FromArgb(25, 135, 84);

           
            pnlOutput.Controls.Add(lblSoLonNhat);
            pnlOutput.Controls.Add(txtSoLonNhat);
            pnlOutput.Controls.Add(lblSoNhoNhat);
            pnlOutput.Controls.Add(txtSoNhoNhat);

            
            pnlButtons = new Panel();
            pnlButtons.Size = new Size(480, 60);
            pnlButtons.Location = new Point(10, 280);
            pnlButtons.BackColor = Color.Transparent;

            // Finding btn
            btnTim = new Button();
            btnTim.Text = "Tìm";
            btnTim.Size = new Size(120, 40);
            btnTim.Location = new Point(70, 10);
            btnTim.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTim.BackColor = Color.FromArgb(45, 45, 48);
            btnTim.ForeColor = Color.White;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.FlatAppearance.BorderSize = 1;
            btnTim.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btnTim.Cursor = Cursors.Hand;
            btnTim.Click += BtnTim_Click;

            // Delete btn 
            btnXoa = new Button();
            btnXoa.Text = "Xóa";
            btnXoa.Size = new Size(120, 40);
            btnXoa.Location = new Point(200, 10);
            btnXoa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnXoa.BackColor = Color.White;
            btnXoa.ForeColor = Color.Black;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.FlatAppearance.BorderSize = 1;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Click += BtnXoa_Click;

            // exit btn
            btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Size = new Size(120, 40);
            btnThoat.Location = new Point(330, 10);
            btnThoat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThoat.BackColor = Color.White;
            btnThoat.ForeColor = Color.Black;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderSize = 1;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Click += BtnThoat_Click;

            
            AddButtonHoverEffects();
            pnlButtons.Controls.Add(btnTim);
            pnlButtons.Controls.Add(btnXoa);
            pnlButtons.Controls.Add(btnThoat);

            pnlMain.Controls.Add(pnlInput);
            pnlMain.Controls.Add(pnlOutput);
            pnlMain.Controls.Add(pnlButtons);

            
            pnlHeader.Controls.Add(lblTieuDe);
            this.Controls.Add(pnlMain);
            this.Controls.Add(pnlHeader);

            txtSoThuNhat.TabIndex = 0;
            txtSoThuHai.TabIndex = 1;
            txtSoThuBa.TabIndex = 2;
            btnTim.TabIndex = 3;
            btnXoa.TabIndex = 4;
            btnThoat.TabIndex = 5;
            this.Load += (s, e) => txtSoThuNhat.Focus();
        }

        private void AddButtonHoverEffects()
        {
            
            btnTim.MouseEnter += (s, e) => {
                btnTim.BackColor = Color.FromArgb(60, 60, 63);
            };
            btnTim.MouseLeave += (s, e) => {
                btnTim.BackColor = Color.FromArgb(45, 45, 48);
            };

            btnXoa.MouseEnter += (s, e) => {
                btnXoa.BackColor = Color.FromArgb(45, 45, 48);
                btnXoa.ForeColor = Color.White;
            };
            btnXoa.MouseLeave += (s, e) => {
                btnXoa.BackColor = Color.White;
                btnXoa.ForeColor = Color.Black;
            };

            btnThoat.MouseEnter += (s, e) => {
                btnThoat.BackColor = Color.FromArgb(45, 45, 48);
                btnThoat.ForeColor = Color.White;
            };
            btnThoat.MouseLeave += (s, e) => {
                btnThoat.BackColor = Color.White;
                btnThoat.ForeColor = Color.Black;
            };
        }

        // Thêm event KeyPress: nhập dấu âm
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            
            // Cho phép: số, dấu âm, dấu thập phân, Backspace, Delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && 
                e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            // Chỉ cho phép một dấu thập phân
            if ((e.KeyChar == '.' || e.KeyChar == ',') && 
                (txt.Text.Contains(".") || txt.Text.Contains(",")))
            {
                e.Handled = true;
                return;
            }

            // Dấu âm chỉ được đặt ở đầu số
            if (e.KeyChar == '-' && txt.SelectionStart != 0)
            {
                e.Handled = true;
                return;
            }

            // Chỉ cho phép một dấu âm
            if (e.KeyChar == '-' && txt.Text.Contains("-"))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtSoThuNhat_Leave(object sender, EventArgs e)
        {
            ValidateDouble(txtSoThuNhat, "Số thứ nhất");
        }

        private void TxtSoThuHai_Leave(object sender, EventArgs e)
        {
            ValidateDouble(txtSoThuHai, "Số thứ hai");
        }

        private void TxtSoThuBa_Leave(object sender, EventArgs e)
        {
            ValidateDouble(txtSoThuBa, "Số thứ ba");
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            errorProvider.SetError(txt, ""); // Xóa error khi user bắt đầu nhập
            
            // Xóa cache cũ của kết quả
            txtSoLonNhat.Text = "";
            txtSoNhoNhat.Text = "";
        }

        private bool ValidateDouble(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, $"{fieldName} không được để trống!");
                return false;
            }

            string text = textBox.Text.Trim();
            
            // count dấu , và chấm thập phân
            int dotCount = text.Count(c => c == '.');
            int commaCount = text.Count(c => c == ',');
            
            // Không được có quá 1 dấu thập phân (dấu chấm hoặc dấu phẩy)
            if (dotCount > 1 || commaCount > 1)
            {
                errorProvider.SetError(textBox, $"{fieldName} chỉ được có tối đa 1 dấu thập phân!");
                return false;
            }
            
            // Không được có cả dấu chấm và dấu phẩy cùng 1 field
            if (dotCount > 0 && commaCount > 0)
            {
                errorProvider.SetError(textBox, $"{fieldName} không được có cả dấu chấm và dấu phẩy!");
                return false;
            }

            int minusCount = text.Count(c => c == '-');
            if (minusCount > 1)
            {
                errorProvider.SetError(textBox, $"{fieldName} chỉ được có 1 dấu âm!");
                return false;
            }
            
            if (minusCount == 1 && !text.StartsWith("-"))
            {
                errorProvider.SetError(textBox, $"{fieldName} dấu âm chỉ được đặt ở đầu!");
                return false;
            }

            // Thay dấu phẩy bằng dấu chấm để parse
            string parseText = text.Replace(',', '.');
            
            if (!double.TryParse(parseText, out _))
            {
                errorProvider.SetError(textBox, $"{fieldName} phải là số hợp lệ!");
                return false;
            }

            errorProvider.SetError(textBox, "");
            return true;
        }

        private string FormatNumberSmart(double number)
        {
            // Nếu là số nguyên, hiển thị không có dấu thập phân
            if (number % 1 == 0)
            {
                return ((long)number).ToString();
            }
            else
            {
                // Nếu là số thập phân:
                string result = number.ToString("0.######");
                
                // Delete số ) thừa
                if (result.Contains("."))
                {
                    result = result.TrimEnd('0').TrimEnd('.');
                }
                
                return result;
            }
        }

        

        private void BtnTim_Click(object sender, EventArgs e)
        {
            // Validate
            bool isValid1 = ValidateDouble(txtSoThuNhat, "Số thứ nhất");
            bool isValid2 = ValidateDouble(txtSoThuHai, "Số thứ hai");
            bool isValid3 = ValidateDouble(txtSoThuBa, "Số thứ ba");

            if (!isValid1 || !isValid2 || !isValid3)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho tất cả các ô!", 
                              "Lỗi dữ liệu đầu vào", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lưu lại string gốc 
                string input1 = txtSoThuNhat.Text.Trim();
                string input2 = txtSoThuHai.Text.Trim();
                string input3 = txtSoThuBa.Text.Trim();

                // Thay dấu 
                double so1 = double.Parse(input1.Replace(',', '.'));
                double so2 = double.Parse(input2.Replace(',', '.'));
                double so3 = double.Parse(input3.Replace(',', '.'));

                // Min Max
                double max = Math.Max(Math.Max(so1, so2), so3);
                double min = Math.Min(Math.Min(so1, so2), so3);

                // kết quả trả về string gốc từ input
                if (max == so1) txtSoLonNhat.Text = input1;
                else if (max == so2) txtSoLonNhat.Text = input2;
                else txtSoLonNhat.Text = input3;

                if (min == so1) txtSoNhoNhat.Text = input1;
                else if (min == so2) txtSoNhoNhat.Text = input2;
                else txtSoNhoNhat.Text = input3;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", 
                              "Lỗi", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            // Xóa tất cả TextBox
            txtSoThuNhat.Clear();
            txtSoThuHai.Clear();
            txtSoThuBa.Clear();
            txtSoLonNhat.Clear();
            txtSoNhoNhat.Clear();
            errorProvider.Clear();
            txtSoThuNhat.Focus();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
