using RentCar.Data;
using RentCar.Service.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;



namespace RentCar
{
    public partial class RentaLista : Form
    {
        private readonly ProcesoRentaService _procesoRentaService;
        private readonly ApplicationDbContext _context;
        DataTable oDt = new DataTable();
        SqlConnection oCon = null;

        public RentaLista()
        {
            InitializeComponent();
            _procesoRentaService = new ProcesoRentaService();
            _context = new ApplicationDbContext();
        }

        private void RentaLista_Load(object sender, EventArgs e)
        {
            dgvRenta.DataSource = _procesoRentaService.GetRenta();
            oCon = new SqlConnection("Data Source=DESKTOP-62BIECC;Initial Catalog=RentCarDb;Integrated Security=True");
            oCon.Open();
            ejecutarConsulta("");
        }

        private void ejecutarConsulta(string pFiltro)
        {
            string sSQL = "select * from procesorenta ";
            if (pFiltro.Trim().Length > 0)
                sSQL += pFiltro;

            SqlDataAdapter oDa = new SqlDataAdapter(sSQL, oCon);
            oDt = new DataTable();
            oDa.Fill(oDt);
            dgvRenta.DataSource = oDt;
            dgvRenta.Refresh();
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            writeFileHeader("ID, Empleado, ID Vehiculo, ID Cliente, Estatus, Fecha Inicio Renta, Fecha Estimada Devolucion, Monto por dias, Cantidad de Dias, Monto total a Pagar, Comentario");

            foreach (DataRow row in oDt.Rows)
            {
                string linea = "";
                foreach (DataColumn dc in oDt.Columns)
                {
                    linea += row[dc].ToString() + ",";
                }
                writeFileLine(linea);
            }
        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText("D:\\prueba.csv"))
            {
                w.WriteLine(pLine);
            }
        }
        private void writeFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText("D:\\prueba.csv"))
            {
                w.WriteLine(pLine);
            }
        }


        private void btnRentaLEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dgvRenta.SelectedCells[0].OwningRow;

                var id = Convert.ToInt32(row.Cells[0].Value);

                var renta = _context.ProcesoRenta.SingleOrDefault(x => x.Id == id);

                var rentaEditar = new RentaCrear();

                rentaEditar.RentaCrear_Load(sender, e, renta);
                rentaEditar.Show();
                rentaEditar.TopMost = true;
                this.Dispose();
            } catch (Exception ex)
            {

            }
        }

        private void btnRentaLEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvRenta.SelectedCells[0].OwningRow;

            var renta = _context.ProcesoRenta.Find(Convert.ToInt32(row.Cells[0].Value));

            _procesoRentaService.Delete(renta);

            RentaLista_Load(sender, e);
        }

        private void btnRentaLCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtRentaBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtRentaBuscar.Text != string.Empty)
            {
               var search = _procesoRentaService.GetRenta().Where(x => x.Comentario.Contains(txtRentaBuscar.Text));
               dgvRenta.DataSource = search.ToList();
            }
            else
            {
                dgvRenta.DataSource = _procesoRentaService.GetRenta();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeFileHeader("ID, Empleado, ID Vehiculo, ID Cliente, Estatus, Fecha Inicio Renta, Fecha Estimada Devolucion, Monto por dias, Cantidad de Dias, Monto total a Pagar, Comentario");

            foreach (DataRow row in oDt.Rows)
            {
                string linea = "";
                foreach (DataColumn dc in oDt.Columns)
                {
                    linea += row[dc].ToString() + ",";
                }
                writeFileLine(linea);
            }
        }

        private void dgvRenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
