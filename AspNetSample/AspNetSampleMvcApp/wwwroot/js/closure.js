function init() {
    let name = 'Vasily Pupkin'; // local var created by init

    function displayName() {//inner function. CLOSURE
        name = 'Vasily Nepupkin';
        console.log(name); // use variable declared in parent function
    }
    return displayName;
}

const myFunc = init();
myFunc(); // have a link to name variable


console.log(name);