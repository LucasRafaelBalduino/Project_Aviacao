using Aviacao;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviacaoWPF.ViewModel
{
    public class PessoasViewModel
    {
        public ObservableCollection<Pessoa> Pessoas
            { get; set; }

        public Boolean PodeRemover {
            get{
                return this.PessoaSelecionada != null;
            }
        }

        public Pessoa PessoaSelecionada { get; set; }
        private ModelAviacao context { get; set; }
        public PessoasViewModel()
        {
            context = new ModelAviacao();
            this.Pessoas = 
                new ObservableCollection<Pessoa>(
                context.Pessoas.ToList());
            this.PessoaSelecionada = context
                .Pessoas.FirstOrDefault();
        }

        public void Remover()
        {            
            if (this.PessoaSelecionada.Id != 0)
            {
                this.context.Pessoas.Remove(
                    this.PessoaSelecionada);
            }
            this.Pessoas.Remove(this.PessoaSelecionada);
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Adicionar()
        {
            Pessoa p = new Pessoa();
            this.Pessoas.Add(p);
            this.context.Pessoas.Add(p);
            this.PessoaSelecionada = p;
        }
    }
}
