using Source_Control_Test.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source_Control_Test.Forms
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
            //
            MessageBox.Show(    "Hello world!", 
                                "Information", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );

            MessageBox.Show(    "Development Add 1", 
                                "Information", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );
            //

            //
            Messages.Show();
            //
        }

        private void AnotherButtonButton_Click ( object sender, EventArgs e )
        {
            MessageBox.Show(    "This is another button!", 
                                "Information", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );
        }
        //
    }
}
