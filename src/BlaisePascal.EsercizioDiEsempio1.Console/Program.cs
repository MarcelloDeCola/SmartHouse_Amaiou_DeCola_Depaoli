public class Program//questa è una classe
{
    //metodo di esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("Benvenuto nell'Easy Class 3E!"); //corrispondente del print di kotlin

        int costoSpedizioneSingoloPacco = 5; //dichiarazione e assegnazione
        costoSpedizioneSingoloPacco = 10; //assegnazione

        int numeroPacchiComprati = 2;

        string tipodiConsegna = "Standard"; //dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        //Stampa a video con concatenazione di stringhe e variabili
        Console.WriteLine($"Il tipo di consegan selezionato è: {tipodiConsegna}, " + $"il costo totale è: {costoTotale}");

    }
}