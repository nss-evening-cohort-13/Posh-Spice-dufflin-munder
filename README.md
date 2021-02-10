# Posh-Spice-dufflin-munder
Console Project

> You are an employee of the really awesome cardboard company and you're trying to create a console application for your fellow Sales Team Members. As the Assistant to the Assistant Regional Manager you take it upon yourself to outdo Tim in anyway possible.

> The biggest issue you have is keeping track of your clients and their orders so you can report them back to Michael your overzealous Regional Manager that you do anything for and your secret, cheating ex-girlfriend Accountant, Angelina.

# User Interface

```
Welcome to Dufflin/Munder Cardboard Co. 
Sales Portal!

1. Enter Sales
2. Generate Report For Accountant
3. Add New Sales Employee
4. Find a Sale
5. Exit
```

1.  `Which Sales Employee Are You` 

```
1. Dwight Hyte
2. Tim Halbert
3. Phyllis Leaf
```

```
Hi, Dwight!
```

2.  `Enter a sale`

```
Sales Agent: Dwight Hyte
Client: Carol's Pen Pals
ClientID: 2343
Sale: $3412
Recurring: Monthly
Time Frame: 3 months
```

3.  `Generate a Report`

```
Monthly Sales Report
For: Oscar

1. Dwight Hyte
	 Clients: 
			1. Carol's Pen Pals
			2. 2 Men & A Horse Moving Co
			3. Taco Hell Distrubuting 
Total: $12,234.20

2. Tim Halbert
	 Clients:
			1. Cleaning Heiresses 
			2. Lillian's Funeral Home
Total: $9,083.94
```

# Implementation Hints:

Create an **Employee** class which will be a base class for **SalesEmployee** & **AccountantEmployee**.

- you should create at least 2 Accountants (Oscar and Kevin are way nicer than Angelina)
- this will allow you *to choose which accountant* you'd like to generate a report for
- **SalesEmployee** class includes a collection of **Sale**

When creating a **Sale**, you should enter all the information pertaining to that sale, and your Name should automatically be populated ( you already entered it in Step 1 🤯 )

- note here a class should be made
- create a client # to identify by

Generating a report:

- Iterate over a collection of Sales to give to the chosen Accountant that shows the following:
    1. each **SalesEmployee** and all of their clients
    2. at the end of that employee's clients, show the total sales amount for that month
        1. This can be displayed however you like

One of the menu options states to "Find a Sale", enter a client's # and display that **Sale** with the corresponding seller. 

### ****Keep in mind the application should keep running until you press '5' to exit it....

## Stretch Goals ⭐

Create a projected 3 month report, calculating those sales over the 3 months.

[Untitled](https://www.notion.so/e8ea95378d3d4cc5a2cf374ced92f2f9)
