using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class Bai3Form : Form
    {
        private Label lblInput;
        private TextBox txtInput;
        private Button btnDoc;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblResult;
        private TextBox txtResult;

        public Bai3Form()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Bai3: Đọc số (nâng cao)";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(400, 250);
            
            lblInput = new Label();
            lblInput.Text = "Nhập Vào Số Nguyên Từ < 12 chữ số";
            lblInput.Location = new Point(20, 20);
            lblInput.Size = new Size(180, 20);
            
            txtInput = new TextBox();
            txtInput.Location = new Point(210, 18);
            txtInput.Size = new Size(150, 20);
            
            btnDoc = new Button();
            btnDoc.Text = "Đọc";
            btnDoc.Location = new Point(280, 60);
            btnDoc.Size = new Size(80, 30);
            btnDoc.Click += BtnDoc_Click;
            
            btnXoa = new Button();
            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(280, 100);
            btnXoa.Size = new Size(80, 30);
            btnXoa.Click += BtnXoa_Click;
            
            btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(280, 140);
            btnThoat.Size = new Size(80, 30);
            btnThoat.Click += BtnThoat_Click;
            
            lblResult = new Label();
            lblResult.Text = "Kết Quả";
            lblResult.Location = new Point(20, 70);
            lblResult.Size = new Size(60, 20);
            
            txtResult = new TextBox();
            txtResult.Location = new Point(20, 95);
            txtResult.Size = new Size(240, 80);
            txtResult.Multiline = true;
            txtResult.ReadOnly = true;
            
            Controls.Add(lblInput);
            Controls.Add(txtInput);
            Controls.Add(btnDoc);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(lblResult);
            Controls.Add(txtResult);
        }

        private void BtnDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text.Trim();
                
                // Validate input is a number
                if (!int.TryParse(input, out int number))
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Check if giá trị số là số nguyên dương
                if (number < 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Advance 12 số   
                if (input.Length > 12)
                {
                    MessageBox.Show("Số quá lớn! Vui lòng nhập số có tối đa 12 chữ số.", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                string result = ReadNumber(input);
                txtResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ReadNumber(string numberStr)
        {
            // Kí hiệu 0
            numberStr = numberStr.TrimStart('0');
            if (string.IsNullOrEmpty(numberStr))
                return "Không";
            
            long number = long.Parse(numberStr);
            
            if (number == 0)
                return "Không";
            
            return ConvertNumberToVietnamese(number);
        }

        private string ConvertNumberToVietnamese(long number)
        {
            if (number == 0)
                return "Không";
            
            string[] units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] levels = { "", "nghìn", "triệu", "tỷ" };
            
            string result = "";
            int levelIndex = 0;
            
            while (number > 0)
            {
                int group = (int)(number % 1000);
                if (group > 0)
                {
                    string groupText = ReadThreeDigits(group, units);
                    if (!string.IsNullOrEmpty(groupText))
                    {
                        if (!string.IsNullOrEmpty(result))
                        {
                            result = groupText + " " + levels[levelIndex] + " " + result;
                        }
                        else
                        {
                            result = groupText + (levelIndex > 0 ? " " + levels[levelIndex] : "");
                        }
                    }
                }
                number /= 1000;
                levelIndex++;
            }
            
            // Capitalize first letter
            if (!string.IsNullOrEmpty(result))
            {
                result = char.ToUpper(result[0]) + result.Substring(1);
            }
            
            return result.Trim();
        }

        private string ReadThreeDigits(int number, string[] units)
        {
            string result = "";
            
            int hundred = number / 100;
            int ten = (number % 100) / 10;
            int unit = number % 10;
            
            // Đọc hàng trăm
            if (hundred > 0)
            {
                result = units[hundred] + " trăm";
            }
            
            // Đọc hàng mười 10 chục 
            if (ten > 1)
            {
                result += (result.Length > 0 ? " " : "") + units[ten] + " mươi";
            }
            else if (ten == 1)
            {
                result += (result.Length > 0 ? " " : "") + "mười";
            }
            else if (ten == 0 && unit > 0 && hundred > 0)
            {
                result += " linh";
            }
            
            // Đọc đơn vị đơn 
            if (unit > 0)
            {
                if (unit == 5 && ten >= 1)
                {
                    result += " lăm";
                }
                else if (unit == 1 && ten >= 2)
                {
                    result += " mốt";
                }
                else
                {
                    result += (result.Length > 0 ? " " : "") + units[unit];
                }
            }
            
            return result.Trim();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtResult.Clear();
            txtInput.Focus();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}