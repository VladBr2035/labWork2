using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1500;
            this.Height = 800;

           BackColor = Color.DarkCyan;


        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            Label label2 = new Label();
            label2.Text = "ФИО";
            this.ForeColor = Color.Purple;
            Label label3 = new Label();
            label3.Text = "Абонентский номер";

            Label label4 = new Label();
            label4.Text = "Лицевой счет";

            Label label5 = new Label();
            label5.Text = "Услуги";

            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            this.Controls.Add(tableLayoutPanel1);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.Location = new Point(200, 80);
            tableLayoutPanel1.Size = new Size(Width = 500, Height = 350);
            tableLayoutPanel1.Controls.Add(label2);
            tableLayoutPanel1.Controls.Add(label3);
            tableLayoutPanel1.Controls.Add(label4);
            tableLayoutPanel1.Controls.Add(label5);
            tableLayoutPanel1.BackColor = Color.Cyan;
            tableLayoutPanel1.CellPaint += tableLayoutPanel1_CellPaint;

          

            Button button1 = new Button();
            button1.Text = "Логотип ТНС";
            button1.Click += button1_Click;
            this.Controls.Add(button1);
            button1.Size = new Size(Width = 70, Height = 30);
            button1.Location = new Point(15,20);
            button1.BackColor = Color.Lime;

            Button button2 = new Button();
            button2.Text = "Абоненты";
            button2.Click += button2_Click;
            this.Controls.Add(button2);
            button2.Size = new Size(Width = 70, Height = 30);
            button2.Location = new Point(15, 80);
            button2.BackColor = Color.Violet;

            Button button3 = new Button();
            button3.Text = "Управление оборудованием";
            button3.Click += button3_Click;
            this.Controls.Add(button3);
            button3.Size = new Size(Width = 70, Height = 30);
            button3.Location = new Point(15, 140);
            button3.BackColor = Color.LightYellow;

            Button button4 = new Button();
            button4.Text = "Активы";
            button4.Click += button4_Click;
            this.Controls.Add(button4);
            button4.Size = new Size(Width = 70, Height = 30);
            button4.Location = new Point(15, 200);
            button4.BackColor = Color.Pink;

            Button button5 = new Button();
            button5.Text = "Биллинг";
            button5.Click += button5_Click;
            this.Controls.Add(button5);
            button5.Size = new Size(Width = 70, Height = 30);
            button5.Location = new Point(15, 260);
            button5.BackColor = Color.Orange;

            Label label = new Label();
            label.Text = "Абоненты ТНС";
            this.Controls.Add(label);
            label.Location = new Point(200, 40);

            Button button7 = new Button();
            button7.Text = "CRM";
            button7.Click += button7_Click;
            this.Controls.Add(button7);
            button7.Size = new Size(Width = 70, Height = 30);
            button7.Location = new Point(15, 380);
            button7.BackColor = Color.Crimson;

            Button button6 = new Button();
            button6.Text = "Поддержка пользвателей";
            button6.Click += button6_Click;
            this.Controls.Add(button6);
            button6.Size = new Size(Width = 70, Height = 30);
            button6.Location = new Point(15, 320);
            button6.BackColor = Color.Gold;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Логотип ТНС");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Абоненты");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Управление оборудованием");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Активы");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Биллинг");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поддержка пользователей");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CRM");
        }

        void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0 && e.Row == 0)
                e.Graphics.DrawRectangle(new Pen(Color.Gray), e.CellBounds);
            if (e.Column == 1 && e.Row == 0)
                e.Graphics.DrawRectangle(new Pen(Color.Gray), e.CellBounds);
            if (e.Column == 2 && e.Row == 0)
                e.Graphics.DrawRectangle(new Pen(Color.Gray), e.CellBounds);
            if (e.Column == 3 && e.Row == 0)
                e.Graphics.DrawRectangle(new Pen(Color.Gray), e.CellBounds);
          
        }
    }
}
