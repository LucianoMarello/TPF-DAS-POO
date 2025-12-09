using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class GeneradorFactura
    {
        public static void GenerarTicket(Venta venta)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("==========================================");
            sb.AppendLine("              TECH STORE                  ");
            sb.AppendLine("          Comprobante de Venta            ");
            sb.AppendLine("==========================================");
            sb.AppendLine($"Fecha:    {venta.FechaMovimiento:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"Nro:      {venta.MovimientoId.ToString("D8")}");
            sb.AppendLine($"Sucursal: {venta.Sucursal.Nombre}");
            sb.AppendLine("------------------------------------------");
            sb.AppendLine($"Cliente:  {venta.Cliente.Nombre}");
            sb.AppendLine($"Condición:{venta.Cliente.Tipo}");
            sb.AppendLine($"Pago:     {venta.MetodoPago}");
            sb.AppendLine("==========================================");
            sb.AppendLine("PRODUCTO              CANT   PRECIO   SUBTOTAL");
            sb.AppendLine("------------------------------------------");

            decimal totalBruto = 0;

            foreach (var item in venta.Detalles)
            {
                string nombre = item.Producto != null ? item.Producto.Nombre : "Desc.";

                if (nombre.Length > 18) nombre = nombre.Substring(0, 18);

                sb.AppendLine(
                    $"{nombre.PadRight(20)} " +
                    $"{item.Cantidad.ToString().PadLeft(4)} " +
                    $"{item.PrecioUnitario.ToString("0.00").PadLeft(8)} " +
                    $"{item.Subtotal.ToString("0.00").PadLeft(9)}"
                );

                totalBruto += item.Subtotal;
            }

            sb.AppendLine("------------------------------------------");

            decimal descuento = totalBruto - venta.Total;

            if (descuento > 0)
            {
                sb.AppendLine($"Subtotal:               $ {totalBruto,10:0.00}");
                sb.AppendLine($"Descuento:            - $ {descuento,10:0.00}");
            }

            sb.AppendLine("==========================================");
            sb.AppendLine($"TOTAL A PAGAR:          $ {venta.Total,10:0.00}");
            sb.AppendLine("==========================================");
            sb.AppendLine("        ¡Gracias por su compra!           ");
            sb.AppendLine("==========================================");

            string rutaBase = @"C:\Users\lucia\OneDrive\Escritorio\UAI\4to Cuatrimestre\DAS\FINAL DAS";
            string carpetaDestino = Path.Combine(rutaBase, "Facturas");
            if (!Directory.Exists(carpetaDestino))
            {
                Directory.CreateDirectory(carpetaDestino);
            }
            string nombreArchivo = $"Ticket_Venta_{venta.MovimientoId}.txt";
            string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);

            File.WriteAllText(rutaCompleta, sb.ToString());
            Process.Start(new ProcessStartInfo
            {
                FileName = rutaCompleta,
                UseShellExecute = true
            });
        }
    }
}
