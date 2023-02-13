navigator.geolocation.getCurrentPosition((position)=>{
    console.log(`${position.coords.latitude} ${position.coords.longitude}`);
    // fetch(`https://api.openweathermap.org/data/2.5/weather?lat=${position.coords.latitude}&lon=${position.coords.longitude}&appid=0466cbde7c464dd7f56717dc5a926737`)
    fetch(`http://api.openweathermap.org/geo/1.0/reverse?lat=${position.coords.latitude}&lon=${position.coords.longitude}&appid=0466cbde7c464dd7f56717dc5a926737`)
    .then(res => res.json())
    .then(data => console.log(data));
});


// function successFunction(position) {
//     console.log(position.coords.latitude);
// }