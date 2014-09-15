using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source_Control_Test
{
    public static class Messages
    {
        public static void Show ()
        {
            MessageBox.Show(    "Hello world again!", 
                                "Information", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );
        }
    }
}
