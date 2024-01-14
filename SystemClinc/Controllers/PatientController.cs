﻿using Clinic_Registration_and_Management_System.Model;
using Microsoft.AspNetCore.Mvc;
using SystemClinc.BLL.Interface;

namespace SystemClinc.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatient _patient;
        private readonly ISpecialization _Special;
        public PatientController(IPatient pation,ISpecialization specialization)
        {
            _patient = pation;
            _Special = specialization;
        }
        public IActionResult Index(string search)
        {
            IEnumerable<Patient> p;
            if (string.IsNullOrEmpty(search))
            {
                p = _patient.GetAll();
            }
            else
            {
                p = _patient.Search(search);
            }
            return View(p);
           
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Special = _Special.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            if (ModelState.IsValid)
            {
                _patient.Create(patient);
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var Dep = _patient.Get(id.Value);
            return View(Dep);

        }
        [HttpPost]
        public IActionResult Update(Patient patient)
        {
            if (ModelState.IsValid)
            {

                _patient.Update(patient);

                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(Patient patient)
        {

            _patient.Delete(patient);
            return RedirectToAction("Index");

        }
    }
}