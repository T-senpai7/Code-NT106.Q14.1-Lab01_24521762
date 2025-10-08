using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class Bai8Form : Form
    {
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private Label lblInstruction;
        private TextBox txtNewFood;
        private Button btnAdd;
        private Button btnRandom;
        private Panel panelResult;
        private Label lblResultFood;
        private ListBox lstFoods;
        private Button btnReset;
        private Label lblCount;

        private string danhSachMonAn = "Phở, Bún chả, Cơm tấm, Bánh mì, Mì Quảng, Bún bò Huế, Cao lầu, Hủ tiếu, Bánh xèo, Gỏi cuốn";

        public Bai8Form()
        {
            InitializeComponent();
            CapNhatDanhSach();
        }

        private void InitializeComponent()
        {
            Text = "Hôm nay ăn gì?";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(650, 700);
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Padding = new Padding(0);

            panelHeader = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(650, 100),
                BackColor = Color.FromArgb(255, 87, 34)
            };

            lblTitle = new Label
            {
                Text = "🍽️ HÔM NAY ĂN GÌ?",
                Location = new Point(0, 30),
                Size = new Size(650, 40),
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelHeader.Controls.Add(lblTitle);

            panelMain = new Panel
            {
                Location = new Point(30, 120),
                Size = new Size(590, 540),
                BackColor = Color.White
            };

            lblInstruction = new Label
            {
                Text = "Thêm món ăn yêu thích",
                Location = new Point(0, 0),
                Size = new Size(590, 25),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 60, 60)
            };

            txtNewFood = new TextBox
            {
                Location = new Point(0, 35),
                Size = new Size(450, 40),
                Font = new Font("Segoe UI", 12),
                BorderStyle = BorderStyle.FixedSingle
            };
            txtNewFood.KeyPress += TxtNewFood_KeyPress;

            btnAdd = new Button
            {
                Text = "Thêm",
                Location = new Point(460, 35),
                Size = new Size(130, 40),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(76, 175, 80),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Click += BtnAdd_Click;

            btnRandom = new Button
            {
                Text = "🎲 CHỌN MÓN NGẪU NHIÊN",
                Location = new Point(0, 95),
                Size = new Size(590, 55),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 87, 34),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnRandom.FlatAppearance.BorderSize = 0;
            btnRandom.Click += BtnRandom_Click;

            panelResult = new Panel
            {
                Location = new Point(0, 170),
                Size = new Size(590, 100),
                BackColor = Color.FromArgb(255, 248, 225),
                BorderStyle = BorderStyle.FixedSingle
            };

            lblResultFood = new Label
            {
                Text = "...",
                Location = new Point(10, 10),
                Size = new Size(570, 80),
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 87, 34),
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelResult.Controls.Add(lblResultFood);

            lblCount = new Label
            {
                Text = "Danh sách món ăn (10 món)",
                Location = new Point(0, 290),
                Size = new Size(400, 25),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 100, 100)
            };

            btnReset = new Button
            {
                Text = "↻ Reset",
                Location = new Point(500, 287),
                Size = new Size(90, 30),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                BackColor = Color.FromArgb(245, 245, 245),
                ForeColor = Color.FromArgb(100, 100, 100),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btnReset.Click += BtnReset_Click;

            lstFoods = new ListBox
            {
                Location = new Point(0, 325),
                Size = new Size(590, 215),
                Font = new Font("Segoe UI", 11),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(250, 250, 250),
                SelectionMode = SelectionMode.One
            };

            panelMain.Controls.Add(lblInstruction);
            panelMain.Controls.Add(txtNewFood);
            panelMain.Controls.Add(btnAdd);
            panelMain.Controls.Add(btnRandom);
            panelMain.Controls.Add(panelResult);
            panelMain.Controls.Add(lblCount);
            panelMain.Controls.Add(btnReset);
            panelMain.Controls.Add(lstFoods);

            Controls.Add(panelHeader);
            Controls.Add(panelMain);
        }

        private void TxtNewFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnAdd_Click(sender, e);
                e.Handled = true;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string monAnMoi = txtNewFood.Text.Trim();

            if (string.IsNullOrWhiteSpace(monAnMoi))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewFood.Focus();
                return;
            }

            string[] danhSach = danhSachMonAn.Split(',').Select(s => s.Trim()).ToArray();
            if (danhSach.Any(mon => mon.Equals(monAnMoi, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Món '{monAnMoi}' đã có trong danh sách", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewFood.Clear();
                txtNewFood.Focus();
                return;
            }

            danhSachMonAn += ", " + monAnMoi;
            
            CapNhatDanhSach();
            txtNewFood.Clear();
            txtNewFood.Focus();

          
            FlashControl(btnAdd, Color.FromArgb(46, 125, 50));
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            string[] danhSach = danhSachMonAn.Split(',').Select(s => s.Trim()).ToArray();

            if (danhSach.Length == 0)
            {
                MessageBox.Show("Danh sách món ăn trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random random = new Random();
            int index = random.Next(0, danhSach.Length);
            string monDuocChon = danhSach[index];

            lblResultFood.Text = "🎲";
            panelResult.BackColor = Color.FromArgb(255, 235, 59);
            Application.DoEvents();
            System.Threading.Thread.Sleep(200);

            lblResultFood.Text = monDuocChon;
            panelResult.BackColor = Color.FromArgb(255, 248, 225);

            lstFoods.SelectedIndex = index;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Reset về danh sách mặc định?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                danhSachMonAn = "Phở, Bún chả, Cơm tấm, Bánh mì, Mì Quảng, Bún bò Huế, Cao lầu, Hủ tiếu, Bánh xèo, Gỏi cuốn";
                lblResultFood.Text = "...";
                CapNhatDanhSach();
                txtNewFood.Clear();
            }
        }

        private void CapNhatDanhSach()
        {
            string[] danhSach = danhSachMonAn.Split(',').Select(s => s.Trim()).ToArray();

            lstFoods.Items.Clear();
            foreach (string mon in danhSach)
            {
                lstFoods.Items.Add(mon);
            }

            lblCount.Text = $"Danh sách món ăn ({danhSach.Length} món)";
        }

        private async void FlashControl(Control control, Color flashColor)
        {
            Color originalColor = control.BackColor;
            control.BackColor = flashColor;
            await System.Threading.Tasks.Task.Delay(150);
            control.BackColor = originalColor;
        }
    }
}