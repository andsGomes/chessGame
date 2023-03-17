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
    // This piece method accesses the private piece property of an array. 
    public Peca peca(int linha, int coluna)
    {
       return _pecas[linha, coluna];
    }
  }
}