## Requirements
You've been provided with the shell of a .NET Core console application with two sample inputs.

Create an application which outputs both Humphries and Megacorp building supplies.
The information printed should be the ID, item name and price.
The supplies should be shown in a combined list.
The supplies should be ordered from most expensive to least expensive.
All prices must be shown to the nearest cent in AUD based on the exchange rate.

The code should be at a standard you'd feel comfortable with putting in production.

### Source Data
Both humphries.csv and megacorp.json contain lists of construction supplies and labour items.

#### megacorp.json
* Code should be unique
* All prices are in USD

#### humphries.csv
* All prices are in AUD

#### Exchange rate
* The exchange rate is found in appsettings.json.

### Example Console Output Using Subset of Actual Data
7f3c48c4-f8b6-453f-b2fa-83ec31dfa85c, Bobcat to Dig LM of Strip Footing, $800.00

0a360e10-4e35-4e94-bd80-2e8bd6c749f1, Under Slab Sand 150mm, $77.24

4000, 100 x 200 x 20mpa Internal Beam, $68.00

## Guidelines
* Please limit your time to 2 hours. If you don't complete it within this time just let us know what is outstanding.
* Commit your code at regular intervals so we can see how you reached your solution.
* Once completed push to a public repo and share the link with us
* The goal of this challenge is not to complete the exercise, but to give us an understanding on how you tackle problems. 
* Be prepared to talk us through your thinking process & assumptions as you go.
* Feel free to use any resources you would normally use (Google, StackOverflow etc.)
* Please ask any questions you wish

## Considerations/Notes
* Please Run this on a windows Based system, as the file path might cause a problem
```
  -------------------------------------------------------------------------------------------------------------------
 | Id                                   | Description                                  | Price(AUD) | Rounded(AUD) |
 -------------------------------------------------------------------------------------------------------------------
 | 7f3c48c4-f8b6-453f-b2fa-83ec31dfa85c | Bobcat to Dig LM of Strip Footing            | $800.00    | $800.00      |
 -------------------------------------------------------------------------------------------------------------------
 | 812c8fe8-7575-474e-bd6d-0be13e72fa0a | Under Slab Pest Control (LM + Penetrations)  | $300.00    | $300.00      |
 -------------------------------------------------------------------------------------------------------------------
 | 3                                    | 100mm x 25mpa Slab                           | $141.65    | $142.00      |
 -------------------------------------------------------------------------------------------------------------------
 | 13                                   | Backhoe to Dig LM of Pier Hole               | $99.65     | $100.00      |
 -------------------------------------------------------------------------------------------------------------------
 | 94884242-19ee-444a-880d-eafccdb47fe8 | Precast Concrete Pad                         | $84.00     | $84.00       |
 -------------------------------------------------------------------------------------------------------------------
 | e1b3e145-782b-43b3-a081-f3634a07db00 | TM3 R11 Mesh                                 | $83.99     | $84.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 0edbbcf2-e61a-4f86-a9a7-34c94637b8cf | Under Slab Sand 100mm                        | $83.50     | $84.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 0a360e10-4e35-4e94-bd80-2e8bd6c749f1 | Under Slab Sand 150mm                        | $77.24     | $77.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 45b0527b-5a8c-464c-9b93-b70629def248 | Under Slab Sand 50mm                         | $66.30     | $66.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 12                                   | 8 x 200 Trench Mesh                          | $57.58     | $58.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 10                                   | 600 x 150 Concrete Gutter Crossover          | $56.00     | $56.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 11                                   | 75mm x 20mpa Slab                            | $52.50     | $52.00       |
 -------------------------------------------------------------------------------------------------------------------
 | fbc8b766-e734-4511-91ae-18b075ff19e5 | N12 Reo Bar                                  | $50.00     | $50.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 1                                    | 100 x 200 x 20mpa Internal Beam              | $28.00     | $28.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 0                                    | 100 x 350 Thickened Edge                     | $24.50     | $24.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 4                                    | 100mm x 32 mpa Slab                          | $15.75     | $16.00       |
 -------------------------------------------------------------------------------------------------------------------
 | b6e3ec90-c008-4d67-b2b2-1904bef08eb6 | Plastic Membrane                             | $10.50     | $10.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 7                                    | 11 x 200 Trench Mesh                         | $10.47     | $10.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 17                                   | 11 x 200 Trench Mesh                         | $10.47     | $10.00       |
 -------------------------------------------------------------------------------------------------------------------
 | 2                                    | 1000 x 1000 x 350 x 20mpa Square Pad Footing | $8.58      | $9.00        |
 -------------------------------------------------------------------------------------------------------------------
 | 14                                   | Bobcat to Dig LM of Strip Footing            | $6.65      | $7.00        |
 -------------------------------------------------------------------------------------------------------------------
 | 16                                   | Bobcat with Auger to Dig LM of Pier Hole     | $4.90      | $5.00        |
 -------------------------------------------------------------------------------------------------------------------
 | 6                                    | 100 x 200 x 20mpa Internal Beam              | $1.40      | $1.00        |
 -------------------------------------------------------------------------------------------------------------------

 Count: 23
```