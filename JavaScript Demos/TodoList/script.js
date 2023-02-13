function AddItem() {
    let text = document.getElementById('txt1').value;
    fetch('http://localhost:3000/todos', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ description: text, isCompleted: false })
    })
}

function RemoveItem(id) {
    fetch(`http://localhost:3000/todos/${id}`, {
        method: 'DELETE'
    })
}

function GetItems() {
    fetch('http://localhost:3000/todos')
        .then(res => res.json())
        .then(data => {
            data.map(item => {
                let li = document.createElement('li');
                if(item.isCompleted){
                    li.innerHTML = `<input type="checkbox" checked onclick="MarkCompleted(${item.id})"/> ${item.description} <i onclick="RemoveItem(${item.id})" class="fa-solid fa-minus float-end text-danger"></i>`;
                    li.className = 'list-group-item text-decoration-line-through';
                }else{
                    li.innerHTML = `<input type="checkbox" onclick="MarkCompleted(${item.id})"/> ${item.description} <i onclick="RemoveItem(${item.id})" class="fa-solid fa-minus float-end text-danger"></i>`;
                    li.className = 'list-group-item';
                }
                document.getElementById('todos').appendChild(li);
            })
        })
}

function MarkCompleted(id) {
    fetch(`http://localhost:3000/todos/${id}`)
        .then(res => res.json())
        .then(data => {
            fetch(`http://localhost:3000/todos/${id}`, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({description: data.description, isCompleted: !data.isCompleted})
            })
        });
}

GetItems();