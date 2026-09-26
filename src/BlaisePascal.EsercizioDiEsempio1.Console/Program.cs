public class Program//questa è una classe
{
    //metodo di esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("inserisci il nome del cliente");
        //ReadLine() permette di leggere l'imput dall'utente
        string nomeCliente = Console.ReadLine();


        Console.WriteLine("inserisci il tipo di spedizione");

        string tipodiConsegna = Console.ReadLine();

        Console.WriteLine("inserisci il numero di pacchi acquistati");
        int numeroPacchiComprati = int.Parse(Console.ReadLine());


        Console.WriteLine($"Benvenuto {nomeCliente} nell'Easy Class 3E!"); //corrispondente del print di kotlin

       
        int costoSpedizioneSingoloPacco = 5; //dichiarazione e assegnazione
        costoSpedizioneSingoloPacco = 10; //assegnazione

        

        

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        //Stampa a video con concatenazione di stringhe e variabili
        Console.WriteLine($"Il tipo di consegna selezionato è: {tipodiConsegna}, " + $"il costo totale è: {costoTotale}");

    }
}