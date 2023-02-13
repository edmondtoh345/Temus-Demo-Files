let arr = [];
function AddItem(){
    document.getElementById('todos').innerHTML='';
    var text = document.getElementById('txt1').value;
    arr.push(text);
    arr.map(item => {
        let li = document.createElement('li');
        li.innerHTML=`${item} <i onclick="RemoveItem('${item}')" class="fa-solid fa-trash float-end text-danger"></i>`;
        li.className='list-group-item';
        document.getElementById('todos').appendChild(li);
    });
}

function RemoveItem(listItem){
    let index = arr.indexOf(listItem);
    arr.splice(index, 1);
    document.getElementById('todos').innerHTML='';
    arr.map(item => {
        let li = document.createElement('li');
        li.innerHTML=`${item} <i onclick="RemoveItem('${item}')" class="fa-solid fa-trash float-end text-danger"></i>`;
        li.className='list-group-item';
        document.getElementById('todos').appendChild(li);
    });
}


