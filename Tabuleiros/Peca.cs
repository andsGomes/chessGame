using Tabuleiros.Enums;

namespace Tabuleiros
{
  public class Peca
  {
     public Posicao _posicao { get; set; }  
     public Cor _cor { get; protected set; }
     public int _qtdMovimentos { get; protected set; }
     public Tabuleiro _tabuleiro { get; protected set; }

     public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
     {
        _posicao = posicao; 
        _tabuleiro = tab;
        _cor = cor;
        _qtdMovimentos = 0;

     }
  }
}