const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

const digitals = new Array(10);

console.log("Введите 10 чисел для заполнения массива: ");

let count = 0;

rl.on('line', (input) => {
    digitals[count] = parseInt(input, 10);
    count++;
    if (count === 10) {
        // Bubble sort
        for (let i = 0; i < 10; i++) {
            for (let j = 0; j < 9; j++) {
                if (digitals[j] > digitals[j + 1]) {
                    let b = digitals[j];
                    digitals[j] = digitals[j + 1];
                    digitals[j + 1] = b;
                }
            }
        }

        process.stdout.write("Массив в отсортированном виде: ");
        for (let i = 0; i < 10; i++) {
            process.stdout.write(digitals[i] + " ");
        }
        console.log();
        rl.close();
    }
});