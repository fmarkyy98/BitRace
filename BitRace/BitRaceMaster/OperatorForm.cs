using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitRaceMaster
{
    public partial class OperatorForm : Form
    {
        public OperatorForm()
        {
            InitializeComponent();
        }

        public void SQLState_Changed(object sender, EventArgs e)
        {
            SQL_StatusLabel.Text =
        }

        #region DiagramGeneratedPropertyes
        internal ServerConnector ServerConnector
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        #endregion

        private void OperatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
