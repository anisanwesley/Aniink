using Aniink.Library;
using Aniink.Library.Structures;
using System;
using Extensions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aniink.Library.Enums;

namespace Aniink.Forms
{
    public partial class PrinterInfo : Form
    {
        ToolTip tooltip;

        PRINTER_INFO_2 info;

        const int partialWidth = 390;
        const int fullWidth = 592;

        public PrinterInfo(Printer printer)
        {
            tooltip = new ToolTip();
            InitializeComponent();

            info = Main.Manager.GetPrinter(printer);
        }

        private void PrinterInfo_Load(object sender, EventArgs e)
        {
            SetTexts();
            SetAttributes();


            tooltip.SetToolTip(txtPortName, txtPortName.Text);
            tooltip.SetToolTip(txtDriverName, txtDriverName.Text);

            Show_More();


        }


        private void Show_More(object sender, EventArgs e)
        {
            btnMore.Text = "<< Hide";
            btnMore.Click += Hide_More;
            btnMore.Click -= Show_More;
            Size = new Size(fullWidth, Size.Height);
        }
        private void Hide_More(object sender, EventArgs e)
        {
            btnMore.Text = "More >>";
            btnMore.Click -= Hide_More;
            btnMore.Click += Show_More;
            Size = new Size(partialWidth, Size.Height);


        }
        private void Show_More() { Show_More(null, null); }



        private void SetTexts()
        {
            this.Text = groupBox.Text= info.pPrinterName;
            txtServerName.Text = info.pServerName;
            txtSharedName.Text = info.pShareName;
            txtPortName.Text = info.pPortName;
            txtDriverName.Text = info.pDriverName;
            txtDevMode.Text = info.pDevMode.ToString();
            txtPrintProcessor.Text = info.pPrintProcessor;
            txtDataType.Text = info.pDatatype;
            txtSecurityDescr.Text = info.pSecurityDescriptor.ToString();
            txtPriority.Text = info.Priority.ToString();
            txtDefaultPriority.Text = info.DefaultPriority.ToString();
            txtStartTime.Text = info.StartTime.ToString();
            txtUntilTime.Text = info.UntilTime.ToString();
            txtStatus.Text = info.Status.ToString();
            txtJobs.Text = info.cJobs.ToString();
            txtPagesPerMin.Text = info.AveragePPM.ToString();
        }


        private void SetAttributes()
        {
            var list = new List<AttrAdapt>
            {
                new AttrAdapt (chkDirect, PRINTER_ATTRIBUTES.DIRECT),
                new AttrAdapt (chkCompleteFirst, PRINTER_ATTRIBUTES.DO_COMPLETE_FIRST),
                new AttrAdapt (chkEnableDevq, PRINTER_ATTRIBUTES.ENABLE_DEVQ),
                new AttrAdapt (chkHidden, PRINTER_ATTRIBUTES.HIDDEN),
                new AttrAdapt (chkDefault, PRINTER_ATTRIBUTES.DEFAULT),
                new AttrAdapt (chkKeepPrinterJobs, PRINTER_ATTRIBUTES.KEEPPRINTEDJOBS),
                new AttrAdapt (chkLocal, PRINTER_ATTRIBUTES.LOCAL),
                new AttrAdapt (chkNetwork, PRINTER_ATTRIBUTES.NETWORK),
                new AttrAdapt (chkPublished, PRINTER_ATTRIBUTES.PUBLISHED),
                new AttrAdapt (chkQueued, PRINTER_ATTRIBUTES.QUEUED),
                new AttrAdapt (chkRawOnly, PRINTER_ATTRIBUTES.RAW_ONLY),
                new AttrAdapt (chkWorkOffline, PRINTER_ATTRIBUTES.WORK_OFFLINE),
                new AttrAdapt (chkShared, PRINTER_ATTRIBUTES.SHARED),
            };
        
            list.ForEach(a =>
            {
                tooltip.SetToolTip(a.Checkbox, a.Attributes.Description());
                a.Checkbox.Checked = info.Attributes.IsBitwise(a.Attributes);
                a.Checkbox.Click+= (s, e)=>((CheckBox)s).Checked= !((CheckBox)s).Checked;
            });
        
        }
    }
    public class AttrAdapt
    {
        public CheckBox Checkbox;
        public PRINTER_ATTRIBUTES Attributes;
        public AttrAdapt(CheckBox chkDirect, PRINTER_ATTRIBUTES attributes)
        {
            Checkbox = chkDirect;
            Attributes = attributes;
        }
    }
}