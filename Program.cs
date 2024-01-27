// See https://aka.ms/new-console-template for more information
double MERCHANT_FLAT_FEE = 5.27;
int COST_OF_SPELL = 10;
double COST_OF_MAGIC_INGREDIENT = .25;
int numberOfSpells = 0;
int numberOfMagicIngredients = 0;
double offerings = 0.0;
double totalSpellCost = 0.0;
double totalIngredientCost = 0.0;
double totalMerchantPayment = 0.0;
double goldOwed = 0.0;

System.Console.WriteLine("Welcome to Penny Pincher's Quest!");

Console.WriteLine("Number of Spells wanted:");
string userInput = Console.ReadLine ();
numberOfSpells = int.Parse(userInput);

System.Console.WriteLine("Number of Magical Ingredients wanted:");
numberOfMagicIngredients= int.Parse(Console.ReadLine ());

System.Console.WriteLine("Offerings willing to give:");
offerings = double.Parse(Console.ReadLine());

totalSpellCost = COST_OF_SPELL*numberOfSpells;
totalIngredientCost = COST_OF_MAGIC_INGREDIENT*numberOfMagicIngredients;
totalMerchantPayment = MERCHANT_FLAT_FEE + offerings;
goldOwed= totalIngredientCost + totalMerchantPayment + totalSpellCost;
System.Console.WriteLine("Total gold owed is " + goldOwed);
System.Console.WriteLine("Thank you for shopping with us!");