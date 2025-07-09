using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ParcialDos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Estructura para almacenar detalles
        class Detalle
        {
            public string NroComprobante { get; set; }
            public string Descripcion { get; set; }
            public int Importe { get; set; }
        }

        private void btnGenerarComprobantes_Click(object sender, EventArgs e)
        {
            lstResultadoComprobantes.Items.Clear();

            // Leer todos los detalles de una sola vez
            List<Detalle> detalles = new List<Detalle>();
            using (var sr = new StreamReader("detalle.txt"))
            {
                string linea;
                bool esPrimera = true;
                while ((linea = sr.ReadLine()) != null)
                {
                    if (esPrimera) { esPrimera = false; continue; }

                    var partes = linea.Split(';');
                    detalles.Add(new Detalle
                    {
                        NroComprobante = partes[0],
                        Descripcion = partes[1],
                        Importe = int.Parse(partes[2])
                    });
                }
            }

            // Leer la cabecera
            using (var sr = new StreamReader("cabecera.txt"))
            {
                string linea;
                bool esPrimera = true;
                while ((linea = sr.ReadLine()) != null)
                {
                    if (esPrimera) { esPrimera = false; continue; }

                    var partes = linea.Split(';');
                    string nroComprobante = partes[0];
                    string razonSocial = partes[1];
                    string fecha = partes[2];

                    lstResultadoComprobantes.Items.Add($"Comprobante: {nroComprobante}");
                    lstResultadoComprobantes.Items.Add($"Razón Social: {razonSocial}");
                    lstResultadoComprobantes.Items.Add($"Fecha: {fecha}");

                    int total = 0;

                    var detallesComprobante = detalles.Where(d => d.NroComprobante == nroComprobante).ToList();
                    foreach (var d in detallesComprobante)
                    {
                        lstResultadoComprobantes.Items.Add($"    - {d.Descripcion} - ${d.Importe}");
                        total += d.Importe;
                    }

                    lstResultadoComprobantes.Items.Add($"TOTAL: ${total}");
                    lstResultadoComprobantes.Items.Add("--------------------------------------"); // línea en blanco entre comprobantes
                }
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
