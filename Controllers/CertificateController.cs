﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly PointyHandler _handler;

        public CertificateController(ApplicationDbContext context)
        {
            this.context = context;
            _handler = new PointyHandler(this.context);
        }


        [HttpGet]
        public ICollection<Certificate> Get()
        {
            return _handler.GetAllCertificates();
        }

        [HttpGet("{id}")]
        public Certificate Get(int id)
        {
            return _handler.CertificateDetails(id);
        }

        [HttpPost]
        public void Post(Certificate certificate)
        {
            if (ModelState.IsValid)
                _handler.AddCertificate(certificate);
        }

        [HttpPut]
        public void Put(Certificate certificate)
        {
            if (ModelState.IsValid)
                _handler.EditCertificate(certificate);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _handler.DeleteCertificate(id);
        }
    }
}