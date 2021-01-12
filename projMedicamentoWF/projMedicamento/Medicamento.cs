using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projMedicamento
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Laboratorio
        {
            get { return laboratorio; }
            set { laboratorio = value; }
        }

        public Queue<Lote> Lotes
        {
            get { return lotes; }
        }

        public Medicamento(int id, string nome, string laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            this.lotes = new Queue<Lote>();
        }

        public Medicamento()
            : this(0, "", "")
        {
        }

        public override string ToString()
        {
            return this.Id.ToString() + " - " +
                this.nome + " - " +
                this.laboratorio;
        }

        public override bool Equals(object obj)
        {
            return ((Medicamento)obj).Id.Equals(this.Id);
        }

        public void comprar(Lote lote)
        {
            this.lotes.Enqueue(lote);
        }

        public int qtdeDisponivel()
        {
            int qtdeTotal = 0;
            foreach (Lote lote in this.lotes)
            {
                qtdeTotal += lote.Qtde;
            }
            return qtdeTotal;
        }

        public bool vender(int qtde)
        {
            int saldo = qtde;
            if (this.qtdeDisponivel() >= qtde)
            {
                do
                {
                    if (this.lotes.Peek().Qtde >= saldo)
                    {
                        this.lotes.Peek().Qtde -= saldo;
                        saldo -= qtde;
                    }
                    else
                        saldo -= this.lotes.Dequeue().Qtde;
                }
                while (saldo > 0);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
