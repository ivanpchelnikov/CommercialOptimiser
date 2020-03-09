# CommercialOptimiser

 ### To start: 

1. git clone https://github.com/ivanpchelnikov/CommercialOptimiser.git
2. Build in the Visiual Studio or 
   from CLI inside solution folder: CommercialOptimiser:
      <b>run dotnet</b>
 cd inside bin folder and run: CommercialOptimiser.exe
 
### Tasks:
1. Place 3 commercials in each of the breaks in a way that achieves the most total ratings for that demographic, with no violations of the restrictions.
2. For each of the 3 demographic scenarios, calculate the total ratings achieved by all 9 commercials, based on the demographic rating of the break it is in, and print it in the console along with the description of the final placement structure.

##### Additional Questions (Bonus points):
• You have 10 commercials and you must leave one unplaced.
• Uneven Break structure (One break takes 2, one 3 and one 4 Commercials)

##### Solution: 
The ouptup group all commercials per demographis per current break, with rules:
 - Commercial Break Restrictions
      - FinanceType Commercial can’t go in to break2
      - CommercialType cannot be next to same CommercialType in break
      
      
It is also should work for uneven Break structure. One break takes 2, one 3 and one 4 Commercials.
