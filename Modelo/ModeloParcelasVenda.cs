using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasVenda
    {
        private int ven_cod;
        private int pve_cod;
        private Double pve_valor;
        private DateTime pve_datapagto;
        private DateTime pve_datavecto;

        public ModeloParcelasVenda()
        {
            this.pve_cod = 0;
            this.pve_valor = 0;
            this.pve_datapagto = DateTime.Now;
            this.pve_datavecto = DateTime.Now;
            this.ven_cod = 0;
        }

        public int Pve_cod
        {
            get { return pve_cod; }
            set { pve_cod = value; }
        }
        public double Pve_valor
        {
            get { return pve_valor; }
            set { pve_valor = value; }
        }
        public DateTime Pve_datapagto
        {
            get { return pve_datapagto; }
            set { pve_datapagto = value; }
        }
        public DateTime Pve_datavecto
        {
            get { return pve_datavecto; }
            set { pve_datavecto = value; }
        }
        public int Ven_cod
        {
            get { return ven_cod; }
            set { ven_cod = value; }
        }

    }
}
