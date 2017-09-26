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
function tick(board) {

  var boardChange=[];
  if(is('Array', board))
  {

    for(let i=0;i<board.length;i++)
    {
      if(is('Array',board[i]))
      {
        boardChange[i]=board[i].slice();
        for(let j=0;j<board[i].length;j++)
        {
          let liveCount = 0;
         for(let k=-1;k<=1;k++)
         {
         for(let m=-1;m<=1;m++)
         {
           if((i+k>=0)&&(j+m>=0)&&(i+k<board.length)&&(j+m<board[i].length))
             {
               try
               {
               if(board[i+k][j+m]==1)
                {if(k!=0||m!=0)
                liveCount++;
              }

              }
              catch(e)
              {
                process.stdout.write('Index overflow in board array\n');
              }
           }
         }
       }
          if(liveCount<2||liveCount>3)
          boardChange[i][j]=0;
          else {
            if(liveCount==3) boardChange[i][j]=1;
          }

        }
      }

    }

   }

   return boardChange;



  function is(type,obj)
  {
    var toString = Object.prototype.toString;
    var clas = toString.call(obj).slice(8,-1);
    return clas!=='undefine'&&clas!==null&&clas===type;

  }

}



//var fs = require('fs');
//var wstream = fs.createWriteStream(process.env.OUTPUT_PATH);

process.stdin.on('end', function() {
    __input_stdin_array = __input_stdin.split("\n");
    var board;
    var board_rows = 0;
    var board_cols = 0;
    var board_rows = parseInt(__input_stdin_array[__input_currentline].trim(), 10);
    __input_currentline += 1;
    var board_cols = parseInt(__input_stdin_array[__input_currentline].trim(), 10);
    __input_currentline += 1;

    var board = Array(board_rows);
    for(var board_i = 0; board_i < board_rows; board_i++) {
      board[board_i] = __input_stdin_array[__input_currentline].trim().split(' ')
      __input_currentline += 1;
      board[board_i] = board[board_i].map(Number);
    }


    res = tick(board);
    var res_rowLength = res.length;
    var res_colLength = res[0].length;
    for(var res_i = 0; res_i < res_rowLength; res_i++) {
        for(var res_j = 0; res_j < res_colLength; res_j++) {
        //    wstream.write(res[res_i][res_j]+" ");
        process.stdout.write(res[res_i][res_j]+" ");
        }
      //  wstream.write("\n");
      process.stdout.write("\n");
    }

  //  wstream.end();
});
