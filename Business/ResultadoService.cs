using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class ResultadoService : IResultadoService{
         private readonly IResultadoRepository _cursoRepository;

    public ResultadoService(IResultadoRepository cursoRepository)
    {
        _cursoRepository = cursoRepository;
    }

    }
}