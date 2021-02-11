using Dominio.Entidades;
using Dominio.IRepositorio;
using Infraestrutura.Contextos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Infraestrutura.Repositorios
{
    public class AnimalRepositorio : IAnimal
    {
        private readonly AppDataContext _banco;

        public AnimalRepositorio(AppDataContext banco)
        {
            _banco = banco;
            
        }

        public void Atualizar(Animal animal)
        {
            _banco.Entry<Animal>(animal).State = EntityState.Modified;
        }

        public void Deletar(int idAnimal)
        {
            var animal = ObterPorId(idAnimal);
            _banco.Animais.Remove(animal);
        }

        public Animal ObterPorId(int idAnimal)
        {
            var animal = _banco.Animais.Find(idAnimal);
            return animal;
        }

        public IList<Animal> ObterTodos(int skip = 0, int take = 25)
        {
            var animal = _banco.Animais
                         .OrderBy(a => a.Nome)
                         .Skip(skip)
                         .Take(take)
                         .ToList();

            return animal;
        }

        public void Cadastrar(Animal animal)
        {
            _banco.Animais.Add(animal);

        }

        public void Dispose()
        {
            _banco.Dispose();
        }

    }
}
