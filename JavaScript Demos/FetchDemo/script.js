fetch('https://jsonplaceholder.typicode.com/users')
    .then(res => res.json())
    .then(data => {
        data.map(item => {
            const li = document.createElement('li');
            li.className = 'list-group-item';
            li.innerText = item.name;
            document.getElementById('users').appendChild(li);
        });
    });