using chessGame;
using Tabuleiros;
using Tabuleiros.Enums;
using Xadrez;

Console.Clear();

Tabuleiro tab = new Tabuleiro(8, 8);

tab.colocarPeca(new Torre(tab,Cor.Preto), new Posicao(0,0));
tab.colocarPeca(new Torre(tab,Cor.Preto), new Posicao(1,3));

tab.colocarPeca(new Rei(tab,Cor.Branco), new Posicao(4,0));

Tela.imprimirTabuleiro(tab);

Console.ReadLine();
Console.Clear();
