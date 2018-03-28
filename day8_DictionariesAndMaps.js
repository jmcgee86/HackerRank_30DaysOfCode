function processData(input) {
    var inputArray = input.split("\n");
    var phoneBook = {};
    var queries = [];
    for (var i = 1; i<inputArray.length; i++){
        if (/\d/.test(inputArray[i])){
             var split = inputArray[i].split(" ");
            phoneBook[split[0]] = split[1];
        }else{
            queries.push(inputArray[i]);
        }
    }
    for (var x = 0; x<queries.length; x++){
        if(!phoneBook[queries[x]]){
            console.log("Not found");
        }else{
        console.log(queries[x] + "=" + phoneBook[queries[x]]);
        }
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