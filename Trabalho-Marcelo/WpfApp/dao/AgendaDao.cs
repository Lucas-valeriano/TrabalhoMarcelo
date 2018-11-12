using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp.model;

namespace WpfApp.dao
{
    public class AgendaDao
    {
        private readonly Contexto _contexto;
        public AgendaDao()
        {
            _contexto = new Contexto();
        }
        public List<Contato> Listar()
        {
            try
            {
                return _contexto.Contato.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao listar produtos!", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
                throw;
            }
        }

        public Contato Inserir(Contato contato)
        {
            try
            {
                var novoContato = _contexto.Contato.Add(contato);
                _contexto.SaveChanges();
                MessageBox.Show("Contato cadastrado com sucesso!", "Erro", MessageBoxButton.OK, MessageBoxImage.Information);
                return novoContato;
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao cadastrar contato!", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
                throw;
            }

        }
    }
}
