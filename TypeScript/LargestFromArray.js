var values = [1, 65, 8, 98, 689, 12, 33, 2, 3, 789];
var topValues = values.sort(function (a, b) { return b - a; }).slice(0, 5);
console.log(topValues);
