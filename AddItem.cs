﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 뎁라디오
{
	public partial class AddItem : Form
	{
		public AddItem()
		{
			InitializeComponent();
		}

		private void OK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
		
	}
}
