namespace Tabuleiros
{
  public class Tabuleiro
  {
     public int _linhas { get; set; }
     public int _colunas { get; set; }
     private Peca[,] _pecas;
     public Tabuleiro(int linhas, int colunas)  
     {
        _linhas = linhas;
        _colunas = colunas;
        _pecas = new Peca[_linhas, _colunas];
     }
  }
}