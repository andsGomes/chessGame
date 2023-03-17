namespace Tabuleiro
{
  public class Posicao
  {
     public int _linhas { get; set; }
     public int _colunas { get; set; }
     public Posicao(int linha, int coluna)
     {
        _linhas = linha; 
        _colunas = coluna;
     }
    public override string ToString()
    {
      return _linhas
             + ", " + 
             _colunas;
    }
  }
}