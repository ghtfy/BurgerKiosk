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

        private readonly Control[] burgerControls;
        private readonly Control[] optionControls;

        public Form1()
        {
            InitializeComponent();

            burgerControls = new Control[] { rdoHamBurger, rdoBulgogiBurger, rdoChickenBurger };
            optionControls = new Control[] { chkPotato, chkCola, chkCheese, chkSauce };

            ConfigureKeyboardNavigation();
            this.Shown += Form1_Shown;
        }

        private void ConfigureKeyboardNavigation()
        {
            grpMenu.TabStop = true;
            grpOption.TabStop = true;
            grpOrder.TabStop = true;

            grpMenu.TabIndex = 0;
            grpOption.TabIndex = 1;
            grpOrder.TabIndex = 2;
            btnOrder.TabIndex = 3;
            btninit.TabIndex = 4;

            foreach (Control control in burgerControls)
            {
                control.TabStop = false;
                control.KeyDown += MenuControl_KeyDown;
            }

            foreach (Control control in optionControls)
            {
                control.TabStop = false;
                control.KeyDown += OptionControl_KeyDown;
            }

            grpMenu.Enter += grpMenu_Enter;
            grpOption.Enter += grpOption_Enter;

            btnOrder.KeyDown += Button_KeyDown;
            btninit.KeyDown += Button_KeyDown;
        }

        private void grpMenu_Enter(object sender, EventArgs e)
        {
            Control target = burgerControls.FirstOrDefault(c => c is RadioButton && ((RadioButton)c).Checked) ?? burgerControls[0];
            target.Focus();
        }

        private void grpOption_Enter(object sender, EventArgs e)
        {
            Control target = optionControls.FirstOrDefault(c => c is CheckBox && ((CheckBox)c).Checked) ?? optionControls[0];
            target.Focus();
        }

        private void MenuControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                MoveFocus(sender as Control, burgerControls, 1);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                MoveFocus(sender as Control, burgerControls, -1);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void OptionControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                MoveFocus(sender as Control, optionControls, 1);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                MoveFocus(sender as Control, optionControls, -1);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void MoveFocus(Control current, Control[] controls, int direction)
        {
            if (current == null)
            {
                return;
            }

            int currentIndex = Array.IndexOf(controls, current);
            if (currentIndex < 0)
            {
                return;
            }

            int nextIndex = (currentIndex + direction + controls.Length) % controls.Length;
            controls[nextIndex].Focus();
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            Button button = sender as Button;
            if (button == null)
            {
                return;
            }

            button.PerformClick();
            e.Handled = true;
            e.SuppressKeyPress = true;
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
