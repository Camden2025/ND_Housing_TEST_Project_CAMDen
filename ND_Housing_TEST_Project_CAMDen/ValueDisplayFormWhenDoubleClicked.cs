using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ND_Housing_TEST_Project_CAMDen
{
    public partial class ValueDisplayFormWhenDoubleClicked : Form{ //start of  public partial class 
        public ValueDisplayFormWhenDoubleClicked()
        {
            InitializeComponent();
        }

       // Below handels the closing out of a double clicked cells ui. and also closing it using the enter or escape(ESC) key
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
