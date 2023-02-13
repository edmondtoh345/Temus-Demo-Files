function SearchMovie() {
    let moviename = document.getElementById('txtMoviename').value;
    fetch(`http://www.omdbapi.com/?t=${moviename}&apiKey=8266bbff`)
        .then(res => res.json())
        .then(data => {
            document.getElementById('poster').src=data.Poster;
            document.getElementById('title').innerText = data.Title;
            document.getElementById('plot').innerText = data.Plot;
            document.getElementById('actors').innerText = data.Actors;
            document.getElementById('genre').innerText = data.Genre;
            document.getElementById('director').innerText = data.Director;
            document.getElementById('duration').innerText = data.Runtime;
        });
}