using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5
{
    public class Intrebare
    {

        int nrIntrebare;
        string tipIntrebare;
        string textIntrebare;
        int nrVarianteRaspuns;
        string[] varianteRaspuns;
        string pathPoza; //daca exista
        string raspunsCorect;

        // user raspunsuri
        bool userPass = false;        // Daca toate raspunsurile au fost corecte
        bool[] userRaspunsuri;        // Tinem minte raspunsurile userului
        bool[] userRaspunsuriCorecte; // Tinem minte daca fiecare raspuns a fost corect


        public Intrebare(int nrIntrebare, string tipIntrebare, string intrebare, int nrVarianteRaspuns, string[] varianteRaspuns, string pathPoza, string raspunsCorect)
        {
            this.nrIntrebare = nrIntrebare;
            this.tipIntrebare = tipIntrebare;
            this.textIntrebare = intrebare;
            this.nrVarianteRaspuns = nrVarianteRaspuns;
            this.varianteRaspuns = varianteRaspuns;
            this.pathPoza = pathPoza;
            this.raspunsCorect = raspunsCorect;

            this.userRaspunsuri = new bool[nrVarianteRaspuns];
            this.userRaspunsuriCorecte = new bool[nrVarianteRaspuns];
        }


        public int NrIntrebare { get => nrIntrebare; set => nrIntrebare = value; }
        public string TipIntrebare { get => tipIntrebare; set => tipIntrebare = value; }
        public string TextIntrebare { get => textIntrebare; set => textIntrebare = value; }
        public int NrVarianteRaspuns { get => nrVarianteRaspuns; set => nrVarianteRaspuns = value; }
        public string[] VarianteRaspuns { get => varianteRaspuns; set => varianteRaspuns = value; }
        public string PathPoza { get => pathPoza; set => pathPoza = value; }
        public string RaspunsCorect { get => raspunsCorect; set => raspunsCorect = value; }
        public bool UserPass { get => userPass; set => userPass = value; }
        public bool[] UserRaspunsuri { get => userRaspunsuri; set => userRaspunsuri = value; }
        public bool[] UserRaspunsuriCorecte { get => userRaspunsuriCorecte; set => userRaspunsuriCorecte = value; }
    }
}