﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ProductDbContext context = new ProductDbContext();


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void ShowDataGridView()
        {
            //取得目前清單中的value值
            int categoryId = int.Parse(comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = context.產品資料s.Where(m => m.類別編號 == categoryId).ToList();
            textBox2.Text = textBox3.Text = textBox4.Text = "";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //將產品類別顯示在combo中
            comboBox1.DataSource = context.產品類別s.ToList();
            comboBox1.DisplayMember = "類別名稱";
            comboBox1.ValueMember = "類別編號";

            // 依類別名稱清單取得產品紀錄顯示在dataGridView
            ShowDataGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
