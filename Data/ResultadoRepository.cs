using GalacticApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GalacticApi.Models
{
    public class ResultadoRepository : IResultadoRepository
    {
        private readonly GalacticApiContext _context;

        private readonly ILogger<ResultadoRepository> _logger;

        public ResultadoRepository(ILogger<ResultadoRepository> logger, GalacticApiContext context)
        {
            _context = context;
            _logger = logger;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}