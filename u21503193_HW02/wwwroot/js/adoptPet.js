$(document).ready(function () {
    document.getElementById("SelectedUserFullName").addEventListener("change", function () {
        var selectedUserFullName = this.value;

        var phoneNumberDropdown = document.getElementById("SelectedUserPhoneNumber");

        phoneNumberDropdown.innerHTML = "";

        if (selectedUserFullName) {
            var selectedOption = document.querySelector(`[value="${selectedUserFullName}"]`);
            if (selectedOption) {
                var phoneNumber = selectedOption.getAttribute("data-phonenumber");

                var newOption = document.createElement("option");
                newOption.value = phoneNumber;
                newOption.text = phoneNumber;

                phoneNumberDropdown.appendChild(newOption);

                console.log("Selected Phone Number: " + phoneNumber);
            }
        } else {
            var defaultOption = document.createElement("option");
            defaultOption.value = "";
            defaultOption.text = "Select a Phone Number";
            phoneNumberDropdown.appendChild(defaultOption);
        }
    });
});

