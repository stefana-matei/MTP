using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5
{
    public class Intrebari
    {

        int nrIntrebare;
        string tipIntrebare;
        string intrebare;
        int nrVarianteRaspuns;
        string[] varianteRaspuns;
        string pathPoza; //daca exista
        string raspunsCorect;


        public Intrebari(int nrIntrebare, string tipIntrebare, string intrebare, int nrVarianteRaspuns, string[] varianteRaspuns, string pathPoza, string raspunsCorect)
        {
            this.nrIntrebare = nrIntrebare;
            this.tipIntrebare = tipIntrebare;
            this.intrebare = intrebare;
            this.nrVarianteRaspuns = nrVarianteRaspuns;
            this.varianteRaspuns = varianteRaspuns;
            this.pathPoza = pathPoza;
            this.raspunsCorect = raspunsCorect;
        }


        public int NrIntrebare { get => nrIntrebare; set => nrIntrebare = value; }
        public string TipIntrebare { get => tipIntrebare; set => tipIntrebare = value; }
        public string Intrebare { get => intrebare; set => intrebare = value; }
        public int NrVarianteRaspuns { get => nrVarianteRaspuns; set => nrVarianteRaspuns = value; }
        public string[] VarianteRaspuns { get => varianteRaspuns; set => varianteRaspuns = value; }
        public string PathPoza { get => pathPoza; set => pathPoza = value; }
        public string RaspunsCorect { get => raspunsCorect; set => raspunsCorect = value; }
    }
}