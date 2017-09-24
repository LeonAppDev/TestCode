/*This function will give an integer as n and a group of integers in which total number is k,
find all the combinations of integers in which sum equals n */

var result = (function combinationSum(n, k)
{
   var combines=[];
   var temp=[];
   var combine=[];
   var combineTemp=[];
   var i,j;
   console.log(n);
   console.log(k);

   if(n==0)
   {
     for(i=0;i<k;i++)
     {
       combine[i]=0;
     }
     combines[0]=combine;
   }
  else
  {

     temp = combinationSum(n-1,k);
     temp.map(array=>{
         for(j=0;j<k;j++)
         {
             combineTemp=array;
             combineTemp[j]=combineTemp[j]+1;

             combines.push(combineTemp);

         }
     })
   }
   return combines;

})(9,5)

console.log(result);
