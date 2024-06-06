using GalacticApi.Data;
using GalacticApi.Models;

namespace GalacticApi.Services
{
    public class ResultadoService : IResultadoService
    {
        private readonly IResultadoRepository _resultadoRepository;

        public ResultadoService(IResultadoRepository resultadoRepository)
        {
            _resultadoRepository = resultadoRepository;
        }

        public List<GetResultadosDTO> GetResultados(){
            return _resultadoRepository.GetResultados().Select(r => new GetResultadosDTO {IdJuego = r.IdJuego, IdUsuario = r.IdUsuario, Completado = r.Completado, Resultado = r.Resultado, Acertadas = r.Acertadas, Falladas = r.Falladas}).ToList();
        }



        public void AddResultado(GetPasapalabraDTO pasapalabraDTO, int id)
        {
            Resultados resultados = new Resultados();
            resultados.Completado = 'Y';
            int acertadas = 0;
            double totales = 0;

            foreach (var pregunta in pasapalabraDTO.Preguntas)
            {
                if (!pregunta.acertado)
                {
                    resultados.Completado = 'N';
                }else{
                    acertadas++;
                }
                totales++;


            }
            resultados.Resultado = Math.Round((acertadas/totales*100), 2) ;
            resultados.Acertadas = acertadas;
            resultados.Falladas = (int)(totales-acertadas);
            resultados.IdJuego = pasapalabraDTO.Id;
            resultados.IdUsuario = id;  
            _resultadoRepository.AddResultado(resultados);
        }

        public List<int> GetResultadosAsignatura(int id){
            List<int> resultados = new List<int>();
            var resultadosDTO =_resultadoRepository.GetResultadosAsignatura(id);
            int mates = 0, lengua = 0, ingles = 0, cono = 0, plastica = 0;

            foreach (var item in resultadosDTO)
            {
                switch (item.IdAsignatura)
                {
                    case 1:
                        lengua++;
                    break;
                    case 2:
                        mates++;
                    break;
                    case 3:
                        cono++;
                    break;
                    case 4:
                        plastica++;
                    break;
                    case 5:
                        ingles++;
                    break;
                }
            }
            resultados.Add(lengua);
            resultados.Add(mates);
            resultados.Add(cono);
            resultados.Add(plastica);
            resultados.Add(ingles);


            return resultados;
        }

        public List<int> GetResultadosCurso(int id){
            List<int> resultados = new List<int>();
            var resultadosDTO =_resultadoRepository.GetResultadosCurso(id);
            int primero = 0, segundo = 0, tercero = 0, cuarto = 0, quinto = 0, sexto = 0;

            foreach (var item in resultadosDTO)
            {
                switch (item.IdCurso)
                {
                    case 1:
                        primero++;
                    break;
                    case 2:
                        segundo++;
                    break;
                    case 3:
                        tercero++;
                    break;
                    case 4:
                        cuarto++;
                    break;
                    case 5:
                        quinto++;
                    break;
                    case 6:
                        sexto++;
                    break;
                }
            }
            resultados.Add(primero);
            resultados.Add(segundo);
            resultados.Add(tercero);
            resultados.Add(cuarto);
            resultados.Add(quinto);
            resultados.Add(sexto);



            return resultados;
        }

        


    }
}