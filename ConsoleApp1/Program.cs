﻿// See https://aka.ms/new-console-template for more information


using ConsoleApp1.Factory.BudgetFactory;
using ConsoleApp1.Factory.TRFactory;
using ConsoleApp1.Util;
using ExpenseTrackingApp.Factory.Concretes.IncomeCategories;
using ExpenseTrackingApp.Models;
using System.Linq.Expressions;


Logger logger = Logger.GetLogger();

logger.log("Creating categories....");

//Categories 
ICategory salary = new IncomeCategory("001", "Salary");
ICategory rent = new IncomeCategory("002", "Rent");
ICategory other = new IncomeCategory("003", "Other");

ICategory  petral = new ExpenseCategory("001", "Petorl");
ICategory meal = new ExpenseCategory("002", "Meal");
ICategory travel = new ExpenseCategory("003", "Traval");

logger.log("Creating budget....");

BudgetTypeCreator[] budgetTypeCreator = new BudgetTypeCreator[2];

budgetTypeCreator[0] = new ExpenseBudgetCreator("Month of Jan", new DateTime(2023, 01, 01), new DateTime(2023, 01, 31));
budgetTypeCreator[1] = new IncomeBudgetCreator("Month of Jan", new DateTime(2023, 01, 01), new DateTime(2023, 01, 31));

budgetTypeCreator[0].CreateBudgetItem("petrol", 500, petral, DateTime.Now);
budgetTypeCreator[0].CreateBudgetItem("meal", 500, meal, DateTime.Now);

budgetTypeCreator[1].CreateBudgetItem("JAN", 10000, salary, DateTime.Now);
budgetTypeCreator[1].CreateBudgetItem("Rent", 1500, rent, DateTime.Now);


foreach (BudgetTypeCreator tc in budgetTypeCreator)
{
    Console.WriteLine("budget ------------------");
    Console.WriteLine(tc);
    foreach (Budget t in tc.BudgetItems)
    {
        Console.WriteLine("budget "+t.Note + " " + t.Amount);
        Console.WriteLine(t.Category.Name + " " + t.Category.CategoryType.ToString());

    }
}

logger.log("adding tranactions...");

Console.WriteLine("actualk ------------------");
TransactionTypeCreator[]  transactionTypes = new TransactionTypeCreator[2];

transactionTypes[0] = new ExpenseCreator();
transactionTypes[1] = new IncomeCreator();

transactionTypes[0].CreateTransaction("petrol", 500 , petral,   DateTime.Now);
transactionTypes[0].CreateTransaction("meal", 500, meal, DateTime.Now);

transactionTypes[1].CreateTransaction("JAN", 10000, salary, DateTime.Now);
transactionTypes[1].CreateTransaction("Rent", 1500, rent, DateTime.Now);


foreach (TransactionTypeCreator tc in transactionTypes)
{
    Console.WriteLine(tc);
    foreach( Transaction t in tc.Transactions)
    {
        Console.WriteLine(t.Note +" "+ t.Amount);
        Console.WriteLine(t.Category.Name +" "+ t.Category.CategoryType.ToString());

    }
}

logger.log("Application successfully executed....");






