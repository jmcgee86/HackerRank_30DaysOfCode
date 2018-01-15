function processData(input) {
    var even =[];
    var odd = [];
var inputArray = input.split("\n");
    for (var i=1; i<inputArray.length; i++){
        for (var n=0; n<inputArray[i].length; n++){
            if(n%2 === 0){
                 even.push(inputArray[i][n]);
            }else{
                odd.push(inputArray[i][n])
            }
        }            
            console.log(even.join("") + " " + odd.join(""));
            even=[];
            odd = [];
    }
    } 



process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});