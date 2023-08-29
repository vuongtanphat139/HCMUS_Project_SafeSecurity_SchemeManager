using DAO_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SS
{
    public partial class Encrypt_Form : Form
    {
        public Encrypt_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (value_Text.Text != "") Encrypt_Text.Text = encrypt(value_Text.Text);
        }
        //string hash = "f0xle@rn";
        string encrypt(string value)
        {
            string query = "SELECT KEY FROM QLCONGTY.KEY_ENCRYPT";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string hash = "";
            foreach (DataRow dr in dt.Rows)
            {
                hash = dr["KEY"].ToString();
                break;
            }
            string newValue = "";
            byte[] data = UTF8Encoding.UTF8.GetBytes(value);
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = MD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform tf = tripDes.CreateEncryptor();
                    byte[] rs = tf.TransformFinalBlock(data, 0, data.Length);
                    newValue = Convert.ToBase64String(rs, 0, rs.Length);
                }
            }
            return newValue;
        }
        string decrypt(string value)
        {
            string query = "SELECT KEY FROM QLCONGTY.KEY_ENCRYPT";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string hash = "";
            foreach (DataRow dr in dt.Rows)
            {
                hash = dr["KEY"].ToString();
                break;
            }
            string newValue = "";
            byte[] data = Convert.FromBase64String(value);
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = MD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform tf = tripDes.CreateDecryptor();
                    byte[] rs = tf.TransformFinalBlock(data, 0, data.Length);
                    newValue = UTF8Encoding.UTF8.GetString(rs);
                }
            }
            return newValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (value_Text.Text != "") Decrypt_Text.Text = decrypt(Encrypt_Text.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            value_Text.Text = "";
            Encrypt_Text.Text = "";
            Decrypt_Text.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
