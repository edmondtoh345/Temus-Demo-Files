let arr = ['Item 1', 'Item 2'];

function GetItems() {
    arr.map(item => {
        console.log(item);
    });
}

function AddItem(item) {
    return new Promise((resolve, reject) => {
        let err = false;
        setTimeout(() => {
            if (!err) {
                arr.push(item);
                resolve('Task Completed');
            } else {
                reject('Error Occurred');
            }
        }, 2000);
    });
}

// AddItem('Item 3').then(data => {
//     GetItems();
//     console.log(data);
// })
// .catch(err => console.log(err));

async function RunTask() {
    await AddItem('Item 3');
    GetItems();
}

RunTask();