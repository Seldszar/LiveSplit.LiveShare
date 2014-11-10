using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    public partial class PinConfimation : Form
    {
        public string Pin { get; set; }

        public PinConfimation()
        {
            InitializeComponent();

            txtPin.DataBindings.Add("Text", this, "Pin", false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
