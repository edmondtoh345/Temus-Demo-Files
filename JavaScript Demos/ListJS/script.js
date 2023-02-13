let customers = [];
function Add(){
    let cname = document.querySelector('#txtName').value;
    let email = document.querySelector('#txtEmail').value;
    let age = document.querySelector('#txtAge').value;
    customers.push({CustomerName: cname, Email: email, Age: age});
    console.log(customers);
    customers.map((item)=>{
        let row = document.createElement('tr');
        row.innerHTML=`<td>${item.CustomerName}</td><td>${item.Email}</td><td>${item.Age}</td>`
        document.querySelector('#customerlist').appendChild(row);
    })
    
}