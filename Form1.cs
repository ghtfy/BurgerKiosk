using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        private readonly Control[] burgerControls;
        private readonly Control[] optionControls;
        private bool isUpdatingDisplay;

        public Form1()
        {
            InitializeComponent();

            burgerControls = new Control[] { rdoHamBurger, rdoBulgogiBurger, rdoChickenBurger };
            optionControls = new Control[] { chkPotato, chkCola, chkCheese, chkSauce };

            ConfigureKeyboardNavigation();
            ConfigureSelectionEvents();
            this.Shown += Form1_Shown;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Control current = GetFocusedControl(this);
            Keys key = keyData & Keys.KeyCode;
            bool isShift = (keyData & Keys.Shift) == Keys.Shift;

            if (key == Keys.Tab)
            {
                if (IsMenuFocus(current))
                {
                    if (isShift)
                    {
                        btninit.Focus();
                    }
                    else
                    {
                        FocusOptionControl();
                    }
                    return true;
                }

                if (IsOptionFocus(current))
                {
                    if (isShift)
                    {
                        FocusMenuControl();
                    }
                    else
                    {
                        btnOrder.Focus();
                    }
                    return true;
                }

                if (current == btnOrder || current == grpOrder)
                {
                    if (isShift)
                    {
                        FocusOptionControl();
                    }
                    else
                    {
                        btninit.Focus();
                    }
                    return true;
                }

                if (current == btninit)
                {
                    if (isShift)
                    {
                        btnOrder.Focus();
                    }
                    else
                    {
                        FocusMenuControl();
                    }
                    return true;
                }

                FocusMenuControl();
                return true;
            }

            if (key == Keys.Up || key == Keys.Down || key == Keys.Left || key == Keys.Right)
            {
                int direction = (key == Keys.Down || key == Keys.Right) ? 1 : -1;

                if (IsMenuFocus(current))
                {
                    if (!burgerControls.Contains(current))
                    {
                        FocusMenuControl();
                    }
                    else
                    {
                        MoveFocus(current, burgerControls, direction);
                    }
                    return true;
                }

                if (IsOptionFocus(current))
                {
                    if (!optionControls.Contains(current))
                    {
                        FocusOptionControl();
                    }
                    else
                    {
                        MoveFocus(current, optionControls, direction);
                    }
                    return true;
                }
            }

            if (key == Keys.Space)
            {
                RadioButton radioButton = current as RadioButton;
                if (radioButton != null)
                {
                    radioButton.Checked = true;
                    return true;
                }

                CheckBox checkBox = current as CheckBox;
                if (checkBox != null && checkBox.Enabled)
                {
                    checkBox.Checked = !checkBox.Checked;
                    return true;
                }
            }

            if (key == Keys.Enter)
            {
                Button button = current as Button;
                if (button != null)
                {
                    button.PerformClick();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
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
            }

            foreach (Control control in optionControls)
            {
                control.TabStop = false;
            }

            grpMenu.Enter += grpMenu_Enter;
            grpOption.Enter += grpOption_Enter;
            grpOrder.Enter += grpOrder_Enter;
        }

        private void ConfigureSelectionEvents()
        {
            rdoHamBurger.CheckedChanged += SelectionControl_CheckedChanged;
            rdoBulgogiBurger.CheckedChanged += SelectionControl_CheckedChanged;
            rdoChickenBurger.CheckedChanged += SelectionControl_CheckedChanged;

            chkPotato.CheckedChanged += SelectionControl_CheckedChanged;
            chkCola.CheckedChanged += SelectionControl_CheckedChanged;
            chkCheese.CheckedChanged += SelectionControl_CheckedChanged;
            chkSauce.CheckedChanged += SelectionControl_CheckedChanged;
        }

        private void SelectionControl_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdatingDisplay)
            {
                return;
            }

            UpdateOrderDisplay();
        }

        private Control GetFocusedControl(Control parent)
        {
            if (parent == null)
            {
                return null;
            }

            ContainerControl container = parent as ContainerControl;
            if (container == null || container.ActiveControl == null)
            {
                return parent;
            }

            return GetFocusedControl(container.ActiveControl);
        }

        private bool IsMenuFocus(Control current)
        {
            return current == grpMenu || burgerControls.Contains(current);
        }

        private bool IsOptionFocus(Control current)
        {
            return current == grpOption || optionControls.Contains(current);
        }

        private void FocusMenuControl()
        {
            Control target = burgerControls.FirstOrDefault(c => c is RadioButton && ((RadioButton)c).Checked && c.CanSelect)
                             ?? burgerControls.FirstOrDefault(c => c.CanSelect)
                             ?? burgerControls[0];
            target.Focus();
        }

        private void FocusOptionControl()
        {
            Control target = optionControls.FirstOrDefault(c => c is CheckBox && ((CheckBox)c).Checked && c.CanSelect)
                             ?? optionControls.FirstOrDefault(c => c.CanSelect)
                             ?? optionControls[0];
            target.Focus();
        }

        private void grpMenu_Enter(object sender, EventArgs e)
        {
            FocusMenuControl();
        }

        private void grpOption_Enter(object sender, EventArgs e)
        {
            FocusOptionControl();
        }

        private void grpOrder_Enter(object sender, EventArgs e)
        {
            btnOrder.Focus();
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

            int nextIndex = currentIndex;
            for (int i = 0; i < controls.Length; i++)
            {
                nextIndex = (nextIndex + direction + controls.Length) % controls.Length;
                if (controls[nextIndex].CanSelect)
                {
                    controls[nextIndex].Focus();
                    return;
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            UpdateOrderDisplay();
            FocusMenuControl();
        }

        private void UpdateOrderDisplay()
        {
            isUpdatingDisplay = true;
            try
            {
                lblGuide.Text = string.Empty;
                lstOrder.Items.Clear();

                bool isBurgerSelected = rdoHamBurger.Checked || rdoBulgogiBurger.Checked || rdoChickenBurger.Checked;

                chkCheese.Enabled = isBurgerSelected;
                chkSauce.Enabled = isBurgerSelected;

                if (!isBurgerSelected)
                {
                    chkCheese.Checked = false;
                    chkSauce.Checked = false;

                    Control focused = GetFocusedControl(this);
                    if (focused == chkCheese || focused == chkSauce)
                    {
                        chkPotato.Focus();
                    }
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

                lblTotalCost.Text = "총금액: " + orderCost.ToString("N0") + "원";

                if (orderCost == 0)
                {
                    lblGuide.Text = "메뉴를 선택해주세요.";
                }
                else
                {
                    lblGuide.Text = "Tab: 영역 이동 / 방향키: 항목 이동 / Space: 선택 / Enter: 주문";
                }
            }
            finally
            {
                isUpdatingDisplay = false;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lstOrder.Items.Count == 0)
            {
                lblGuide.Text = "메뉴를 선택해주세요.";
                return;
            }

            lblGuide.Text = "주문이 완료되었습니다.";
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

            UpdateOrderDisplay();
            FocusMenuControl();
        }
    }

}
