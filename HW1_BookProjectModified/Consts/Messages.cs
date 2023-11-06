namespace HW1_BookProjectModified.Consts;

public  class Messages
{
    public static string BookTitleExceptionMessage(string title)
    {
        return $"{title} , minimum 2 karakterli olmalıdır girdiğiniz karakter sayısı : {title.Length}";
    }

    public static string BookPriceAndStockExceptionMessage(double price, int stock)
    {
        return $"girdiğiniz stok ve değer bilgisi negatif değerler olamaz. Stok :{stock}, Kitap değeri : {price}";
    }

    internal static string AuthorNameExceptionMessage(string name)
    {
        return $"Auhtor name \"{name}\" should be at least two characters long. Current length: {name.Length}";
    }
}
