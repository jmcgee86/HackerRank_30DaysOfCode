function processData(input) {
    var inputArray = input.split("\n");
    var hasNumber = /\d/;
    var phoneBook = {};
    var queries = [];
    for (var i = 1; i<inputArray.length; i++){
        if (hasNumber.test(inputArray[i])){
             var split = inputArray[i].split(" ");
            var k = split[0];
            var v = split[1];
            phoneBook[k] = v;
        }else{
            queries.push(inputArray[i]);
        }
    }
console.log(queries);
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