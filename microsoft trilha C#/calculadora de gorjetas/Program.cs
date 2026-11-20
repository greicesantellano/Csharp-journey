// Collect the bill amount and tip percentage

// Display the entered values

// Calculate the tip and total

// Display the results

decimal totalConta = 45.50m;
decimal totalGorjetas = 18;

Console.WriteLine($"Total da conta: {totalConta}");
Console.WriteLine($"Total gorjetas: {totalGorjetas}");

totalGorjetas = totalConta * (totalGorjetas / 100);

totalConta = totalConta + totalGorjetas;

Console.WriteLine(totalConta);
