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

        private static Manager _man;
        public static Manager Manager {
            get {
                if (_man == null)
                    _man = new Manager();
                return _man;
            }

        }
        Printer _selectedPrinter;

        public Main()
        {
            _man = new Manager();

            InitializeComponent();

            listPrinters.Items.AddRange(_man.Printers.ToArray());

            listPrinters.ContextMenu = PrinterListContextMenu();

            _selectedPrinter = listPrinters.Items[0] as Printer;

        }

        private ContextMenu PrinterListContextMenu()
        {
            var contextMenu = new ContextMenu();

            var properties = new MenuItem
            {
                Index = 0,
                Text = "Properties"
            };
            properties.Click += Properties_Click;

            var setAsDefault = new MenuItem
            {
                Index = 1,
                Text = "Set As Default"
            };
            setAsDefault.Click += SetAsDefault_Click;

            var viewDetails = new MenuItem
            {
                Index = 1,
                Text = "View Details"
            };
            viewDetails.Click += ViewDetails_Click;

            contextMenu.MenuItems.AddRange(new MenuItem[] { setAsDefault , viewDetails,properties });
            
            return contextMenu;
        }

        public void Properties_Click(object sender, EventArgs e)
        {
            _man.DocumentProperty(_selectedPrinter);
        }
        public void ViewDetails_Click(object sender, EventArgs e)
        {
            var form = new PrinterInfo(_selectedPrinter);
            form.Show();
        }

        public void SetAsDefault_Click(object sender, EventArgs e)
        {
            _man.SetDefaultPrinter(_selectedPrinter);
        }
        
        private void listPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPrinter = ((ListBox)sender).SelectedItem as Printer;
        }
    }
}

        