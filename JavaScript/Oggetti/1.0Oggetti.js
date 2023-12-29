//BMI=mass/(height*height)

const mark = {
  fullName: "Mark",
  mass: 78,
  height: 169,
  calcBMI: function () {
    let mass = this.mass;
    let height = this.height;
    let BMI = mass / (height * height);
    return BMI;
  },
};
const john = {
  fullName: "John",
  mass: 92,
  height: 195,
  calcBMI: function () {
    let mass = this.mass;
    let height = this.height;
    let BMI = mass / (height * height);
    return BMI;
  },
};
mark.calcBMI();
john.calcBMI();

if (mark.calcBMI() > john.calcBMI()) {
  console.log(
    `${mark.fullName}'s BMI (${mark.calcBMI()}) is higher than ${
      john.fullName
    }'s (${john.calcBMI()})!`
  );
} else if (john.calcBMI() > mark.calcBMI()) {
  console.log(
    `${john.fullName}'s BMI (${john.calcBMI()}) is higher than ${
      mark.fullName
    }'s (${mark.calcBMI()})!`
  );
}

console.log(dice);

while (dice !== 6) {
  let dice = Math.trunc(Math.random() * 6) + 1;
  console.log(dice);
}
