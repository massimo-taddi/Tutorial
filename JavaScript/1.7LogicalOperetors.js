"use strict";

const restaurant = {
  name: "Classico Italiano",
  location: "Via Angelo Tavanti 23, Firenze, Italy",
  categories: ["Italian", "Pizzeria", "Vegetarian", "Organic"],
  starterMenu: ["Focaccia", "Bruschetta", "Garlic Bread", "Caprese Salad"],
  mainMenu: ["Pizza", "Pasta", "Risotto"],
  openingHours: {
    thu: {
      open: 12,
      close: 22,
    },
    fri: {
      open: 11,
      close: 23,
    },
    sat: {
      open: 0,
      close: 24,
    },
  },
  order: function (starterIndex, mainIndex) {
    //con questo return riesco a riportare 2 valori fuori dalla funzione quindi order da 2 risultati
    return [this.starterMenu[starterIndex], this.mainMenu[mainIndex]];
  },
  orderDelivery: function ({
    starterIndex = 1,
    mainIndex = 0,
    time = "20:00",
    address,
  }) {
    console.log(
      `Order received! ${this.starterMenu[starterIndex]} and ${this.starterMenu[mainIndex]} ${this.starterMenu[address]} and ${this.starterMenu[time]} `
    );
  },
  orderPizza: function (mainIngredient, ...otherIngredients) {
    console.log(mainIngredient);
    console.log(otherIngredients);
  },
};

const rest1 = {
  name: "Capri",
  numGuests: 20,
};
const rest2 = {
  name: "La Piazza",
  owner: "Giovanni Rossi",
};
//or assign operator
rest1.numGuests ||= 10;
rest2.numGuests ||= 10;
//nullish assign operator che sta per null or undefined
rest1.numGuests ??= 10;
rest2.numGuests ??= 10;
rest2.owner = rest2.owner && "<ANONYMOUS>";
