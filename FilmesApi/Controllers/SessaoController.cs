﻿using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos.Gerente;
using FilmesApi.Data.Dtos.Sessao;
using FilmesApi.Models;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public SessaoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaSessao(CreateSessaoDto dto)
        {
            Sessao sessao = _mapper.Map<Sessao>(dto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaSessoesPorId), new { id = sessao.Id }, sessao);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessoesPorId(int id)
        {
                Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
                if (sessao != null)
                {
                ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);

                    return Ok(sessaoDto);
                }
                return NotFound();

        }

    }
}
