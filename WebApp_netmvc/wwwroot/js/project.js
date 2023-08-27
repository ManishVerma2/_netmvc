function getstate() {

    var e = document.getElementById("Country");
    var value = e.value;
    var text = e.options[e.selectedIndex].text;
    alert(`Your Selected ${text} - ${value}`)  

    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };

    fetch(`https://localhost:5082/State/Countrystate/${value}`, requestOptions)
        .then(response => response.text())
        .then(result => {
            var data = JSON.parse(result);
            console.log(data)
        })
        .catch(error => console.log('error', error));

    //var state = document.getElementById("state");
    //var data = ["1", "2", "3", "4", "5"]; 
    //for (var i = 0; i <= data.length; i++)
    //{
    //    var opt = data[i];
    //    var el = document.createElement("option");
    //    el.textContent = opt
    //    el.value = opt;
    //    state.add(el);
    //}
    //for (var state of data) {
    //    var sname = state.sname;
    //    console.log(sname)
    //}
}
