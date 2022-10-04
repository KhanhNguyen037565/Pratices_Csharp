﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPQUANLYTRUYEN
{

    public partial class Form1 : Form
    {
        private Button buttonHienHanh;
        private Random random;
        private int chiSoTamThoi;
        //constructors
        public Form1()
        {
            InitializeComponent();
           
            random = new Random();
        }
        
        //phuong thuc
        // chon random màu từ danh sách màu theme
        private Color chonMauTuTheme()
        {
            int chiSo = random.Next(ThemeColor.DanhSachColor.Count);
            // nếu màu đã được chọn, chúng tôi chọn lại để chọn một màu khác
            while (chiSoTamThoi == chiSo)
            {
                chiSo= random.Next(ThemeColor.DanhSachColor.Count);
            }
            chiSoTamThoi = chiSo;
            string color = ThemeColor.DanhSachColor[chiSo];
            return ColorTranslator.FromHtml(color);
        }
        // chúng ta làm nổi bật button đã được click:
        // 1. chúng ta chọn random màu từ theme, cần sử dụng 1 màu đơn để làm nổi bật button
        // 2. chúng ta thay đổi màu nền của button
        // 3. chúng ta thay đổi màu chữ của button
        // 4. chúng ta thay đổi kích thước chữ của button
        private void buttonHoatDong(object btnSender)
        {
            if(btnSender != null)
            {
                if(buttonHienHanh != (Button)btnSender)
                {
                    voHieuHoaButton();
                    Color color = chonMauTuTheme();
                    buttonHienHanh = (Button)btnSender;
                    buttonHienHanh.BackColor = color;
                    buttonHienHanh.ForeColor = Color.White;
                    buttonHienHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    panelTieuDe.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.4);
                }
            }
        }

        // chúng ta hủy kích hoạt làm nổi bật button - giá trị mặc định
        private void voHieuHoaButton()
        {
            foreach(Control truocButton in panelSideMenu.Controls)
            {
                if(truocButton.GetType() == typeof(Button))
                {
                    truocButton.BackColor = Color.FromArgb(51, 51, 76);
                    truocButton.ForeColor = Color.Gainsboro;
                    truocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                }
            }
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            buttonHoatDong(sender);
          
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            buttonHoatDong(sender);
            
        }

        private void btnTruyen_Click(object sender, EventArgs e)
        {
            buttonHoatDong(sender);
            
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            buttonHoatDong(sender);
            
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            buttonHoatDong(sender);
           
        }

        private void btnDanhSachMuon_Click(object sender, EventArgs e)
        {
            buttonHoatDong(sender);
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            buttonHoatDong(sender);
            
        }


    }
}
