// See https://aka.ms/new-console-template for more information

string[] allOrders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

const string exoticStartingCharacter = "B";

foreach (var order in allOrders) {
    if (order.StartsWith(exoticStartingCharacter)) {
        Console.WriteLine(order);
    }
}
