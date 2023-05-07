using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Memory;

namespace TrainerShadowFlear
{
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
        }

        //private readonly string nameGame = "00001A28-ShadowFlare for Window98/Me/2000";
        private readonly string nameGame = "ShadowFlare.exe";

        private readonly Mem mem = new Mem();

        private Thread checkGameThread;

        private int pID = 0;
        private string mineAddress = "base+430A4";
        private string initialMineValue = null;

        private string hpAddress = "base+43EDC";
        private string initialHpValue = null;

        private string manaAddress = "base+428C9";
        private string initialManaValue = null;

        private string expCharacterAddress = "base+0008CE08";

        private string powerAddress = "base+439C7";

        private void UpdateStatusLabel(string status)
        {
            if (labelStatusGame.InvokeRequired)
            {
                labelStatusGame.Invoke(new Action<string>(UpdateStatusLabel), status);
            }
            else
            {
                labelStatusGame.Text = status;
            }
        }

        private void CheckGame()
        {
            while (true)
            {
                int pID = mem.GetProcIdFromName(nameGame);
                if (pID == 0)
                {
                    MessageBox.Show("Vui lòng chạy game!", "Trainer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(0);
                }
                Thread.Sleep(3000);
            }
        }

        private void Trainer_Load(object sender, EventArgs e)
        {
            checkGameThread = new Thread(new ThreadStart(CheckGame));
            checkGameThread.Start();
            pID = mem.GetProcIdFromName(nameGame);
            mem.OpenProcess(pID);
            initialMineValue = ReadByteMem(mineAddress);
            initialManaValue = ReadByteMem(manaAddress);
            initialHpValue = ReadByteMem(hpAddress);
        }

        private string ReadByteMem(string address)
        {
            return mem.ReadByte(address).ToString("X2");
        }

        private void BtnExist_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u want to Exist !!!", "Trainer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void BoxHp_CheckedChanged(object sender, EventArgs e)
        {
            string newValue = "01";
            if (sender is CheckBox checkbox && checkbox.Checked)
            {
                mem.WriteMemory(hpAddress, "bytes", newValue);
                labelHp.BackColor = Color.Red;
            }
            else
            {
                mem.WriteMemory(hpAddress, "bytes", initialHpValue);
                labelHp.BackColor = Color.Transparent;
            }
        }

        private void CBoxMine_CheckedChanged(object sender, EventArgs e)
        {
            string newValue = "90";
            if (sender is CheckBox checkbox && checkbox.Checked)
            {
                mem.WriteMemory(mineAddress, "bytes", newValue);
                labelMine.BackColor = Color.Red;
            }
            else
            {
                mem.WriteMemory(mineAddress, "bytes", initialMineValue);
                labelMine.BackColor = Color.Transparent;
            }
        }

        private void CBoxMana_CheckedChanged(object sender, EventArgs e)
        {
            string newValue = "03 C7";
            if (sender is CheckBox checkbox && checkbox.Checked)
            {
                mem.WriteMemory(manaAddress, "bytes", newValue);
                labelMana.BackColor = Color.Red;
            }
            else
            {
                mem.WriteMemory(manaAddress, "bytes", initialManaValue);
                labelMana.BackColor = Color.Transparent;
            }
        }

        private void CBoxExpCharacter_CheckedChanged(object sender, EventArgs e)
        {
            string newValue = "99999999";
            string address = expCharacterAddress + ",0,28,CC,310,E8";
            if (sender is CheckBox checkbox && checkbox.Checked)
            {
                mem.FreezeValue(address,"int",newValue);
                labelExpCharacter.BackColor = Color.Red;
            }
            else
            {
                mem.UnfreezeValue(address);
                labelExpCharacter.BackColor = Color.Transparent;
            }
        }

        private bool CheckNumber(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }

        private void WriteGold(string gold)
        {
            string address = "base+0008CE0C,4,0,514,40";
            mem.WriteMemory(address, "int", gold);
        }

        private void BtnGold_Click(object sender, EventArgs e)
        {
            string gold = txtGold.Text;
            if (CheckNumber(gold))
            {
                WriteGold(gold);
            }
            else
            {
                MessageBox.Show("Number please!!!", "Trainer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CbPower_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkbox && checkbox.Checked)
            {
                byte[] newOpcode = { 0xFF, 0x86, 0x54, 0x15, 0x00, 0x00 };
                mem.WriteBytes(powerAddress, newOpcode);
                labelPower.BackColor = Color.Red;
            }
        }
        private void CBoxExpFireBall_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkbox && checkbox.Checked)
            {
                string address = "base+0008CE0C,4,0,4E4,30,14F4";
                mem.WriteMemory(address, "int", "9999");
                labelFireBall.BackColor = Color.Red;
            }
            else
            {
                labelFireBall.BackColor = Color.Transparent;
            }
        }
    }
}
