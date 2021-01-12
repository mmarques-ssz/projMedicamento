using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projMedicamento
{
    class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;

        public List<Medicamento> ListaMedicamentos
        {
            get { return listaMedicamentos; }
        }

        public Medicamentos()
        {
            this.listaMedicamentos = new List<Medicamento>();
        }

        public void adicionar(Medicamento medicamento)
        {
            this.listaMedicamentos.Add(medicamento);
        }

        public bool deletar(Medicamento medicamento)
        {
            bool podeDeletar = (pesquisar(medicamento).qtdeDisponivel() == 0);
            if (podeDeletar)
            {
                this.listaMedicamentos.Remove(medicamento);
            }
            return podeDeletar;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            Medicamento medicamentoAchado;
            medicamentoAchado = new Medicamento();
            foreach (Medicamento med in this.listaMedicamentos)
                if (med.Equals(medicamento))
                    medicamentoAchado = med;
            return medicamentoAchado;
        }
    }
}
