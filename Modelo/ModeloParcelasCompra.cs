using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasCompra
    {

        private int pco_cod;
        private Double pco_valor;
        private DateTime pco_datapagto;
        private DateTime pco_datavecto;
        private int com_cod;

        public ModeloParcelasCompra()
        {
            this.pco_cod = 0;
            this.pco_valor = 0;
            //this.pco_datapagto = DateTime.Now;
            this.pco_datavecto = DateTime.Now;
            this.com_cod = 0;
        }
        public int Pco_cod
        {
            get { return pco_cod; }
            set { pco_cod = value; }
        }
        public double Pco_valor
        {
            get { return pco_valor; }
            set { pco_valor = value; }
        }
        public DateTime Pco_datapagto
        {
            get { return pco_datapagto; }
            set { pco_datapagto = value; }
        }
        public DateTime Pco_datavecto
        {
            get { return pco_datavecto; }
            set { pco_datavecto = value; }
        }
        public int Com_cod
        {
            get { return com_cod; }
            set { com_cod = value; }
        }
    }
}
