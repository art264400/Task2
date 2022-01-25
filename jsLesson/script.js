//es5 
//синаксические изменения
// console.log("this is strokaa"[0]);
// let arr = [0,1,2,3,];
// const text = "my family is very big \
//               you are clever \
// ";
// const obj = {
//     name: "Arthur",
//     new: "Action",
// }
//strict mode use strict, напоминает, что ты забыл объявить переменную
// {
// 'use strict';
// let pi= 3.14;
// let item = 1;
// letitem = 2;
// console.log(letitem)
// }

//Методы стринг 
// let trim=" dssd  ".trim();
// console.log(trim);

//Методы array
//console.log(Array.isArray([]));

//const arr = [0,1,2,3,];
// arr.forEach(element => {
//     console.log(element);
// });

// let array1=[1,2,3,4,5,6];
// let array2 = array1.map(element => {
//     debugger;
//     return element*2;
// });
// console.log(array2);

//возвращает индекс первого вхождения указанного значения в строковый объект
// let array1=[1,2,3,4,5,6];
// console.log(array1.indexOf(3));

//json parse, stringify в заданнии есть

//es6
//Создание переменных, теперь рекомендуется использовать let, а не var
// let a = 20;
// {
//     let a = 1232144421;
//     console.log(a);
// }
// console.log(a);

//появился const

//стрелочные функции 

//литералы восьмериные, двоичные
// let oValue= 0o110;
// console.log(oValue);
// let bValue= 0b10;
// console.log(bValue);

//классы, наследование super();
// class Animal{
//     constructor(){
//         console.log("Создали объект животного");
//     }
// }
// class Dog extends Animal{
//     constructor(){
//         super();
//         console.log("Создали объект собаку");
//     }
// }
// let animal = new Animal();
// let dog = new Dog();

//конгломерация строк
// let world = 'World';
// console.log(`Hello ${world}`);

//promises
// let a = "5 sec"
// setTimeout(() => {
//     a ="2 sec"
//     console.log(a);
// }, 2000);
// console.log(a);

// let a = "5 sec";
// const prom = new Promise((resolve,reject)=>{
//     setTimeout(() => {
//         a = "2 sec";
//         // reject();
//     resolve();
//     }, 2000);})
//     //будет выполнен then когда выполниться ассинхронная операция
// prom.then((resolve,reject) =>{
//     console.log(a);
// })
// prom.catch(()=>{
//     console.log("catch");
// })


//контексты
// const user = {
//     name: 'Arthur',
//     sayHello(){console.log(`привет, я - ${this.name}`, this)}
// }
// user.sayHello();
// const f = user.sayHello;
// ==, вместо this подставляет window глобальный объект
// const f = function(){
//     console.log(`Привет, я $this.name`, this);
// }
// f();
// setTimeout(user.sayHello, 1000);

// как не потерять контекст
// const f = user.sayHello;
// f.call(user);

//async/await
// const delay = ms =>{
//     return new Promise(r => setTimeout(() => r(),2000));
// }
// const url='https://www.cbr-xml-daily.ru/daily_json.js';
// async function fetchAsync(){
//     await delay(2000);
//     const response = await fetch(url);
//     const data = await response.json();
//     console.log(data);
// }
// fetchAsync();
//delay(2000).then(() => console.log("2 sec"));

//прототипы
// const person = {
//     name: 'Arthur',
//     height: 183,
//     write : () =>{console.log('Hello world')}
// }
//==
// const person = new Object({
//     name: 'Arthur',
//     height: 183,
//     write : () =>{console.log('Hello world')}
// });

//расширяем базовый прототип object

// Object.prototype.sayHello = () =>{
//     console.log("Hello");
// }
// person.sayHello();

//грубо говоря создаем наследуемый объект, прототип
// const igor = Object.create(person);