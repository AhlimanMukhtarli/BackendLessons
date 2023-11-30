var checkAccept = document.getElementById("checkAccept");
var btnRegister = document.getElementById("btnRegister");
var email = document.getElementById("email");
var Remail = document.getElementById("Remail");
var pass = document.getElementById("pass");
var Rpass = document.getElementById("Rpass");
var Fname = document.getElementById("Fname");
var phone = document.getElementById("phone");
var city = document.getElementById("city");
var country = document.getElementById("country");

checkAccept.addEventListener("change", function () {
    btnRegister.disabled = !checkAccept.checked;
});

btnRegister.addEventListener("click", function () {
    ValidateEmail(email, Remail);
    ValidatePassword(pass, Rpass);
    CheckNull(Fname);
    CheckNull(phone);
    CheckNull(city);
    CheckNull(country);
    
});
var isGenderSelected = CheckGender();


if (isGenderSelected) {
    
    alert("Registration completed!");
} else {
    alert("Registration failed. Please complete all fields.");
}

function CheckNull(input) {
    if (input.value.trim() === "") {
        setValidationResult(input, false, "Boshdur, doldur");
    } else {
        setValidationResult(input, true, "");
    }
}

function ValidateEmail(input1, input2) {
    var emailInput1 = input1.value.trim();
    var emailInput2 = input2.value.trim();
    var gmailRegex = /^[a-zA-Z0-9._-]+@gmail\.com$/;

    if (emailInput1 !== "" && emailInput2 !== "") {
        if (emailInput1 === emailInput2) {
            setValidationResult(input1, true, "");
            setValidationResult(input2, true, "");

            if (gmailRegex.test(emailInput1)) {
                setValidationResult(input1, true, "");
            } else {
                setValidationResult(input1, false, "Invalid Gmail address. Please enter a valid Gmail address");
            }
        } else {
            setValidationResult(input1, false, "Beraber deyil");
            setValidationResult(input2, false, "Beraber deyil");
        }
    } else {
        setValidationResult(input1, false, "Boshdur");
        setValidationResult(input2, false, "Boshdur");
    }
}

function ValidatePassword(input1, input2) {
    var passInput1 = input1.value.trim();
    var passInput2 = input2.value.trim();
    var passwordRegex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}\[\]:;<>,.?~\\-]).{8,}$/;

    if (passInput1 !== "" && passInput2 !== "") {
        if (passInput1 === passInput2) {
            setValidationResult(input1, true, "");

            if (passwordRegex.test(passInput1)) {
                setValidationResult(input1, true, "");
            } else {
                setValidationResult(input1, false, "Invalid Password. Please enter a valid password (at least one uppercase letter, one lowercase letter, one number, one symbol, and the password length should be at least 8 characters)");
            }
        } else {
            setValidationResult(input1, false, "It is not same");
            setValidationResult(input2, false, "It is not same");
        }
    } else {
        setValidationResult(input1, false, "Please Fill");
        setValidationResult(input2, false, "Please Fill");
    }
}

function CheckGender() {
    var genderRadios = document.getElementsByName("gender");
    var selectedGender = "";

    for (var i = 0; i < genderRadios.length; i++) {
        if (genderRadios[i].checked) {
            selectedGender = genderRadios[i].value;
            break;
        }
    }

    if (selectedGender !== "") {
        alert("Registration successful! Selected gender: " + selectedGender);
        return true; // Gender is selected
    } else {
        alert("Please select a gender to register.");
        return false; // Gender is not selected
    }
}

function setValidationResult(input, isValid, errorMessage) {
    input.style.borderColor = isValid ? "green" : "red";
    input.nextElementSibling.innerHTML = isValid ? "" : errorMessage;
}