// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



function get() {

    const r = fetch('/api/Contacts');
    const d = r.json();
    console.log(d);
}


console.log("get")
fetch('/api/contacts', {

    method: 'GET',
    headers: {

        'Content-Type': 'application/json'

    },
    body: JSON.stringify()
})
    .then(res => res.json())
    .then(data => console.log(data))    //print data to console

    .catch(error => (console.log('ERROR')))



fetch('/api/contacts', {

    method: 'POST',
    headers: {

        'Content-Type':'application/json'

    },
    body: JSON.stringify( {  id:"2" })
})
    .then(res => {
      /*  if (res.ok) {
            console.log("SUCCESS")
        } else {
            console.log(" NOT SUCCESS")
        }*/

        return res.json()
    })
    .then(data => console.log(data))    //print data to console

    .catch(error => (console.log('ERROR')))

//console.log(res)
console.log("iiiiiiiiiiivjb ekjc akjcb")




