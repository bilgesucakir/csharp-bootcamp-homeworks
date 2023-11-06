using  HW1_BookProjectModified.Consts;

namespace HW1_BookProjectModified.Exceptions;

public class BookPriceAndStockException : Exception
{
    public BookPriceAndStockException(double price, int stock) : base(Messages.BookPriceAndStockExceptionMessage(price,stock))
    {
        
    }
}
