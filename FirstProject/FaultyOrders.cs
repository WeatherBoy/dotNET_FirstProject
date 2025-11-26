namespace FirstProject;

public static class FaultyOrders
{
    private static string exoticStartingCharacter = "B";

    public static void printOrdersForInspection(string[] allOrders)
    {
        foreach (var order in allOrders) {
            if (order.StartsWith(exoticStartingCharacter)) {
                Console.WriteLine(order);
            }
        }   
    }

}