using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source_Control_Test
{
    public partial class SimpleForm : Form
    {
        //
        public SimpleForm ()
        {
            InitializeComponent();
        }
        //

        //
        private void ButtonButton_Click ( object sender, EventArgs e )
        {
            MessageBox.Show(    "Hello world!", 
                                "Information", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );

            MessageBox.Show(    "Hello all!", 
                                "Information", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );

            MessageBox.Show(    "Hello all again!", 
                                "Information", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );

            MessageBox.Show(    "Goodbye world!", 
                                "Information", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );

            MessageBox.Show(    "Goodbye all!", 
                                "Information", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );

            MessageBox.Show(    "Goodbye all again!", 
                                "Information", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );
        }
        //
    }
}
