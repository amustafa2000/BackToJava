using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApplication
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("User Name = " + this.UserName.Text);
			MessageBox.Show("User Name = " + this.UserName.Text);
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}
	}
}
