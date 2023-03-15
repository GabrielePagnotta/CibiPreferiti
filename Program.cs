string[] cibi = { "lasagne al ragu", "pasta al pesto", "gnocchi", "pizza margherita", "spaghetti al pomodoro" };

//La lunghezza della classifica:

var lunghezza = cibi.Length;

var ciao = "la lunghezza è" + " " +  lunghezza;

Console.WriteLine(ciao);


//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica):

for (int i = 0; i < cibi.Length; i++)
{
    
    Console.WriteLine(i+1 + " " + cibi[i]);
}


//Il vostro cibo top (prima posizione della classifica):

Console.WriteLine(cibi[0]);


//Il vostro cibo preferito ma non troppo (ultima posizione della classifica):

Console.WriteLine(cibi[4]);