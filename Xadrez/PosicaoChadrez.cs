using Tabuleiros;

namespace Xadrez
{
  public class PosicaoChadrez
  {
    public char _coluna { get; set; }
    public int _linha { get; set; }

    public PosicaoChadrez(char coluna, int linha)
    {
      _coluna = coluna;
      _linha = linha;
    }
    // Convert chess position to vector. 
    public Posicao ToPosicao()
    {
      return new Posicao(8 - _linha, _coluna -'a');
    }

    public override string ToString()
    {
      return "" + _coluna + _linha;
    }
  }
}