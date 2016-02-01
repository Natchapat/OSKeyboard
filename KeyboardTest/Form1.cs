using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardTest
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000; 
                return param;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Chnlg_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                checkBox3.Checked = true;
                Chnlg.Text = "EN";
            }
            else
            {
                checkBox3.Checked = false;
                Chnlg.Text = "TH";
            }
        }

        private void Capslk_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                Capslk.BackColor = Color.Gray;
            }
            else
            {
                checkBox1.Checked = false;
                Capslk.BackColor = Color.White;
            }
        }

        private void LShift_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                checkBox2.Checked = true;
                RShift.BackColor = Color.Gray;
                LShift.BackColor = Color.Gray;
            }
            else
            {
                checkBox2.Checked = false;
                RShift.BackColor = Color.White;
                LShift.BackColor = Color.White;
            }
        }

        private void RShift_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                checkBox2.Checked = true;
                LShift.BackColor = Color.Gray;
                RShift.BackColor = Color.Gray;
            }
            else
            {
                checkBox2.Checked = false;
                LShift.BackColor = Color.White;
                RShift.BackColor = Color.White;
            }
        }

        private void Q_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%q");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^q");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;                    
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%q");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^q");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;                    
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%q");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๐");
                        }
                        else
                        {
                            SendKeys.Send("Q");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ๆ");
                        }
                        else
                        {
                            SendKeys.Send("q");
                        }
                    }
                }
            }
        }

        private void W_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%w");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^w");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%w");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^w");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%w");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("\"");
                        }
                        else
                        {
                            SendKeys.Send("W");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ไ");
                        }
                        else
                        {
                            SendKeys.Send("w");
                        }
                    }
                }
             }
        }

        private void E_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%e");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^e");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%e");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^e");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%e");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฎ");
                        }
                        else
                        {
                            SendKeys.Send("E");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ำ");
                        }
                        else
                        {
                            SendKeys.Send("e");
                        }
                    }
                }
             }
        }

        private void R_Click(object sender, EventArgs e)
        {
             if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%r");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^r");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%r");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^r");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%r");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฑ");
                        }
                        else
                        {
                            SendKeys.Send("R");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("พ");
                        }
                        else
                        {
                            SendKeys.Send("r");
                        }
                    }
                }
             }
        }

        private void T_Click(object sender, EventArgs e)
        {
           if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%t");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^t");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%t");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^t");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%t");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ธ");
                        }
                        else
                        {
                            SendKeys.Send("T");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ะ");
                        }
                        else
                        {
                            SendKeys.Send("t");
                        }
                    }
                }
             }
        }

        private void Y_Click(object sender, EventArgs e)
        {
           if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%y");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^y");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%y");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^y");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%y");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ํ");
                        }
                        else
                        {
                            SendKeys.Send("Y");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ั");
                        }
                        else
                        {
                            SendKeys.Send("y");
                        }
                    }
                }
             }
        }

        private void U_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%u");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^u");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%u");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^u");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%u");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๊");
                        }
                        else
                        {
                            SendKeys.Send("U");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ี");
                        }
                        else
                        {
                            SendKeys.Send("u");
                        }
                    }
                }
            }
             
        }

        private void I_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%i");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^i");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%i");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^i");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%i");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ณ");
                        }
                        else
                        {
                            SendKeys.Send("I");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ร");
                        }
                        else
                        {
                            SendKeys.Send("i");
                        }
                    }
                }
            }
        }

        private void O_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%o");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^o");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%o");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^o");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%o");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฯ");
                        }
                        else
                        {
                            SendKeys.Send("O");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("น");
                        }
                        else
                        {
                            SendKeys.Send("o");
                        }
                    }
                }
            }
        }

        private void P_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%p");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^p");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%p");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^p");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%p");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ญ");
                        }
                        else
                        {
                            SendKeys.Send("P");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ย");
                        }
                        else
                        {
                            SendKeys.Send("p");
                        }
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%[");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^[");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%[");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^[");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%[");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฐ");
                        }
                        else
                        {
                            SendKeys.Send("{");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("บ");
                        }
                        else
                        {
                            SendKeys.Send("[");
                        }
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%]");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^]");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%]");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^]");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%]");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send(",");
                        }
                        else
                        {
                            SendKeys.Send("}");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ล");
                        }
                        else
                        {
                            SendKeys.Send("]");
                        }
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                if (checkBox3.Checked)
                {
                    SendKeys.Send("ฅ");
                }
                else
                {
                    SendKeys.Send("|");
                }
                checkBox2.Checked = false;
                LShift.BackColor = Color.White;
                RShift.BackColor = Color.White;
            }
            else
            {
                if (checkBox3.Checked)
                {
                    SendKeys.Send("ฃ");
                }
                else
                {
                    SendKeys.Send("\\");
                }
            }
        }

        private void A_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%a");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^a");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%a");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^a");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%a");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฤ");
                        }
                        else
                        {
                            SendKeys.Send("A");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฟ");
                        }
                        else
                        {
                            SendKeys.Send("a");
                        }
                    }
                }
            }
        }

        private void S_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%s");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^s");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%s");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^s");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%s");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฆ");
                        }
                        else
                        {
                            SendKeys.Send("S");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ห");
                        }
                        else
                        {
                            SendKeys.Send("s");
                        }
                    }
                }
            }
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%d");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^d");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%d");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^d");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%d");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฏ");
                        }
                        else
                        {
                            SendKeys.Send("D");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ก");
                        }
                        else
                        {
                            SendKeys.Send("d");
                        }
                    }
                }
            }
        }

        private void F_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%f");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^f");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%f");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^f");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%f");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("โ");
                        }
                        else
                        {
                            SendKeys.Send("F");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ด");
                        }
                        else
                        {
                            SendKeys.Send("f");
                        }
                    }
                }
            }
        }

        private void G_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%g");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^g");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%g");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^g");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%g");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฌ");
                        }
                        else
                        {
                            SendKeys.Send("G");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("เ");
                        }
                        else
                        {
                            SendKeys.Send("g");
                        }
                    }
                }
            }
        }

        private void H_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%h");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^h");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%h");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^h");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%h");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("็");
                        }
                        else
                        {
                            SendKeys.Send("H");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("้");
                        }
                        else
                        {
                            SendKeys.Send("h");
                        }
                    }
                }
            }
        }

        private void J_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%j");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^j");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%j");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^j");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%j");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๋");
                        }
                        else
                        {
                            SendKeys.Send("J");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("่");
                        }
                        else
                        {
                            SendKeys.Send("j");
                        }
                    }
                }
            }
        }

        private void K_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%k");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^k");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%k");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^k");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%k");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ษ");
                        }
                        else
                        {
                            SendKeys.Send("K");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("า");
                        }
                        else
                        {
                            SendKeys.Send("k");
                        }
                    }
                }
            }
        }

        private void L_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%l");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^l");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%l");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^l");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%l");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ศ");
                        }
                        else
                        {
                            SendKeys.Send("L");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ส");
                        }
                        else
                        {
                            SendKeys.Send("l");
                        }
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%;");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^;");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%;");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^;");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%;");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send(":");
                        }
                        else
                        {
                            SendKeys.Send("E");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ว");
                        }
                        else
                        {
                            SendKeys.Send(";");
                        }
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%'");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^'");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%'");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^'");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%'");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send(".");
                        }
                        else
                        {
                            SendKeys.Send("\"");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ง");
                        }
                        else
                        {
                            SendKeys.Send("'");
                        }
                    }
                }
            }
        }

        private void Z_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%z");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^z");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%z");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^z");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%z");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("(");
                        }
                        else
                        {
                            SendKeys.Send("Z");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ผ");
                        }
                        else
                        {
                            SendKeys.Send("z");
                        }
                    }
                }
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%x");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^x");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%x");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^x");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%x");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send(")");
                        }
                        else
                        {
                            SendKeys.Send("X");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ป");
                        }
                        else
                        {
                            SendKeys.Send("x");
                        }
                    }
                }
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%c");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^c");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%c");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^c");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%c");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฉ");
                        }
                        else
                        {
                            SendKeys.Send("C");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("แ");
                        }
                        else
                        {
                            SendKeys.Send("c");
                        }
                    }
                }
            }
        }

        private void V_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%v");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^v");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%v");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^v");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%v");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฮ");
                        }
                        else
                        {
                            SendKeys.Send("V");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("อ");
                        }
                        else
                        {
                            SendKeys.Send("v");
                        }
                    }
                }
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%b");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^b");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%b");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^b");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%b");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฺ");
                        }
                        else
                        {
                            SendKeys.Send("B");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ิ");
                        }
                        else
                        {
                            SendKeys.Send("b");
                        }
                    }
                }
            }
        }

        private void N_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%n");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^n");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%n");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^n");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%n");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("์");
                        }
                        else
                        {
                            SendKeys.Send("N");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ื");
                        }
                        else
                        {
                            SendKeys.Send("n");
                        }
                    }
                }
            }
        }

        private void M_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%m");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^m");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%m");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^m");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%m");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("?");
                        }
                        else
                        {
                            SendKeys.Send("M");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ท");
                        }
                        else
                        {
                            SendKeys.Send("m");
                        }
                    }
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%,");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^,");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%,");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^,");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%,");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฒ");
                        }
                        else
                        {
                            SendKeys.Send("<");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ม");
                        }
                        else
                        {
                            SendKeys.Send(",");
                        }
                    }
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%.");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^.");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%.");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^.");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%.");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ฬ");
                        }
                        else
                        {
                            SendKeys.Send(">");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ใ");
                        }
                        else
                        {
                            SendKeys.Send(".");
                        }
                    }
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                if (checkBox3.Checked)
                {
                    SendKeys.Send("ฦ");
                }
                else
                {
                    SendKeys.Send("?");
                }
                checkBox2.Checked = false;
                LShift.BackColor = Color.White;
                RShift.BackColor = Color.White;
            }
            else
            {
                if (checkBox3.Checked)
                {
                    SendKeys.Send("ฝ");
                }
                else
                {
                    SendKeys.Send("/");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%1");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^1");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%1");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^1");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%1");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("+");
                        }
                        else
                        {
                            SendKeys.Send("!");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ๅ");
                        }
                        else
                        {
                            SendKeys.Send("1");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%2");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^2");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%2");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^2");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%2");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๑");
                        }
                        else
                        {
                            SendKeys.Send("@");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("/");
                        }
                        else
                        {
                            SendKeys.Send("2");
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%3");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^3");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%3");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^3");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%3");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๒");
                        }
                        else
                        {
                            SendKeys.Send("#");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("-");
                        }
                        else
                        {
                            SendKeys.Send("3");
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%4");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^4");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%4");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^4");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%4");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๓");
                        }
                        else
                        {
                            SendKeys.Send("$");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ภ");
                        }
                        else
                        {
                            SendKeys.Send("4");
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%5");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^5");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%5");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^5");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%5");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๔");
                        }
                        else
                        {
                            SendKeys.Send("%");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ถ");
                        }
                        else
                        {
                            SendKeys.Send("5");
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%6");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^6");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%6");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^6");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%6");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ู");
                        }
                        else
                        {
                            SendKeys.Send("^");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ุ");
                        }
                        else
                        {
                            SendKeys.Send("6");
                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%7");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^7");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%7");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^7");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%7");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("฿");
                        }
                        else
                        {
                            SendKeys.Send("&");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ึ");
                        }
                        else
                        {
                            SendKeys.Send("7");
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%8");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^8");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%8");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^8");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%8");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๕");
                        }
                        else
                        {
                            SendKeys.Send("*");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ค");
                        }
                        else
                        {
                            SendKeys.Send("8");
                        }
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%9");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^9");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%9");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^9");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%9");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๖");
                        }
                        else
                        {
                            SendKeys.Send("(");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ต");
                        }
                        else
                        {
                            SendKeys.Send("9");
                        }
                    }
                }
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%0");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^0");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%0");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^0");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%0");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๗");
                        }
                        else
                        {
                            SendKeys.Send(")");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("จ");
                        }
                        else
                        {
                            SendKeys.Send("0");
                        }
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%-");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^-");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%-");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^-");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%-");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๘");
                        }
                        else
                        {
                            SendKeys.Send("_");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ข");
                        }
                        else
                        {
                            SendKeys.Send("-");
                        }
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (checkBox2.Checked)
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("+^%=");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("+^=");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                {
                    if (checkBox5.Checked)
                    {
                        SendKeys.SendWait("^%=");
                        LAlt.BackColor = Color.White;
                        RAlt.BackColor = Color.White;
                        checkBox5.Checked = false;
                    }
                    else
                    {
                        SendKeys.SendWait("^=");
                    }
                    LShift.BackColor = Color.White;
                    RShift.BackColor = Color.White;
                    LCtrl.BackColor = Color.White;
                    RCtrl.BackColor = Color.White;
                    checkBox2.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                if (checkBox5.Checked)
                {
                    SendKeys.SendWait("%=");
                    LAlt.BackColor = Color.White;
                    RAlt.BackColor = Color.White;
                    checkBox5.Checked = false;
                }
                else
                {
                    if (checkBox1.Checked || checkBox2.Checked)
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("๙");
                        }
                        else
                        {
                            SendKeys.Send("+");
                        }
                        checkBox2.Checked = false;
                        LShift.BackColor = Color.White;
                        RShift.BackColor = Color.White;
                    }
                    else
                    {
                        if (checkBox3.Checked)
                        {
                            SendKeys.Send("ช");
                        }
                        else
                        {
                            SendKeys.Send("=");
                        }
                    }
                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void BTEnd_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{END}");
        }

        private void Del_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
        }

        private void PrtSc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

        private void ESC_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void F1_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F1}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F1}");
            }
        }

        private void F2_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F2}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F2}");
            }
        }

        private void F3_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F3}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F3}");
            }
        }

        private void F4_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F4}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F4}");
            }
        }

        private void F5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F5}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F5}");
            }
        }

        private void F6_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F6}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F6}");
            }
        }

        private void F7_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F7}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F7}");
            }
        }

        private void F8_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F8}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F8}");
            }
        }

        private void F9_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F9}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F9}");
            }
        }

        private void F10_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F10}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F10}");
            }
        }

        private void F11_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F11}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F11}");
            }
        }

        private void F12_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SendKeys.SendWait("%{F12}");
                LAlt.BackColor = Color.White;
                RAlt.BackColor = Color.White;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("{F12}");
            }
        }

        private void PgUp_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void PgDn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void BackSp_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void BTEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void Space_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void BTUp_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Up}");
        }

        private void BTLeft_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Left}");
        }

        private void BTDown_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Down}");
        }

        private void BTRight_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Right}");
        }
        
        private void Tab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Tab}");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{Esc}");
        }

        private void LCtrl_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                checkBox4.Checked = true;
                RCtrl.BackColor = Color.Gray;
                LCtrl.BackColor = Color.Gray;
            }
            else
            {
                checkBox4.Checked = false;
                RCtrl.BackColor = Color.White;
                LCtrl.BackColor = Color.White;
            }
        }

        private void RCtrl_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                checkBox4.Checked = true;
                RCtrl.BackColor = Color.Gray;
                LCtrl.BackColor = Color.Gray;
            }
            else
            {
                checkBox4.Checked = false;
                RCtrl.BackColor = Color.White;
                LCtrl.BackColor = Color.White;
            }
        }

        private void LAlt_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false)
            {
                checkBox5.Checked = true;
                RAlt.BackColor = Color.Gray;
                LAlt.BackColor = Color.Gray;
            }
            else
            {
                checkBox5.Checked = false;
                RAlt.BackColor = Color.White;
                LAlt.BackColor = Color.White;
            }
        }

        private void RAlt_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false)
            {
                checkBox5.Checked = true;
                RAlt.BackColor = Color.Gray;
                LAlt.BackColor = Color.Gray;
            }
            else
            {
                checkBox5.Checked = false;
                RAlt.BackColor = Color.White;
                LAlt.BackColor = Color.White;
            }
        }
    }
}