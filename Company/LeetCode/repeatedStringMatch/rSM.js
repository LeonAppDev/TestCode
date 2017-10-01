/**
 * @param {string} A
 * @param {string} B
 * @return {number}
 */
var repeatedStringMatch = function(A, B) {

           var count=1;
           var stringExtend = A;

           while(!(stringExtend.includes(B))&&stringExtend.length<2*B.length)
           {
                   stringExtend+=A
                  count++;

              

           }


    return stringExtend.includes(B)?count:-1;
};




console.log(repeatedStringMatch('sdsd','dsccdcdcfddgdfgfd'));
