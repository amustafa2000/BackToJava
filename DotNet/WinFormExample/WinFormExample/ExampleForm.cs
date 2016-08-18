using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExample
{
	public partial class ExampleForm : Form
	{
		public ExampleForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.textBox1.Text ="Hellow World";
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Console.Out.Write("Text Changed");
		}

		private void ExampleForm_Load(object sender, EventArgs e)
		{
			Console.Out.Write("XXXXXXXXXXXXX Form Load Called");
		}
	}
}
