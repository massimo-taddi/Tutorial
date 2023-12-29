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
restaurant.orderDelivery({
  time: "22:30",
  address: "Via del Sole, 21",
  mainIndex: 2,
  starterIndex: 2,
});

//OPERATORE SPREAD SERVE PER PRENDERE TUTTI GLI ELEMENTI DI UN ARRAY IN UNA VOLTA SOLA

const arr = [7, 8, 9];

const badNewArr = [1, 2, arr[0], arr[1], arr[2]];
console.log(badNewArr);
//l'operatore spread si scrive con 3 punti e poi il vettore che vogliamo "spalmare"
//ciò che succede è che i valori presi dall'arr vengono disposti tutti in fila ordinati uno ad uno

const newArr = [1, 2, ...arr];
console.log(newArr);

const newMenu = [...restaurant.mainMenu, "Gnocchi"];
console.log(newMenu);

//esempi di operatori spread

//creare copie i array
const mainMenuCopy = [...restaurant.mainMenu];

//fare join

const menu = [...restaurant.starterMenu, ...restaurant.mainMenu];
console.log(menu);

//la funzione di spread può essere usato su tutte le variabili iterabili come
//array,stringhe,maps,set ma non oggetti su ES6 anche su oggetti
const newRestaurant = { foundation: 1998, ...restaurant, founder: "Giuseppe" };
console.log(newRestaurant);
const restaurantCopy = { ...restaurant };
restaurantCopy.name = "Ristorante Roma";

//come usare l'operatore spread per prendere solo dati che ci interessano di un array
const array = [1, 2, ...[3, 4]];

//si chiama REST perchè prende il resto dell'array
const [a, b, ...others] = [1, 2, 3, 4, 5];
console.log(a, b, others);

const [pizza, , risotto, ...otherFood] = [
  ...restaurant.mainMenu,
  ...restaurant.starterMenu,
];
console.log(pizza, risotto, otherFood);

//vediamo come funziona con gli oggeti
const { sat, ...weekdays } = restaurant.openingHours;
console.log(weekdays);

//funzioni
const add = function (...numbers) {
  let sum = 0;
  for (let i = 0; i < numbers.length; i++) {
    sum += numbers[i];
  }

  console.log(sum);
  return;
};
add(2, 3);
add(5, 3, 7, 2);
add(8, 2, 5, 3, 2, 1, 4);

const x = [23, 5, 7];

add(...x);
