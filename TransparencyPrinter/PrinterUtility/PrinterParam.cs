using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.DocObjects;
using Rhino.Input;

namespace TransparencyPrinter
{
    public  class PrinterParam
    {
        public enum OutputFormat
        {
            PNG,
            PDF
        }
        public BoundingBox SelectedPrintArea { get; set; }
        public BoundingBox PagePrintArea { get; set; }
        public Size PageSizeMM { get;set; }
        public OutputFormat FileFormat { get; set; }
        public string FilePath { get; set; }
        public int DPI { get; set; }
    }
}
