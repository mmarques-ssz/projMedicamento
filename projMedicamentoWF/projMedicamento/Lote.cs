using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projMedicamento
{
    class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public DateTime Venc
        {
            get { return venc; }
            set { venc = value; }
        }

        public Lote(int id, int qtde, DateTime venc)
        {
            this.id = id;
            this.qtde = qtde;
            this.venc = venc;
        }

        public Lote()
            : this(0, 0, new DateTime(0))
        { 
        }

        public override string ToString()
        {
            return this.Id.ToString() + " - " +
                this.Qtde.ToString() + " - " +
                this.Venc.ToShortDateString();
        }

    }
}
