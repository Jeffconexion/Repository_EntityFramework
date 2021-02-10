using Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.IRepositorio
{
    public interface IAnimal : IDisposable
    {
        IList<Animal> ObterTodos(int skip = 0, int take = 25);
        Animal ObterPorId(int idAnimal);
        void Salvar(Animal animal);
        void Atualizar(Animal animal);
        void Deletar(int idAnimal);
    }
}
