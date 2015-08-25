
namespace Casino
{
    interface ICardGame
    {
        int GetSumOfCards();

        bool IsWinner(int sumOfCards);
    }
}