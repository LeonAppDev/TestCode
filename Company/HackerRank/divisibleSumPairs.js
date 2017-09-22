process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function (data) {


    input_stdin += data;

  if(typeof data === 'string')
  {
    data=data.slice(0,-2);

    if (data==='')
    {
      process.stdin.emit('end');
    }
  }


});

process.stdin.on('end', function () {

    input_stdin_array = input_stdin.split("\n");
    main();
});

function readLine() {
    return input_stdin_array[input_currentline++];
}

/////////////// ignore above this line ////////////////////

function divisibleSumPairs(n, k, ar) {

       var numbers=[];
       var i;
       var count=0;
       //Initialze a k space array with 0
       for(i=0;i<k;i++)
       {
         numbers[i]=0
       }
      //Set each element as the sum of division of k
       for(i=0;i<n;i++)
       {
         numbers[ar[i]%k]++;

       }

       var index=Math.ceil(k/2);
       count+= numbers[0]*(numbers[0]-1)/2
       for(i=1;i<index;i++)
       {
             count+=numbers[i]*numbers[k-i];
       }

       if(k%2==0)
       {
         count+=numbers[index]*(numbers[index]-1)/2;
       }

       return count;

}

function main() {

    var n_temp = readLine().split(' ');
    var n = parseInt(n_temp[0]);
    var k = parseInt(n_temp[1]);
    ar = readLine().split(' ');
    ar = ar.map(Number);
    var result = divisibleSumPairs(n, k, ar);
    process.stdout.write("" + result + "\n");
}
