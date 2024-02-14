"use strict";

// document.getElementById("btn1").addEventListener("click", (e) => {
//   alert("Produto cadastrado com sucesso!");
//   e.stopPropagation();
// });

// document.getElementById("div1").addEventListener("click", () => {
//   alert("Produto carregado!");
// });

// document.getElementById("link").addEventListener("click", (e) => {
//   e.preventDefault();

//   // alert("Produto carregado!");
// });

window.addEventListener("keydown", (e) => {
  if (e.key == "Enter") {
    console.log(e);
  }
});

 
// window.addEventListener("mousemove", (e) => {
 
//     console.log(e.x);
//     console.log(e.y);
 

// });

// let timeout;
// window.addEventListener("mousemove", (e) => {
//   clearTimeout(timeout);

//   timeout = setTimeout(() => {
//     console.log(e.x);
//     console.log(e.y);
//   }, 100);

// });


 
window.addEventListener("scroll", (e) => {
 
    // console.log(window.scrollY);
    
 if(window.scrollY > 200){
  console.log("Xpto");
 }

});