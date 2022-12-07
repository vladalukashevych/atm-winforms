using ATM.ClassLibrary;
using ATM.ClassLibrary.Classes;
using ATM.ConsoleApp;

string customersDataPath = @"..\..\..\..\data\customers.json";
var atms = new List<AutomatedTellerMachine> { new AutomatedTellerMachine("1", "17. listopadu 588/10", 100000) };
var bank = new Bank("LoliPop", atms, customersDataPath);
int atmId = 0;
new ATMConsole(new Session(bank, atmId));