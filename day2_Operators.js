'use strict';

var _input = '';
var _index = 0;
process.stdin.on('data', (data) => { _input += data; });
process.stdin.on('end', () => {
	_input = _input.split(new RegExp('[\n ]+'));
	main(+(_input[0]), +(_input[1]), +(_input[2]));    
});

function main(mealCost, tipPercent, taxPercent) {
    var tip = parseFloat(mealCost*(tipPercent/100));
var tax = parseFloat(mealCost*(taxPercent/100));
var total = Math.round(parseFloat(mealCost + tip + tax));
console.log("The total meal cost is " + total + " dollars.");
    // Use console.log() to print to stdout
}