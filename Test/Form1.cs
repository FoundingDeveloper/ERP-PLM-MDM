using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SetCulture();
            InitializeComponent();
        }
        private void SetCulture()
        {
            
            try
            {
                CultureInfo m_ci = new CultureInfo("en");
                Thread.CurrentThread.CurrentCulture = m_ci;
                Thread.CurrentThread.CurrentUICulture = m_ci;
            }
            catch
            { }
        }
    }
}
