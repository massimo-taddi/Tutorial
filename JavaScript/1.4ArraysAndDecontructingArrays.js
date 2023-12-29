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
};
restaurant.orderDelivery({
  time: "22:30",
  address: "Via del Sole, 21",
  mainIndex: 2,
  starterIndex: 2,
});
const arr = [2, 3, 4];
const a = arr[0];
const b = arr[1];
const c = arr[2];

//praticamente rendo x uguale alla posizione 0 y uguale alla posizione 1 e z alla posizione 3
const [x, y, z] = arr;
console.log(x, y, z);

let [main, secondary] = restaurant.categories;
console.log(main, secondary);

//rearranging array
[main, secondary] = [secondary, main];
console.log(main, secondary);

console.log(restaurant.order(2, 0));

const [starter, mainCourse] = restaurant.order(2, 0);
console.log(starter, mainCourse);

//nested array un array dentro un array

const nested = [2, 4, [5, 6]];

//const [i, , j] = nested;

//console.log(i, j);

const [i, , [j, k]] = nested;
console.log(i, b, [j, k]);

//Default values

const [p = 1, q = 1, r = 1] = [8];
console.log(p, q, r);

//deconstructing objects
//così creo 3 costanti separate con le specifiche parti dell'oggetto
const { name, openingHours, categories } = restaurant;
console.log(name, openingHours, categories);

const {
  name: restaurantName,
  openingHours: hours,
  categories: tags,
} = restaurant;
console.log(restaurantName, hours, tags);

// come funziona il valore do default
//ciò che viene messo dopo = è il valore di default nel caso che il deconstructoring non vada
//a buon fine ciò che accade nell'effettivo è che il valore diventa ciò che vi è dopo ll'uguale
const { menu = [], starterMenu: starters = [] } = restaurant;
console.log(menu, starters);

//modificare variabili
let e = 111;
let f = 999;
const obj = { e: 23, f: 7, c: 14 };
({ e, f } = obj);
console.log(e, f);

//nested objects

const {
  fri: { open, close },
} = openingHours;
console.log(open, close);
