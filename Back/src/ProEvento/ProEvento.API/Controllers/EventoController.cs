using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                EventoDate = DateTime.Now.AddDays(2).ToString(),
                EventoLocal = "João Pessoa",
                QtdPessoasEvento = 20,
                TemaEvento = "Evento",
                ImagemUrlEvento = "http://google.com/img",
                LoteEvento = "2200LSNDNSHB"
            },
            new Evento()
            {
                EventoId = 2,
                EventoDate = DateTime.Now.AddDays(2).ToString(),
                EventoLocal = "João Pessoa",
                QtdPessoasEvento = 20,
                TemaEvento = "Evento 2",
                ImagemUrlEvento = "http://google.com/img",
                LoteEvento = "2202LSNDNSHB"
            }

        };
        
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }


        [HttpPost]
        public string Post()
        {
            return "exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"exemplo de put id = {id}";
        }
        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"exemplo de delete id = {id}";
        }
    }
}
