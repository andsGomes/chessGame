using Tabuleiros;

namespace chessGame
{
  public class Tela
  {
    public static void imprimirTabuleiro(Tabuleiro tab)
    {
      // printing lines
      for (int i = 0; i < tab._linhas; i++)
      {
        // printing columns
        for (int j = 0; j < tab._colunas; j++)
        {
          // Checking whether there is a part in position
          if (tab.peca(i, j) == null)
          {
             System.Console.Write("- ");
          } 
          else {
             System.Console.Write(tab.peca(i,j) + " ");
          }
        }
        
        System.Console.WriteLine();
      }
    }
  }
}