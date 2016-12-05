using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItensCompra
    {
        private int itc_cod;
        private double itc_qtde;
        private double itc_valor;
        private int com_cod;
        private int pro_cod;

        public int ItcCod
        {
            get { return itc_cod; }
            set { this.itc_cod = value; }
        }

        public double Itc_qtde
        {
            get { return itc_qtde; }
            set { this.itc_qtde = value; }
        }

        public double Itc_valor
        {
            get { return itc_valor; }
            set { this.itc_valor = value; }
        }

        public int Com_cod
        {
            get { return com_cod; }

            set { this.com_cod = value; }
        }

        public int Pro_cod
        {
            get { return pro_cod; }
            set { this.pro_cod = value; }
        }
    }
}
