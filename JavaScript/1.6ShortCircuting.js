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

//short circuting evaluation

console.log(3 || "Jonas");
console.log("" || "Jonas");
//praticamente ciò che accade è se il primo valore letto è un valore "true" un truthy value
//allora riporterà il primo valore altrimenti il secondo

const guest1 = restaurant.numGuests ? restaurant.numGuests : 10;

console.log(guest1);

//mentre && riporta entrambi i risultati se sono entrambi valori truthy
