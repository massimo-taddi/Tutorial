//esempi di funzioni freccia e funzioni normali

const calcAverage = (score1, score2, score3) => (score1 + score2 + score3) / 3;
console.log(calcAverage(3, 4, 5));

let scoreDolphins = calcAverage(44, 23, 71);
let scoreKoalas = calcAverage(65, 54, 49);

function checkWinner(scoreDolphins, scoreKoalas) {
  if (scoreDolphins > scoreKoalas)
    console.log(`Dolphins win(${scoreDolphins} vs. ${scoreKoalas})`);
  else if (scoreKoalas > scoreDolphins)
    console.log(`Koalas win(${scoreKoalas} vs. ${scoreDolphins})`);
  else console.log("No team wins...");
}

checkWinner(scoreDolphins, scoreKoalas);
