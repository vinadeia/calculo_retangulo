﻿using System;

namespace ProgOrientadaObjetos_Ex01
{
    class Retangulo
    {
            public double Altura;
            public double Largura;
            
            public double Area() {
                return Largura * Altura;
            }

            public double Perimetro()
            {
                return 2 * (Largura * Altura);
            }

            public double Diagonal()
            {
                return Math.Sqrt(Largura * Largura + Altura * Altura);
            }
    }
}
