using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryPerezTPIntegrador
{
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void tblPnlAsientosAzul_Paint(object sender, PaintEventArgs e)
        {
            tblPnlAsientosAzul.ColumnCount = 5;
            //tblPnlAsientosAzul.ColumnStyles.Clear();
            //for (int i = 0; i < 20; i++)
            //{
            //    tblPnlAsientosAzul.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,
            //    (float)20));
            //}

        }

        private void btnReservar_Click(object sender, System.EventArgs e)
        {

            if (cmbLocal.SelectedItem != null)
            {
                if (cmbLocal.SelectedItem.ToString() == "Quenaken")
                {
               
                    tblPnlAsientosAzul.ColumnCount = 5;
                    tblPnlAsientosAzul.RowCount = 4;

                    tblPnlAsientosVerde.ColumnCount = 5;
                    tblPnlAsientosVerde.RowCount = 4;
                }
                else if (cmbLocal.SelectedItem.ToString() == "Onas")
                {
                    tblPnlAsientosAzul.ColumnCount = 4;
                    tblPnlAsientosAzul.RowCount = 10;

                    tblPnlAsientosVerde.ColumnCount = 5;
                    tblPnlAsientosVerde.RowCount = 4;
                }
                else if (cmbLocal.SelectedItem.ToString() == "Tobas")
                {
                    tblPnlAsientosAzul.ColumnCount = 3;
                    tblPnlAsientosAzul.RowCount = 4;

                    tblPnlAsientosVerde.ColumnCount = 5;
                    tblPnlAsientosVerde.RowCount = 3;
                }
            }
            tblPnlAsientosAzul.BorderStyle = BorderStyle.FixedSingle; // Puedes usar Fixed3D si prefieres un estilo tridimensional
            tblPnlAsientosVerde.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
