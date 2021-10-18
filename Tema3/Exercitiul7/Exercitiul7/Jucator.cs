using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul7
{
    public enum Post { Portar, Fundas, Mijlocas, Atacant };

    class Jucator
    {
        string nume;
        string cnp;
        Post post;


        public Jucator(string nume, string cnp, Post post)
        {
            this.nume = nume;
            this.cnp = cnp;
            this.post = post;
        }


        public string Cnp
        {
            get => cnp;

            set => cnp = value;
        }


        public string Nume
        {
            get => nume;

            set => nume = value;
        }


        public Post CurrentPost
        {
            get => post;

            set => post = value;
        }
    }
}
