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
    public Peca peca(int linhas, int colunas)
    {
      return _pecas[linhas, colunas];
    }
    public Peca peca(Posicao pos)
    {
      return _pecas[pos._linhas, pos._colunas];
    }
    // Check if there os a given position
    public bool existePeca(Posicao pos)
    {
       validarPosicao(pos);
       return peca(pos) != null;
    }
    // Operation to place a piece on the board 
    public void colocarPeca(Peca p, Posicao pos)
    {
      _pecas[pos._linhas, pos._colunas] = p;
      p._posicao = pos;
    }
    // Method to test if the position is empty
    public bool posicaoValida(Posicao pos)
    {
      if (pos._linhas < 0 || pos._linhas >= _linhas || pos._colunas < 0 || pos._colunas >= _colunas)
        return false;

      return true;
    }
    // Method to validate position
    public void validarPosicao(Posicao pos)
    {
      if (!posicaoValida(pos))
        throw new TabuleiroException("Posicao invalida");
    }
  }
}