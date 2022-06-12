//alert("connected to webClinet.html")

// shift+alt+f -arrange the code
var inVal = [];
// name & nick name
var validname = 1
var validpass = 1
var validnick = 1
var validConfirmpass = 1
var passCheck;
var myFormData = [];   //declare an array

// users //
const users = [
    { username: 'Brian1' }, { username: 'Trevor1' }, { username: 'Jonathan1' },
    { username: 'Joshua1' }, { username: 'Ruth1' }, { username: 'Anne1' },
    { username: 'Abigail1' }];

const form = document.querySelector('.form-container form');
const inputs = document.querySelectorAll('form input');


// saving the form input 
form.addEventListener('submit', (e) => {
    e.preventDefault(); inputs.forEach(input => {
        let messages = []
        inVal.push(input.value);




        if (input.name == "username") {


            if (input.value == "Brian1" || input.value == "Trevor1" || input.value == "Jonathan1" ||
                input.value == "Joshua1" || input.value == "Ruth1" || input.value == "Anne1" ||
                input.value == "Abigail1") {

                const errorElement1 = document.getElementById("error5")
                messages.push("This username is already taken")
                errorElement1.innerText = messages.join(', ')
                validname = 0



            }

            if (input.value.length < 2) {
                // errorMsg="Error-user name needs to be atleast with 1 charachters";
                const errorElement = document.getElementById('error')
                messages.push('user name should be atleast 4 charachters')
                errorElement.innerText = messages.join(', ')
                validname = 0


            }
        }
        //nickname
        if (input.name == "nickname") {
            if (input.value.length < 2) {
                const errorElement = document.getElementById('error2')
                messages.push('nick name should be atleast 4 charachters')
                errorElement.innerText = messages.join(', ')
                validname = 0;
            }
        }
        //password

        if (input.name == "pswd") {
            passCheck = input.value;
            if (input.value.length < 4) {
                const errorElement = document.getElementById('error3')
                messages.push('password should be atleast 4 charachters')
                errorElement.innerText = messages.join(', ')
                validpass = 0



            }

        }
        ///confirmation password
        if (input.name == "confirmPsw") {
            if (passCheck != input.value) {
                const errorElement = document.getElementById('error4')
                messages.push('the password is not correct')
                errorElement.innerText = messages.join(', ')
                validConfirmpass = 0
            }
        }

        if (input.name == "picture") {
            var pic = document.getElementById("picture-upload").files[0].name;
            // var pic = document.getElementById("picture-upload");
            inVal[4] = pic;
            console.log("full path-> " + inVal[4])
        }

    });
    //passing to another html file -to chat.html
    redirect();

});

document.querySelector("#picture-upload").addEventListener("change", function () {
    const reader = new FileReader();
    reader.addEventListener("load", () => {
        window.localStorage.setItem("6", reader.result);
    })
    reader.readAsDataURL(this.files[0]);
});

//redirect to another html page
function redirect(event) {
    forr();
    if ((validname == 1) && (validnick == 1) && (validpass == 1) && (validConfirmpass == 1)) {
        window.location.href = "chat.html";
    }
}

function forr() {
    console.log("loop");
    for (var i = 0; i < 4; i++) {
        console.log(inVal[i]);
        myFormData.push(inVal[0]);
        //passingg the values to chat.html
        var userName = inVal[0];
        window.localStorage.setItem("0", userName);

        var nickName = inVal[1];
        window.localStorage.setItem("1", nickName);

        var passWord = inVal[2];
        window.localStorage.setItem("2", passWord);

        var conf = inVal[3];
        window.localStorage.setItem("3", conf);

        var picture = inVal[4];
        window.localStorage.setItem("4", picture);

        // var signUp="signUp"
        window.localStorage.setItem("5", "signup");

    }
    console.log("loop");

}



