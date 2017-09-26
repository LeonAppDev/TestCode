
process.stdin.resume();
process.stdin.setEncoding('utf-8');

var __input_stdin = "";
var __input_stdin_array = "";
var __input_currentline = 0;

process.stdin.on('data', function(data) {
    __input_stdin += data;

    if(typeof data ==='string')
    {
      data = data.slice(0,-2);

      if(data=='')
      {
        process.stdin.emit('end');
      }
    }
});

/*
 * Complete the function below.
 */
function GetTaxPayable(income) {


  var tax = 0;

  var incomeTax = addFloat(multiFloat(Math.min(40000,income),0.1),
  multiFloat(Math.min(40000,Math.max(0,income-40000)),0.2),
  multiFloat(Math.max(0,income-80000),0.3));

  var healthLevy = income<=40000?multiFloat(income,0.015):(income<=80000?multiFloat(income,0.025):multiFloat(income,0.035));

  tax = round(addFloat(incomeTax,healthLevy),2);

  function addFloat(...args)
  {
    var m=0,power=0,result = 0;
    for(let value of args)
    {
      let r=0;
      try{r=value.toSting.split('.')[1].length;}catch(e){r=0;}
      m=Math.max(m,r);
    }
    power = Math.pow(10,m);
    for(let value of args)
    {
      result+=value*power;
    }
    return (result = result/power);

    }

    function multiFloat(...args)
    {

      var m=0,power=0,result = 1;
      for(let value of args)
      {
        let r=0;
        try{r=value.toSting.split('.')[1].length;}catch(e){r=0;}
        m=Math.max(m,r);
      }
      power = Math.pow(10,m);
      for(let value of args)
      {
        result*=value*power;
      }
      return (result = result/power);
    }

    function round(number,precision)
    {
       var factor = Math.pow(10,precision);
       var tempNumber = number*factor;
       var tempNumberRound = Math.round(tempNumber);
       return number = tempNumberRound/factor;

    }
  return tax;
}

//var fs = require('fs');
//var wstream = fs.createWriteStream(process.env.OUTPUT_PATH);

process.stdin.on('end', function() {
    __input_stdin_array = __input_stdin.split("\n");
    var income;
    var income = parseInt(__input_stdin_array[__input_currentline].trim(), 10);
    __input_currentline += 1;


    res = GetTaxPayable(income);

    process.stdout.write(res.toString());
    //wstream.write(res + "\n");

    //wstream.end();
});
