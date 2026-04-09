using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        private int totalCost = 0;

        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblGuide.Text = string.Empty;

            bool isBurgerSelected = rdoHamBurger.Checked || rdoBulgogiBurger.Checked || rdoChickenBurger.Checked;

            if ((chkCheese.Checked || chkSauce.Checked) && !isBurgerSelected)
            {
                lblGuide.Text = "치즈/소스 추가는 버거 선택 시에만 가능합니다.";
                return;
            }

            int orderCost = 0;

            if (rdoHamBurger.Checked)
            {
                orderCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                orderCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                orderCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            if (chkPotato.Checked)
            {
                orderCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }

            if (chkCola.Checked)
            {
                orderCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }

            if (chkCheese.Checked)
            {
                orderCost += 1500;
                lstOrder.Items.Add("치즈추가 1,500원");
            }

            if (chkSauce.Checked)
            {
                orderCost += 500;
                lstOrder.Items.Add("소스추가 500원");
            }

            if (orderCost == 0)
            {
                lblGuide.Text = "메뉴를 선택해주세요.";
                return;
            }

            totalCost += orderCost;
            lblTotalCost.Text = "총금액: " + totalCost.ToString("N0") + "원";
        }

        private void btninit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            totalCost = 0;
            lblTotalCost.Text = "총금액: 0원";
            lblGuide.Text = string.Empty;
        }
    }
}
