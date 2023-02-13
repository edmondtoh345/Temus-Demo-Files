// document.write('Welcome to JavaScript');

const heading = document.createElement('h1');
heading.innerText = 'Welcome to DOM';
heading.style.color = 'Red';
document.getElementById('div1').appendChild(heading);

let fruits = ['Apple', 'Banana', 'Cherry', 'Mango'];

fruits.map(item => {
    const li = document.createElement('li');
    li.innerText = item;
    document.getElementById('fruitlist').appendChild(li);
})

let persons = [
    {
        fname: 'Peter',
        lname: 'Parker',
        age: 25
    },
    {
        fname: 'Tony',
        lname: 'Stark',
        age: 40
    },
    {
        fname: 'Steven',
        lname: 'Strange',
        age: 45
    },
    {
        fname: 'James',
        lname: 'Cameron',
        age: 60
    }
]

// persons.map(item => {
//     const tr = document.createElement('tr');
//     const td1 = document.createElement('td');
//     const td2 = document.createElement('td');
//     const td3 = document.createElement('td');
//     td1.innerText=item.fname;
//     td2.innerText=item.lname;
//     td3.innerText=item.age;
//     tr.appendChild(td1);
//     tr.appendChild(td2);
//     tr.appendChild(td3);
//     document.getElementById('personTable').appendChild(tr);
// });

persons.map(item => {
    const tr = document.createElement('tr');
    tr.innerHTML=`<td>${item.fname}</td><td>${item.lname}</td><td>${item.age}</td>`
    document.getElementById('personTable').appendChild(tr);
});

// persons.map(item => {
//     document.getElementById('personTable').innerHTML=`<tr><td>${item.fname}</td><td>${item.lname}</td><td>${item.age}</td></tr>`
// });

