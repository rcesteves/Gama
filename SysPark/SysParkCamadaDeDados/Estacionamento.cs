using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysParkCamadaDeDados
{
    class Estacionamento
    {
       private int codEstacionamento;
       private string cnpj;
       private string razaoSocial;
       private string nomeFantasia;
       private int inscricaoEstadual;
       private int tolerancia;
       private int totalVagas;

        

        public Estacionamento(int codEstac, string cnpje, string razSocial, string nomFantasia, int ie, int toler, int totVagas)
        {
            codEstacionamento = codEstac;
            cnpj = cnpje;
            razaoSocial = razSocial;
            nomeFantasia = nomFantasia;
            inscricaoEstadual = ie;
            tolerancia = toler;
            totalVagas = totVagas;
        }

        public Estacionamento()
        {

        }

        public int CodEstacionamento
        {
            get
            {
                return codEstacionamento;
            }

            set
            {
                codEstacionamento = value;
            }
        }

        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return razaoSocial;
            }

            set
            {
                razaoSocial = value;
            }
        }

        public string NomeFantasia
        {
            get
            {
                return nomeFantasia;
            }

            set
            {
                nomeFantasia = value;
            }
        }

        public int InscricaoEstadual
        {
            get
            {
                return inscricaoEstadual;
            }

            set
            {
                inscricaoEstadual = value;
            }
        }

        public int Tolerancia
        {
            get
            {
                return tolerancia;
            }

            set
            {
                tolerancia = value;
            }
        }

        public int TotalVagas
        {
            get
            {
                return totalVagas;
            }

            set
            {
                totalVagas = value;
            }
        }





    }
}
