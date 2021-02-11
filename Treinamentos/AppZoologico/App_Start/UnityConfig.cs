using Dominio.Entidades;
using Dominio.IRepositorio;
using Infraestrutura.Contextos;
using Infraestrutura.Repositorios;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using UoW.Contratos;

namespace AppZoologico
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();


            container.RegisterType<AppDataContext, AppDataContext>();
            container.RegisterType<IAnimal, AnimalRepositorio>();
            container.RegisterType<IUnidadeDeTrabalho, UnidadeDeTrabalho>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}