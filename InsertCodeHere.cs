using System;
#pragma warning disable 219

namespace WebShopV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            int noOfBooksInOrder = 23;
            int noOfDVDsInOrder = 16;
            int noOfGamesInOrder = 7;

            double netPricePlusTax = 1.1;
            int shippingCost = 49;
            double creditCardFee = 1.02;

            double totalPrice = 0.0; // This variable should contain the total price for the order

            double totalBooksPrice = netPriceBook*noOfBooksInOrder;
            double totalDVDPrice = netPriceDVD*noOfDVDsInOrder;
            double totalGamesPrice = netPriceGame*noOfGamesInOrder;
            
            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            totalPrice = ((totalBooksPrice+totalDVDPrice+totalGamesPrice)*netPricePlusTax+shippingCost)*creditCardFee;
            Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}