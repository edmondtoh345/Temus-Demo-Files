function Show() {
    // console.log('Welcome to Event Handling');
    document.getElementById('heading1').style.color = 'red';
}

function Add() {
    let x = parseInt(document.getElementById('txt1').value);
    let y = parseInt(document.getElementById('txt2').value);
    let z = x + y;
    document.getElementById('txt3').value = z;
}