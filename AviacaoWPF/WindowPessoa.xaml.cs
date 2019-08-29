using Aviacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AviacaoWPF
{
    /// <summary>
    /// Lógica interna para WindowPessoa.xaml
    /// </summary>
    public partial class WindowPessoa : Window
    {
        public ViewModel.PessoasViewModel PessoasViewModel { get; set; }
        public WindowPessoa()
        {
            InitializeComponent();
            this.PessoasViewModel = new ViewModel.PessoasViewModel();
            this.DataContext = this;
        }


        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Salvar();
            this.Close();
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Remover();
        }

        private void AdicionarButton_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Adicionar();
        }
    }
}
