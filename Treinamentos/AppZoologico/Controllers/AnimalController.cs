﻿using Dominio.Entidades;
using Dominio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UoW.Contratos;

namespace AppZoologico.Controllers
{
    public class AnimalController : Controller
    {

        private IAnimal _animal;
        private IUnidadeDeTrabalho _unidadeDeTrabalho;


        public AnimalController(IAnimal animal, IUnidadeDeTrabalho unidadeDeTrabalho)
        {
            _animal = animal;
            _unidadeDeTrabalho = unidadeDeTrabalho;
        }

        // GET: Animal
        public ActionResult Index()
        {
            return View(_animal.ObterTodos());
        }

        // GET: Animal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Animal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Animal/Create
        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            try
            {
                _animal.Cadastrar(animal);
                _unidadeDeTrabalho.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Animal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Animal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Animal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Animal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
