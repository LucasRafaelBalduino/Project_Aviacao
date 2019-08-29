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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AviacaoWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Propriedade para Exemplo de Binding.
        /// É possível visualizar o binding com o TextBox com o nome TextBox3
        /// </summary>
        public String TextoExemplo { get; set; } = 
            "Exemplo";

        public MainWindow()
        {
            InitializeComponent();
            //Para definir um binding é necessário
            //definir o contexto dos dados. 
            //Caso não seja definido a aplicação não irá 
            //mostrar os dados corretamente.
            this.DataContext = this;
        }


        /// <summary>
        /// Esta propriedade é chamada pelo clique no botão definido no XAML.
        /// Pressione Shift-F7 para visualizar o código XAML.
        /// A propriedade Click no Button faz referência ao nome deste botão.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ModelAviacao ctx = new ModelAviacao();
            //var pessoa = ctx.Pessoas.First();
            WindowPessoa wp = new WindowPessoa();
            //wp.Pessoa = pessoa;
            wp.Show();
        }
    }
}
