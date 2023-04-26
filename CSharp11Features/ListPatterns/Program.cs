

int[] numbers = { 1, 2, 3 };

var pattern1 = numbers is [1, 2, 3]; // true
var pattern2 = numbers is [1, 2]; // false 
var pattern3 = numbers is [_, 2, 3]; // true [0] can be any 
var pattern4 = numbers is [1, 2,  > 2 and < 5]; // true 2 < [2] < 5 
var pattern5 = numbers is [1, 2, 3]; // true

int[] numbers2= { 1, 2, 3, 4, 5 };

var pattern5 = numbers is [1, 2, ..]; // true
var pattern5 = numbers is [.., 4, 5]; // true
var pattern5 = numbers is [1, .., 5]; // true
 
