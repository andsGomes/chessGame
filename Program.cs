using chessGame;
using Tabuleiros;
using Tabuleiros.Enums;
using Xadrez;

Console.Clear();
try
{
  Tabuleiro tab = new Tabuleiro(8, 8);

  tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
  tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));

  tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(4, 0));
  tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(0, 9));

  Tela.imprimirTabuleiro(tab);
}
catch (Exception e)
{

  System.Console.WriteLine(e.Message);
}



Console.ReadLine();
Console.Clear();
