﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }

        public Cor cor { get;protected set; }
        public int qteMovimentos { get;protected set; }
        public  Tabuleiro tab { get;protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

       
    }
}
