# Loopings &nbsp;

 * while loops 
           ```while (some condition is true) {
              do something
      }```
 * do–while loops
       ```do {
           do something
       } while(condition)```
 * for loops
       ```for (initialization ; condition ; update) {
           do something 
       }```
 * nested loops
       ```for (initialization ; condition ; update) {
           inner loop
        for (initialization ; condition ; update) {
           do something 
        } 
       }```
## Como usar &nbsp;
* while loops <br>
let bottles = 10;<br>
while (bottles > 0){<br>
    console.log(`Havia ${bottles} garrafas verdes penduradas na parede. \n<br>
                E se uma garrafa verde cair acidentalmente, haverá ${bottles-1} <br>
                \n garrafas verdes penduradas na parede.`);<br>
     bottles--;
}
<br>

* do–while loops<br>
let bottles1 = 10;<br>
do{<br>
    console.log(`There were ${bottles1} green bottles, hanging on a wall. <br>
                And if one green bottle should accidentally fall, 
                there'd be ${bottles1-1} green bottles hanging on the wall.`);<br>
    bottles1--; <br>
<br>} while(bottles1 > 0);
<br>

* for loops <br>
for(let bottles2 = 10; bottles2 > 0; bottles2--){<br>
    console.log(`Havia ${bottles2} garrafas verdes penduradas na parede. \n
        E se uma garrafa verde cair acidentalmente, haverá ${bottles2-1} \n
        garrafas penduradas na parede.`);<br>
}
<br><br>

To achieve this, we want the outer loop to set the first number to 1 
and then use the inner loop to multiply it by a second number that will 
go from 1 to 12 in each step. After we’ve multiplied 1 by every number, 
we’ll increase the first number to 2 in the outer loop and multiply this by all the numbers from 1 to 12 in the inner loop, and so on, until we get to 12 multiplied by 12. 

for(let i =1; i<13; i++){<br>
    for(let j=1; j<13; j++){<br>
        console.log(`${j} multiplicado por ${i} é ${i*j}`);<br>
    }
}