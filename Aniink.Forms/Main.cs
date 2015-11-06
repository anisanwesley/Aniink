using Aniink.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aniink.Forms
{
    public partial class Main : Form
    {

        Manager _man;
        Printer _selected;

        public Main()
        {
            _man = new Manager();

            InitializeComponent();

            listPrinters.Items.AddRange(_man.Printers.ToArray());

            listPrinters.ContextMenu = PrinterListContextMenu();

        }

        private ContextMenu PrinterListContextMenu()
        {
            var contextMenu = new ContextMenu();

            var viewDetails = new MenuItem
            {
                Index = 0,
                Text = "View Details"
            };
            viewDetails.Click += ViewDetails_Click;

            var setAsDefault = new MenuItem
            {
                Index = 1,
                Text = "Set As Default"
            };
            setAsDefault.Click += SetAsDefault_Click;

            contextMenu.MenuItems.AddRange(new MenuItem[] { viewDetails, setAsDefault });



            return contextMenu;
        }

        public void ViewDetails_Click(object sender, EventArgs e)
        {

        }

        public void SetAsDefault_Click(object sender, EventArgs e)
        {
            _man.SetDefaultPrinter(_selected);
        }
        
        private void listPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selected = ((ListBox)sender).SelectedItem as Printer;
        }
    }
}

        